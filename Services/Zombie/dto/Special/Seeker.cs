﻿using Core;
using Domain.Zombie;
using Services.Map;

namespace Services.Zombie.dto
{
    public class Seeker : Zombie
    {
        public Seeker(Location location) : base(location)
        {
            Priority = 3;
            Action = 1;
            MinDamage = 1;
            Experience = 1;
            Name = "Seeker";
            Type = ZombieMainTypeEnum.Seeker;
            Family = ZombieFamilyEnum.Seeker;
        }
    }
}
