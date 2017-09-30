using Domain.Map;

namespace Domain.Zombie.Standard
{
    public class Runner : Zombie
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