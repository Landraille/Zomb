using Caliburn.Micro;
using Services.GameOption;

namespace Zombicide.Business.Option.Tab
{
    public class OptionGameViewModel : Screen, IOptionScreen
    {
        private readonly IGameOptionService _gameOptionService;

        private string _difficulty;
        private int _playerNumber;
        private int _characterNumberByPlayer;

        public int CharacterNumberByPlayer
        {
            get { return _characterNumberByPlayer; }
            set
            {
                _characterNumberByPlayer = value;
                NotifyOfPropertyChange(() => CharacterNumberByPlayer);
                NotifyOfPropertyChange(() => TotalCharacterNumber);
            }
        }


        public int PlayerNumber
        {
            get { return _playerNumber; }
            set
            {
                _playerNumber = value;
                NotifyOfPropertyChange(() => PlayerNumber);
                NotifyOfPropertyChange(() => TotalCharacterNumber);
            }
        }


        public string Difficulty
        {
            get { return _difficulty; }
            set
            {
                _difficulty = value;
                NotifyOfPropertyChange(() => Difficulty);
            }
        }

        public int TotalCharacterNumber => PlayerNumber * CharacterNumberByPlayer;


        public OptionGameViewModel(IGameOptionService gameOptionService)
        {
            _gameOptionService = gameOptionService;
        }
    }
}