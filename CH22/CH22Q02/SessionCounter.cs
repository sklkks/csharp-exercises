using System;
using System.Collections.Generic;
using System.Text;

namespace CH22Q02
{
    internal class SessionCounter : ILifetime, ISession
    {
        public int sum;

        public int totalSum;


        public bool Add(int sum)
        {
            if(sum > 0)
            {
                this.sum += sum;
                totalSum += sum;
                return true;
            }
            return false;
        }

        void ISession.Reset()
        {
            sum = 0; 
        }

        void ILifetime.Reset()
        {
            totalSum = 0;
        }
        
    }
}
