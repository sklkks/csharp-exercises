using System;
using System.Collections.Generic;
using System.Text;

namespace CH17Q09
{
    internal class Member
    {
        public const int SlotCount = 3;

        private static readonly Member[] owners = new Member[SlotCount];
        private int count;

        public int GetCount() => count;
        
        public bool TryBook(int slot)
        {
            if(slot < 0 || slot >= owners.Length ||  owners[slot] != null)
            {
                return false;
            }

            owners[slot] = this;
            count++;
            return true;
        }
        public bool TryRelease(int slot)
        {
            if (slot < 0 || slot >= owners.Length || owners[slot] != this) 
            {
                return false;
            }

            owners[slot] = null;
            count--;
            return true;
        }
        public static int GetUsedCount()
        {
            int used = 0;
            foreach (Member m in owners) 
            {
                if (m != null)
                {
                    used++;
                }
                
            }
            return used;
        }

        public static Member GetOwner(int slot)
        {
            return owners[slot];
        }
    }

}
