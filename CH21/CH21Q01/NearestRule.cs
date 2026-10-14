using CH21Q01;
using System;
using System.Collections.Generic;
using System.Text;

namespace CH21Q01
{
    internal class NearestRule : ValueRule
    {
        public NearestRule(int interval) : base(interval) { }
        public override int Adjust(int value)
        {
            return (int)(Math.Round((double)value / interval, MidpointRounding.AwayFromZero) * interval);
        }
    }
}

