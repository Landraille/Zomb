using System.Windows;
using System.Windows.Controls;

namespace Zombicide.Business.Confirm
{
    /// <summary>
    /// Logique d'interaction pour ConfirmView.xaml
    /// </summary>
    public partial class ConfirmView : UserControl
    {
        public ConfirmView()
        {
            InitializeComponent();
        }

        private void ConfirmView_OnLoaded(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.ResizeMode = ResizeMode.NoResize;
                parentWindow.WindowStyle = WindowStyle.None;
                parentWindow.ShowInTaskbar = false;
            }
        }
    }
}
