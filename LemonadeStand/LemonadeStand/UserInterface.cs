using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {
        static string tabSpace = "    ";
        static public void DisplayRules()
        {
            Console.WriteLine("[RULES GO HERE]");
        }

        static public void DisplayWeatherForecast(int temperature, string weather)
        {
            Console.WriteLine("Forecast: {0} and {1}",temperature,weather);
        }

        static public void DisplayStoreOptions(decimal cupPrice, decimal sugarPrice, decimal lemonPrice, decimal icePrice)
        {
            Console.WriteLine("[Store] Select to purchase:");
            Console.WriteLine("1 - Cup - ${0}", cupPrice);
            Console.WriteLine("2 - Sugar - ${0}", sugarPrice);
            Console.WriteLine("3 - Lemon - ${0}", lemonPrice);
            Console.WriteLine("4 - Ice - ${0}", icePrice);
            Console.WriteLine("5 - Exit Store");
        }
    }
}