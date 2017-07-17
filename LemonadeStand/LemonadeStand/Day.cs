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
        Weather weather;
        Player player;
        Store store;
        Recipe recipe;

        public Day(Random random, Player player)
        {
            weather = new Weather(weatherType, random);
            recipe = new Recipe();
            this.player = player;
            store = new Store(this.player);
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
    }
}
