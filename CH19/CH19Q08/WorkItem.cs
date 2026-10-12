using System;
using System.Collections.Generic;
using System.Text;

namespace CH19Q08
{
    internal class WorkItem
    {
        public string Title { get; }

        public bool Completed { get; private set; } = false;

        public WorkItem(string title)
        {
            Title = title;
        }

        public void Complete()
        {
            Completed = true;
        }
    }
}
