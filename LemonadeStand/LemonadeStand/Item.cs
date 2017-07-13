using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract class Item
    {
        protected decimal price;
        protected string name;

        public decimal GetPrice()
        {
            return price;
        }

        public string GetName()
        {
            return name;
        }
    }
}
