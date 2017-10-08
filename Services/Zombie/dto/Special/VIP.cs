using Services.Map;

namespace Services.Zombie.dto.Special
{
    public class VIP : Zombie
    {
        public VIP(Location location) : base(location)
        {
            Priority = 3;
            Action = 1;
            MinDamage = 1;
            Experience = 1;
            Name = "VIP";
            Type = ZombieMainTypeEnum.Walker;
            Family = ZombieFamilyEnum.VIP;
        }
    }
}