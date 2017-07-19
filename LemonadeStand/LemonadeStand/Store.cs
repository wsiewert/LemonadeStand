using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        decimal cupPrice = 0.05m;
        decimal sugarPrice = 0.05m;
        decimal lemonPrice = 0.05m;
        decimal icePrice = 0.05m;
        Wallet playerWallet;
        Inventory playerInventory;

        public decimal CupPrice { get { return cupPrice; } }
        public decimal SugarPrice { get { return sugarPrice; } }
        public decimal LemonPrice { get { return lemonPrice; } }
        public decimal IcePrice { get { return icePrice; } }

        public Store(Player player)
        {
            playerWallet = player.wallet;
            playerInventory = player.inventory;
        }

        public int GetPurchaseQuantity()
        {
            try
            {
                Console.WriteLine("Please enter a quanity:");
                int userInput = int.Parse(Console.ReadLine());
                return userInput;
            }
            catch (Exception)
            {
                Console.WriteLine("ENTER A NUMBER!");
                return GetPurchaseQuantity();
            }
        }

        public bool GetPurchasedItem()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    PurchaseCup(GetPurchaseQuantity());
                    return false;
                case "2":
                    PurchaseSugar(GetPurchaseQuantity());
                    return false;
                case "3":
                    PurchaseLemon(GetPurchaseQuantity());
                    return false;
                case "4":
                    PurchaseIce(GetPurchaseQuantity());
                    return false;
                case "5":
                    return true;
                default:
                    UserInterface.DisplayNotACommand();
                    return GetPurchasedItem();
            }
        }

        public void PurchaseCup(int quantity)
        {
            decimal totalCost = cupPrice * quantity;
            bool fundsInWallet = playerWallet.SubtractCash(totalCost);
            if (fundsInWallet)
            {
                playerInventory.AddItem("cup", quantity);
                Console.WriteLine("Purchased {0} Cups for ${1}",quantity,totalCost);
            }
        }

        public void PurchaseSugar(int quantity)
        {
            decimal totalCost = sugarPrice * quantity;
            bool fundsInWallet = playerWallet.SubtractCash(totalCost);
            if (fundsInWallet)
            {
                playerInventory.AddItem("sugar", quantity);
                Console.WriteLine("Purchased {0} Sugar for ${1}", quantity, totalCost);
            }
        }

        public void PurchaseLemon(int quantity)
        {
            decimal totalCost = lemonPrice * quantity;
            bool fundsInWallet = playerWallet.SubtractCash(totalCost);
            if (fundsInWallet)
            {
                playerInventory.AddItem("lemon", quantity);
                Console.WriteLine("Purchased {0} Lemons for ${1}", quantity, totalCost);
            }
        }

        public void PurchaseIce(int quantity)
        {
            decimal totalCost = icePrice * quantity;
            bool fundsInWallet = playerWallet.SubtractCash(totalCost);
            if (fundsInWallet)
            {
                playerInventory.AddItem("ice", quantity);
                Console.WriteLine("Purchased {0} Ice for ${1}", quantity, totalCost);
            }
        }
    }
}
