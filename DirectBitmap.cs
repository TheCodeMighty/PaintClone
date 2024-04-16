﻿using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


//https://stackoverflow.com/questions/24701703/c-sharp-faster-alternatives-to-setpixel-and-getpixel-for-bitmaps-for-windows-f/34801225#34801225

namespace WinFormsLab
{
    public class DirectBitmap : IDisposable
    {
        public Bitmap Bitmap { get; private set; }
        public Int32[] Bits { get; private set; }
        public bool Disposed { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        protected GCHandle BitsHandle { get; private set; }

        public DirectBitmap(int width, int height)
        {
            Width = width;
            Height = height;
            Bits = new Int32[width * height];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width * 4, PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());
        }

        public void SetPixel(int x, int y, Color color)
        {
            if (x >= 0 && y >= 0 && x < Width && y < Height)
            {
                int index = x + (y * Width);
                int col = color.ToArgb();
                Bits[index] = col;
            }
        }

        public Color GetPixel(int x, int y)
        {
            if (x >= 0 && y >= 0 && x < Width && y < Height)
            {
                int index = x + (y * Width);
                int col = Bits[index];
                return Color.FromArgb(col);
            }
            return Color.Transparent;
        }

        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;
            Bitmap.Dispose();
            BitsHandle.Free();
        }
    }
}
