using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        decimal cash;

        public Wallet()
        {
            cash = 20;
        }

        public decimal Cash
        {
            get
            {
                return cash;
            }
        }

        public void AddCash(decimal amount)
        {
            cash += amount;
        }

        public bool SubtractCash(decimal amount)
        {
            if (amount > cash)
            {
                UserInterface.DisplayInsufficientFunds();
                return false;
            }
            cash -= amount;
            return true;
        }
    }
}
