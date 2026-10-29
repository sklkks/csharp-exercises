using System;
using System.Collections.Generic;
using System.Text;

namespace CH26Q07
{
    internal class AccountActions
    {
        public Action<int> Charge { get; }
        public Func<int, bool> Spend { get;}
        public Func<int> Read { get; }

        public AccountActions(Action<int> charge, Func<int, bool> spend, Func<int> read)
        {
            Charge = charge;
            Spend = spend;
            Read = read;
        }

        public static AccountActions Create(int capacity)
        {
            int remaining = 0;
            Action<int> charge = amount =>
            {
                remaining = Math.Min(capacity, remaining + amount);
            };

            Func<int, bool> spend = amount =>
            {
                if (amount > remaining || amount <= 0)
                {
                    return false;
                }
                
                remaining -= amount;
                return true;
            };
            Func<int> read = () => remaining;

            return new AccountActions(charge, spend, read);
        }
    }
}