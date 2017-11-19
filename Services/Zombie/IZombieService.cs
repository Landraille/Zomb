using System.Collections.Generic;
using Core;
using Domain.Zombie;
using Services.Map;
using Services.Zombie.dto;

namespace Services.Zombie
{
    public interface IZombieService
    {
        dto.Zombie CreateZombie(ZombieTypeEnum zombieType, Location location);
    }
}