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
using RectangleF = System.Drawing.RectangleF;
using PointF = System.Drawing.PointF;

namespace vgarender
{

    #region types

    public enum ColorChannel { Red = 0, Green = 1, Blue = 2 };
    public enum SourceChannel { X = 0, Y = 1, Gray = 2, Min = 3, Max = 4 };

    public enum OneBitMode { None = 0, RandomNoise = 1, OrderedDithering = 2, Pwm = 3 };
    public enum OneBitSwapMode { None = 0, AfterPosition = 1, Checkered = 2, Random = 3 };

    public enum SourceValuesDither { None = 0, Random = 1, Ordered = 2 };


    public class OutputSettings
    {

        //  0 = no limit
        // -1 = vsync
        public int RefreshRate { get; set; }

        public int AnimationFrameRate { get; set; }

        public ImageSettings ImageSettings { get; set; }

        public SourceValuesSettings SourceValuesSettings { get; set; }

        public RectangleF Bounds { get; set; }

        public IEnumerable<ChannelsMapInfo> ChannelMap { get; set; }

    }

    public class SourceValuesSettings
    {
        public Dictionary<SourceChannel, RangeF> Ranges { get; set; }
        public SourceValuesDither Dither { get; set; }
    }

    public class ImageSettings
    {
        public ColorF GrayscaleRatios { get; set; }
        public bool AntialiasingEnable { get; set; }
        public bool Invert { get; set; }
        public float Gamma { get; set; }
        public RangeF GrayThreshold { get; set; }
        public bool SwapXY { get; set; }
        public PointF Scale { get; set; }
        public OneBitSettings OneBitSettings { get; set; }
    }


    public class ChannelsMapInfo
    {
        public SourceChannel Source { get; set; }
        public ColorChannel Color { get; set; }
        public bool CoordinateModulateWithOneBitColor { get; set; }
    }


    public class OneBitSettings
    {
        public OneBitMode Mode { get; set; }

        public RangeF Blanking { get; set; }
                
        public float SwapEveryNFrame { get; set; } // -1 = disabled
        public OneBitSwapMode SwapMode { get; set; }

        public PointF SwapAfter { get; set; }

        public PointF SwapCheckeredSize { get; set; }


        public OrderedDitherSettings OrderedDitherSettings { get; set; }
    }


    public class OrderedDitherSettings
    {
        public int MatrixSize { get; set; }
        public float RefreshesPerShift { get; set; }
        public PointF Shift { get; set; }
    }


    public class RangeF
    {
        public RangeF(float min, float max)
        {
            Min = min;
            Max = max;
        }
        public float Min { get; set; }
        public float Max { get; set; }
    }


    public class ColorF
    {
        public ColorF(float red, float green, float blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public float Red { get; set; }
        public float Green { get; set; }
        public float Blue { get; set; }
    }


    #endregion types

    public class DrawWindow
    {
        #region shader const

        // main shader


        private const string shaderFilename = @"FragmentShader.frag";

        private const string suTexture = "texture";
        private const string suWindowSize = "windowSize";

        private const string suChannelSource    = "channelSource";

        private const string suGrayColorRatio   = "grayColorRatio";
        private const string suGrayThreshBlack  = "grayThreshBlack";
        private const string suGrayThreshWhite  = "grayThreshWhite";
        private const string suGamma            = "gamma";
        private const string suColorInvert      = "colorInvert";

        private const string suOneBitEncodingMode   = "oneBitEncodingMode";
        private const string suOneBitEnabled        = "oneBitEnabled";
        private const string suOneBitTop            = "oneBitTop";
        private const string suOneBitBottom         = "oneBitBottom";
        private const string suOneBitSwapMode       = "oneBitSwapMode";
        private const string suOneBitSwapAfter      = "oneBitSwapAfter";
        private const string suOneBitSwapCheckered  = "oneBitSwapCheckered";

