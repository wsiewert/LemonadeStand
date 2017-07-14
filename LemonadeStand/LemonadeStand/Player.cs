using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        protected string name;
        public Inventory inventory;
        public Wallet wallet;

        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }

        public string GetName()
        {
            return name;
        }

        public void SetName()
        {
            name = Console.ReadLine();
        }
    }
}
