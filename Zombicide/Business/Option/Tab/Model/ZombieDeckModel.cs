using Services;
using Zombicide.Extensions;

namespace Zombicide.Business.Option.Tab.Model
{
    public class ZombieDeckModel
    {
        public ZombicideGameEnum Version { get; set; }
        public bool IsSelected { get; set; }
        public string ZombieTypeList { get; set; }
        public string VersionName => Version.GetZombicideGameName();
    }
}