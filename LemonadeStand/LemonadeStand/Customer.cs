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
        List<string> weatherType;
        double maxValue = 1;
        double minValue = 0.01;
        double pricePreferenceTolerance = 0.05;

        public Customer(Random random, Recipe recipe, Inventory inventory, Weather weather, List<string> weatherType)
        {
            this.inventory = inventory;
            this.recipe = recipe;
            this.random = random;
            this.weather = weather;
            this.weatherType = weatherType;
        }

        public double GeneratePricePreference()
        {
            double randomNumber = random.NextDouble();
            double highestPrice = minValue + (randomNumber * (maxValue - minValue));
            return Math.Round(highestPrice,2);
        }
        public string GenerateWeatherPreference()
        {
            int index = random.Next(0,weatherType.Count);
            string preferredWeather = weatherType[index];
            return preferredWeather;
        }
        public int GenerateTemperaturePreference()
        {
            int preferredTemperature = random.Next(weather.TemperatureRangeMin, weather.TemperatureRangeMax+1);
            return preferredTemperature;
        }

        public bool ComparePricePreference()
        {
            //compare price pref to actual
            return false;
        }

        public bool CompareWeatherPreference()
        {
            //compare weather preference to actual
            return false;
        }

        public bool CopareTemperaturePreference()
        {
            //compare temperature pref to actual
            return false;
        }

        public void GetCustomerDecision()
        {
            //compare preferences to actual
            //if true, then purchase lemonade
            //if false, then continue on.
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
