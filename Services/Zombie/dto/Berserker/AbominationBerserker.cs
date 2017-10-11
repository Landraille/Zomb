using Services.Map;

namespace Services.Zombie.dto
{
    class AbominationBerserker : ZombieBerserker
    {
        public AbominationBerserker(Location location) : base(location)
        {
            Priority = 7;
            Action = 1;
            MinDamage = 3;
            Experience = 5;
            Name = "Berserker Abomination";
            Type = ZombieMainTypeEnum.Abomination;
        }
    }
}
