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
        protected decimal money;
        Inventory inventory;

        public Player()
        {
            inventory = new Inventory();
        }

        public string GetName()
        {
            return name;
        }

        public decimal GetMoney()
        { 
            return money;
        }

        public void SetName()
        {
            name = Console.ReadLine();
        }

        public void AddMoney(decimal money)
        {
            this.money += money;
        }

    }
}
