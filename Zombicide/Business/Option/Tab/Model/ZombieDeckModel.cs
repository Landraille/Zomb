using Services;

namespace Zombicide.Business.Option.Tab.Model
{
    public class ZombieDeckModel
    {
        public ZombicideGameEnum Version { get; set; }
        public bool IsSelected { get; set; }
        public string ZombieTypeList { get; set; }
    }
}