using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace vgarender
{
    public partial class DrawForm : Form
    {

        int _currentFrameIndex = 0;
        int _blankFramesCounter = 0;

        ImageRenderer _renderer = new ImageRenderer();

        Image _currentFrameImage = null;

        public List<string> Files { get; set; }
        public Screen Screen { get; set; }
        public int FrameInterval { get; set; }
        public bool DisableAntialiasing { get; set; }
        public RenderSettings RenderSettings { get; set; }
        public int BlankFrames { get; set; }


        public long LastProcessingTime { get; protected set; }
        public bool Running { get; protected set; }


        public DrawForm()
        {
            InitializeComponent();
        }

        public void Start()
        {
            if (Running)
                return;

            _currentFrameIndex = 0;

            Running = true;

            pictureBox1.Image = null;

            this.Visible = true;
            this.Left = Screen.Bounds.X;
            this.Top = Screen.Bounds.Y;
            this.Width = Screen.Bounds.Width;
            this.Height = Screen.Bounds.Height;


            timer1.Interval = FrameInterval;
            timer1.Enabled = true;

        }


        public void Stop()
        {
            if (!Running)
                return;

            timer1.Enabled = false;

            Running = false;
            this.Visible = false;

            Files.Clear();

            _currentFrameImage = null;


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!Running)
                return;

            if (_blankFramesCounter < BlankFrames)
            {
                Thread.Sleep((int)LastProcessingTime);
                _currentFrameImage = null;
                pictureBox1.Image = null;
                pictureBox1.Refresh();
                _blankFramesCounter++;
                return;
            }

            _blankFramesCounter = 0;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            var filepath = Files[_currentFrameIndex];

            var ms = new MemoryStream();

            var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            fs.CopyTo(ms);
            fs.Close();
            fs.Dispose();



            var res = _renderer.Render(ms, RenderSettings);

            ms.Position = 0;
            if (!DisableAntialiasing)
            {
                pictureBox1.Image = Bitmap.FromStream(res);
            }
            else
            {
                pictureBox1.Image = null;
                _currentFrameImage = Bitmap.FromStream(res);
                pictureBox1.Refresh();
            }

            res.SetLength(0);
            res.Close();
            ms.SetLength(0);
            ms.Close();

            _currentFrameIndex = (_currentFrameIndex + 1) % Files.Count();


            sw.Stop();
            LastProcessingTime = sw.ElapsedMilliseconds;

        }

        private void DrawForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Stop();
            e.Cancel = true;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (!DisableAntialiasing || _currentFrameImage == null)
                return;

            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            // e.Graphics.DrawImage(_currentFrame, GetScaledImageRect(_currentFrame, (Control)sender));
            e.Graphics.DrawImage(_currentFrameImage, pictureBox1.ClientRectangle);
        }

        // public RectangleF GetScaledImageRect(Image image, Control canvas)
        // {
        //     return GetScaledImageRect(image, canvas.ClientSize);
        // }
        // 
        // public RectangleF GetScaledImageRect(Image image, SizeF containerSize)
        // {
        //     RectangleF imgRect = RectangleF.Empty;
        // 
        //     Single scaleFactor = (image.Width / image.Height);
        //     Single containerRatio = containerSize.Width / containerSize.Height;
        // 
        //     if (containerRatio >= scaleFactor)
        //     {
        //         imgRect.Size = new SizeF(containerSize.Height * scaleFactor, containerSize.Height);
        //         imgRect.Location = new PointF((containerSize.Width - imgRect.Width) / 2, 0);
        //     }
        //     else
        //     {
        //         imgRect.Size = new SizeF(containerSize.Width, containerSize.Width / scaleFactor);
        //         imgRect.Location = new PointF(0, (containerSize.Height - imgRect.Height) / 2);
        //     }
        // 
        //     return imgRect;
        // }

        private void DrawForm_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Stop();
        }
    }
}
