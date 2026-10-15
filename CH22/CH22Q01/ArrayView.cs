using System;
using System.Collections.Generic;
using System.Text;

namespace CH22Q01
{
    internal class ArrayView : IIntView
    {
        private readonly int[] values;

        public ArrayView(int[] values)
        {
            this.values = values;
        }
        public int this[int index]
        {
            get
            {
                if(index < 0 || index >= values.Length)
                {
                    return 0;

                }
                return values[index];
            }
        }
        public int Count => throw new NotImplementedException();
    }
}
