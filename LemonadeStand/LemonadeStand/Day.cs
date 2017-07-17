using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        List<string> weatherType = new List<string>() { "rain", "sunny", "cloudy" };
        public Weather weather;
        Player player;
        Store store;
        Recipe recipe;
        Random random;
        decimal income;
        int customers;


        public Day(Random random, Player player)
        {
            weather = new Weather(weatherType, random);
            recipe = new Recipe();
            this.player = player;
            this.random = random;
            store = new Store(this.player);
            customers = 100;
        }

        public void StartDay()
        {
            GetStoreMenu();
            GetRecipeMenu();
        }

        public void GetStoreMenu()
        {
            bool exit = false;
            while (exit == false)
            {
                store.DisplayStoreOptions();
                exit = store.GetPurchasedItem();
            }
        }

        public void GetRecipeMenu()
        {
            bool exitRecipe = false;
            while (exitRecipe == false)
            {
                exitRecipe = recipe.SetRecipe();
            }
        }

        public void CreateCustomer()
        {
            for (int i = 0; i < customers; i++)
            {
                Customer customer = new Customer(random, recipe, player.inventory, weather);
            }
        }
    }
}
