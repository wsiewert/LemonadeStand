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

        public void StartGame()
        {
            userInterface.DisplayRules();
            //ask player name
            //ask how long to play for, at least 7 days.
            Console.WriteLine("press any key to continue...");
            Console.ReadLine();
        }

        public void PlayGame()
        {
            //call day object x times until a winner.
        }
    }
}
