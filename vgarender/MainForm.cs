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

        DrawForm _drawForm = new DrawForm();


        class Info<T>
        {
            public Info(T value, string description)
            {
                Value = value;
                Description = description;
            }

            public Info(T value): this(value, value.ToString())
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
                monitorListCb.Items.Add(new Info<Screen>(screen, $"{screen.DeviceName}: {screen.Bounds.Width}x{screen.Bounds.Height} {(screen.Primary ? "Primary" : " ")}"));
            }
            monitorListCb.SelectedIndex = 0;
        }

        void UpdateCurrentScreen()
        {
            currentmonitorlabel.Text = Screen.FromControl(this).DeviceName;
        }


        private void FillLists()
        {
            var channels = new Info<AxisChannel>[] {
                new Info<AxisChannel>(AxisChannel.X),
                new Info<AxisChannel>(AxisChannel.Y),
                new Info<AxisChannel>(AxisChannel.Z),
                new Info<AxisChannel>(AxisChannel.Min),
                new Info<AxisChannel>(AxisChannel.Max)
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


            imageColorZCb.Items.Clear();
            imageColorZCb.Items.Add(new Info<ChannelZSourceChannel>(ChannelZSourceChannel.Red));
            imageColorZCb.Items.Add(new Info<ChannelZSourceChannel>(ChannelZSourceChannel.Green));
            imageColorZCb.Items.Add(new Info<ChannelZSourceChannel>(ChannelZSourceChannel.Blue));
            imageColorZCb.Items.Add(new Info<ChannelZSourceChannel>(ChannelZSourceChannel.Grayscale, "Grayscale from all channels"));
            imageColorZCb.SelectedIndex = 3;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            FillLists();

            UpdateScreenList();

            LoadSettings();

            ApplySettings();

            timer1.Enabled = true;
            this.TopMost = mainWinTopmostChb.Checked;
        }

        private bool ValidateControls()
        {
            if (!mainWinTopmostChb.Checked && (Screen.FromControl(this).DeviceName == ((Info<Screen>)monitorListCb.SelectedItem).Value.DeviceName))
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
            if (!ValidateControls())
                return;

            if (_drawForm.Running)
                _drawForm.Stop();

            var rednerSettings = new RenderSettings()
            {
                ChannelZSourceChannel = ((Info<ChannelZSourceChannel>)imageColorZCb.SelectedItem).Value,
                SwapXY = swapxyChb.Checked,
                ChannelMap = new[] 
                {
                    new ColorAxisMapInfo(((Info<AxisChannel>)channelMapRedCb.SelectedItem).Value  , ColorChannel.Red  , vgachannelinvertRedChb.Checked  ),
                    new ColorAxisMapInfo(((Info<AxisChannel>)channelMapGreenCb.SelectedItem).Value, ColorChannel.Green, vgachannelinvertGreenChb.Checked),
                    new ColorAxisMapInfo(((Info<AxisChannel>)channelMapBlueCb.SelectedItem).Value , ColorChannel.Blue , vgachannelinvertBlueChb.Checked )
                }
            };

            if (pathFileRb.Checked)
                _drawForm.Files = new List<string>() { framesdirpathed.Text };
            if (pathDirRb.Checked)
                _drawForm.Files = Directory.GetFiles(Path.GetDirectoryName(framesdirpathed.Text)).ToList();

            _drawForm.FrameInterval = (int)frameintervalud.Value;
            _drawForm.Screen = ((Info<Screen>)monitorListCb.SelectedItem).Value;
            _drawForm.RenderSettings = rednerSettings;
            _drawForm.DisableAntialiasing = disableAntialiasingChb.Checked;
            // _drawForm.BlankFrames = (int)blankFramesUd.Value;
            _drawForm.Fullscreen = drawWinFullscreenChb.Checked;
            _drawForm.Start();
        }


        private void refreshMonitoListB_Click(object sender, EventArgs e)
        {
            UpdateScreenList();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateCurrentScreen();
            frameproctimelabel.Text = _drawForm.LastProcessingTime.ToString();
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
            _drawForm.Stop();
        }

        private void swapxyB_Click(object sender, EventArgs e)
        {
            new[] { channelMapRedCb, channelMapGreenCb, channelMapBlueCb }.Select(cb =>
            {
                if (((Info<AxisChannel>)cb.SelectedItem).Value == AxisChannel.X)
                    cb.SelectedItem = cb.Items.OfType<Info<AxisChannel>>().First(i => i.Value == AxisChannel.Y);
                else  if (((Info<AxisChannel>)cb.SelectedItem).Value == AxisChannel.Y)
                    cb.SelectedItem = cb.Items.OfType<Info<AxisChannel>>().First(i => i.Value == AxisChannel.X);

                return true;
            }).ToArray();
        }
    }
}
