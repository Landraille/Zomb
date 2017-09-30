using Domain.Map;

namespace Domain.Zombie.Standard
{
    public class Walker : Zombie
    {
        public Walker(Location location) : base(location)
        {
            Action = 1;
            Experience = 1;
            MinDamage = 1;
            Priority = 3;
            Name = "Walker";
            Type = ZombieMainTypeEnum.Walker;
        }
    }
}