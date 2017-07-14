using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract class Item
    {
        protected static decimal price;
        protected static string name;

        public static decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public static string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
