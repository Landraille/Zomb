using System.Collections.Generic;

namespace Services.Character
{
    public class Character
    {
        public string Name { get; set; }
        public List<TagEnum> Tags { get; set; }
        public string LongDescription { get; set; }
        public string BoardImage { get; set; }
        public string Image { get; set; }
        public string IdImage { get; set; }
        //public bool IsSelected { get; set; }
        public CharacterPower Powers { get; set; }
        //public int Exp { get; set; }
        //public CharacterActionNumber ActionNumber { get; set; }
        //public CharacterEquipment Equipment { get; set; }
        public bool IsZombie { get; set; }
        public ZombicideGameEnum ZombicideGame { get; set; }

    }
}