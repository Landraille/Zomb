using Core;
using Domain.Zombie;
using Services.Map;

namespace Services.Zombie.dto
{
    public class Dogz : Zombie
    {
        public Dogz(Location location) : base(location)
        {
            Priority = 11;
            Action = 3;
            MinDamage = 1;
            Experience = 1;
            Name = "Dogz";
            Type = ZombieMainTypeEnum.Dogz;
            Family = ZombieFamilyEnum.Dogz;
        }
    }
}