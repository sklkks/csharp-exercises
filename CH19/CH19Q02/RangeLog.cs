using System;
using System.Collections.Generic;
using System.Text;

namespace CH19Q02
{
    internal class RangeLog
    {
        public int Count { get; private set; }
        public int Minimum { get; private set; }
        public int Maximum { get; private set; }
        public int Spread;

        public RangeLog(int value)
        {
            Count = value;
            Minimum = int.MaxValue;
            Maximum = int.MinValue;
            Spread = 0;
        }

        public void Record(int value)
        {
            if (value < Minimum) Minimum = value;
            if (value > Maximum) Maximum = value;
            Spread = Maximum - Minimum;
        }
    }

}

