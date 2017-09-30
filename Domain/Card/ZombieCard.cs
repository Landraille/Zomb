using Domain.Zombie;

namespace Domain.Card
{
    public class ZombieCard : Card
    {
        public Invasion BlueInvasion { get; set; }
        public Invasion YellowInvasion { get; set; }
        public Invasion OrangeInvasion { get; set; }
        public Invasion RedInvasion { get; set; }
        public bool IsSewerInvasion { get; set; }
        public bool IsBlueBedInvasion { get; set; }
        public bool IsGreenBedInvasion { get; set; }
        public bool IsSupplementaryActivation { get; set; }

        public ZombieCard(ZombicideGameEnum zombicideGame, int number, Invasion blueInvasion, Invasion yellowInvasion,
            Invasion orangeInvasion, Invasion redInvasion) : base(zombicideGame, number)
        {
            BlueInvasion = blueInvasion;
            YellowInvasion = yellowInvasion;
            OrangeInvasion = orangeInvasion;
            RedInvasion = redInvasion;
            IsBlueBedInvasion = false;
            IsGreenBedInvasion = false;
            IsSupplementaryActivation = false;
            IsSewerInvasion = false;
        }

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