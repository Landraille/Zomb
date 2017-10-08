using Services.Map;

namespace Services.Zombie.dto.Standard
{
    public class Fatty : StandardZombie
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