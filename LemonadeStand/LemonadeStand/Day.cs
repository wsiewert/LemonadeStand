﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        List<string> weatherType = new List<string>() { "rainy", "sunny", "cloudy" };
        public Weather weather;
        Player player;
        Store store;
        Recipe recipe;
        Random random;
        decimal income;
        int customers = 100;


        public Day(Random random, Player player)
        {
            weather = new Weather(weatherType, random);
            recipe = new Recipe();
            this.player = player;
            this.random = random;
            store = new Store(this.player);
        }

        public void StartDay()
        {
            GetStoreMenu();
            GetRecipeMenu();
            Console.WriteLine("Press Enter to Start the Day...");
            Console.ReadLine();
            CreateCustomers();
        }

        public void GetStoreMenu()
        {
            bool exit = false;
            while (exit == false)
            {
                UserInterface.DisplayStoreOptions(store.CupPrice, store.SugarPrice, store.LemonPrice, store.IcePrice);
                exit = store.GetPurchasedItem();
            }
        }

        public void GetRecipeMenu()
        {
            bool exitRecipe = false;
            while (exitRecipe == false)
            {
                UserInterface.DisplayRecipeOptions(recipe.LemonQuantity, recipe.SugarQuantity, recipe.IceQuantity, recipe.Price);
                exitRecipe = recipe.SetRecipe();
            }
        }

        public void CreateCustomers()
        {
            for (int i = 0; i < customers; i++)
            {
                Customer customer = new Customer(random, recipe, player, weather, weatherType);
            }
        }
    }
}
