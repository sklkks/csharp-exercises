using System;
using System.Collections.Generic;
using System.Text;

namespace CH21Q01
{
    internal class ValueRule
    {
        protected int interval;
        public ValueRule(int interval)
        {
            this.interval = interval;
        }

        public virtual int Adjust(int value)
        {
            return value;
        }

    }
}