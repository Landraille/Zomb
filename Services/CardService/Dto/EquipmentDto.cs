namespace Services.CardService.Dto
{
    public class EquipmentDto : CardDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool InDeck { get; set; }

        public EquipmentDto(ZombicideGameEnum zombicideGame, int number, string name, string description) : base(zombicideGame, number)
        {
            Name = name;
            Description = description;
            InDeck = true;
        }
    }
}