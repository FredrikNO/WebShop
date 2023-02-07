using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop
{
    internal class Game
    {
        public string GameName;
        protected int Price;
        public int Id;

        public Game(string name, int price, int id)
        {
            GameName = name;
            Price = price;
            Id = id;
        }
        public void PrintGameNameAndPrice()
        {
            Console.WriteLine($"Item: {GameName} Price: {Price} ID: {Id}");
        }
    }
}
