﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        Inventory inventory;
        Recipe recipe;
        Random random;

        public Customer(Random random, Recipe recipe, Inventory inventory)
        {
            this.inventory = inventory;
            this.recipe = recipe;
            this.random = random;
        }

        public void GeneratePricePreference()
        {
            //Price
        }
        public void GenerateWeatherPreference()
        {
            //Weather
        }
        public void GenerateTemperaturePreference()
        {
            //Temperature
        }

        public bool PurchaseLemonade()
        {
            if (CheckInventory())
            {
                Console.WriteLine("Lemonade Was Purchased");
                return true;
            }
            return false;
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
