using System;
using System.Collections.Generic;
using System.Text;

namespace CH18Q10
{
    internal class ExpenseBook
    {
        private readonly int limit;
        private int total;
        private int count;

        public ExpenseBook(int limit)
        {
            this.limit = limit;
        }

        public ExpenseBook(int limit, int[] initial) : this(limit)
        {
            TryAdd(initial);
        }
        public bool TryAdd(int amount)
        {
            return TryAdd(new int[] {amount});
        }
        public bool TryAdd(int[] amounts)
        {
            int sum = 0;
            foreach(int amount in amounts)
            {
                if(amount <= 0)
                {
                    return false;
                }
                sum += amount;
            }
            if(total + sum > limit)
            {
                return false;
            }

            total += sum;
            count += amounts.Length;
            return true;

        }
        public string Describe() => $"{count}건, {total}/{limit}";
    }
}
