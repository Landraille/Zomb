using System.Collections.Generic;
using Services;
using Services.Zombie.dto;

namespace Zombicide.Business.Option.Tab.Model
{
    public class ZombieDeckModel
    {
        public ZombicideGameEnum Version { get; set; }
        public List<ZombieFamilyEnum> ZombieTypeList { get; set; }
    }
}