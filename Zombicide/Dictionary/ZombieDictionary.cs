using System.Collections.Generic;
using System.Windows.Media;
using Core;
using Services.Zombie.dto;

namespace Zombicide.Dictionary
{
    public static class ZombieDictionary
    {
        public static Dictionary<ZombieFamilyEnum, string> ZombieColors { get; }

        static ZombieDictionary()
        {
            ZombieColors = new Dictionary<ZombieFamilyEnum, string>
            {
                {ZombieFamilyEnum.Standard, "StandardZombieBrush"},
                {ZombieFamilyEnum.Toxic, "ToxicZombieBrush"},
                {ZombieFamilyEnum.Berserker, "BerserkerZombieBrush"},
                {ZombieFamilyEnum.Skinner, "SkinnerZombieBrush"},
                {ZombieFamilyEnum.Dogz, "DogzZombieBrush"},
                {ZombieFamilyEnum.Crowz, "CrowzZombieBrush"},
                {ZombieFamilyEnum.Seeker, "SeekerZombieBrush"},
                {ZombieFamilyEnum.VIP, "VIPZombieBrush"},
            };
        }
    }
}