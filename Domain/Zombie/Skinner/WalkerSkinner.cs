﻿using Domain.Map;

namespace Domain.Zombie.Skinner
{
    public class WalkerSkinner : ZombieSkinner
    {
        public WalkerSkinner(Location location) : base(location)
        {
            Priority = 3;
            Action = 1;
            MinDamage = 1;
            Experience = 1;
            Name = "Skinner Walker";
            Type = ZombieMainTypeEnum.Walker;
        }
    }
}