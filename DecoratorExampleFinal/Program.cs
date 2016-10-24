using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorExampleFinal.Properties;

namespace DecoratorExampleFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hiRes = Settings.Default.HiRes;
            
            VideoGame game = new SimpleVideoGame();
            if (hiRes) game = new HiResGameDecorator(game);
            game = new MultiplayerGameDecorator(game, 2);
            Console.WriteLine(game.Description);

            Console.ReadKey();
        }
    }
}
