using System.Collections.Generic;
using Services.CardService.Dto;
using Services.Zombie.dto;

namespace Services.CardService
{
    public interface ICardService
    {
        List<ZombieCardDto> GetZombieDeck(List<ZombicideGameEnum> zombicideGames = null);

        List<EquipmentDto> GetEquimentDeck(List<ZombicideGameEnum> zombicideGames = null);

        CardDto DrawCard(List<CardDto> deck);

        List<ZombieFamilyEnum> GetDeckZombieFamilyFromVersion(ZombicideGameEnum version);
    }
}