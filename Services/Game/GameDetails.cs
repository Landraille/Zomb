using System.Collections.Generic;
using Core;
using Domain.Zombie;

namespace Services.Game
{
    public class GameDetailsDto
    {
        public ZombicideGameEnum Game { get; set; }
        public List<ZombieFamilyEnum> ZombieFamilyTypes { get; set; }
        public int FirstZombieDeckCardNumber { get; set; }
        public int LastZombieDeckCardNumber { get; set; }
    }
}