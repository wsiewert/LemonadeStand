using System;
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
        Weather weather;

        public Customer(Random random, Recipe recipe, Inventory inventory, Weather weather)
        {
            this.inventory = inventory;
            this.recipe = recipe;
            this.random = random;
            this.weather = weather;
        }

        public decimal GeneratePricePreference()
        {
            //price
            return 1;
        }
        public void GenerateWeatherPreference()
        {
            //Weather
        }
        public void GenerateTemperaturePreference()
        {
            //Temperature
            int preferredTemperature = random.Next(weather.TemperatureRangeMin, weather.TemperatureRangeMax+1); 
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
