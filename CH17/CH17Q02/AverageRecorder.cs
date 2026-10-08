using System;
using System.Collections.Generic;
using System.Text;

namespace CH17Q02
{
    public class AverageRecorder
    {
        private int sum = 0;
        private int count = 0;

        public void Add(int value)
        {
            sum += value;
            count++;
        }

        public int GetCount()
        {
            return count;
        }

        public double GetAverage()
        {
            if (count == 0)
            {
                return 0.0;
            }
            return (double)sum / count;
        }
    }
}