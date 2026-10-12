using System;
using System.Collections.Generic;
using System.Text;

namespace CH19Q03
{
    internal class GridLayout
    {
        public int ItemCount { get; set; } = 0;
        public int Columns {  get; set; } = 4;

        public int Rows
        {
            get
            {
                if(ItemCount == 0 || Columns == 0) return 0;

                return (ItemCount + Columns - 1) / Columns;
            }
        }

        public int EmptySlots
        {
            get
            {
                if (ItemCount == 0) return 0;
                int totalSlots = Rows * Columns;
                return totalSlots - ItemCount;
            }
        }
    }
}
