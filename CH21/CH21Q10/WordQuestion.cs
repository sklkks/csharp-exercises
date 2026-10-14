using System;
using System.Collections.Generic;
using System.Text;

namespace CH21Q10
{
    internal class WordQuestion : Question
    {
        private readonly string word;

        public WordQuestion(string word)
        {
            this.word = word;
        }

        protected override bool Check(string answer)
        {
            return string.Equals(answer.Trim(), word, StringComparison.OrdinalIgnoreCase);
        }
    }
}
