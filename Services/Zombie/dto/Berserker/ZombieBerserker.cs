using Services.Map;

namespace Services.Zombie.dto.Berserker
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
