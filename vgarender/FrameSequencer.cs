using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace vgarender
{
    public delegate void OnNexFrameDelegate(Image image);

    public class FrameSequencer
    {
        private readonly IEnumerable<string> _files;
        private readonly int _frameInterval;
        private readonly RenderSettings _renderSettings;
        Timer _frameTimer;

        List<Image> _frames = null;
        int _currentFrameIndex = 0;

        public FrameSequencer(IEnumerable<string> files, int frameInterval, RenderSettings renderSettings)
        {
            _files = files;
            _frameInterval = frameInterval;
            _renderSettings = renderSettings;
        }


        public bool Running { get; protected set; }

        public IEnumerable<Image> Frames => _frames.AsReadOnly();


        public event OnNexFrameDelegate OnNexFrame;


        // TODO: cyclyng loading from disk instead of putting everything in memory
        public void LoadFrames()
        {
            _frames = new List<Image>();

            var renderer = new ImageRenderer();

            foreach (var filepath in _files)
            {

                using (var ms = new MemoryStream())
                {

                    using (var fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
                    {
                        fs.CopyTo(ms);
                    }

                    using (var res = renderer.Render(ms, _renderSettings))
                    {
                        res.Position = 0;
                        var image = Image.FromStream(res);
                        _frames.Add(image);
                    }
                }

            }

        }

        public void Start()
        {
            _frameTimer = new Timer(FrameTimerCallback, null, _frameInterval, _frameInterval);
            Running = true;
        }

        public void Stop()
        {
            _frameTimer.Dispose();
            _frameTimer = null;
            Running = false;
        }


        void FrameTimerCallback(object state)
        {
            _currentFrameIndex = (_currentFrameIndex + 1) % _frames.Count();
            OnNexFrame(_frames[_currentFrameIndex]);
        }


    }
}
