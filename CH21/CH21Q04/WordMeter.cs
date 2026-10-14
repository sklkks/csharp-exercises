using System;
using System.Collections.Generic;
using System.Text;

namespace CH21Q04
{
    internal class WordMeter : TextMeter
    {
        public new int Measure(string text)
        {
            int count = 0;
            string[] parts = text.Split(' ');
            foreach (string part in parts)
            {
                if(part.Length > 0)
                {
                    count++;
                }
            }
            return count;
        }

 
        public override string Summary(string text)
        {
            return $"문자: {base.Measure(text)}, 단어: {Measure(text)}";
        }
    }
}
