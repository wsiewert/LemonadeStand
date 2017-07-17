﻿using System;
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
        Player player;
        Store store;
        Day day;
        int dayCounter;
        int daysToPlay;
        
        public Game()
        {

        }

        public void StartGame()
        {
            dayCounter = 1;
            userInterface.DisplayRules();
            player = new Player();
            player.SetName();
            Console.WriteLine(player.GetName());

            store = new Store(player);

            GetDaysToPlay();


            while (dayCounter <= daysToPlay)
            {
                day = new Day(random);
                //display stats
                Console.WriteLine("");
                Console.WriteLine("===================================");
                Console.WriteLine("Day: {0}", dayCounter);
                Console.WriteLine("Money: ${0}", player.wallet.Cash);
                Console.WriteLine("Forecast: {0} And {1}", day.weather.GetForecastTemperature(), day.weather.GetForecastWeather());
                //store
                
                store.DisplayStoreOptions();
                store.GetPurchasedItem();
                //recipe and set price
                //day.start day
                //show results
                dayCounter++;
            }

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
