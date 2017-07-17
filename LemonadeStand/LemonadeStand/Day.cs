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
        Recipe recipe;

        public Day(Random random)
        {
            weather = new Weather(weatherType, random);
            recipe = new Recipe();
        }

        public void StartDay()
        {
            bool exitRecipe = false;
            while (exitRecipe == false)
            {
                exitRecipe = recipe.SetRecipe();
            }
            
        }
    }
}
