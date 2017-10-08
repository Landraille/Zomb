using Services.Map;

namespace Services.Zombie.dto.Standard
{
    public class StandardZombie : Zombie
    {
        public StandardZombie(Location location) : base(location)
        {
            Family = ZombieFamilyEnum.Standard;
        }
    }
}