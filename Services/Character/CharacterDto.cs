using System.Collections.Generic;
using Core;

namespace Services.Character
{
    public class CharacterDto
    {
        public string Name { get; set; }
        public List<TagEnum> Tags { get; set; }
        public string LongDescription { get; set; }
        public string BoardImage { get; set; }
        public string Image { get; set; }
        public string IdImage { get; set; }
        //public bool IsSelected { get; set; }
        public CharacterPowerDto Powers { get; set; }
        //public int Exp { get; set; }
        //public CharacterActionNumber ActionNumber { get; set; }
        //public CharacterEquipmentDto Equipment { get; set; }
        public bool IsZombie { get; set; }
        public ZombicideGameEnum ZombicideGame { get; set; }

    }
}