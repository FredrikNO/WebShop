using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    internal class StoreInventory
    {
        public List<Game> InventoryList;
        public StoreInventory()
        {
            InventoryList = new List<Game>();
            InventoryList.Add(new PUBG());
            InventoryList.Add(new PokemonLetsGoEevee());
            InventoryList.Add(new Cyberpunk());
            InventoryList.Add(new Battlefield());
        }
        public List<Game> ListPhysicalItems()
        {
            // for å finne alle elementene i InventoryList som selges i fysisk format 
            return InventoryList.Where(GameItem => GameItem is IPhysicalCopy).ToList();
        }

        public List<Game> ListDownLoadable()
        {
            return InventoryList.Where(GameItem => GameItem is IDownLoadable).ToList();
        }
        public void PrintInventory(string command)
        {
            if (command == "1")
            {
                Print(InventoryList);
            }
            else if (command == "2")
            {
                Print(ListPhysicalItems());
            }
            else
            {
                Print(ListDownLoadable());
            }
        }
        public void Print(List<Game> games)
        {
            foreach (Game game in games) game.PrintGameNameAndPrice();
        }
    }
}
