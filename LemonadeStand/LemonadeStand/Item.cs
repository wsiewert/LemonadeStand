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

        public Item()
        {

        }

        public decimal GetPrice()
        {
            return price;
        }
    }
}
