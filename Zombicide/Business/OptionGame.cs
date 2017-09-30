using System.Collections.Generic;

namespace Zombicide
{
    public class OptionGame
    {
        public string Difficulty { get; set; }
        public int PlayerNumber { get; set; }
        public int CharacterNumberByPlayer { get; set; }
        //public List<Character> SelectedCharacters {get; set; }

        public OptionGame(string difficulty, int playerNumber, int characterNumberByPlayer)
        {
            Difficulty = difficulty;
            PlayerNumber = playerNumber;
            CharacterNumberByPlayer = characterNumberByPlayer;
        }
    }


}