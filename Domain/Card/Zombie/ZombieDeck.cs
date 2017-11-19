using System.Collections.Generic;
using System.Collections.ObjectModel;
using Core;

namespace Domain.Card.Zombie
{
    public class ZombieDeck
    {
        public static readonly IList<ZombieDeckDetails> ZombieDeckCardNumber = new ReadOnlyCollection<ZombieDeckDetails>
        (new List<ZombieDeckDetails> {
            new ZombieDeckDetails(ZombicideGameEnum.Season1, 1, 42),
            new ZombieDeckDetails(ZombicideGameEnum.WalkOfTheDead1, 43, 54),
            new ZombieDeckDetails(ZombicideGameEnum.ZombieDogz, 55, 66),
            new ZombieDeckDetails(ZombicideGameEnum.ToxicCityMall, 67, 78),
            new ZombieDeckDetails(ZombicideGameEnum.PrisonOutBreak, 79, 120),
            new ZombieDeckDetails(ZombicideGameEnum.WalkOfTheDead2, 121, 132),
            new ZombieDeckDetails(ZombicideGameEnum.ToxicCrowd, 133, 138),
            new ZombieDeckDetails(ZombicideGameEnum.AngryZombies, 139, 144),
            new ZombieDeckDetails(ZombicideGameEnum.RueMorgue, 145, 192),
            new ZombieDeckDetails(ZombicideGameEnum.AngryNeighbors, 193, 204),
            new ZombieDeckDetails(ZombicideGameEnum.LostZombivors, 205, 210),
            new ZombieDeckDetails(ZombicideGameEnum.Vip1, 211, 222),
            new ZombieDeckDetails(ZombicideGameEnum.Vip2, 223, 234),
            new ZombieDeckDetails(ZombicideGameEnum.Crowz, 235, 245),
        });

        public class ZombieDeckDetails
        {
            public ZombicideGameEnum Game { get; set; }
            public int First { get; set; }
            public int Last { get; set; }

            public ZombieDeckDetails(ZombicideGameEnum game, int first, int last)
            {
                Game = game;
                First = first;
                Last = last;
            }
        }
    }
}