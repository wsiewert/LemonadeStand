using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
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
            Console.WriteLine("1 - Cup (x10) - ${0}", Cup.Price);
            Console.WriteLine("2 - Sugar (x10) -${0}", Sugar.Price);
            Console.WriteLine("3 - Lemon (x10) - ${0}", Lemon.Price);
            Console.WriteLine("4 - Ice (x10) - ${0}", Ice.Price);
        }

        public void GetPurchasedItem()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //call add item
                    playerInventory.AddItem("cup", 10);
                    //call wallet price drop
                    playerWallet.SubtractCash(Cup.Price);
                    Console.WriteLine("***Yay you purchased something***");
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
    }
}
