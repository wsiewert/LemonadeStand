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
        protected int quantity;

        public Item()
        {
            quantity = 0;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public int GetQuantity()
        {
            return quantity;
        }
    }
}
