using System.Collections.Generic;
using Domain;

namespace Services.CardService
{
    public interface ICardService
    {
        List<Domain.Card.ZombieCard> GetZombieDeck(List<ZombicideGameEnum> zombicideGames);

        List<Domain.Card.Equipment> GetEquimentDeck(List<ZombicideGameEnum> zombicideGames);

        Domain.Card.Card DrawCard(List<Domain.Card.Card> deck);
    }
}