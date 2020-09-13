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

        Image _currentFrameImage = null;

        public Screen Screen { get; set; }
        public bool DisableAntialiasing { get; set; }
        public bool Fullscreen { get; set; }

        public long LastProcessingTime { get; protected set; }


        public DrawForm()
        {
            InitializeComponent();
        }

        public void Show2()
        {

            pictureBox1.Image = null;


            if (Fullscreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.Visible = true;
                this.Left = Screen.Bounds.X;
                this.Top = Screen.Bounds.Y;
                this.Width = Screen.Bounds.Width;
                this.Height = Screen.Bounds.Height;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.SizableToolWindow;
                this.Visible = true;
                this.Left = Screen.Bounds.X;
                this.Top = Screen.Bounds.Y;
                this.Width = 640;
                this.Height = 480;
            }

        }


        public void Hide2()
        {
            this.Visible = false;
            _currentFrameImage = null;
        }

        private delegate void SafeCallDelegate();

        public void SetFrame(Image image)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (!DisableAntialiasing)
            {
                pictureBox1.Invoke(new SafeCallDelegate(() => pictureBox1.Image = image));
            }
            else
            {
                pictureBox1.Invoke(new SafeCallDelegate(() =>
                {
                    pictureBox1.Image = null;
                    _currentFrameImage = image;
                    pictureBox1.Refresh();
                }));
            }

            sw.Stop();
            LastProcessingTime = sw.ElapsedMilliseconds;

        }

        private void DrawForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide2();
            e.Cancel = true;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (!DisableAntialiasing || _currentFrameImage == null)
                return;

            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
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
                this.Hide2();
        }
    }
}
