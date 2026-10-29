using System;
using System.Collections.Generic;
using System.Text;

namespace CH26Q04
{
    internal class Accunulator
    {
        public int Value { get; private set; } = 1;
        public int Calls { get; private set; } = 0;

        public void Add(int value)
        {
            Value += value;
            Calls++;
        }
        public void Multiply(int value)
        {
            Value *= value;
            Calls++;
        }
    }
}
