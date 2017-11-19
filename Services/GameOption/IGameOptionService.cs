using System.Collections.Generic;
using Core;

namespace Services.GameOption
{
    public interface IGameOptionService
    {
        List<Character.CharacterDto> GetCharacters(List<ZombicideGameEnum> zombicideGames, bool withZombie = false);

    }
}