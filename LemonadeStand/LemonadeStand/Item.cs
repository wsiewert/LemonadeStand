using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract class Item
    {
        protected static string name;

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
