using System.Collections.Generic;

namespace Services.GameOption
{
    public interface IGameOptionService
    {
        List<Character.Character> GetCharacters(List<ZombicideGameEnum> zombicideGames, bool withZombie = false);

    }
}