using System.Collections.Generic;
using Services.CardService.Dto;
using Services.Zombie.dto;

namespace Services.CardService
{
    public interface ICardService
    {
        List<ZombieCard> GetZombieDeck(List<ZombicideGameEnum> zombicideGames = null);

        List<Equipment> GetEquimentDeck(List<ZombicideGameEnum> zombicideGames = null);

        Card DrawCard(List<Card> deck);

        List<ZombieFamilyEnum> GetDeckZombieFamilyFromVersion(ZombicideGameEnum version);
    }
}