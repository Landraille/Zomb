using System;

namespace Domain.Card
{
    public class Equipment : Card
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool InDeck { get; set; }

        public Equipment(ZombicideGameEnum zombicideGame, int number, string name, string description) : base(zombicideGame, number)
        {
            Name = name;
            Description = description;
            InDeck = true;
        }
    }
}