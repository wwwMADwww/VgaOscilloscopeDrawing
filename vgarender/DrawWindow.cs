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

namespace vgarender
{

    #region types

    public enum ColorChannel { Red = 0, Green = 1, Blue = 2 };
    public enum SourceChannel { X = 0, Y = 1, Gray = 2, Min = 3, Max = 4 };

    public enum OneBitMode { None = 0, RandomNoise = 1, OrderedDithering = 2, Pwm = 3 };

    public enum OneBitSwapMode { None = 0, AfterPosition = 1, Checkered = 2, Random = 3 };


    public class OutputSettings
    {
        public bool EnableAntialiasing { get; set; }

        //  0 = no limit
        // -1 = vsync
        public int RefreshRate { get; set; }

        public int AnimationFrameRate { get; set; }

        public ImageColorSettings ImageColorSettings { get; set; }

        public Dictionary<SourceChannel, (float Min, float Max)> SourceRanges { get; set; }

        public RectangleF Bounds { get; set; }

        public IEnumerable<ChannelsMapInfo> ChannelMap { get; set; }

        public bool SwapXY { get; set; }
    }

    public class ImageColorSettings
    {
        public float[] GrayscaleRatios { get; set; }
        public bool Invert { get; set; }
        public float Gamma { get; set; }
        public float GrayThresholdBlack { get; set; }
        public float GrayThresholdWhite { get; set; }
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

        public float BlankingTop { get; set; }
        public float BlankingBottom { get; set; }
                
        public float SwapEveryNFrame { get; set; } // -1 = disabled
        public OneBitSwapMode SwapMode { get; set; }

        public float SwapAfterX { get; set; }
        public float SwapAfterY { get; set; }

        public float SwapCheckeredW { get; set; }
        public float SwapCheckeredH { get; set; }


        public OrderedDitherSettings OrderedDitherSettings { get; set; }
    }

    public class OrderedDitherSettings
    {
        public int MatrixSize { get; set; }
        public float RefreshesPerShift { get; set; }
        public float ShiftX { get; set; }
        public float ShiftY { get; set; }
    }

    #endregion types

    public class DrawWindow
    {
        #region shader const

        private const string suTexture = "texture";
        private const string suWindowSize = "windowSize";

        private const string suActiveChannel   = "activeChannel";

        private const string suGrayColorRatio   = "grayColorRatio";
        private const string suGrayThreshBlack  = "grayThreshBlack";
        private const string suGrayThreshWhite  = "grayThreshWhite";
        private const string suGamma            = "gamma";
        private const string suColorInvert      = "colorInvert";

        private const string suOneBitEncodingMode   = "oneBitEncodingMode";
        private const string suOneBitTop            = "oneBitTop";
        private const string suOneBitBottom         = "oneBitBottom";
        private const string suOneBitSwapMode       = "oneBitSwapMode";
        private const string suOneBitSwapAfter      = "oneBitSwapAfter";
        private const string suOneBitSwapCheckered  = "oneBitSwapCheckered";

        private const string suOrderedMatrixFlat        = "orderedMatrixFlat";
        private const string suOrderedMatrixFlatSize    = "orderedMatrixFlatSize";
        private const string suOrderedShift             = "orderedShift";

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

