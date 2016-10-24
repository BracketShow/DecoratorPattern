using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDecoratorExample
{
    public class HiResVideoGame : SimpleVideoGame
    {
        public HiResVideoGame() : base()
        {
            
        }

        public override string Description => base.Description + " Avec graphiques en haute résolution!";

    }
}
