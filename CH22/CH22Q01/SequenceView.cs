using System;
using System.Collections.Generic;
using System.Text;

namespace CH22Q01
{
    internal class SequenceView : IIntView
    {
        private readonly int start;
        private readonly int step;

        public SequenceView(int start, int step, int count)
        {
            this.start = start;
            this.step = step;
            Count = count;
        }

        public int Count { get; }
        public int this[int index]
        {
            get
            {
                if(index < 0 || index >= Count)
                {
                    return 0;
                }
                return start + step * index;
            }
        }


    }
}
