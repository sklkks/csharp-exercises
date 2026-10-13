using System;
using System.Collections.Generic;
using System.Text;

namespace CH20Q02
{
    internal class PositiveRecorder : RecordStore 
    {
        public PositiveRecorder(int capacity) : base(capacity)
        {

        }
            public bool Record(int value)
            {
                return value > 0 && TryAppend(value);
        
            }
    }
}
