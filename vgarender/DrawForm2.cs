using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Screen = System.Windows.Forms.Screen;
using SFML.Graphics;
using SFML.System;
using SFML.Window;
using SFML.Graphics.Glsl;

namespace vgarender
{


    public enum ColorChannel { Red = 0, Green = 1, Blue = 2 };
    public enum ChannelZSourceChannel { Red = 0, Green = 1, Blue = 2, Grayscale = 3 };
    public enum AxisChannel { X = 0, Y = 1, Z = 2, Min = 3, Max = 4 };


    public class RenderSettings
    {
        public IEnumerable<ColorAxisMapInfo> ChannelMap { get; set; }

        public ChannelZSourceChannel ChannelZSourceChannel { get; set; }
        public bool SwapXY { get; set; }
    }

    public class ColorAxisMapInfo
    {
        public ColorAxisMapInfo(AxisChannel axis, ColorChannel color, bool invert = false)
        {
            Axis = axis;
            Color = color;
            Invert = invert;
        }

        public AxisChannel Axis { get; set; }
        public ColorChannel Color { get; set; }
        public bool Invert { get; set; }
    }


    public class DrawForm2
    {
        private const string shaderInColorsGrayscale = "incolorsgrayscale";
        private const string shaderInColorsKoeff = "incolorskoeff";
        private const string shaderInColorsInvert = "incolorsinvert";
        private const string shaderOutColorsInvert = "outcolorsinvert";
        private const string shaderOutColorsKoeff = "outcolorskoeff";
        private const string shaderOutGamma = "outgamma";

        Dictionary<ColorChannel, Color> _colorMap = new Dictionary<ColorChannel, Color>() {
            { ColorChannel.Red, Color.Red},
            { ColorChannel.Green, Color.Green },
            { ColorChannel.Blue, Color.Blue }
        };

        object _drawingLock = new object();
        Task _drawingTask;
        CancellationTokenSource _drawingCancelSource;
        CancellationToken _drawingCancelToken;



        public Screen Screen { get; set; }

        public bool DisableAntialiasing { get; set; }

        public bool Fullscreen { get; set; }

        public IEnumerable<string> Files { get; set; }

        //  0 = no limit
        // -1 = vsync
        public int RefreshRate { get; set; }

        public RenderSettings RenderSettings { get; set; }


        public int CurrentFps { get; protected set; }

        public event EventHandler OnClosed = (o, e) => {};



        public void Run()
        {
            lock (_drawingLock)
            {
                if (_drawingTask != null)
                    return;

                _drawingCancelSource = new CancellationTokenSource();
                _drawingCancelToken = _drawingCancelSource.Token;
                _drawingTask = new Task(DrawingProc, _drawingCancelToken);

                _drawingTask.Start();
            }
        }


        public void Stop()
        {
            lock (_drawingLock)
            {
                if (_drawingTask == null || (_drawingCancelSource?.IsCancellationRequested ?? true))
                    return;

                _drawingCancelSource.Cancel();

                _drawingTask.Wait();
                _drawingTask = null;

                _drawingCancelSource.Dispose();
                _drawingCancelSource = null;

                _drawingCancelToken = CancellationToken.None;
            }
        }




