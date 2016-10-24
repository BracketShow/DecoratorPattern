using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDecoratorExample
{
    public class MultiplayerVideoGame : SimpleVideoGame
    {
        public MultiplayerVideoGame(int numberOfPlayers) : base()
        {
            NumberOfPlayers = numberOfPlayers;
        }

        public override string Description => base.Description + $" Avec possibilité de jouer jusqu'à {NumberOfPlayers} joueurs!";
    }
}
