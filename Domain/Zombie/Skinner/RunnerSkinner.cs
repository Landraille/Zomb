﻿using Domain.Map;

namespace Domain.Zombie.Skinner
{
    public class RunnerSkinner : ZombieSkinner
    {
        public RunnerSkinner(Location location) : base(location)
        {
            Priority = 9;
            Action = 1;
            MinDamage = 1;
            Experience = 1;
            Name = "Skinner Runner";
            Type = ZombieMainTypeEnum.Runner;
        }
    }
}
