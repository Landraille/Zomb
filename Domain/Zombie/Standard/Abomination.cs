using Domain.Map;

namespace Domain.Zombie.Standard
{
    public class Abomination : Zombie
    {
        public Abomination(Location location) : base(location)
        {
            Priority = 6;
            Action = 1;
            MinDamage = 3;
            Experience = 5;
            Name = "Abomination";
            Type = ZombieMainTypeEnum.Abomination;
        }
    }
}