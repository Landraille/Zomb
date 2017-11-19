using System.Globalization;
using System.Resources;
using Core;
using Services;
using Zombicide.Assets;

namespace Zombicide.Extensions
{
    public static class ZombicideGameEnumExtension
    {
        public static string GetZombicideGameName(this ZombicideGameEnum @this)
        {
            ResourceManager rm = new ResourceManager(typeof(Translations));

            return rm.GetString("GAME_NAME_" + @this.ToString().ToUpper(), CultureInfo.CurrentUICulture);
        }

        public static string GetDetails(this ZombicideGameEnum @this)
        {
            ResourceManager rm = new ResourceManager(typeof(Translations));

            return rm.GetString("DETAILS_ZOMBIE_" + @this.ToString().ToUpper(), CultureInfo.CurrentUICulture);
        }
    }
}