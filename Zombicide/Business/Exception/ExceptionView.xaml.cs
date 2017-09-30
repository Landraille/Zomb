using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zombicide.Business.Exception
{
    /// <summary>
    /// Logique d'interaction pour ExceptionView.xaml
    /// </summary>
    public partial class ExceptionView : UserControl
    {
        public ExceptionView()
        {
            InitializeComponent();
        }

        private void ExceptionView_OnLoaded(object sender, RoutedEventArgs e)
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
