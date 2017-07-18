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
        Weather weather;
        List<string> weatherType;
        double maxValue = 1;
        double minValue = 0.01;
        int temperaturePreferenceTolerance = 10;
        decimal pricePreference;
        string weatherPreference;
        int temperaturePreference;
        int minimumPassingPreferences = 2;

        public Customer(Random random, Recipe recipe, Inventory inventory, Weather weather, List<string> weatherType)
        {
            this.inventory = inventory;
            this.recipe = recipe;
            this.random = random;
            this.weather = weather;
            this.weatherType = weatherType;

            pricePreference = GeneratePricePreference();
            weatherPreference = GenerateWeatherPreference();
            temperaturePreference = GenerateTemperaturePreference();

            if (GetCustomerDecision(CreatePreferenceList()))
            {
                PurchaseLemonade();
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
                //call get lemonade on player inventory
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
