using System;
using System.Collections.Generic;
using System.Text;

namespace CH23Q01
{
    internal struct StockState
    {
        public int Total;
        public int Reserved;
        public int Available => Total - Reserved;

        public StockState(int total, int reserved)
        {
            Total = total;
            Reserved = reserved;
        }

        public override string ToString()
        {
            return $"예약: {Reserved}, 남은: {Available}";
        }
    }
}
