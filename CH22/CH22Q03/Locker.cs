using System;
using System.Collections.Generic;
using System.Text;

namespace CH22Q03
{
    internal class Locker : ILockable
    {
        public Locker(string name)
        {
            
        }

        private bool isLocked = false;

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

                
    }
}
