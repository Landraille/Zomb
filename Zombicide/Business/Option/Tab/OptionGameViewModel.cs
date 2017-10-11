using System;
using System.Collections.Generic;
using Caliburn.Micro;
using Services;
using Services.CardService;
using Services.Zombie;
using Zombicide.Business.Option.Tab.Model;

namespace Zombicide.Business.Option.Tab
{
    public class OptionGameViewModel : Screen, IOptionScreen
    {
        private readonly ICardService _cardService;
        private bool _isDayFogOfWar;
        private bool _isNightFogOfWar;
        private bool _isStealthMode;
        private bool _isFogOfWarMode;
        private bool _isStandardGame;
        private bool _isCustomizedGame;
        private List<ZombieDeckModel> _zombieDeckList;

        public List<ZombieDeckModel> ZombieDeckList
        {
            get => _zombieDeckList;
            set
            {
                _zombieDeckList = value; 
                NotifyOfPropertyChange(() => ZombieDeckList);
            }
        }

        public bool IsCustomizedGame
        {
            get => _isCustomizedGame;
            set
            {
                if (value.Equals(_isCustomizedGame)) return;
                _isCustomizedGame = value;
                NotifyOfPropertyChange(() => IsCustomizedGame);
            }
        }

        public bool IsStandardGame
        {
            get => _isStandardGame;
            set
            {
                if (value.Equals(_isStandardGame)) return;
                _isStandardGame = value;
                if (value)
                {
                    IsFogOfWarMode = false;
                    IsStealthMode = false;
                    IsDayFogOfWar = false;
                    IsNightFogOfWar = false;
                    IsCustomizedGame = false;
                }
                NotifyOfPropertyChange(() => IsStandardGame);
            }
        }

        public bool IsFogOfWarMode
        {
            get => _isFogOfWarMode;
            set
            {
                _isFogOfWarMode = value;
                if (!value)
                {
                    IsDayFogOfWar = false;
                    IsNightFogOfWar = false;
                }
                NotifyOfPropertyChange(() => IsFogOfWarMode);
            }
        }

        public bool IsStealthMode
        {
            get => _isStealthMode;
            set
            {
                _isStealthMode = value; 
                NotifyOfPropertyChange(() => IsStealthMode);
            }
        }


        public bool IsNightFogOfWar
        {
            get => _isNightFogOfWar;
            set
            {
                if (value.Equals(_isNightFogOfWar)) return;
                _isNightFogOfWar = value;
                NotifyOfPropertyChange(() => IsNightFogOfWar);
            }
        }

        public bool IsDayFogOfWar
        {
            get => _isDayFogOfWar;
            set
            {
                if (value.Equals(_isDayFogOfWar)) return;
                _isDayFogOfWar = value; 
                NotifyOfPropertyChange(() => IsDayFogOfWar);
            }
        }

        public OptionGameViewModel(ICardService cardService)
        {
            IsStandardGame = true;
            _cardService = cardService;

            ZombieDeckList = SetZombieDeckList();
            NotifyOfPropertyChange(() => ZombieDeckList);
        }

        private List<ZombieDeckModel> SetZombieDeckList()
        {
            var list = new List<ZombieDeckModel>();
            foreach (ZombicideGameEnum version in Enum.GetValues(typeof(ZombicideGameEnum)))
            {
                var zombielist = _cardService.GetDeckZombieFamilyFromVersion(version);
                list.Add(new ZombieDeckModel
                {
                    Version = version,
                    ZombieTypeList = String.Join(", ", zombielist)
                });
            }
            return list;
        }
    }
}