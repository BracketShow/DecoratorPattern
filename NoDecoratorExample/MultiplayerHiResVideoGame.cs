using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDecoratorExample
{
    public class MultiplayerHiResVideoGame : HiResVideoGame
    {
        public MultiplayerHiResVideoGame(int numberOfPlayers) : base()
        {
            NumberOfPlayers = numberOfPlayers;
        }

        public override string Description => base.Description + $" Avec possibilité de jouer jusqu'à {NumberOfPlayers} joueurs!";

    }
}
