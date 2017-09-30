using Caliburn.Micro;
using Zombicide.Extensions;

namespace Zombicide.Business.Confirm
{
    public class ConfirmViewModel : Screen
    {
        public string Title { get; set; }
        public string Label { get; set; }

        public bool ShowCancelButton { get; set; }

        public ConfirmViewModel()
        {
            ShowCancelButton = true;
        }

        public void Ok()
        {
            this.SafeExecute(() =>
            {
                TryClose(true);
            });
        }

        public void Close()
        {
            this.SafeExecute(() => TryClose(false));
        }
    }
}