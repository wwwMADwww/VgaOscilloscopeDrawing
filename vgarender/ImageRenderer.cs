using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace vgarender
{
    public enum ColorChannel { Red = 0, Green = 1, Blue = 2 };
    public enum ChannelZSourceChannel { Red = 0, Green = 1, Blue = 2, Grayscale = 3 };
    public enum AxisChannel { X = 0, Y = 1, Z = 2, Min = 3, Max = 4 };


    public class RenderSettings
    {
        public IEnumerable<ColorAxisMapInfo> ChannelMap { get; set; }

        public ChannelZSourceChannel ChannelZSourceChannel { get; set; }
        public bool SwapXY { get; set; }
    }

    public class ColorAxisMapInfo
    {
        public ColorAxisMapInfo(AxisChannel axis, ColorChannel color, bool invert = false)
        {
            Axis = axis;
            Color = color;
            Invert = invert;
        }

        public AxisChannel Axis { get; set; }
        public ColorChannel Color { get; set; }
        public bool Invert { get; set; }
    }


    public class ImageRenderer
    {
        const int colorIndexRed = 2;
        const int colorIndexGreen = 1;
        const int colorIndexBlue = 0;

        const byte rgbMin = 0;
        const byte rgbMax = 255;

        const UInt16 bmpSignature = 19778; // "BM" at the start

        const int bmpHeaderSizePos = 2;
        const int bmpHeaderOffBitsPos = 10;
        const int bmpHeaderWidthPos = 18;
        const int bmpHeaderHeightPos = 22;
        const int bmpHeaderSizeImagePos = 90;

        const int pixelBytes = 3; // RGB

        const int vgaColorResolution = 255;

        public Stream Render(Stream stream, RenderSettings settings)
        {
            stream.Position = 0;
            var sr = new BinaryReader(stream);

            // header

            UInt16 bfType = sr.ReadUInt16();
            if (bfType != bmpSignature)
                throw new ArgumentException($"File is not BMP.");

            UInt32 bfSize = sr.ReadUInt32();
            UInt16 bfReserved1 = sr.ReadUInt16();
            UInt16 bfReserved2 = sr.ReadUInt16();
            UInt32 bfOffBits = sr.ReadUInt32();

            UInt32 biSize = sr.ReadUInt32();
            Int32 biWidth = sr.ReadInt32();
            Int32 biHeight = sr.ReadInt32();
            UInt16 biPlanes = sr.ReadUInt16();
            UInt16 biBitCount = sr.ReadUInt16();
            UInt32 biCompression = sr.ReadUInt32();
            UInt32 biSizeImage = sr.ReadUInt32();
            Int32 biXPelsPerMeter = sr.ReadInt32();
            Int32 biYPelsPerMeter = sr.ReadInt32();
            UInt32 biClrUsed = sr.ReadUInt32();
            UInt32 biClrImportant = sr.ReadUInt32();

            int paddingSource = biWidth % 4;

            if (biBitCount != 24)
                throw new ArgumentException($"BMP BitCount must be 24, {biBitCount} given.");

            if (biCompression != 0)
                throw new ArgumentException($"BMP Compression must be 0, {biCompression} given.");




            var ms = new MemoryStream();
            ms.Position = 0;
            var sw = new BinaryWriter(ms);

            sr.BaseStream.Position = 0;
            sw.Write(sr.ReadBytes((int)bfOffBits));


            int resultPadding;
            int resultWidth, resultHeight;

            if (settings.SwapXY)
            {
                resultWidth = biHeight;
                resultHeight = biWidth;
                resultPadding = resultWidth % 4;


                sw.Seek(bmpHeaderSizePos, SeekOrigin.Begin);
                sw.Write(sw.BaseStream.Length);

                sw.Seek(bmpHeaderWidthPos, SeekOrigin.Begin);
                sw.Write(resultWidth);

                sw.Seek(bmpHeaderHeightPos, SeekOrigin.Begin);
                sw.Write(resultHeight);

            }
            else
            {
                resultWidth = biWidth;
                resultHeight = biHeight;
                resultPadding = paddingSource;

            }

            int sizeImage = (resultWidth * pixelBytes + resultPadding) * resultHeight;
            sw.BaseStream.SetLength(bfOffBits + sizeImage);

            sw.Seek(bmpHeaderSizeImagePos, SeekOrigin.Begin);
            sw.Write(sizeImage);


            sr.BaseStream.Position = bfOffBits;

            sw.Seek((int)bfOffBits, SeekOrigin.Begin);




            var mapR = settings.ChannelMap.First(m => m.Color == ColorChannel.Red);
            var mapG = settings.ChannelMap.First(m => m.Color == ColorChannel.Green);
            var mapB = settings.ChannelMap.First(m => m.Color == ColorChannel.Blue);


            float xkoeff = biWidth  / (float)vgaColorResolution;
            float ykoeff = biHeight / (float)vgaColorResolution;

            int x = 0, y = 0;

            while (true)
            {

                // reversed - 012 BGR
                var pixel = sr.ReadBytes(3);

                byte z = 0;

                switch (settings.ChannelZSourceChannel)
                {
                    case ChannelZSourceChannel.Red  : z = pixel[colorIndexRed]; break;
                    case ChannelZSourceChannel.Green: z = pixel[colorIndexGreen]; break;
                    case ChannelZSourceChannel.Blue : z = pixel[colorIndexBlue]; break;
                    case ChannelZSourceChannel.Grayscale:
                        // almost fisrt from google
                        z = (byte)(.21 * pixel[colorIndexRed] + .71 * pixel[colorIndexGreen] + .071 * pixel[colorIndexBlue]);
                        break;
                }

                byte GetColor(ColorAxisMapInfo mapinfo)
                {
                    byte xx, yy;

                    if (settings.SwapXY)
                    {
                        xx = (byte)(y / ykoeff);
                        yy = (byte)(x / xkoeff);
                    }
                    else
                    {
                        xx = (byte)(x / xkoeff);
                        yy = (byte)((biHeight - 1 - y) / ykoeff);
                    }


                    switch (mapinfo.Axis)
                    {
                        case AxisChannel.X  : return mapinfo.Invert ? (byte)(rgbMax - xx) : xx;
                        case AxisChannel.Y  : return mapinfo.Invert ? (byte)(rgbMax - yy) : yy;
                        case AxisChannel.Z  : return mapinfo.Invert ? (byte)(rgbMax - z) : z;
                        case AxisChannel.Min: return mapinfo.Invert ? (byte)(rgbMax - rgbMin) : rgbMin;
                        case AxisChannel.Max: return mapinfo.Invert ? (byte)(rgbMax - rgbMax) : rgbMax;
                        default:
                            throw new ArgumentException($"Unknown AxisChannel {mapinfo.Axis}");
                    }
                }


                pixel[colorIndexRed]   = GetColor(mapR);
                pixel[colorIndexGreen] = GetColor(mapG);
                pixel[colorIndexBlue]  = GetColor(mapB);


                if (settings.SwapXY)
                {
                    sw.BaseStream.Position = 
                        bfOffBits + 
                        ((resultWidth * pixelBytes + resultPadding) * ((resultHeight - 1) - x)) + 
                        (pixelBytes * y);
                }
                else
                {
                    sw.BaseStream.Position =
                        bfOffBits +
                        ((resultWidth * pixelBytes + resultPadding) * y) +
                        (pixelBytes * x);
                }

                sw.Write(pixel);



                x++;

                if (x >= biWidth)
                {
                    sr.BaseStream.Position += paddingSource;

                    x = 0;
                    y++;
                    if (y >= biHeight)
                    {
                        break;
                    }
                }

            }

            return ms;



        }


    }

}
