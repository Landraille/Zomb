using Domain.Map;

namespace Domain.Zombie.Standard
{
    public class Fatty : Zombie
    {
        public Fatty(Location location) : base(location)
        {
            Priority = 6;
            Action = 1;
            MinDamage = 2;
            Experience = 1;
            Name = "Fatty";
            Type = ZombieMainTypeEnum.Fatty;
        }
    }
}