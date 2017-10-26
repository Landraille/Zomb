namespace Services.CardService.Dto
{
    public abstract class CardDto
    {
        public ZombicideGameEnum ZombicideGame { get; set; }
        public int Number { get; set; }
        public bool IsSpecial { get; set; }

        protected CardDto(ZombicideGameEnum zombicideGame, int number)
        {
            ZombicideGame = zombicideGame;
            Number = number;
            IsSpecial = false;
        }
    }
}