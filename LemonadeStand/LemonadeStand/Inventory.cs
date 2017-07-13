using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        Sugar sugar;
        Lemon lemon;
        Cup cup;
        Ice ice;

        List<object> sugarInventory = new List<object>() { };
        List<object> lemonInventory = new List<object>() { };
        List<object> cupInventory = new List<object>() { };
        List<object> iceInventory = new List<object>() { };

        public Inventory()
        {
            
        }

        public void AddItem(string itemName, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                switch (itemName)
                {
                    case "sugar":
                        sugarInventory.Add(new Sugar());
                        break;
                    case "lemon":
                        lemonInventory.Add(new Lemon());
                        break;
                    case "cup":
                        cupInventory.Add(new Cup());
                        break;
                    case "ice":
                        iceInventory.Add(new Ice());
                        break;
                    default:
                        break;
                }
            }
        }

        public void RemoveItem(string itemName)
        {
            switch (itemName)
            {
                case "sugar":
                    sugarInventory.RemoveAt(0);
                    break;
                case "lemon":
                    lemonInventory.RemoveAt(0);
                    break;
                case "cup":
                    cupInventory.RemoveAt(0);
                    break;
                case "ice":
                    iceInventory.RemoveAt(0);
                    break;
                default:
                    break;
            }
        }

        public int GetInventoryQuantity(string name)
        {
            switch (name)
            {
                case "sugar":
                    return sugarInventory.Count();
                case "lemon":
                    return lemonInventory.Count();
                case "cup":
                    return cupInventory.Count();
                case "ice":
                    return iceInventory.Count();
                default:
                    return 0;
            }
        }
    }
}
