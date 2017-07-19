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

        public void StartGame()
        {
            dayCounter = 1;
            UserInterface.DisplayRules();
            player = new Player();
            UserInterface.DisplayEnterName();
            player.SetName();
            GetDaysToPlay();
            PlayGame();
        }

        public void PlayGame()
        {
            Recipe recipe = new Recipe();
            while (dayCounter <= daysToPlay)
            {
                Day day = new Day(random, player, recipe);
                UserInterface.DisplayDailyStats(player.inventory, day.weather, player.wallet, dayCounter);
                day.StartDay();
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
                    GetDaysToPlay();
                }
                else
                {
                    daysToPlay = userInput;
                }
            }
            catch (Exception)
            {
                UserInterface.DisplayEnterANumber();
                GetDaysToPlay();
            }
        }
    }
}
