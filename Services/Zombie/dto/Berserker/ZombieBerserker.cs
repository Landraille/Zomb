using Services.Map;

namespace Services.Zombie.dto
{
    public abstract class ZombieBerserker : Zombie
    {
        public ZombieBerserker(Location location) : base(location)
        {
            IsBerserk = true;
            Family = ZombieFamilyEnum.Berserker;
        }
    }
}
