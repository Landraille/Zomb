using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace Zombicide
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Style = (Style)FindResource(typeof(Window));
        }

        private void ButtonNewGame_OnClick(object sender, RoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            //OptionWindow optionWindow = new OptionWindow();
            //optionWindow.Show();
            this.Close();
        }

        private void ButtonLoadGame_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Zombicide files (*.zbc)|*.zbc";
            if (openFileDialog.ShowDialog() == true)
            {
                
            }

        }

        private void ButtonQuit_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}