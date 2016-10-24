using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDecoratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new SimpleVideoGame();
            Console.WriteLine(game.Description);

            var multiplayerGame = new MultiplayerVideoGame(4);
            Console.WriteLine(multiplayerGame.Description);

            var hiResGame = new HiResVideoGame();
            Console.WriteLine(hiResGame.Description);

            var multiplayerHiResGame = new MultiplayerHiResVideoGame(4);
            Console.WriteLine(multiplayerHiResGame.Description);

            Console.ReadKey();
        }
    }
}
