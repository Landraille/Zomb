using System;
using System.Windows;
using Caliburn.Micro;
using Zombicide.Assets;
using Zombicide.Business.Confirm;
using Zombicide.Event;
using Zombicide.Extensions;

namespace Zombicide.Business.Home
{
    public class HomeViewModel : Screen
    {
        private static readonly Lazy<IWindowManager> _windowManager = new Lazy<IWindowManager>(() => IoC.Get<IWindowManager>());
        private readonly IEventAggregator _eventAggregator;

        public HomeViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public void Quit()
        {
            this.SafeExecute(() =>
            {
                var confirmVm = IoC.Get<ConfirmViewModel>();
                if (confirmVm != null)
                {
                    confirmVm.Label = Translations.QUIT_CONFIRM_QUESTION;
                    confirmVm.Title = Translations.QUIT_TITLE;
                    var result = _windowManager.Value.ShowDialog(confirmVm);
                    if (result.HasValue && result.Value)
                    {
                        // OK
                        Application.Current.Shutdown();
                    }
                }
            });
        }

        public void NewGame()
        {
            _eventAggregator.PublishOnUIThread(new OpenOptionScreenEvent());
        }
    }
}