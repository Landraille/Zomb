using Domain.Map;

namespace Domain.Zombie.Berserker
{
    public abstract class ZombieBerserker : Zombie
    {
        public ZombieBerserker(Location location) : base(location)
        {
            IsBerserk = true;
        }
    }
}
