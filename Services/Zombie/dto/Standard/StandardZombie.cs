using Services.Map;

namespace Services.Zombie.dto
{
    public class StandardZombie : Zombie
    {
        public StandardZombie(Location location) : base(location)
        {
            Family = ZombieFamilyEnum.Standard;
        }
    }
}