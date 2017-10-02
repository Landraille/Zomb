using Caliburn.Micro;
using System.Collections.Generic;
using Zombicide.Business.Option.Tab;

namespace Zombicide.Business.Option
{
    public class OptionViewModel : Conductor<IOptionScreen>.Collection.OneActive
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly OptionGameViewModel _optionGameViewModel;
        private readonly OptionCharacterViewModel _optionCharacterViewModel;
        private readonly OptionMapViewModel _optionMapViewModel;
        private readonly OptionParameterViewModel _optionParameterViewModel;

        public OptionViewModel(IEventAggregator eventAggregator, OptionGameViewModel optionGameViewModel, OptionCharacterViewModel optionCharacterViewModel, OptionMapViewModel optionMapViewModel, OptionParameterViewModel optionParameterViewModel)
        {
            _eventAggregator = eventAggregator;
            _optionGameViewModel = optionGameViewModel;
            _optionCharacterViewModel = optionCharacterViewModel;
            _optionMapViewModel = optionMapViewModel;
            _optionParameterViewModel = optionParameterViewModel;

            var tabs = new List<IOptionScreen>
            {
                _optionGameViewModel,
                _optionCharacterViewModel,
                _optionMapViewModel,
                _optionParameterViewModel
            };

            //add tab to tabcontrol
            Items.AddRange(tabs);
        }

        protected override void OnActivate()
        {
            base.OnActivate();
            _eventAggregator.Subscribe(this);
        }

        protected override void OnDeactivate(bool close)
        {
            _eventAggregator.Unsubscribe(this);
            base.OnDeactivate(close);
        }
    }
}