                if (Fullscreen)
                {
                    window = new RenderWindow(new VideoMode((uint)Screen.Bounds.Width, (uint)Screen.Bounds.Height), "VGA Oscilloscope drawing", Styles.None);
                    window.Position = new Vector2i(Screen.Bounds.X, Screen.Bounds.Y);
                }
                else
                {
                    window = new RenderWindow(new VideoMode(800, 600), "VGA Oscilloscope drawing", Styles.Default);
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

                window.Resized += (o, e) =>
                {
                    window.SetView(new View(new Vector2f(e.Width / 2, e.Height / 2), new Vector2f(e.Width, e.Height)));
                };

                #endregion window

                #region gradients

                // Func allows to edit during debugging
                // Dictionary<ColorChannel, VertexArray> createRgbGradients(uint sizeX, uint sizeY) => colorChannels
                Func<Vector2f, Vector2f, Dictionary<ColorChannel, VertexArray>> createRgbGradients = (pos, size) => colorChannels
                    .Select(color => new KeyValuePair<ColorChannel, VertexArray>(
                            color,
                            CreateGradient(
                                pos,
                                size,
                                colorChannelMap[color],
                                ymap.Any(ym => ym.Color == color))))
                    .ToDictionary(kv => kv.Key, kv => kv.Value);

                var gradientMap = createRgbGradients(
                    new Vector2f(window.Size.X * OutputSettings.Bounds.X    , window.Size.Y * OutputSettings.Bounds.Y),
                    new Vector2f(window.Size.X * OutputSettings.Bounds.Width, window.Size.Y * OutputSettings.Bounds.Height)
                    );

                window.Resized += (o, e) =>
                {
                    gradientMap = createRgbGradients(
                        new Vector2f(e.Width * OutputSettings.Bounds.X    , e.Height * OutputSettings.Bounds.Y),
                        new Vector2f(e.Width * OutputSettings.Bounds.Width, e.Height * OutputSettings.Bounds.Height)
                        );
                };

                #endregion gradients

                #region shader

                if (!Shader.IsAvailable)
                    throw new Exception("shaders are not available");

                var shader = new Shader(null, null, @"FragmentShader.frag");

                shader.SetUniform(suTexture, Shader.CurrentTexture);

                shader.SetUniform(suWindowSize, new Vec2(window.Size.X, window.Size.Y));

                window.Resized += (o, e) =>
                {
                    shader.SetUniform(suWindowSize, new Vec2(e.Width, e.Height));
                };

                shader.SetUniform(suGrayThreshBlack, OutputSettings.ImageColorSettings.GrayThresholdBlack);
                shader.SetUniform(suGrayThreshWhite, OutputSettings.ImageColorSettings.GrayThresholdWhite);

                shader.SetUniform(suOneBitSwapMode, (int)OutputSettings.ImageColorSettings.OneBitSettings.SwapMode);

                shader.SetUniform(suOneBitSwapAfter, new Vec2(
                    OutputSettings.ImageColorSettings.OneBitSettings.SwapAfterX,
                    OutputSettings.ImageColorSettings.OneBitSettings.SwapAfterY));

                shader.SetUniform(suOneBitSwapCheckered, new Vec2(
                    OutputSettings.ImageColorSettings.OneBitSettings.SwapCheckeredW,
                    OutputSettings.ImageColorSettings.OneBitSettings.SwapCheckeredH));

                var matrix = GenerateOrderedDitherMatrix(OutputSettings.ImageColorSettings.OneBitSettings.OrderedDitherSettings.MatrixSize);
                shader.SetUniformArray(suOrderedMatrixFlat, matrix);

                shader.SetUniform(suOrderedMatrixFlatSize, OutputSettings.ImageColorSettings.OneBitSettings.OrderedDitherSettings.MatrixSize);


                shader.SetUniform(suGrayColorRatio, new Vec3(
                    OutputSettings.ImageColorSettings.GrayscaleRatios[0],
                    OutputSettings.ImageColorSettings.GrayscaleRatios[1],
                    OutputSettings.ImageColorSettings.GrayscaleRatios[2]));


                shader.SetUniform(suGamma, OutputSettings.ImageColorSettings.Gamma);

                shader.SetUniform(suColorInvert, OutputSettings.ImageColorSettings.Invert ? 1 : 0);

                #endregion shader

                #region frames

                var frames = new List<Texture>();

                foreach (var filepath in Files)
                {
                    var tex = new Texture(filepath);
                    if (frames.Count > 0 && tex.Size != frames[0].Size)
                        throw new Exception("Texture sizes must be equal.");
                    tex.Smooth = OutputSettings.EnableAntialiasing;
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

                float blankValueTop     = OutputSettings.ImageColorSettings.OneBitSettings.BlankingTop;
                float blankValueBottom  = OutputSettings.ImageColorSettings.OneBitSettings.BlankingBottom;

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

                    shader.SetUniform(suOrderedShift, new Vec2(
                        OutputSettings.ImageColorSettings.OneBitSettings.OrderedDitherSettings.ShiftX * 
                            (int)(refreshCounter / OutputSettings.ImageColorSettings.OneBitSettings.OrderedDitherSettings.RefreshesPerShift),
                        OutputSettings.ImageColorSettings.OneBitSettings.OrderedDitherSettings.ShiftY * 
                            (int)(refreshCounter / OutputSettings.ImageColorSettings.OneBitSettings.OrderedDitherSettings.RefreshesPerShift)));

                    shader.SetUniform(suOneBitTop   , blankValueTop);
                    shader.SetUniform(suOneBitBottom, blankValueBottom);

                    #endregion update shader uniform

                    #region draw animation frame

                    frameSprite.Texture = frames[animationFrame];

                    if (OutputSettings.SwapXY)
                    {
                        frameSprite.Position = new Vector2f(
                            (float)window.Size.X * OutputSettings.Bounds.X,
                            (float)window.Size.Y * OutputSettings.Bounds.Y);
                        frameSprite.Origin = new Vector2f(0, frameSprite.TextureRect.Height);
                        frameSprite.Rotation = 90;
                        frameSprite.Scale = new Vector2f(
                            (window.Size.Y / (float)frameSprite.TextureRect.Width) * OutputSettings.Bounds.Height,
                            (window.Size.X / (float)frameSprite.TextureRect.Height) * OutputSettings.Bounds.Width);
                    }
                    else
                    {
                        frameSprite.Position = new Vector2f(
                            (float) window.Size.X * OutputSettings.Bounds.X,
                            (float) window.Size.Y * OutputSettings.Bounds.Y);
                        frameSprite.Scale = new Vector2f(
                        (window.Size.X / (float)frameSprite.TextureRect.Width) * OutputSettings.Bounds.Width,
                        (window.Size.Y / (float)frameSprite.TextureRect.Height) * OutputSettings.Bounds.Height);
                    }


                    foreach (var color in colorChannels)
                    {
                        var colorMap = colorChannelMap[color];

                        var renderSprite = new Sprite();

                        var rt = new RenderTexture(window.Size.X, window.Size.Y);
                        rt.Smooth = false;

                        rt.Clear(Color.Black);


                        var gradientBlend = new BlendMode(BlendMode.Factor.One, BlendMode.Factor.One, BlendMode.Equation.Add);
                        var gradientStage = new RenderStates(gradientBlend);

                        rt.Draw(gradientMap[color], gradientStage);

                        if (colorMap.CoordinateModulateWithOneBitColor || colorMap.Source == SourceChannel.Gray)
                        {
                            var oneBitMode = colorMap.CoordinateModulateWithOneBitColor & colorMap.Source != SourceChannel.Gray
                                ? OutputSettings.ImageColorSettings.OneBitSettings.Mode
                                : OneBitMode.None;

                            shader.SetUniform(suOneBitEncodingMode, (int)oneBitMode);

                            shader.SetUniform(suActiveChannel, (int)colorMap.Color);


                            var state = new RenderStates() { 
                                Transform = Transform.Identity, 
                                Shader = shader, 
                                BlendMode = oneBitMode == OneBitMode.None ? BlendMode.Add : BlendMode.Alpha
                            };

                            rt.Draw(frameSprite, state);
                        }

                        rt.Display();
                        renderSprite.Texture = rt.Texture;

                        var renderSpriteState = new RenderStates() { Transform = Transform.Identity, BlendMode = BlendMode.Add };

                        window.Draw(renderSprite, renderSpriteState);

                        rt.Dispose();

                        renderSprite.Dispose();
                    }

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
                        OutputSettings.ImageColorSettings.OneBitSettings.SwapEveryNFrame > 0 &&
                        ModF(refreshCounter, OutputSettings.ImageColorSettings.OneBitSettings.SwapEveryNFrame) == 0)
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


                foreach (var kv in gradientMap)
                {
                    kv.Value.Clear();
                    kv.Value.Dispose();
                }
                gradientMap.Clear();

                shader.Dispose();

                CurrentFps = -1;

                #endregion cleanup

            }
            catch (Exception e)
            {

            }

        }



