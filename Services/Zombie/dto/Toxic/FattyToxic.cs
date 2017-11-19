using Core;
using Domain.Zombie;
using Services.Map;

namespace Services.Zombie.dto
{
    public class FattyToxic : ZombieToxic
    {
        public FattyToxic(Location location) : base(location)
        {
            Action = 1;
            Experience = 1;
            MinDamage = 2;
            Priority = 5;
            Name = "Toxic Fatty";
            Type = ZombieMainTypeEnum.Fatty;
        }
    }
}