        protected void DrawingProc()
        {

            var redmap   = RenderSettings.ChannelMap.First(m => m.Color == ColorChannel.Red);
            var greenmap = RenderSettings.ChannelMap.First(m => m.Color == ColorChannel.Green);
            var bluemap  = RenderSettings.ChannelMap.First(m => m.Color == ColorChannel.Blue);

            var xmap = RenderSettings.ChannelMap.Where(m => m.Axis == AxisChannel.X);
            var ymap = RenderSettings.ChannelMap.Where(m => m.Axis == AxisChannel.Y);
            var zmap = RenderSettings.ChannelMap.Where(m => m.Axis == AxisChannel.Z);

            var bgcolor = RenderSettings.ChannelMap
                .Where(m => (m.Axis == AxisChannel.Max && !m.Invert) || (m.Axis == AxisChannel.Min && m.Invert))
                .Select(m => _colorMap[m.Color])
                .DefaultIfEmpty(Color.Black)
                .Aggregate((c1, c2) => c1 + c2);


            #region window and gradients

            RenderWindow window;

            if (Fullscreen)
            {
                window = new RenderWindow(new VideoMode((uint)Screen.Bounds.Width, (uint)Screen.Bounds.Height), "VGA Oscilloscope drawing", Styles.None);
                window.Position = new Vector2i(Screen.Bounds.X, Screen.Bounds.Y);
            }
            else
            {
                window = new RenderWindow(new VideoMode(800, 600), "VGA Oscilloscope drawing", Styles.Default);
            }

            window.KeyReleased += (o, e) => {
                if (e.Code == Keyboard.Key.Escape)
                    window.Close();
            };
            window.Closed += (_, __) =>
            {
                window.Close();
                OnClosed(this, EventArgs.Empty);
            };

            if (RefreshRate == -1)
            {
                window.SetVerticalSyncEnabled(true);
            }
            else if (RefreshRate > 1)
            {
                window.SetFramerateLimit((uint)RefreshRate);
            }



            var gradientx = CreateGradient(window.Size.X, window.Size.Y, xmap, false);
            var gradienty = CreateGradient(window.Size.X, window.Size.Y, ymap, true);


            window.Resized += (o, e) =>
            {
                window.SetView(new View(new Vector2f(e.Width / 2, e.Height / 2), new Vector2f(e.Width, e.Height)));

                gradientx = CreateGradient(e.Width, e.Height, xmap, false);
                gradienty = CreateGradient(e.Width, e.Height, ymap, true);
            };

            #endregion window and gradients

            #region shader

            if (!Shader.IsAvailable)
                throw new Exception("shaders are not available");

            var shader = new Shader(null, null, @"ColoringShader.frag");

            shader.SetUniform("texture", Shader.CurrentTexture);

            if (RenderSettings.ChannelZSourceChannel == ChannelZSourceChannel.Grayscale)
            {
                shader.SetUniform(shaderInColorsGrayscale, true);
                shader.SetUniform(shaderInColorsKoeff, new Vec3(0.2125f, 0.7154f, 0.0721f));
            }
            else
            {
                shader.SetUniform(shaderInColorsGrayscale, true);
                shader.SetUniform(shaderInColorsKoeff, new Vec3(
                    RenderSettings.ChannelZSourceChannel == ChannelZSourceChannel.Red ? 1 : 0,
                    RenderSettings.ChannelZSourceChannel == ChannelZSourceChannel.Green ? 1 : 0,
                    RenderSettings.ChannelZSourceChannel == ChannelZSourceChannel.Blue ? 1 : 0));
            }

            shader.SetUniform(shaderInColorsInvert, new Vec3(0, 0, 0));

            shader.SetUniform(shaderOutColorsInvert, new Vec3(
                redmap.Axis   == AxisChannel.Z && redmap.Invert   ? 1 : 0,
                greenmap.Axis == AxisChannel.Z && greenmap.Invert ? 1 : 0,
                bluemap.Axis  == AxisChannel.Z && bluemap.Invert  ? 1 : 0));

            shader.SetUniform(shaderOutColorsKoeff, new Vec3(
                redmap.Axis   == AxisChannel.Z ? 1 : 0,
                greenmap.Axis == AxisChannel.Z ? 1 : 0,
                bluemap.Axis  == AxisChannel.Z ? 1 : 0));

            shader.SetUniform(shaderOutGamma, 1f);

            #endregion shader

            #region frames


            var frames = new List<Texture>();

            foreach (var filepath in Files)
            {
                var tex = new Texture(filepath);
                if (frames.Count > 0 && tex.Size != frames[0].Size)
                    throw new Exception("Texture sizes must be equal.");
                tex.Smooth = !DisableAntialiasing;
                frames.Add(tex);
            }

            #endregion frames


            #region drawing vars

            int fps = 0;
            var fpstime = DateTime.Now;
            var fpstime2 = DateTime.Now;

            int currentFrame = 0;
            var frameSprite = new Sprite(frames[0]);

            #endregion drawing vars

            #region drawing loop



            while (window.IsOpen & !_drawingCancelToken.IsCancellationRequested)
            {
                window.DispatchEvents();

                window.Clear(bgcolor);

                #region draw gradients

                var gradientBlend = new BlendMode(BlendMode.Factor.One, BlendMode.Factor.One, BlendMode.Equation.Add);
                var gradientStrategy = new RenderStates(gradientBlend);

                window.Draw(gradientx, gradientStrategy);

                window.Draw(gradienty, gradientStrategy);

                #endregion

                frameSprite.Texture = frames[currentFrame];

                var blend = new BlendMode(BlendMode.Factor.One, BlendMode.Factor.One, BlendMode.Equation.Add);
                var state = new RenderStates() { Transform = Transform.Identity, Shader = shader, BlendMode = blend };

                if (RenderSettings.SwapXY)
                {
                    frameSprite.Origin = new Vector2f(0, frameSprite.TextureRect.Height);
                    frameSprite.Rotation = 90;
                    frameSprite.Scale = new Vector2f(
                        window.Size.Y / (float)frameSprite.TextureRect.Width,
                        window.Size.X / (float)frameSprite.TextureRect.Height);
                }
                else 
                {
                    frameSprite.Scale = new Vector2f(
                    window.Size.X / (float)frameSprite.TextureRect.Width,
                    window.Size.Y / (float)frameSprite.TextureRect.Height);                    
                }

                window.Draw(frameSprite, state);

                window.Display();

                #region FPS and current frame

                currentFrame++;
                currentFrame %= frames.Count;

                fps++;
                fpstime2 = DateTime.Now;

                if (fpstime2 - fpstime >= TimeSpan.FromSeconds(1))
                {
                    CurrentFps = fps;
                    fps = 0;
                    fpstime = DateTime.Now;
                }

                #endregion

            }

            #endregion drawing loop

            if (window.IsOpen)
            {
                window.Close();
                window.Dispose();
            }

            frameSprite.Dispose();

            frames.ForEach(t => t.Dispose());
            frames.Clear();

            gradientx.Clear();
            gradientx.Dispose();

            gradienty.Clear();
            gradienty.Dispose();

            CurrentFps = -1;

        }

        VertexArray CreateGradient(uint width, uint height, IEnumerable<ColorAxisMapInfo> mapinfo, bool vertical)
        {
            if (!mapinfo?.Any() ?? true)
                return new VertexArray(PrimitiveType.Quads, 4);

            var color1 = mapinfo.Select(m => m.Invert ? _colorMap[m.Color] : Color.Black).Aggregate((c1, c2) => c1 + c2);
            var color2 = mapinfo.Select(m => m.Invert ? Color.Black : _colorMap[m.Color]).Aggregate((c1, c2) => c1 + c2);

            var colors = vertical
                ? new Color[] { color1, color1, color2, color2 }
                : new Color[] { color1, color2, color2, color1 };

            var res = new VertexArray(PrimitiveType.Quads, 4);
            res.Append(new Vertex(new Vector2f(0, 0), colors[0]));
            res.Append(new Vertex(new Vector2f(width, 0), colors[1]));
            res.Append(new Vertex(new Vector2f(width, height), colors[2]));
            res.Append(new Vertex(new Vector2f(0, height), colors[3]));

            return res;
        }


    }

}
