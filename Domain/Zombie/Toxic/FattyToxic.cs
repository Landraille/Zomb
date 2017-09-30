using Domain.Map;

namespace Domain.Zombie.Toxic
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
