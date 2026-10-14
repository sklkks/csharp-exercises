using System;
using System.Collections.Generic;
using System.Text;

namespace CH21Q10
{
    internal class RangeQuestion : Question
    {
        private readonly int min;
        private readonly int max;
        public RangeQuestion(int min, int max)
        {
            this.min = min;
            this.max = max;
        }
        protected override bool Check(string answer)
        {
            return int.TryParse(answer, out int value) && value >= min && value <= max;
        }
    }
}
