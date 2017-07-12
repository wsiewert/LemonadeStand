using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        int lemon;
        int cup;
        int sugar;
        int iceCube;

        public int GetAmountLemon()
        {
            return lemon;
        }

        public int GetAmountCup()
        {
            return cup;
        }

        public int GetAmountSugar()
        {
            return sugar;
        }

        public int GetAmountIceCube()
        {
            return iceCube;
        }
    }
}
