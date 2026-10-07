using System;
using System.Collections.Generic;
using System.Text;

namespace CH16Q05
{
    internal class Rate
    {
        public int UnitPrice;
    }

    internal class Subscriber
    {
        public string Name;
        public int Usage;
        public Rate Rate;

        public int GetCharge()
        {
            return Usage * Rate.UnitPrice;
        }
    }
}
