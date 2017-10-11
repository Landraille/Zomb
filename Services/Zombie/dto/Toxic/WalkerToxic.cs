using Services.Map;

namespace Services.Zombie.dto
{
    class WalkerToxic : ZombieToxic
    {
        public WalkerToxic(Location location) : base(location)
        {
            Priority = 2;
            Action = 1;
            MinDamage = 1;
            Experience = 1;
            Name = "Toxic Walker";
            Type = ZombieMainTypeEnum.Walker;
        }
    }
}
