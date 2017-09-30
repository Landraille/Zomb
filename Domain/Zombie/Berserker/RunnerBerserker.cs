﻿using Domain.Map;

namespace Domain.Zombie.Berserker
{
    public class RunnerBerserker : ZombieBerserker
    {
        public RunnerBerserker(Location location) : base(location)
        {
            Priority = 10;
            Action = 2;
            MinDamage = 1;
            Experience = 1;
            Name = "Berserker Runner";
            Type = ZombieMainTypeEnum.Runner;
        }
    }
}
