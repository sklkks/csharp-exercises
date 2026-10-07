using System;
using System.Collections.Generic;
using System.Text;

namespace CH16Q06
{
    internal class Product
    {
        public int Code;
        public Stock Stock;
    }
    internal class Stock
    {
        public int StockCount;
        public bool AddStock(int amount)
        {
            if (amount > 0)
            {
                StockCount = StockCount + amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
