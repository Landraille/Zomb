using Services.Map;

namespace Services.Zombie.dto
{
    public class Runner : StandardZombie
    {
        public Runner(Location location) : base(location)
        {
            Priority = 9;
            Action = 2;
            MinDamage = 1;
            Experience = 1;
            Name = "Runner";
            Type = ZombieMainTypeEnum.Runner;
        }
    }
}