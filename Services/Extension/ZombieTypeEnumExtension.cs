using System;
using System.Collections.Generic;
using Services.Zombie.dto;
using System.Linq;

namespace Services.Extension
{
    public static class ZombieTypeEnumExtension
    {
        public static Zombie.dto.Zombie ToZombieDto(this ZombieTypeEnum @this)
        {
            return (Zombie.dto.Zombie)Activator.CreateInstance(null, @this.ToString()).Unwrap();
        }

        public static List<Zombie.dto.Zombie> ToZombieDtos(this IEnumerable<ZombieTypeEnum> @this)
        {
            return @this?.Select(x => x.ToZombieDto()).ToList();
        }
    }
}