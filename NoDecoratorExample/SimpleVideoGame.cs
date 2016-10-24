using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDecoratorExample
{
    public class SimpleVideoGame
    {

        public SimpleVideoGame()
        {
            NumberOfPlayers = 1;
        }

        public virtual string Description => "Ceci est un simple jeu !";

        public int NumberOfPlayers { get; set; }
    }
}
