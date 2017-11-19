using Core;
using Domain.Zombie;
using Services.Map;

namespace Services.Zombie.dto
{
    public class RunnerToxic : ZombieToxic
    {
        public RunnerToxic(Location location) : base(location)
        {
            Priority = 8;
            Action = 2;
            MinDamage = 1;
            Experience = 1;
            Name = "Toxic Runner";
            Type = ZombieMainTypeEnum.Runner;
        }
    }
}
