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

        void UpdateScreenList()
        {
            monitorListCb.Items.Clear();
            foreach (var screen in Screen.AllScreens)
            {
                monitorListCb.Items.Add(new ComboBoxItem<Screen>(screen, $"{screen.DeviceName}: {screen.Bounds.Width}x{screen.Bounds.Height} {(screen.Primary ? "Primary" : " ")}"));
            }
            monitorListCb.SelectedIndex = 0;
        }

        void UpdateCurrentScreen()
        {
            currentmonitorlabel.Text = Screen.FromControl(this).DeviceName;
        }


        private void FillLists()
        {
            var channels = new ComboBoxItem<SourceChannel>[] {
                new ComboBoxItem<SourceChannel>(SourceChannel.X   , "X Coord"),
                new ComboBoxItem<SourceChannel>(SourceChannel.Y   , "Y Coord"),
                new ComboBoxItem<SourceChannel>(SourceChannel.Gray, "Gray image"),
                new ComboBoxItem<SourceChannel>(SourceChannel.Max , "Const Max"),
                new ComboBoxItem<SourceChannel>(SourceChannel.Min , "Const Min")
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
                ( oneBitMethodRandomRb, OneBitMode.RandomNoise ),
                ( oneBitMethodOrderedRb, OneBitMode.OrderedDithering ),
                ( oneBitMethodPwmRb, OneBitMode.Pwm ),
            };

            _oneBitSwapModeMap = new List<(RadioButton rb, OneBitSwapMode swapMode)>() {
                ( blankSwapAfterRb, OneBitSwapMode.AfterPosition ),
                ( blankSwapCheckeredRb, OneBitSwapMode.Checkered ),
                ( blankSwapRandomRb, OneBitSwapMode.Random )
            };

            FillLists();

            UpdateScreenList();

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

            if (pathFileRb.Checked)
            {
                if (!File.Exists(framesdirpathed.Text))
                {
                    MessageBox.Show(this, "Select image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (pathDirRb.Checked)
            {
                if (!Directory.Exists(Path.GetDirectoryName(framesdirpathed.Text)))
                {
                    MessageBox.Show(this, "Select frames directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
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
                RefreshRate = (int)refreshrateud.Value,
                AnimationFrameRate = (int)animationFpsUd.Value,

                SourceRanges = new Dictionary<SourceChannel, RangeF>() {
                    { SourceChannel.X  , new RangeF((float)coordRangeXMinUd.Value, (float)coordRangeXMaxUd.Value) },
                    { SourceChannel.Y  , new RangeF((float)coordRangeYMinUd.Value, (float)coordRangeYMaxUd.Value) },
                    { SourceChannel.Min, new RangeF((float)coordRangeCMinUd.Value, (float)coordRangeCMinUd.Value) },
                    { SourceChannel.Max, new RangeF((float)coordRangeCMaxUd.Value, (float)coordRangeCMaxUd.Value) },
                },

                ChannelMap = new[]
                {
                    new ChannelsMapInfo() {
                        Source = ((ComboBoxItem<SourceChannel>)channelMapRedCb.SelectedItem).Value,
                        Color = ColorChannel.Red,
                        CoordinateModulateWithOneBitColor = vgachannel1BitRedChb.Checked
                    },
                    new ChannelsMapInfo() {
                        Source = ((ComboBoxItem<SourceChannel>)channelMapGreenCb.SelectedItem).Value,
                        Color = ColorChannel.Green,
                        CoordinateModulateWithOneBitColor = vgachannel1BitGreenChb.Checked
                    },
                    new ChannelsMapInfo() {
                        Source = ((ComboBoxItem<SourceChannel>)channelMapBlueCb.SelectedItem).Value,
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
                    EnableAntialiasing = enableAntialiasingChb.Checked,
                    SwapXY = swapxyChb.Checked,
                    Scale = new PointF((float)imageScaleXUd.Value, (float)imageScaleYUd.Value),
                    Gamma = (float) gammaUd.Value,
                    GrayscaleRatios = new ColorF((float)grayscaleRedUd.Value, (float)grayscaleGreenUd.Value, (float)grayscaleBlueUd.Value),
                    GrayThreshold = new RangeF((float)toneThreshBlackUd.Value, (float)toneThreshWhiteUd.Value),
                    Invert = colorInvertChb.Checked,
                    OneBitSettings = new OneBitSettings()
                    { 
                        Mode = _oneBitModeMap.First(p => p.rb.Checked).mode,

                        Blanking = new RangeF((float) blankValueBottomUd.Value, (float) blankValueTopUd.Value),
                        
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
                            ? _oneBitSwapModeMap.First(p => p.rb.Checked).swapMode
                            : OneBitSwapMode.None,

                        SwapAfter = new PointF((float) blankSwapAfterXUd.Value, (float) blankSwapAfterYUd.Value),

                        SwapCheckeredSize = new PointF((float) blankSwapCheckerWUd.Value, (float) blankSwapCheckerHUd.Value),
                    }
                }
            };

            IEnumerable<string> files = null;
            if (pathFileRb.Checked)
                files = new List<string>() { framesdirpathed.Text };
            if (pathDirRb.Checked)
                files = Directory.GetFiles(Path.GetDirectoryName(framesdirpathed.Text)).ToList();

            _drawWindow.Screen = ((ComboBoxItem<Screen>)monitorListCb.SelectedItem).Value;
            _drawWindow.Fullscreen = drawWinFullscreenChb.Checked;
            _drawWindow.Files = files;
            _drawWindow.OutputSettings = outputSettings;

            _drawWindow.Run();


            startB.Enabled = true;
        }


        private void refreshMonitoListB_Click(object sender, EventArgs e)
        {
            UpdateScreenList();
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
                if (((ComboBoxItem<SourceChannel>)cb.SelectedItem).Value == SourceChannel.X)
                    cb.SelectedItem = cb.Items.OfType<ComboBoxItem<SourceChannel>>().First(i => i.Value == SourceChannel.Y);
                else  if (((ComboBoxItem<SourceChannel>)cb.SelectedItem).Value == SourceChannel.Y)
                    cb.SelectedItem = cb.Items.OfType<ComboBoxItem<SourceChannel>>().First(i => i.Value == SourceChannel.X);

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
    }
}
