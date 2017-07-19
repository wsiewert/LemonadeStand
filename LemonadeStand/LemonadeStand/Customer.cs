using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        Player player;
        Recipe recipe;
        Random random;
        Weather weather;
        List<string> weatherType;
        double maxValue = 1;
        double minValue = 0.01;
        int temperaturePreferenceTolerance = 10;
        decimal pricePreference;
        string weatherPreference;
        int temperaturePreference;
        int minimumPassingPreferences = 2;
        bool customerPurchasedLemonade;

        public bool CustomerPurchasedLemonade { get { return customerPurchasedLemonade; } }

        public Customer(Random random, Recipe recipe, Player player, Weather weather, List<string> weatherType)
        {
            //ALL FUNCTIONALITY IN CONSTRUCTOR SHOULD BE HANDLED BY ANOTHER FUNCTION
            this.player = player;
            this.recipe = recipe;
            this.random = random;
            this.weather = weather;
            this.weatherType = weatherType;
            
            pricePreference = GeneratePricePreference();
            weatherPreference = GenerateWeatherPreference();
            temperaturePreference = GenerateTemperaturePreference();

            if (GetCustomerDecision(CreatePreferenceList()))
            {
                customerPurchasedLemonade = PurchaseLemonade();
            } 
        }

        public decimal GeneratePricePreference()
        {
            double randomNumber = random.NextDouble();
            double highestPrice = minValue + (randomNumber * (maxValue - minValue));
            return Convert.ToDecimal(Math.Round(highestPrice,2));
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
            if (recipe.Price > pricePreference)
            {
                return false;
            }
            return true;
        }

        public bool CompareWeatherPreference()
        {
            if (weather.ActualWeather == weatherPreference)
            {
                return true;
            }
            return false;
        }

        public bool CompareTemperaturePreference()
        {
            int minRange = temperaturePreference - temperaturePreferenceTolerance;
            int maxRange = temperaturePreference + temperaturePreferenceTolerance;
            if (weather.ActualTemperature <= (maxRange) && weather.ActualTemperature >= (minRange))
            {
                return true;
            }
            return false;
        }

        public bool GetCustomerDecision(List<bool> preferenceList)
        {
            if (preferenceList.Count >= minimumPassingPreferences)
            {
                return true;
            }
            return false;
        }

        public List<bool> CreatePreferenceList()
        {
            List<bool> preferenceList = new List<bool>();
            if (CompareTemperaturePreference())
            {
                preferenceList.Add(true);
            }
            if (CompareWeatherPreference())
            {
                preferenceList.Add(true);
            }
            if (ComparePricePreference())
            {
                preferenceList.Add(true);
            }
            return preferenceList;
        }

        public bool PurchaseLemonade()
        {
            if (CheckInventory())
            {
                //CUSTOMER SHOULD NOT BE TAKING DIRECTLY FROM INVENTORY
                //1. subract lemonade resources
                player.inventory.RemoveItem("sugar",recipe.SugarQuantity);
                player.inventory.RemoveItem("lemon", recipe.SugarQuantity);
                player.inventory.RemoveItem("ice", recipe.SugarQuantity);
                player.inventory.RemoveItem("cup", recipe.SugarQuantity);
                //2. add cash to wallet
                player.wallet.AddCash(recipe.Price);
                return true;
            }
            return false;
        }

        public bool CheckInventory()
        {
            //INVENTORY SHOULD CHECK ITSELF, NOT CUSTOMER!
            int sugarInventory = player.inventory.GetInventoryQuantity("sugar");
            int lemonInventory = player.inventory.GetInventoryQuantity("lemon");
            int iceInventory = player.inventory.GetInventoryQuantity("ice");
            int cupInventory = player.inventory.GetInventoryQuantity("cup");

            if (recipe.SugarQuantity > sugarInventory || recipe.LemonQuantity > lemonInventory || recipe.IceQuantity > iceInventory || 1 > cupInventory)
            {
                return false;
            }
            return true;
        }
    }
}
