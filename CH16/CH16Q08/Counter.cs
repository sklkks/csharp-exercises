using System;
using System.Collections.Generic;
using System.Text;

namespace CH16Q08
{
    internal class Counter
    {
        public string Name;
        public int Capacity;
        public int Waiting;

        public bool CanAccept(int amount)
        {
            return amount > 0 && Waiting + amount <= Capacity;
        }
        public void Accept(int amount)
        {
            if (CanAccept(amount))
            {
                Waiting += amount;
            }
        }
    }
}
