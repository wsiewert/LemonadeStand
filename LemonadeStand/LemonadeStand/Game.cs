﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            decimal totalGameProfit = 0;
            decimal startingCash = player.wallet.Cash;
            Recipe recipe = new Recipe();
            while (dayCounter <= daysToPlay)
            {
                Day day = new Day(random, player, recipe);
                UserInterface.DisplayDailyStats(player.inventory, day.weather, player.wallet, dayCounter);
                day.StartDay();
                totalGameProfit = player.wallet.Cash - startingCash;
                UserInterface.DisplayGameTotalProfit(totalGameProfit);
                dayCounter++;
            }
            UserInterface.DisplayEndGameStats(player.GetName(),totalGameProfit,startingCash, player.inventory);
            Console.WriteLine("Press Enter to Submit HighScores and Quit.");
            Console.ReadLine();
            SubmitHighScores(totalGameProfit);
        }

        public void SubmitHighScores(decimal totalGameProfit)
        {
            string connectionString = "server=DESKTOP-RSKE7OA;" + "database=LemonadeStand;" + "trusted_connection=true;";
            SqlConnection conn = new SqlConnection(connectionString);
            string sqlCommandString = "INSERT INTO HighScores(Player_Name, Total_Profit) VALUES ('"+ player.GetName() +"', '"+ totalGameProfit + "')";
            conn.Open();
            SqlCommand command = new SqlCommand(sqlCommandString,conn);
            command.ExecuteNonQuery();
            conn.Close();
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
