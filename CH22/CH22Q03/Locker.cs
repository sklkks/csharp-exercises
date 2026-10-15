using System;
using System.Collections.Generic;
using System.Text;

namespace CH22Q03
{
    internal class Locker : ILockable
    {
        private string _name;
        private bool isLocked = false;
        public Locker(string name)
        {
            _name = name;
        }

        // ILockable 인터페이스 구현
        public bool Lock()
        {
            if (isLocked)
            {
                return false;
            }
            isLocked = true;
            return true;
        }

        public override string ToString()
        {
            return isLocked.ToString();
        }
    }
}
