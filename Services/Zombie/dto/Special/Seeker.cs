using Services.Map;

namespace Services.Zombie.dto.Special
{
    public class Seeker : Zombie
    {
        public Seeker(Location location) : base(location)
        {
            Priority = 3;
            Action = 1;
            MinDamage = 1;
            Experience = 1;
            Name = "Seeker";
            Type = ZombieMainTypeEnum.Seeker;
            Family = ZombieFamilyEnum.Seeker;
        }
    }
}