        private const string suOrderedMatrixFlat        = "orderedMatrixFlat";
        private const string suOrderedMatrixFlatSize    = "orderedMatrixFlatSize";
        private const string suOrderedShift             = "orderedShift";

        private const string suGradientParams = "gradientParams";
        private const string suGradientOrderedMatrixFlat = "gradientOrderedMatrixFlat";

        private const string suPwmColor = "pwmColor";

        private const string suRandomSeed = "randomSeed";


        #endregion shader const


        Dictionary<ColorChannel, Color> _colorMap = new Dictionary<ColorChannel, Color>() {
            { ColorChannel.Red  , Color.Red   },
            { ColorChannel.Green, Color.Green },
            { ColorChannel.Blue , Color.Blue  }
        };

        object _drawingLock = new object();
        Task _drawingTask;
        CancellationTokenSource _drawingCancelSource;
        CancellationToken _drawingCancelToken;


        Vector2i _windowPos  = new Vector2i(0, 0);
        Vector2u _windowSize = new Vector2u(800, 600);

        #region props

        public Screen Screen { get; set; }


        public bool Fullscreen { get; set; }

        public IEnumerable<string> Files { get; set; }


        public OutputSettings OutputSettings { get; set; }



        public int CurrentFps { get; protected set; }

        public event EventHandler OnClosed = (o, e) => {};

