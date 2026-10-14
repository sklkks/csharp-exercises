using System;
using System.Collections.Generic;
using System.Text;

namespace CH22Q01
{
    internal interface IIntView
    {
        int Count { get; }

        int this[int index] { get; }
    }
}
