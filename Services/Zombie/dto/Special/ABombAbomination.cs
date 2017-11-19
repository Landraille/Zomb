using Core;
using Domain.Zombie;
using Services.Map;

namespace Services.Zombie.dto
{
    public class ABombAbomination : Zombie
    {
        public ABombAbomination(Location location) : base(location)
        {
            Priority = 6;
            Action = 1;
            MinDamage = 10;
            Experience = 5;
            Name = "A-Bomb Abomination";
            Type = ZombieMainTypeEnum.Abomination;
        }
    }
}
