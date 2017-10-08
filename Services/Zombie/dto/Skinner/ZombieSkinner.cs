using Services.Map;

namespace Services.Zombie.dto.Skinner
{
    public class ZombieSkinner : Zombie
    {
        public ZombieSkinner(Location location) : base(location)
        {
            IsSkinner = true;
            Family = ZombieFamilyEnum.Skinner;
        }
    }
}
