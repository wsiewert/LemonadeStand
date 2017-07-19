using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        public Weather weather;
        Player player;
        Store store;
        Recipe recipe;
        Random random;
        decimal totalDayProfit;
        int purchasesMade;
        int customers = 100;


        public Day(Random random, Player player, Recipe recipe)
        {
            weather = new Weather(random);
            this.recipe = recipe;
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
            EndDay();
        }

        public void EndDay()
        {
            UserInterface.DisplayEndDayStats(purchasesMade,customers,weather,totalDayProfit);
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
                Customer customer = new Customer(random, recipe, player, weather, weather.WeatherType);
                if (customer.CustomerPurchasedLemonade)
                {
                    purchasesMade++;
                    totalDayProfit += recipe.Price;
                }
            }
        }
    }
}
