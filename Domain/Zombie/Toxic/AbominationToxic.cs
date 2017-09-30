using Domain.Map;

namespace Domain.Zombie.Toxic
{
    class AbominationToxic : ZombieToxic
    {
        public AbominationToxic(Location location) : base(location)
        {
            Priority = 5;
            Action = 1;
            MinDamage = 3;
            Experience = 5;
            Name = "Toxic Abomination";
            Type = ZombieMainTypeEnum.Abomination;
        }
    }
}
