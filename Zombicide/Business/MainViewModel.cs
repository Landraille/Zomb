using Caliburn.Micro;
using Zombicide.Business.Home;
using Zombicide.Business.Option;
using Zombicide.Event;

namespace Zombicide.Business
{
    public class MainViewModel : Conductor<Screen>,
        IHandle<OpenOptionScreenEvent>
    {
        private readonly IEventAggregator _eventAggregator;

        public MainViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        protected override void OnActivate()
        {
            base.OnActivate();
            _eventAggregator.Subscribe(this);
            var homeVm = IoC.Get<HomeViewModel>();
            ActivateItem(homeVm);
        }

        protected override void OnDeactivate(bool close)
        {
            _eventAggregator.Unsubscribe(this);
            base.OnDeactivate(close);
        }

        public void Handle(OpenOptionScreenEvent message)
        {
            var vm = IoC.Get<OptionViewModel>();
            if (vm != null)
            {
                ActivateItem(vm);
            }
        }
    }
}