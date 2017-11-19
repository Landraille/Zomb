using System.Collections.Generic;
using Core;
using Domain.Zombie;
using Services.CardService.Dto;
using Services.Zombie.dto;

namespace Services.CardService
{
    public interface ICardService
    {
        List<int> GetZombieDeck(List<ZombicideGameEnum> zombicideGames);

        List<EquipmentDto> GetEquimentDeck(List<ZombicideGameEnum> zombicideGames = null);

        CardDto DrawCard(List<CardDto> deck);

        List<ZombieFamilyEnum> GetDeckZombieFamilyFromVersion(ZombicideGameEnum version);
    }
}