using System;
using System.Collections.Generic;
using System.Text;

namespace CH18Q01
{
    internal class MinuteClock
    {
        private int hour;
        private int minute;

        public MinuteClock(int hour, int minute)
        {
            this.hour = 0;
            this.minute = 0;
            Advance(minute);
        }
        public void Advance(int minutes)
        {
            minute += minutes;

            if (minute >= 60)
            {               
                hour = hour + minute / 60;
                minute %= 60;
                hour %= 24; 
            }

        }
        
        public string GetTime() => $"{(hour):D2}:{(minute):D2}"; 

    }
}
