using System;
using System.Collections.Generic;
using Services.Zombie.dto;
using System.Linq;
using Services.Map;

namespace Services.Extension
{
    public static class ZombieTypeEnumExtension
    {
        public static Zombie.dto.Zombie ToZombieDto(this ZombieTypeEnum @this, Location location)
        {
            var z = Type.GetType("Services.Zombie.dto." + @this.ToString() + ", Services");

            object[] args = new object[] { location };
            return (Zombie.dto.Zombie)(Activator.CreateInstance(z, args));
        }

        public static List<Zombie.dto.Zombie> ToZombieDtos(this IEnumerable<ZombieTypeEnum> @this, Location location = null)
        {
            return @this?.Select(x => x.ToZombieDto(location)).ToList();
        }
    }
}