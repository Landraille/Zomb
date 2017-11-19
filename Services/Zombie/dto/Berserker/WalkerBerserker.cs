using Core;
using Domain.Zombie;
using Services.Map;

namespace Services.Zombie.dto
{
    public class WalkerBerserker : ZombieBerserker
    {
        public WalkerBerserker(Location location) : base(location)
        {
            Priority = 4;
            Action = 1;
            MinDamage = 1;
            Experience = 1;
            Name = "Berserker Walker";
            Type = ZombieMainTypeEnum.Walker;
        }
    }
}