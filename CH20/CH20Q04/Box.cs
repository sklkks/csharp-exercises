using System;
using System.Collections.Generic;
using System.Text;

namespace CH20Q04
{
    internal class Box
    {
        public readonly int Width;
        public readonly int Length;
        public readonly int Height;

        public int ExternalVolume => Width * Length * Height;
        public Box(int width, int length, int height)
        {
            Width = Math.Clamp(width, 1, 8);
            Length = Math.Clamp(length, 1, 8);
            Height = Math.Clamp(height, 1, 8);
        }
    }
}
