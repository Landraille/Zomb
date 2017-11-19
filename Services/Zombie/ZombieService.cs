using Core;
using Domain.Zombie;
using Services.Extension;
using Services.Map;
using Services.Zombie.dto;

namespace Services.Zombie
{
    public class ZombieService : IZombieService
    {
        public dto.Zombie CreateZombie(ZombieTypeEnum zombieType, Location location)
        {
            var zombie = zombieType.ToZombieDto(location);

            return zombie;
        }
    }
}