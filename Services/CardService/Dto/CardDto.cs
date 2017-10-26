namespace Services.CardService.Dto
{
    public abstract class CardDto
    {
        public ZombicideGameEnum ZombicideGame { get; set; }
        public int Number { get; set; }
        public bool InDeck { get; set; }
    }
}