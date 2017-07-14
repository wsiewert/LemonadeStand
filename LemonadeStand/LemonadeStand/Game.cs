using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        UserInterface userInterface = new UserInterface();
        Random random = new Random();
        Player player1;
        int dayCounter;
        int daysToPlay;

        public Game()
        {

        }

        public void StartGame()
        {
            dayCounter = 1;
            userInterface.DisplayRules();
            player1 = new Player();
            player1.SetName();
            Console.WriteLine(player1.GetName());


            GetDaysToPlay();


            while (dayCounter <= 7)
            {
                Day day = new Day(random);
                Console.WriteLine("");
                Console.WriteLine("Day: {0}", dayCounter);
                Console.WriteLine("Money: {0}", player1.GetMoney());
                Console.WriteLine("Forecast: {0} And {1}", day.weather.GetForecastTemperature(), day.weather.GetForecastWeather());
                //get weather from day
                //store 
                //recipe
                //day.start day
                //show results
                dayCounter++;
            }

            Console.WriteLine("press any key to continue...");
            Console.ReadLine();
        }

        public void GetDaysToPlay()
        {
            Console.WriteLine("How many days would you like to play?");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < 7)
            {
                Console.WriteLine("You must choose at least 7 days to play!");
                GetDaysToPlay();
            }
            else
            {
                daysToPlay = userInput;
            }
        }
    }
}
