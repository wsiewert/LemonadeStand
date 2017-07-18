using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Random random = new Random();
        Player player;
        int dayCounter;
        int daysToPlay;
        
        public Game()
        {

        }

        public void StartGame()
        {
            dayCounter = 1;
            UserInterface.DisplayRules();
            player = new Player();
            player.SetName();
            Console.WriteLine(player.GetName());

            GetDaysToPlay();


            while (dayCounter <= daysToPlay)
            {
                Day day = new Day(random,player);
                //display stats
                Console.WriteLine("");
                Console.WriteLine("===================================");
                Console.WriteLine("Day: {0}", dayCounter);
                Console.WriteLine("Money: ${0}", player.wallet.Cash);
                Console.WriteLine("Forecast: {0} And {1}", day.weather.GetForecastTemperature(), day.weather.GetForecastWeather());
                Console.WriteLine("Cups: {0} Sugar: {1} Lemon: {2} Ice: {3}", player.inventory.GetInventoryQuantity("cup"), player.inventory.GetInventoryQuantity("sugar"), player.inventory.GetInventoryQuantity("lemon"), player.inventory.GetInventoryQuantity("ice"));

                day.StartDay();

                //show Daily results

                dayCounter++;
            }

            //Show End Game Results

            Console.WriteLine("press any key to continue...");
            Console.ReadLine();
        }

        public void GetDaysToPlay()
        {
            try
            {
                Console.WriteLine("How many days would you like to play?");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput < 7)
                {
                    Console.WriteLine("Please enter at least 7 days");
                }
                else
                {
                    daysToPlay = userInput;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a number!");
                GetDaysToPlay();
            }
        }
    }
}
