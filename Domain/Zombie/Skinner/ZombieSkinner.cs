using Domain.Map;

namespace Domain.Zombie.Skinner
{
    public class ZombieSkinner : Zombie
    {
        public ZombieSkinner(Location location) : base(location)
        {
            IsSkinner = true;
        }
    }
}
