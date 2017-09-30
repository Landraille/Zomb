using System.Windows;
using System.Windows.Controls;

namespace Zombicide.Business.Information
{
    /// <summary>
    /// Logique d'interaction pour InformationView.xaml
    /// </summary>
    public partial class InformationView : UserControl
    {
        public InformationView()
        {
            InitializeComponent();
        }

        private void InformationView_OnLoaded(object sender, RoutedEventArgs e)
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
