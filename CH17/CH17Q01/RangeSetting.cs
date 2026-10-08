using System;
using System.Collections.Generic;
using System.Text;

namespace CH17Q01
{
    public class RangeSetting
    {

        private int lower = 0;
        private int upper = 30;

        public int Lower => lower;
        public int Upper => upper;
        public bool TrySet(int lower, int upper)
        {
            if (lower >= -20 && lower <= 50 && upper >= -20 &&
                upper <= 50 && lower <= upper)
            {
                this.lower = lower;
                this.upper = upper;
                return true;
            }
            return false;
        }

        public int Width => upper - lower;

    }
}