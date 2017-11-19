using Core;
using Domain.Zombie;
using Services.Zombie.dto;

namespace Services.CardService.Dto
{
    public class ZombieCardDto : CardDto
    {
        public Invasion BlueInvasion { get; set; }
        public Invasion YellowInvasion { get; set; }
        public Invasion OrangeInvasion { get; set; }
        public Invasion RedInvasion { get; set; }
        public bool IsSewerInvasion { get; set; }
        public bool IsBlueBedInvasion { get; set; }
        public bool IsGreenBedInvasion { get; set; }
        public bool IsSupplementaryActivation { get; set; }        
    }

    public class Invasion
    {
        public int ZombieNumber { get; set; }
        public ZombieTypeEnum ZombieType { get; set; }

        public Invasion(int zombieNumber, ZombieTypeEnum zombieType)
        {
            ZombieNumber = zombieNumber;
            ZombieType = zombieType;
        }
    }
}