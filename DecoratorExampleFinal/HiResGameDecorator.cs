namespace DecoratorExampleFinal
{
    public class HiResGameDecorator : VideoGameDecorator
    {
        public HiResGameDecorator(VideoGame game) : base(game)
        {
        }

        public override string Description => 
            base.Description + " Avec graphiques en haute résolution!";
    }

        public class VRGameDecorator : VideoGameDecorator
    {
        public VRGameDecorator(VideoGame game, int numberOfPlayers) : base(game)
        {
            NumberOfPlayers = numberOfPlayers;
        }

        public override int NumberOfPlayers { get; }

        public override string Description => "Mode VR disponible !!! " + base.Description;
    }

}
