using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        decimal cupPrice = 1;
        decimal sugarPrice = 1;
        decimal lemonPrice = 1;
        decimal icePrice = 1;
        Wallet playerWallet;
        Inventory playerInventory;

        public Store(Player player)
        {
            playerWallet = player.wallet;
            playerInventory = player.inventory;
        }

        public void DisplayStoreOptions()
        {
            Console.WriteLine("Please Purchase what you need:");
            Console.WriteLine("1 - Cup (x10) - ${0}", cupPrice);
            Console.WriteLine("2 - Sugar (x10) -${0}", sugarPrice);
            Console.WriteLine("3 - Lemon (x10) - ${0}", lemonPrice);
            Console.WriteLine("4 - Ice (x10) - ${0}", icePrice);
        }

        public void GetPurchasedItem()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    PurchaseCup();
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

        public void PurchaseCup()
        {
            bool fundsInWallet = playerWallet.SubtractCash(cupPrice);
            if (fundsInWallet)
            {
                playerInventory.AddItem("cup", 10);
                Console.WriteLine("Purchased Cup, Total: {0}", playerInventory.GetInventoryQuantity("cup"));
            }
        }
    }
}
