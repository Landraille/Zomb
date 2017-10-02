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
using Zombicide.Assets;

namespace Zombicide.Business.Option.Tab
{
    /// <summary>
    /// Logique d'interaction pour OptionGameView.xaml
    /// </summary>
    public partial class OptionGameView : UserControl
    {
        public OptionGameView()
        {
            InitializeComponent();
        }

        //private void RadioButton_OnChecked(object sender, RoutedEventArgs e)
        //{
        //    if (StandardGame?.IsChecked ?? false)
        //    {
        //        ModeStatusBar.Text = Translations.STANDARD_GAME;
        //    }

        //    if (CustomizedGame?.IsChecked ?? false)
        //    {
        //        ModeStatusBar.Text = Translations.CUSTOMIZED_GAME;
        //    }
        //}

        //private void DifficultyComboBox_OnDropDownClosed(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(DifficultyComboBox.Text))
        //    {
        //        DifficultyStatusBar.Foreground = Brushes.Red;
        //        DifficultyStatusBar.Text = "??";
        //    }
        //    else
        //    {
        //        DifficultyStatusBar.Foreground = Brushes.Black;
        //        DifficultyStatusBar.Text = DifficultyComboBox.Text;
        //    }
        //}

        //private void PlayerNumberComboBox_OnDropDownClosed(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(PlayerNumberComboBox.Text))
        //    {
        //        PlayerStatusBar.Foreground = Brushes.Red;
        //        PlayerStatusBar.Text = "??";
        //    }
        //    else
        //    {
        //        PlayerStatusBar.Foreground = Brushes.Black;
        //        PlayerStatusBar.Text = PlayerNumberComboBox.Text;
        //    }
        //}

        //private void CharacterNumberByPlayerComboBox_OnDropDownClosed(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(CharacterNumberByPlayerComboBox.Text))
        //    {
        //        CharacterStatusBar.Foreground = Brushes.Red;
        //        CharacterStatusBar.Text = "??";
        //    }
        //    else
        //    {
        //        CharacterStatusBar.Foreground = Brushes.Black;
        //        CharacterStatusBar.Text = CharacterNumberByPlayerComboBox.Text;
        //    }
        //}
    }
}
