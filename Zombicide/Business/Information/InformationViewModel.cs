using Caliburn.Micro;
using Zombicide.Assets;
using Zombicide.Extensions;

namespace Zombicide.Business.Information
{
    public class InformationViewModel : Screen
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set { _message = value; NotifyOfPropertyChange(() => Message); }
        }

        public override string DisplayName { get; set; }

        public InformationViewModel()
        {
            DisplayName = Translations.INFORMATION;
        }
        public void Initialize(string message)
        {
            Message = message;
        }

        public void Close()
        {
            this.SafeExecute(() => TryClose());
        }
    }
}