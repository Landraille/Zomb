﻿using Core;
using Domain.Zombie;
using Services.Map;

namespace Services.Zombie.dto
{
    public class FattyBerserker : ZombieBerserker
    {
        public FattyBerserker(Location location) : base(location)
        {
            Priority = 7;
            Action = 1;
            MinDamage = 2;
            Experience = 1;
            Name = "Berserker Fatty";
            Type = ZombieMainTypeEnum.Fatty;
        }
    }
}
