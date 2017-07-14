using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        Lemon lemon;
        Sugar sugar;
        Ice ice;
        Cup cup;
        string userInput;

        public Store()
        {
            lemon = new Lemon();
            sugar = new Sugar();
            ice = new Ice();
            cup = new Cup();
        }

        public void DisplayStoreOptions()
        {
            Console.WriteLine("Please Purchase what you need:");
            Console.WriteLine("1 - Cup (x10)");
            Console.WriteLine("2 - Sugar (x10)");
            Console.WriteLine("3 - Lemon (x10)");
            Console.WriteLine("4 - Ice (x10)");
        }

        public void GetPurchasedItem()
        {
            switch (userInput)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Not A Command!");
                    GetPurchasedItem();
                    break;
            }
        }

        public void GetUserInput()
        {
            userInput = Console.ReadLine();
        }
    }
}
