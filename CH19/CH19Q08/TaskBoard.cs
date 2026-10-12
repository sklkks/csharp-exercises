using System;
using System.Collections.Generic;
using System.Text;

namespace CH19Q08
{
    internal class TaskBoard
    {
        private readonly WorkItem[] slots = new WorkItem[3];

        public WorkItem this[int index]
        {
            get => index >= 0 && index < slots.Length ? slots[index] : null;
            set
            {
                if(index >= 0 && index < slots.Length)
                {
                    slots[index] = value;
                }
            }
        }

        public int PendingCount
        {
            get
            {
                int count = 0;
                foreach (var item in slots)
                {
                    if (item != null && !item.Completed)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public string NextTitle
        {
            get
            {
                foreach(var item in slots)
                {
                    if (item != null && !item.Completed)
                    {
                        return item.Title;
                    }
                }

                return null;
            }
        }
    }
}
