namespace Domain.Card
{
    public abstract class Card
    {
        public ZombicideGameEnum ZombicideGame { get; set; }
        public int Number { get; set; }
        public bool IsSpecial { get; set; }

        protected Card(ZombicideGameEnum zombicideGame, int number)
        {
            ZombicideGame = zombicideGame;
            Number = number;
            IsSpecial = false;
        }
    }
}