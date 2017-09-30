﻿using Domain.Map;

namespace Domain.Zombie.Berserker
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
