using Core;
using Domain.Zombie;
using Services.Map;

namespace Services.Zombie.dto
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
