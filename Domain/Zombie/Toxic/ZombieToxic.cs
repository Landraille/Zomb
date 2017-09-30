using Domain.Map;

namespace Domain.Zombie.Toxic
{
    public abstract class ZombieToxic : Zombie
    {
        public ZombieToxic(Location location) : base(location)
        {
            IsToxic = true;
        }
    }
}
