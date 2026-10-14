using System;
using System.Collections.Generic;
using System.Text;

namespace CH21Q01
{
    internal class FloorRule : ValueRule
    {
        public FloorRule(int interval) : base(interval) { }
        
        public override int Adjust(int value)
        {
            return (value / interval) * interval;
        }
    } 
}
