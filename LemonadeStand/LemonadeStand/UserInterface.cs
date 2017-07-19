using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {
        static public void DisplayRules()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("[RULES]");
            Console.WriteLine("You are owner of a local lemonade stand. To succeed, you must:");
            Console.WriteLine(" - Purchase supplies");
            Console.WriteLine(" - Adjust recipes and pricing");
            Console.WriteLine(" - Predict the weather");
            Console.WriteLine("Good luck!");
            Console.ResetColor();
        }

        static public void DisplayWeatherForecast(int temperature, string weather)
        {
            Console.WriteLine("Forecast: {0} and {1}",temperature,weather);
        }

        static public void DisplayWeatherActual(int temperature, string weather)
        {
            Console.WriteLine("Actual Weather: {0} and {1}", temperature, weather);
        }

        static public void DisplayStoreOptions(decimal cupPrice, decimal sugarPrice, decimal lemonPrice, decimal icePrice)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Store");
            Console.ResetColor();
            Console.WriteLine("] Select to purchase:");
            Console.WriteLine("1 - Cup - ${0}",cupPrice);
            Console.WriteLine("2 - Sugar - ${0}", sugarPrice);
            Console.WriteLine("3 - Lemon - ${0}", lemonPrice);
            Console.WriteLine("4 - Ice - ${0}", icePrice);
            Console.WriteLine("5 - Exit Store");
        }

        static public void DisplayRecipeOptions(int lemonQuantity, int sugarQuantity, int iceQuantity, decimal price)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Recipe");
            Console.ResetColor();
            Console.WriteLine("] Select option to change:");
            Console.WriteLine("1 - Lemon [{0}]", lemonQuantity);
            Console.WriteLine("2 - Sugar [{0}]", sugarQuantity);
            Console.WriteLine("3 - Ice [{0}]", iceQuantity);
            Console.WriteLine("4 - Price [${0}]", price);
            Console.WriteLine("5 - Exit");
        }

        static public void DisplayDailyStats(Inventory inventory, Weather weather, Wallet wallet, int dayCounter)
        {
            Console.WriteLine("");
            Console.WriteLine("===================================");
            Console.WriteLine("Day: {0}", dayCounter);
            Console.WriteLine("Money: ${0}", wallet.Cash);
            DisplayWeatherForecast(weather.GetForecastTemperature(),weather.GetForecastWeather());
            DisplayInventory(inventory);
        }

        static public void DisplayInventory(Inventory inventory)
        {
            Console.Write("Inventory: ");

            Console.Write("Cups: [");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("{0}",inventory.GetInventoryQuantity("cup"));
            Console.ResetColor();
            Console.Write("] ");

            Console.Write("Sugar: [");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("{0}", inventory.GetInventoryQuantity("sugar"));
            Console.ResetColor();
            Console.Write("] ");

            Console.Write("Lemon: [");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("{0}", inventory.GetInventoryQuantity("lemon"));
            Console.ResetColor();
            Console.Write("] ");

            Console.Write("Ice: [");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("{0}", inventory.GetInventoryQuantity("ice"));
            Console.ResetColor();
            Console.WriteLine("] ");
        }

        static public void DisplayEndDayStats(int purchasesMade, int totalCustomers, Weather weather, decimal totalDayProfit)
        {
            Console.WriteLine("[End Of Day Stats]");
            DisplayWeatherActual(weather.ActualTemperature, weather.ActualWeather);
            Console.WriteLine("Total Customers: {0}", totalCustomers);
            Console.WriteLine("Total Sales: {0}",purchasesMade);
            Console.WriteLine("Total Day Profit: ${0}",totalDayProfit);
        }

        static public void DisplayGameTotalProfit(decimal totalProfit)
        {
            Console.WriteLine("Total Game Profit: ${0}",totalProfit);
        }

        static public void DisplayEndGameStats()
        {

        }

        static public void DisplayNotACommand()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-NOT A COMMAND-");
            Console.ResetColor();
        }

        static public void DisplayInsufficientFunds()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Insufficient Funds!");
            Console.ResetColor();
        }

        static public void DisplayEnterANumber()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Please Enter A Number!");
            Console.ResetColor();
        }

        static public void DisplayEnterName()
        {
            Console.WriteLine("Please Enter Your Name:");
        }
    }
}