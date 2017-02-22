namespace NoDecoratorExample
{
    public class HiResVideoGame : SimpleVideoGame
    {
        public HiResVideoGame() : base()
        {
        }

        public override string Description => 
            base.Description + " Avec graphiques en haute résolution!";

    }
}
