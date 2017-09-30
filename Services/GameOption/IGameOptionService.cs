using System.Collections.Generic;
using Domain;

namespace Services.GameOption
{
    public interface IGameOptionService
    {
        List<Domain.Character.Character> GetCharacters(List<ZombicideGameEnum> zombicideGames, bool withZombie = false);

    }
}