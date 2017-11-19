using System.Collections.Generic;
using Core;
using Domain.Zombie;

namespace Domain.Game
{
    public class GameDetails
    {
        public string Game { get; set; }
        public string ZombieFamilyTypes { get; set; }
        public int FirstZombieDeckCardNumber { get; set; }
        public int LastZombieDeckCardNumber { get; set; }
    }
}