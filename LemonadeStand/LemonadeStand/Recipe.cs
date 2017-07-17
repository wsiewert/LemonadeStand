using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        int lemonQuantity;
        int sugarQuantity;
        int iceQuantity;
        decimal price;

        public int LemonQuantity
        {
            get { return lemonQuantity; }
        }

        public int SugarQuantity
        {
            get { return sugarQuantity; }
        }

        public int IceQuantity
        {
            get { return iceQuantity; }
        }

        public Recipe()
        {
            lemonQuantity = 3;
            sugarQuantity = 3;
            iceQuantity = 3;
            price = 0.25m;
        }

        public bool SetRecipe()
        {
            DisplayRecipeCommands();
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    lemonQuantity = GetQuantity();
                    return false;
                case "2":
                    sugarQuantity = GetQuantity();
                    return false;
                case "3":
                    iceQuantity = GetQuantity();
                    return false;
                case "4":
                    price = SetPrice();
                    return false;
                case "5":
                    return true;
                default:
                    Console.WriteLine("-NOT A COMMAND-");
                    return SetRecipe();
            }
        }

        public void DisplayRecipeCommands()
        {
            Console.WriteLine("[Recipe] Select an option to change:");
            Console.WriteLine("1 - Lemon [{0}]",lemonQuantity);
            Console.WriteLine("2 - Sugar [{0}]",sugarQuantity);
            Console.WriteLine("3 - Ice [{0}]",iceQuantity);
            Console.WriteLine("4 - Price [${0}]",price);
            Console.WriteLine("5 - Exit");
        }

        public int GetQuantity()
        {
            try
            {
                Console.WriteLine("Please select quantity:");
                int userInput = int.Parse(Console.ReadLine());
                return userInput;
            }
            catch (Exception)
            {
                Console.WriteLine("-NOT A COMMAND-");
                return GetQuantity();
            }
        }
        public decimal SetPrice()
        {
            try
            {
                Console.WriteLine("Enter a price per lemonade:");
                decimal userInput = decimal.Parse(Console.ReadLine());
                return userInput;
            }
            catch (Exception)
            {
                Console.WriteLine("-NOT A COMMAND-");
                return GetQuantity();
            }
        }
    }
}
