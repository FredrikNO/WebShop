using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    internal class NewWebShop
    {
        StoreInventory Inventory = new StoreInventory();
        private List<Game> ShoppingCart = new List<Game>();

        public NewWebShop()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the shop! ");
                Console.WriteLine("1: Show all available games");
                Console.WriteLine("2: Show only physical games");
                Console.WriteLine("3: Show only downloadable games");
                HandleCommand();
            }
        }
        public void HandleCommand()
        {
            Console.Write("Input the type of games you want to show: ");
            var inputType = Console.ReadLine();
            Inventory.PrintInventory(inputType);
            Console.Write("Input the ID of game you want to buy: ");
            var inputId = Console.ReadLine();
            var gameToBuy = Inventory.InventoryList.Find(x => x.Id == Int32.Parse(inputId));
            ShoppingCart.Add(gameToBuy);
            if(gameToBuy is IPhysicalCopy and IDownLoadable)
            {
                Console.WriteLine("Do you want to download or ship a physical copy of the game: d / s: ");
                var input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case 's':
                        PrintShippingMessage(gameToBuy.GameName);
                        break;
                    case 'd':
                        PrintDownloadMessage(gameToBuy.GameName);
                        break;
                }
                //return;
            }
            if (gameToBuy is IPhysicalCopy and not IDownLoadable) PrintShippingMessage(gameToBuy.GameName);
            if (gameToBuy is IDownLoadable and not IPhysicalCopy) PrintDownloadMessage(gameToBuy.GameName);
        }
        private void PrintDownloadMessage(string gameName)
        {
            Console.WriteLine($"Game {gameName} will now be downloaded..");
        }
        private void PrintShippingMessage(string gameName)
        {
            Console.WriteLine($"Game {gameName} will be shipped shortly..");
        }
    }
}