        int ModF(float a, float b) => (int)(a - b * Math.Floor(a / b));


        float[] GenerateOrderedDitherMatrix(int matrixSize)
        {

            int Index(int i, int arraySize) => i < 0 ? arraySize + i : i % arraySize;

            // https://github.com/curioustorvald/arbitrary-bayer-matrix-generator

            var matrix = Enumerable.Range(0, matrixSize)
                .Select(a => Enumerable.Range(0, matrixSize)
                    .Select(b => -1)
                    .ToArray())
                .ToArray();

            var cellX = 0;
            var cellY = (matrixSize >> 1);

            // init matrix
            foreach (var num in Enumerable.Range(0, matrixSize * matrixSize))
            {
                int y = Index(cellY, matrixSize);

                if (matrix[y][cellX] == -1)
                {
                    matrix[y][cellX] = num;
                }
                else
                {
                    var thefuck = matrix[y][cellX];
                    throw new Exception($"Matrix position ({cellX}, {y}) is occupied by {thefuck}");
                }


                y = Index((cellY - 1) % matrixSize, matrixSize);

                if (matrix[y][(cellX + 1) % matrixSize] == -1)
                {
                    cellX = (cellX + 1) % matrixSize;
                    cellY = (cellY - 1) % matrixSize;
                }
                else
                {
                    cellY = (cellY + 1) % matrixSize;
                }

            }



            // vertical shifts
            foreach (var xpos in Enumerable.Range(0, matrixSize))
            {
                var lookup = Enumerable.Range(0, matrixSize).Select(_ => -1).ToArray();
            
                foreach (var ycursor in Enumerable.Range(0, matrixSize))
                    lookup[ycursor] = matrix[ycursor][xpos];
            
            
                foreach (var ycursor in Enumerable.Range(0, matrixSize))
                    matrix[Index((ycursor - xpos) % matrixSize, matrixSize)][xpos] = lookup[ycursor];
            }
            
            // horizontal shifts
            foreach (var ypos in Enumerable.Range(0, matrixSize))
            {
                var shift = (matrixSize - 1) - ypos + 1;
                var lookup = matrix[ypos].ToArray();
            
                foreach (var xcursor in Enumerable.Range(0, matrixSize))
                    matrix[ypos][(xcursor + shift) % matrixSize] = lookup[xcursor];
            }

            return matrix.SelectMany(m => m.Select(n => (float) n)).ToArray();

        }



