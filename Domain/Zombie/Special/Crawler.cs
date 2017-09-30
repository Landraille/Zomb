using Domain.Map;

namespace Domain.Zombie.Special
{
    public class Crawler : Zombie
    {
        public Crawler(Location location) : base(location)
        {
            Priority = 11;
            Action = 1;
            MinDamage = 1;
            Experience = 1;
            Name = "Crawler";
            Type = ZombieMainTypeEnum.Crawler;
        }
    }
}
