using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemonade
    {
        decimal price;
        Recipe recipe;
        Inventory inventory;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public Lemonade(Recipe recipe, Inventory inventory)
        {
            price = 0.25m;
            this.recipe = recipe;
            this.inventory = inventory;
        }

        public bool PurchaseLemonade()
        {
            
            Console.WriteLine("Lemonade Was Purchased");
            return true;
        }

        public bool CheckInventory()
        {
            int sugarInventory = inventory.GetInventoryQuantity("sugar");
            int lemonInventory = inventory.GetInventoryQuantity("lemon");
            int iceInventory = inventory.GetInventoryQuantity("ice");
            int cupInventory = inventory.GetInventoryQuantity("cup");

            if (recipe.SugarQuantity > sugarInventory || recipe.LemonQuantity > lemonInventory || recipe.IceQuantity > iceInventory || 1 > cupInventory)
            {
                return false;
            }
            return true;
        }
    }
}