        #endregion props



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
            try
            {

                #region vars


                var colorChannels = new[] { ColorChannel.Red, ColorChannel.Green, ColorChannel.Blue };

                var colorChannelMap = OutputSettings.ChannelMap.ToDictionary(cm => cm.Color);

                var xmap = OutputSettings.ChannelMap.Where(m => m.Source == SourceChannel.X);
                var ymap = OutputSettings.ChannelMap.Where(m => m.Source == SourceChannel.Y);
                var graymap = OutputSettings.ChannelMap.Where(m => m.Source == SourceChannel.Gray);

                var refreshesPerFrame = (float)OutputSettings.RefreshRate / (float)OutputSettings.AnimationFrameRate;

                #endregion vars

                #region window

                RenderWindow window;

                int resolutionX, resolutionY;

                if (Fullscreen)
                {
                    resolutionX = Screen.Bounds.Width;
                    resolutionY = Screen.Bounds.Height;
                    window = new RenderWindow(new VideoMode((uint)resolutionX, (uint)resolutionY), "VGA Oscilloscope drawing", Styles.None);
                    window.Position = new Vector2i(Screen.Bounds.X, Screen.Bounds.Y);
                }
                else
                {
                    resolutionX = 800;
                    resolutionY = 600;
                    window = new RenderWindow(new VideoMode((uint)resolutionX, (uint)resolutionY), "VGA Oscilloscope drawing", Styles.Default);
                    window.Position = _windowPos;
                    window.Size = _windowSize;
                }

                window.KeyReleased += (o, e) =>
                {
                    if (e.Code == Keyboard.Key.Escape)
                        window.Close();
                };

                window.Closed += (_, __) =>
                {
                    window.Close();
                    OnClosed(this, EventArgs.Empty);
                };

                if (OutputSettings.RefreshRate == -1)
                {
                    window.SetVerticalSyncEnabled(true);
                }
                else if (OutputSettings.RefreshRate > 1)
                {
                    window.SetFramerateLimit((uint)OutputSettings.RefreshRate);
                }


                #endregion window


                #region shaders

                if (!Shader.IsAvailable)
                    throw new Exception("shaders are not available");

                var shader = new Shader(null, null, shaderFilename);

                shader.SetUniform(suTexture, Shader.CurrentTexture);

                shader.SetUniform(suWindowSize, new Vec2(
                    (float)resolutionX * OutputSettings.ImageSettings.Scale.X,
                    (float)resolutionY * OutputSettings.ImageSettings.Scale.Y));

                shader.SetUniform(suChannelSource, new Ivec3(
                    (int)(OutputSettings.ChannelMap.FirstOrDefault(m => m.Color == ColorChannel.Red  )?.Source ?? SourceChannel.Min),
                    (int)(OutputSettings.ChannelMap.FirstOrDefault(m => m.Color == ColorChannel.Green)?.Source ?? SourceChannel.Min),
                    (int)(OutputSettings.ChannelMap.FirstOrDefault(m => m.Color == ColorChannel.Blue )?.Source ?? SourceChannel.Min)
                    ));


                shader.SetUniform(suGrayThreshBlack, OutputSettings.ImageSettings.GrayThreshold.Min);
                shader.SetUniform(suGrayThreshWhite, OutputSettings.ImageSettings.GrayThreshold.Max);

                shader.SetUniform(suOneBitSwapMode, (int)OutputSettings.ImageSettings.OneBitSettings.SwapMode);

                shader.SetUniform(suOneBitSwapAfter, new Vec2(
                    OutputSettings.ImageSettings.OneBitSettings.SwapAfter.X,
                    OutputSettings.ImageSettings.OneBitSettings.SwapAfter.Y));

                shader.SetUniform(suOneBitSwapCheckered, new Vec2(
                    OutputSettings.ImageSettings.OneBitSettings.SwapCheckeredSize.X,
                    OutputSettings.ImageSettings.OneBitSettings.SwapCheckeredSize.Y));

                var matrix = GenerateOrderedDitherMatrix(OutputSettings.ImageSettings.OneBitSettings.OrderedDitherSettings.MatrixSize);
                shader.SetUniformArray(suOrderedMatrixFlat, matrix);

                shader.SetUniform(suOrderedMatrixFlatSize, OutputSettings.ImageSettings.OneBitSettings.OrderedDitherSettings.MatrixSize);


                shader.SetUniform(suGrayColorRatio, new Vec3(
                    OutputSettings.ImageSettings.GrayscaleRatios.Red,
                    OutputSettings.ImageSettings.GrayscaleRatios.Green,
                    OutputSettings.ImageSettings.GrayscaleRatios.Blue));


                shader.SetUniform(suGamma, OutputSettings.ImageSettings.Gamma);

                shader.SetUniform(suColorInvert, OutputSettings.ImageSettings.Invert ? 1 : 0);

                shader.SetUniform(suOneBitEncodingMode, (int)OutputSettings.ImageSettings.OneBitSettings.Mode);

                shader.SetUniform(suOneBitEnabled, new Ivec3(
                    OutputSettings.ChannelMap.FirstOrDefault(m => m.Color == ColorChannel.Red  )?.CoordinateModulateWithOneBitColor ?? false ? 1 : 0,
                    OutputSettings.ChannelMap.FirstOrDefault(m => m.Color == ColorChannel.Green)?.CoordinateModulateWithOneBitColor ?? false ? 1 : 0,
                    OutputSettings.ChannelMap.FirstOrDefault(m => m.Color == ColorChannel.Blue )?.CoordinateModulateWithOneBitColor ?? false ? 1 : 0
                ));


                var gradientParams = new Vec3[3];

                foreach (var entry in OutputSettings.ChannelMap)
                {
                    var range = entry.Source == SourceChannel.Gray 
                        ? new RangeF(0, 0) 
                        : OutputSettings.SourceValuesSettings.Ranges[entry.Source];

                    float min = range.Min;
                    float max = range.Max;

                    gradientParams[(int) entry.Color] = new Vec3(min, max, (float) SourceValuesDither.Random);
                }

                shader.SetUniformArray(suGradientParams, gradientParams);

                shader.SetUniformArray(suGradientOrderedMatrixFlat, GenerateOrderedDitherMatrix(16));

                #endregion shader

                #region frames

                var frames = new List<Texture>();

                foreach (var filepath in Files)
                {
                    var tex = new Texture(filepath);
                    if (frames.Count > 0 && tex.Size != frames[0].Size)
                        throw new Exception("Texture sizes must be equal.");
                    tex.Smooth = OutputSettings.ImageSettings.AntialiasingEnable;
                    frames.Add(tex);
                }

                #endregion frames

                #region drawing vars

                // display refresh count
                int refreshCounter = 0;

                int fpsCounter = 0;
                var fpstime = DateTime.Now;
                var fpstime2 = DateTime.Now;

                int animationFrame = 0;
                var frameSprite = new Sprite(frames[0]);

                float blankValueTop     = OutputSettings.ImageSettings.OneBitSettings.Blanking.Max;
                float blankValueBottom  = OutputSettings.ImageSettings.OneBitSettings.Blanking.Min;

                #endregion drawing vars

                #region drawing loop

                var random = new Random((int)DateTime.Now.Ticks);

                while (window.IsOpen & !_drawingCancelToken.IsCancellationRequested)
                {
                    window.DispatchEvents();

                    window.Clear(Color.Black);


                    #region update shader uniform

                    shader.SetUniform(suRandomSeed, (float)random.NextDouble() * 100000.0f);

                    shader.SetUniform(suPwmColor, ModF(refreshCounter, refreshesPerFrame) / refreshesPerFrame);

                    if (OutputSettings.ImageSettings.OneBitSettings.OrderedDitherSettings.RefreshesPerShift > 0)
                    {
                        shader.SetUniform(suOrderedShift, new Vec2(
                            OutputSettings.ImageSettings.OneBitSettings.OrderedDitherSettings.Shift.X *
                                (int)(refreshCounter / OutputSettings.ImageSettings.OneBitSettings.OrderedDitherSettings.RefreshesPerShift),
                            OutputSettings.ImageSettings.OneBitSettings.OrderedDitherSettings.Shift.Y *
                                (int)(refreshCounter / OutputSettings.ImageSettings.OneBitSettings.OrderedDitherSettings.RefreshesPerShift)));
                    }
                    else
                    {
                        shader.SetUniform(suOrderedShift, new Vec2(0, 0));
                    }

                    shader.SetUniform(suOneBitTop   , blankValueTop);
                    shader.SetUniform(suOneBitBottom, blankValueBottom);

                    #endregion update shader uniform

                    #region draw animation frame

                    frameSprite.Texture = frames[animationFrame];



                    if (OutputSettings.ImageSettings.SwapXY)
                    {
                        frameSprite.Position = new Vector2f(
                            (float)resolutionX * OutputSettings.Bounds.X * OutputSettings.ImageSettings.Scale.X,
                            (float)resolutionY * OutputSettings.Bounds.Y * OutputSettings.ImageSettings.Scale.Y);
                        frameSprite.Origin = new Vector2f(0, frameSprite.TextureRect.Height);
                        frameSprite.Rotation = 90;
                        frameSprite.Scale = new Vector2f(
                            (resolutionY / (float)frameSprite.TextureRect.Width) * OutputSettings.Bounds.Height * OutputSettings.ImageSettings.Scale.Y,
                            (resolutionX / (float)frameSprite.TextureRect.Height) * OutputSettings.Bounds.Width * OutputSettings.ImageSettings.Scale.X);
                    }
                    else
                    {
                        frameSprite.Position = new Vector2f(
                            (float) resolutionX * OutputSettings.Bounds.X * OutputSettings.ImageSettings.Scale.X,
                            (float) resolutionY * OutputSettings.Bounds.Y * OutputSettings.ImageSettings.Scale.Y);
                        frameSprite.Scale = new Vector2f(
                            (resolutionX / (float)frameSprite.TextureRect.Width ) * OutputSettings.Bounds.Width  * OutputSettings.ImageSettings.Scale.X,
                            (resolutionY / (float)frameSprite.TextureRect.Height) * OutputSettings.Bounds.Height * OutputSettings.ImageSettings.Scale.Y);
                    }




                    var frameRenderTexture = new RenderTexture(
                        (uint)(resolutionX * OutputSettings.ImageSettings.Scale.X),
                        (uint)(resolutionY * OutputSettings.ImageSettings.Scale.Y));
                    frameRenderTexture.Smooth = false;

                    frameRenderTexture.Clear(Color.Black);



                    var state = new RenderStates()
                    {
                        Transform = Transform.Identity,
                        Shader = shader,
                        BlendMode = new BlendMode(BlendMode.Factor.One, BlendMode.Factor.Zero)
                    };

                    frameRenderTexture.Draw(frameSprite, state);

                    frameRenderTexture.Display();

                    var frameRenderSprite = new Sprite();
                    frameRenderSprite.Texture = frameRenderTexture.Texture;

                    frameRenderSprite.Scale = new Vector2f(1 / OutputSettings.ImageSettings.Scale.X, 1 / OutputSettings.ImageSettings.Scale.Y);

                    var frameRenderSpriteState = new RenderStates()
                    {
                        Transform = Transform.Identity,
                        BlendMode = BlendMode.Add
                    };


                    window.Draw(frameRenderSprite, frameRenderSpriteState);

                    frameRenderSprite.Dispose();
                    frameRenderTexture.Dispose();


                    #endregion draw animation frame

                    window.Display();


                    #region animation and colors sequencing

                    refreshCounter++;

                    if (ModF(refreshCounter, refreshesPerFrame) == 0)
                    {
                        animationFrame++;
                        animationFrame %= frames.Count;
                    }

                    if (
                        OutputSettings.ImageSettings.OneBitSettings.SwapEveryNFrame > 0 &&
                        ModF(refreshCounter, OutputSettings.ImageSettings.OneBitSettings.SwapEveryNFrame) == 0)
                    {
                        (blankValueTop, blankValueBottom) = (blankValueBottom, blankValueTop);
                    }

                    #endregion animation and colors sequencing


                    #region FPS counting

                    fpsCounter++;
                    fpstime2 = DateTime.Now;

                    if (fpstime2 - fpstime >= TimeSpan.FromSeconds(1))
                    {
                        CurrentFps = fpsCounter;
                        fpsCounter = 0;
                        fpstime = DateTime.Now;
                    }

                    #endregion

                }

                #endregion drawing loop


                if (!Fullscreen)
                {
                    _windowSize = window.Size;
                    _windowPos = window.Position;
                }

                #region cleanup

                if (window.IsOpen)
                {
                    window.Close();
                    window.Dispose();
                }

                frameSprite.Dispose();

                frames.ForEach(t => t.Dispose());
                frames.Clear();


                shader.Dispose();

                CurrentFps = -1;

                #endregion cleanup

            }
            catch (Exception e)
            {

            }

        }



