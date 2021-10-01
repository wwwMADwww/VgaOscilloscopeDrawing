using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vgarender
{
    public partial class MainForm : Form
    {

        DrawWindow _drawWindow = new DrawWindow();

        List<(RadioButton rb, OneBitMode mode)> _oneBitModeMap;

        List<(RadioButton rb, OneBitSwapMode swapMode)> _oneBitSwapModeMap;

        List<(RadioButton rb, SourceValuesDither dither)> _sourceValuesDitherMap;

        List<(RadioButton rb, ImageSource source)> _imageSourceMap;

        //List<(RadioButton rb, OneBitValues source)> _oneBitBlankingValuesMap;

        class ComboBoxItem<T>
        {
            public ComboBoxItem(T value, string description)
            {
                Value = value;
                Description = description;
            }

            public ComboBoxItem(T value): this(value, value.ToString())
            {
            }

            public T Value { get; set; }

            public String Description { get; set; }

            public override string ToString()
            {
                return Description;
            }
        }


        public MainForm()
        {
            InitializeComponent();
        }

        void UpdateScreenList(ComboBox cb)
        {
            cb.Items.Clear();
            foreach (var screen in Screen.AllScreens)
            {
                var item = new ComboBoxItem<Screen>(screen, $"{screen.DeviceName}: {screen.Bounds.Width}x{screen.Bounds.Height} {(screen.Primary ? "Primary" : " ")}");
                cb.Items.Add(item);
            }
            cb.SelectedIndex = 0;
        }

        void UpdateCurrentScreen()
        {
            currentmonitorlabel.Text = Screen.FromControl(this).DeviceName;
        }


        private void FillLists()
        {
            var channels = new ComboBoxItem<VgaSourceChannel>[] {
                new ComboBoxItem<VgaSourceChannel>(VgaSourceChannel.X   , "X Coord"),
                new ComboBoxItem<VgaSourceChannel>(VgaSourceChannel.Y   , "Y Coord"),
                new ComboBoxItem<VgaSourceChannel>(VgaSourceChannel.Gray, "Gray image"),
                new ComboBoxItem<VgaSourceChannel>(VgaSourceChannel.Max , "Const Max"),
                new ComboBoxItem<VgaSourceChannel>(VgaSourceChannel.Min , "Const Min")
            };

            channelMapRedCb.Items.Clear();
            channelMapGreenCb.Items.Clear();
            channelMapBlueCb.Items.Clear();
            foreach (var c in channels)
            {
                channelMapRedCb.Items.Add(c);
                channelMapGreenCb.Items.Add(c);
                channelMapBlueCb.Items.Add(c);
            }
            channelMapRedCb.SelectedIndex = 0;
            channelMapGreenCb.SelectedIndex = 2;
            channelMapBlueCb.SelectedIndex = 1;

            oneBitOrderedMatrixSizeCb.Items.Clear();
            oneBitOrderedMatrixSizeCb.Items.Add(new ComboBoxItem<int>(2));
            oneBitOrderedMatrixSizeCb.Items.Add(new ComboBoxItem<int>(4));
            oneBitOrderedMatrixSizeCb.Items.Add(new ComboBoxItem<int>(8));
            oneBitOrderedMatrixSizeCb.Items.Add(new ComboBoxItem<int>(16));
            oneBitOrderedMatrixSizeCb.SelectedIndex = 2;

        }

        private void LoadSettings()
        {

        }

        private void SaveSettings()
        {

        }

        private void ApplySettings()
        {

        }

        private void MainForm_Load(object sender, EventArgs eventArgs)
        {
            _oneBitModeMap = new List<(RadioButton rb, OneBitMode mode)>() {
                ( oneBitMethodRandomRb , OneBitMode.RandomNoise ),
                ( oneBitMethodOrderedRb, OneBitMode.OrderedDithering ),
                ( oneBitMethodPwmRb    , OneBitMode.Pwm ),
            };

            _oneBitSwapModeMap = new List<(RadioButton rb, OneBitSwapMode swapMode)>() {
                ( blankSwapAfterRb    , OneBitSwapMode.AfterPosition ),
                ( blankSwapCheckeredRb, OneBitSwapMode.Checkered ),
                ( blankSwapRandomRb   , OneBitSwapMode.Random )
            };

            _sourceValuesDitherMap = new List<(RadioButton rb, SourceValuesDither dither)>() {
                ( coordGradientDitherNoneRb   , SourceValuesDither.None ),
                ( coordGradientDitherRandomRb , SourceValuesDither.Random ),
                ( coordGradientDitherOrderedRb, SourceValuesDither.Ordered ),
            };

            _imageSourceMap = new List<(RadioButton rb, ImageSource source)>() {
                ( frameSourceFileRb   , ImageSource.AnimationFrames ),
                ( frameSourceScreenCaptureRb , ImageSource.ScreenCapture )
            };

            //_oneBitBlankingValuesMap = new List<(RadioButton rb, OneBitValues values)>() {
            //    ( oneBitBlankLevelsConstantRb      , OneBitValues.Constant),
            //    ( oneBitBlankLevelsNearestActiveRb , OneBitValues.NearestActivePos)
            //};

            FillLists();

            UpdateScreenList(monitorListCb);
            UpdateScreenList(captureMonitorCb);

            LoadSettings();

            ApplySettings();

            timer1.Enabled = true;
            this.TopMost = mainWinTopmostChb.Checked;
        }

        private bool ValidateControls()
        {
            if (!mainWinTopmostChb.Checked && (Screen.FromControl(this).DeviceName == ((ComboBoxItem<Screen>)monitorListCb.SelectedItem).Value.DeviceName))
            {
                if (MessageBox.Show(
                    "Control window is not topmost and will be hidden behind rendering window." + Environment.NewLine +
                    "Drawing window can be closed by presing Esc key." + Environment.NewLine +
                    "Continue?",
                    "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                    return false;
            }


            if (frameSourceFileRb.Checked)
            {

                if (allFramesFromDirChb.Checked)
                {
                    if (!Directory.Exists(Path.GetDirectoryName(framesdirpathed.Text)))
                    {
                        MessageBox.Show(this, "Select frames directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    if (!File.Exists(framesdirpathed.Text))
                    {
                        MessageBox.Show(this, "Select image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }


            return true;
        }

        private void startB_Click(object sender, EventArgs e)
        {
            startB.Enabled = false;

            if (!ValidateControls())
            {
                startB.Enabled = true;
                return;
            }

            _drawWindow.Stop();


            var outputSettings = new OutputSettings()
            {
                FrameRate = (int)refreshrateud.Value,
                AnimationFrameRate = (int)animationFpsUd.Value,

                VgaSourceValuesSettings = new VgaSourceValuesSettings()
                {

                    Ranges = new Dictionary<VgaSourceChannel, RangeF>() {
                        { VgaSourceChannel.X, new RangeF((float)coordRangeXMinUd.Value, (float)coordRangeXMaxUd.Value) },
                        { VgaSourceChannel.Y, new RangeF((float)coordRangeYMinUd.Value, (float)coordRangeYMaxUd.Value) },
                        { VgaSourceChannel.Min, new RangeF((float)coordRangeCMinUd.Value, (float)coordRangeCMinUd.Value) },
                        { VgaSourceChannel.Max, new RangeF((float)coordRangeCMaxUd.Value, (float)coordRangeCMaxUd.Value) },
                    },

                    Dither = _sourceValuesDitherMap.Single(m => m.rb.Checked).dither
                },

                ChannelMap = new[]
                {
                    new ChannelsMapInfo() {
                        VgaSource = ((ComboBoxItem<VgaSourceChannel>)channelMapRedCb.SelectedItem).Value,
                        Color = ColorChannel.Red,
                        CoordinateModulateWithOneBitColor = vgachannel1BitRedChb.Checked
                    },
                    new ChannelsMapInfo() {
                        VgaSource = ((ComboBoxItem<VgaSourceChannel>)channelMapGreenCb.SelectedItem).Value,
                        Color = ColorChannel.Green,
                        CoordinateModulateWithOneBitColor = vgachannel1BitGreenChb.Checked
                    },
                    new ChannelsMapInfo() {
                        VgaSource = ((ComboBoxItem<VgaSourceChannel>)channelMapBlueCb.SelectedItem).Value,
                        Color = ColorChannel.Blue,
                        CoordinateModulateWithOneBitColor = vgachannel1BitBlueChb.Checked
                    }
                },

                Bounds = new RectangleF(
                    (float)outputBoundsLeftUd.Value,
                    (float)outputBoundsTopUd.Value,
                    (float)(outputBoundsRightUd.Value - outputBoundsLeftUd.Value),
                    (float)(outputBoundsBottomUd.Value - outputBoundsTopUd.Value)),

                ImageSettings = new ImageSettings()
                {
                    Antialiasing = enableAntialiasingChb.Checked,
                    SwapXY = swapxyChb.Checked,
                    Scale = new PointF((float)imageScaleXUd.Value, (float)imageScaleYUd.Value),
                    Brightness = (float) brightnessUd.Value,
                    Contrast = (float) contrastUd.Value,
                    Gamma = (float) gammaUd.Value,
                    GrayscaleRatios = new ColorF((float)grayscaleRedUd.Value, (float)grayscaleGreenUd.Value, (float)grayscaleBlueUd.Value),
                    GrayThreshold = new RangeF((float)toneThreshBlackUd.Value, (float)toneThreshWhiteUd.Value),
                    Invert = colorInvertChb.Checked,
                    OneBitSettings = new OneBitSettings()
                    { 
                        Mode = _oneBitModeMap.Single(p => p.rb.Checked).mode,


                        //Values = _oneBitBlankingValuesMap.Single(i => i.rb.Checked).source,

                        Blanking = new RangeF((float) blankValueBottomUd.Value, (float) blankValueTopUd.Value),

                        //NearestActiveFallbackDistance = (float) nearestActiveDistanceUd.Value,
                        //NearestActiveNext = nearestActiveNextChb.Checked,
                        //NearestActivePrev = nearestActivePrevChb.Checked,
                        

                        OrderedDitherSettings = new OrderedDitherSettings()
                        {                             
                            MatrixSize = ((ComboBoxItem<int>) oneBitOrderedMatrixSizeCb.SelectedItem).Value,
                            RefreshesPerShift = (float) ditherOrderedShiftFrameUd.Value,
                            Shift = new PointF((float) ditherOrderedShiftXUd.Value, (float) ditherOrderedShiftYUd.Value)
                        },

                        SwapEveryNFrame = blankSwapEveryNFrameChb.Checked 
                            ? (float) blankSwapEveryNFrameUd.Value
                            : -1,

                        SwapMode = blankSwapByPosChb.Checked 
                            ? _oneBitSwapModeMap.Single(p => p.rb.Checked).swapMode
                            : OneBitSwapMode.None,

                        SwapAfter = new PointF((float) blankSwapAfterXUd.Value, (float) blankSwapAfterYUd.Value),

                        SwapCheckeredSize = new PointF((float) blankSwapCheckerWUd.Value, (float) blankSwapCheckerHUd.Value),

                    }
                },

                OutputScreen = ((ComboBoxItem<Screen>)monitorListCb.SelectedItem).Value,
                
                Fullscreen = drawWinFullscreenChb.Checked

            };

            _drawWindow.OutputSettings = outputSettings;

            var inputSettings = new InputSettings()
            {
                ImageSource = _imageSourceMap.Single(i => i.rb.Checked).source
            };

            if (frameSourceFileRb.Checked)
            {
                IEnumerable<string> files = null;
                if (allFramesFromDirChb.Checked)
                    files = Directory.GetFiles(Path.GetDirectoryName(framesdirpathed.Text)).ToList();
                else
                    files = new List<string>() { framesdirpathed.Text };

                inputSettings.AnimationFramesFiles = files;
            }
            else if (frameSourceScreenCaptureRb.Checked)
            {
                inputSettings.InputScreen = ((ComboBoxItem<Screen>)captureMonitorCb.SelectedItem).Value;
                inputSettings.CaptureArea = new Rectangle() 
                { 
                    X      = (int) captureAreaXUd.Value,
                    Y      = (int) captureAreaYUd.Value,
                    Width  = (int) captureAreaWUd.Value,
                    Height = (int) captureAreaHUd.Value
                };
            }

            _drawWindow.InputSettings = inputSettings;

            _drawWindow.Run();


            startB.Enabled = true;
        }


        private void refreshMonitoListB_Click(object sender, EventArgs e)
        {
            UpdateScreenList(monitorListCb);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateCurrentScreen();
            fpslabel.Text = _drawWindow.CurrentFps.ToString();
        }

        private void topmostChb_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = mainWinTopmostChb.Checked;
        }

        private void selectFramesPathB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(framesdirpathed.Text) &&
                (File.Exists(framesdirpathed.Text) || 
                Directory.Exists(Path.GetDirectoryName(framesdirpathed.Text)))
                )
                openFileDialog1.FileName = framesdirpathed.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                framesdirpathed.Text = openFileDialog1.FileName;
            }
        }


        private void stopB_Click(object sender, EventArgs e)
        {
            _drawWindow.Stop();
        }

        private void swapxyB_Click(object sender, EventArgs e)
        {
            new[] { channelMapRedCb, channelMapGreenCb, channelMapBlueCb }.Select(cb =>
            {
                if (((ComboBoxItem<VgaSourceChannel>)cb.SelectedItem).Value == VgaSourceChannel.X)
                    cb.SelectedItem = cb.Items.OfType<ComboBoxItem<VgaSourceChannel>>().First(i => i.Value == VgaSourceChannel.Y);
                else  if (((ComboBoxItem<VgaSourceChannel>)cb.SelectedItem).Value == VgaSourceChannel.Y)
                    cb.SelectedItem = cb.Items.OfType<ComboBoxItem<VgaSourceChannel>>().First(i => i.Value == VgaSourceChannel.X);

                return true;
            }).ToArray();
        }

        private void nofpsB_Click(object sender, EventArgs e)
        {
            refreshrateud.Value = 0;
        }

        private void vsyncB_Click(object sender, EventArgs e)
        {
            refreshrateud.Value = -1;
        }

        private void mainWinTopmostChb_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = mainWinTopmostChb.Checked;
        }

        private void refreshrateud_ValueChanged(object sender, EventArgs e)
        {
            animationFpsUd.Maximum = refreshrateud.Maximum;
        }

        private void outputBoundsResetB_Click(object sender, EventArgs e)
        {
            outputBoundsLeftUd.Value = 0;
            outputBoundsRightUd.Value = 1;
            outputBoundsTopUd.Value = 0;
            outputBoundsBottomUd.Value = 1;
        }

        private void grayscaleDefB_Click(object sender, EventArgs e)
        {
            grayscaleRedUd.Value   = 0.299M;
            grayscaleGreenUd.Value = 0.587M;
            grayscaleBlueUd.Value  = 0.114M;
        }

        private void coordRangeXInvertB_Click(object sender, EventArgs e)
        {
            (coordRangeXMinUd.Value, coordRangeXMaxUd.Value) = (coordRangeXMaxUd.Value, coordRangeXMinUd.Value);
        }

        private void coordRangeYInvertB_Click(object sender, EventArgs e)
        {
            (coordRangeYMinUd.Value, coordRangeYMaxUd.Value) = (coordRangeYMaxUd.Value, coordRangeYMinUd.Value);
        }

        private void outBoundsFlipHB_Click(object sender, EventArgs e)
        {
            (outputBoundsLeftUd.Value, outputBoundsRightUd.Value) = (outputBoundsRightUd.Value, outputBoundsLeftUd.Value);
        }

        private void outBoundsFlipVB_Click(object sender, EventArgs e)
        {
            (outputBoundsTopUd.Value, outputBoundsBottomUd.Value) = (outputBoundsBottomUd.Value, outputBoundsTopUd.Value);
        }

        private void grayscaleRedLabel_Click(object sender, EventArgs e)
        {
            if (grayscaleRedUd.Value == 1)
                grayscaleRedUd.Value = 0;
            else
                grayscaleRedUd.Value = 1;
        }

        private void grayscaleGreenLabel_Click(object sender, EventArgs e)
        {
            if (grayscaleGreenUd.Value == 1)
                grayscaleGreenUd.Value = 0;
            else
                grayscaleGreenUd.Value = 1;
        }

        private void grayscaleBlueLabel_Click(object sender, EventArgs e)
        {
            if (grayscaleBlueUd.Value == 1)
                grayscaleBlueUd.Value = 0;
            else
                grayscaleBlueUd.Value = 1;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _drawWindow.Stop();
        }

        private void captureMonitorRefreshB_Click(object sender, EventArgs e)
        {
            UpdateScreenList(captureMonitorCb);
        }

        private void captureAreaFullB_Click(object sender, EventArgs e)
        {
            if (captureMonitorCb.SelectedIndex < 0)
                return; 

            var monitor = (ComboBoxItem<Screen>) captureMonitorCb.SelectedItem;
            captureAreaXUd.Value = 0;
            captureAreaYUd.Value = 0;
            captureAreaWUd.Value = monitor.Value.WorkingArea.Width;
            captureAreaHUd.Value = monitor.Value.WorkingArea.Height;
        }

        private void colorLevelsResetB_Click(object sender, EventArgs e)
        {
            brightnessUd.Value = 0;
            contrastUd.Value = 1;
            gammaUd.Value = 1;
        }
    }
}
