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
                new ComboBoxItem<SourceChannel>(SourceChannel.X),
                new ComboBoxItem<SourceChannel>(SourceChannel.Y),
                new ComboBoxItem<SourceChannel>(SourceChannel.Gray),
                new ComboBoxItem<SourceChannel>(SourceChannel.Max),
                new ComboBoxItem<SourceChannel>(SourceChannel.Min)
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


            // imageColorZCb.Items.Clear();
            // imageColorZCb.Items.Add(new ComboBoxItem<ChannelZSourceChannel>(ChannelZSourceChannel.Red));
            // imageColorZCb.Items.Add(new ComboBoxItem<ChannelZSourceChannel>(ChannelZSourceChannel.Green));
            // imageColorZCb.Items.Add(new ComboBoxItem<ChannelZSourceChannel>(ChannelZSourceChannel.Blue));
            // imageColorZCb.Items.Add(new ComboBoxItem<ChannelZSourceChannel>(ChannelZSourceChannel.Grayscale, "Grayscale from all channels"));
            // imageColorZCb.SelectedIndex = 3;
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
                ( blankSwapEveryRb, OneBitSwapMode.EveryNPixels ),
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
                SwapXY = swapxyChb.Checked,
                DisableAntialiasing = disableAntialiasingChb.Checked,
                RefreshRate = (int)refreshrateud.Value,
                AnimationFrameRate = (int)animationFpsUd.Value,

                ChannelMap = new[]
                {
                    new ChannelsMapInfo() {
                        Source = ((ComboBoxItem<SourceChannel>)channelMapRedCb.SelectedItem).Value,
                        Color = ColorChannel.Red,
                        Invert = vgachannelinvertRedChb.Checked,
                        OneBitColor = vgachannel1BitRedChb.Checked
                    },
                    new ChannelsMapInfo() {
                        Source = ((ComboBoxItem<SourceChannel>)channelMapGreenCb.SelectedItem).Value,
                        Color = ColorChannel.Green,
                        Invert = vgachannelinvertGreenChb.Checked,
                        OneBitColor = vgachannel1BitGreenChb.Checked
                    },
                    new ChannelsMapInfo() {
                        Source = ((ComboBoxItem<SourceChannel>)channelMapBlueCb.SelectedItem).Value,
                        Color = ColorChannel.Blue,
                        Invert = vgachannelinvertBlueChb.Checked,
                        OneBitColor = vgachannel1BitBlueChb.Checked
                    }
                },

                Bounds = new RectangleF(
                    (float) outputBoundsLeftUd.Value,
                    (float) outputBoundsTopUd.Value,
                    (float) (outputBoundsRightUd.Value - outputBoundsLeftUd.Value),
                    (float) (outputBoundsBottomUd.Value - outputBoundsTopUd.Value)),
                
                ImageColorSettings = new ImageColorSettings()
                { 
                    Gamma = (float) gammaUd.Value,
                    GrayscaleRatios = new float[] { (float)grayscaleRedUd.Value, (float)grayscaleGreenUd.Value, (float)grayscaleBlueUd.Value, },
                    GrayThresholdBlack = (float)toneThreshBlackUd.Value,
                    GrayThresholdWhite = (float)toneThreshWhiteUd.Value,
                    OneBitSettings = new OneBitSettings()
                    { 
                        Mode = _oneBitModeMap.First(p => p.rb.Checked).mode,

                        BlankingBottom = (float) blankValueBottomUd.Value,
                        BlankingTop = (float) blankValueTopUd.Value,
                        
                        OrderedDitherSettings = new OrderedDitherSettings()
                        { 
                            MatrixSize = (int) ditherOrderedMatrixUd.Value,
                            RefreshesPerShift = (float) ditherOrderedShiftFrameUd.Value,
                            ShiftX = (float) ditherOrderedShiftXUd.Value,
                            ShiftY = (float) ditherOrderedShiftYUd.Value
                        },

                        SwapMode = _oneBitSwapModeMap.First(p => p.rb.Checked).swapMode,

                        SwapAfterX = (float) blankSwapAfterXUd.Value,
                        SwapAfterY = (float) blankSwapAfterYUd.Value,

                        SwapEveryX = (float) blankSwapEveryXUd.Value,
                        SwapEveryY = (float) blankSwapEveryYUd.Value,
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

        private void sourceGb_Enter(object sender, EventArgs e)
        {

        }
    }
}
