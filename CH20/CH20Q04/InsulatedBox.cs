using System;
using System.Collections.Generic;
using System.Text;

namespace CH20Q04
{
    internal class InsulatedBox : Box
    {
        public readonly int InternalVolume;

        public InsulatedBox(int width, int length, int height, int insulation) : base(width, length, height)
        {
            int innerWidth = Math.Clamp(Width - 2 * insulation, 0, Width);
            int innerLength = Math.Clamp(Length - 2 * insulation, 0, Length);
            int innerHeight = Math.Clamp(Height - 2 * insulation, 0, Height);
            InternalVolume = innerWidth * innerLength * innerHeight;
        }
    }
}
