﻿//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace vgarender
//{
//    public enum ColorChannel { Red = 0, Green = 1, Blue = 2 };
//    public enum ChannelZSourceChannel { Red = 0, Green = 1, Blue = 2, Grayscale = 3 };
//    public enum AxisChannel { X = 0, Y = 1, Z = 2 };


//    public class RenderSettings
//    {
//        public Dictionary<AxisChannel, ColorMapInfo> ChannelMap { get; set; }
//        public ChannelZSourceChannel ChannelZSourceChannel { get; set; }
//        public bool SwapXY { get; set; }
//    }

//    public class ColorMapInfo
//    {
//        public ColorMapInfo(ColorChannel channel, bool invert = false)
//        {
//            Channel = channel;
//            Invert = invert;
//        }

//        public ColorChannel Channel { get; set; }
//        public bool Invert { get; set; }
//    }


//    public class ImageRenderer
//    {
//        const int colorIndexRed = 2;
//        const int colorIndexGreen = 1;
//        const int colorIndexBlue = 0;

//        const int vgaColorResolution = 255;

//        public Stream Render(Stream stream, RenderSettings settings)
//        {
//            stream.Position = 0;

//            var ms = new MemoryStream();
//            stream.CopyTo(ms);

//            ms.Position = 0;
//            var sr = new BinaryReader(ms);
//            var sw = new BinaryWriter(ms);


//            // header

//            UInt16 bfType = sr.ReadUInt16();
//            if (bfType != 19778) // "BM" at the start
//                throw new ArgumentException($"File is not BMP.");

//            UInt32 bfSize = sr.ReadUInt32();
//            UInt16 bfReserved1 = sr.ReadUInt16();
//            UInt16 bfReserved2 = sr.ReadUInt16();
//            UInt32 bfOffBits = sr.ReadUInt32();

//            UInt32 biSize = sr.ReadUInt32();
//            Int32 biWidth = sr.ReadInt32();
//            Int32 biHeight = sr.ReadInt32();
//            UInt16 biPlanes = sr.ReadUInt16();
//            UInt16 biBitCount = sr.ReadUInt16();
//            UInt32 biCompression = sr.ReadUInt32();
//            UInt32 biSizeImage = sr.ReadUInt32();
//            Int32 biXPelsPerMeter = sr.ReadInt32();
//            Int32 biYPelsPerMeter = sr.ReadInt32();
//            UInt32 biClrUsed = sr.ReadUInt32();
//            UInt32 biClrImportant = sr.ReadUInt32();


//            if (biBitCount != 24)
//                throw new ArgumentException($"BMP BitCount must be 24, {biBitCount} given.");

//            if (biCompression != 0)
//                throw new ArgumentException($"BMP Compression must be 0, {biCompression} given.");

//            ms.Position = bfOffBits;



//            int x = 0, y = 0;

//            int i = 0;

//            int padding = biWidth % 4;

//            // pixel direction - left to right, bottom to top

//            int colorX = 2 - (int)settings.ChannelMap[AxisChannel.X].Channel;
//            int colorY = 2 - (int)settings.ChannelMap[AxisChannel.Y].Channel;
//            int colorZ = 2 - (int)settings.ChannelMap[AxisChannel.Z].Channel;

//            bool invertX = settings.ChannelMap[AxisChannel.X].Invert;
//            bool invertY = settings.ChannelMap[AxisChannel.Y].Invert;
//            bool invertZ = settings.ChannelMap[AxisChannel.Z].Invert;

//            float xkoeff = biWidth / (float)vgaColorResolution;
//            float ykoeff = biHeight / (float)vgaColorResolution;

//            while (true)
//            {

//                // reversed - 012 BGR
//                var pixel = sr.ReadBytes(3);
//                ms.Position -= 3;

//                byte z = 0;

//                switch (settings.ChannelZSourceChannel)
//                {
//                    case ChannelZSourceChannel.Red: z = pixel[colorIndexRed]; break;
//                    case ChannelZSourceChannel.Green: z = pixel[colorIndexGreen]; break;
//                    case ChannelZSourceChannel.Blue: z = pixel[colorIndexBlue]; break;
//                    case ChannelZSourceChannel.Grayscale:
//                        // almost fisrt from google
//                        z = (byte)(.21 * pixel[colorIndexRed] + .71 * pixel[colorIndexGreen] + .071 * pixel[colorIndexBlue]);
//                        break;
//                }

//                pixel[colorX] = (byte)(x / xkoeff);
//                if (invertX)
//                    pixel[colorX] = (byte)(vgaColorResolution - pixel[colorX]);

//                pixel[colorY] = (byte)(y / ykoeff);
//                if (invertY)
//                    pixel[colorY] = (byte)(vgaColorResolution - pixel[colorY]);

//                pixel[colorZ] = z;
//                if (invertZ)
//                    pixel[colorZ] = (byte)(vgaColorResolution - pixel[colorZ]);

//                sw.Write(pixel);

//                x++;

//                if (x >= biWidth)
//                {
//                    ms.Position += padding;

//                    x = 0;
//                    y++;
//                    if (y >= biHeight)
//                    {
//                        break;
//                    }
//                }

//            }

//            return ms;

//        }


//    }

//}