        int ModF(float a, float b) => (int)(a - b * Math.Floor(a / b));


        float[] GenerateOrderedDitherMatrix(int size)
        {
            var matrix = InitBayer(0, 0, size, 0, 1);
            return matrix.SelectMany(m => m.Select(x => (float) x)).ToArray();
        }

        int[][] InitBayer(int x, int y, int size, int value, int step, int[][] matrix = null)
        {
            // https://github.com/tromero/BayerMatrix/blob/1c8c8b9ff3119461dda969514b6885707cfc29e8/MakeBayer.py#L1-L18

            if (matrix == null)
                matrix = Enumerable.Range(0, size)
                    .Select(a => Enumerable.Range(0, size)
                        .Select((b, i) => i)
                        .ToArray())
                    .ToArray();

            if (size == 1)
            {
                matrix[y][x] = value;
                return matrix;
            }

            var half = size / 2;

            matrix = InitBayer(x,      y,      half, value+(step*0), step*4, matrix);
            matrix = InitBayer(x+half, y+half, half, value+(step*1), step*4, matrix);
            matrix = InitBayer(x+half, y,      half, value+(step*2), step*4, matrix);
            matrix = InitBayer(x,      y+half, half, value+(step*3), step*4, matrix);

            return matrix;
        }


    }

}
