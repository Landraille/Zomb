﻿using Core;
using Domain.Zombie;
using Services.Map;

namespace Services.Zombie.dto
{
    public class Walker : StandardZombie
    {
        public Walker(Location location) : base(location)
        {
            Action = 1;
            Experience = 1;
            MinDamage = 1;
            Priority = 3;
            Name = "Walker";
            Type = ZombieMainTypeEnum.Walker;
        }
    }
}