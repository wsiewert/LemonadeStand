using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        Lemon lemon;
        Sugar sugar;
        Ice ice;
        Cup cup;

        public Store()
        {
            lemon = new Lemon();
            sugar = new Sugar();
            ice = new Ice();
            cup = new Cup();
        }
    }
}
