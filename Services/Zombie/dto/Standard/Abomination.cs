using Services.Map;

namespace Services.Zombie.dto
{
    public class Abomination : StandardZombie
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