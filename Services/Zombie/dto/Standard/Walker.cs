using Services.Map;

namespace Services.Zombie.dto.Standard
{
    public class Walker : StandardZombie
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