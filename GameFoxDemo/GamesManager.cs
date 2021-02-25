using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace GameFoxDemo
{
    class GamesManager : IGamesManager
    {

        public void AddGame(IGames game)
        {
            Console.WriteLine($@"{game.ProductName} is added to the game repository!");
        }

        public void UpdateGame(IGames game)
        {
            Console.WriteLine($@"{game.ProductName} is updated!");
        }

        public void DeleteGame(IGames game)
        {
            Console.WriteLine($@"{game.ProductName} is removed from the game repository!");
        }

        public void BringGameInfo(IGames game)
        {
            Console.WriteLine($@"Product Id: {game.Id} | Product Name: {game.ProductName} | Description: {game.Description} | Release Date: {game.DateOfRelease}");
        }
    }
}
