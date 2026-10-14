using System;
using System.Collections.Generic;
using System.Text;

namespace CH21Q10
{
    internal abstract class Question
    {
        public int Attempts { get; private set; }
        public bool Solved { get; private set; }
        public bool Finished => Solved || Attempts == 2;

        public override string ToString()
        {
            return $"시도: {Attempts}, 정답: {Solved}, 종료: {Finished}";
        }

        protected abstract bool Check(string answer);

        public bool Submit(string answer)
        {
            if (Finished)
            {
                return false;
            }
            Attempts++;
            Solved = Check(answer);
            return true;
        }
    }
}
