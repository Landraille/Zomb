using Caliburn.Micro;
using Zombicide.Assets;
using Zombicide.Extensions;

namespace Zombicide.Business.Exception
{
    public class ExceptionViewModel : Screen
    {
        private string[] _messages;

        public string[] Messages
        {
            get { return _messages; }
            set { _messages = value; NotifyOfPropertyChange(() => Messages); }
        }

        public override string DisplayName { get; set; }

        public ExceptionViewModel()
        {
            DisplayName = Translations.EXCEPTION_TITLE;
            Messages = new string[1];
        }

        public void Initialize(System.Exception exception)
        {
            var ex = exception.GetFirstException();
            Messages[0] = ex.Message;
        }

        public void Close()
        {
            this.SafeExecute(() => TryClose());
        }
    }
}