using System.Collections.Generic;
using Services.Map;
using Services.Zombie.dto;

namespace Services.Zombie
{
    public interface IZombieService
    {
        dto.Zombie CreateZombie(ZombieTypeEnum zombieType, Location location);
    }
}