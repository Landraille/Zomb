using Services.Map;

namespace Services.Zombie.dto
{
    public abstract class ZombieToxic : Zombie
    {
        public ZombieToxic(Location location) : base(location)
        {
            IsToxic = true;
            Family = ZombieFamilyEnum.Toxic;
        }
    }
}
