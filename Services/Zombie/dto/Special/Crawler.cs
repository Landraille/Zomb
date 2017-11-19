using Core;
using Domain.Zombie;
using Services.Map;

namespace Services.Zombie.dto
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