        VertexArray CreateGradient(Vector2f pos, Vector2f size, ChannelsMapInfo mapinfo, bool vertical)
        {
            if (mapinfo == null || mapinfo.Source == SourceChannel.Gray)
                return new VertexArray(PrimitiveType.Quads, 4);
            
            Color MulColor(Color c, float m)
            {
                c.R = (byte)(m * (float)c.R);
                c.G = (byte)(m * (float)c.G);
                c.B = (byte)(m * (float)c.B);
                return c;
            }

            Color[] gradientColors;

            var color = _colorMap[mapinfo.Color];

            var colorRanges = OutputSettings.SourceRanges[mapinfo.Source];

            var colorMin = MulColor(color, colorRanges.Min);
            var colorMax = MulColor(color, colorRanges.Max);

            if (mapinfo.Source == SourceChannel.Min)
            {
                gradientColors = new Color[] { colorMin, colorMin, colorMin, colorMin };
            }
            else if (mapinfo.Source == SourceChannel.Max)
            {
                gradientColors = new Color[] { colorMax, colorMax, colorMax, colorMax };
            }
            else
            {
                var colorStart = colorMin;
                var colorEnd   = colorMax;

                gradientColors = vertical
                    ? new Color[] { colorStart, colorStart, colorEnd, colorEnd   }
                    : new Color[] { colorStart, colorEnd  , colorEnd, colorStart };
            }

            var res = new VertexArray(PrimitiveType.Quads, 4);
            res.Append(new Vertex(new Vector2f(pos.X         , pos.Y         ), gradientColors[0]));
            res.Append(new Vertex(new Vector2f(pos.X + size.X, pos.Y         ), gradientColors[1]));
            res.Append(new Vertex(new Vector2f(pos.X + size.X, pos.Y + size.Y), gradientColors[2]));
            res.Append(new Vertex(new Vector2f(pos.X         , pos.Y + size.Y), gradientColors[3]));

            return res;
        }


    }

}
