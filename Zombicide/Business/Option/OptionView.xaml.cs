using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Zombicide.Assets;

namespace Zombicide.Business.Option
{
    /// <summary>
    /// Logique d'interaction pour OptionView.xaml
    /// </summary>
    public partial class OptionView : UserControl
    {
        public OptionView()
        {
            InitializeComponent();
        }

        private void RadioButton_OnChecked(object sender, RoutedEventArgs e)
        {
            if (StandardGame?.IsChecked ?? false)
            {
                ModeStatusBar.Text = Translations.STANDARD_GAME;
            }

            if (CustomizedGame?.IsChecked ?? false)
            {
                ModeStatusBar.Text = Translations.CUSTOMIZED_GAME;
            }
        }

        private void DifficultyComboBox_OnDropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DifficultyComboBox.Text))
            {
                DifficultyStatusBar.Foreground = Brushes.Red;
                DifficultyStatusBar.Text = "??";
            }
            else
            {
                DifficultyStatusBar.Foreground = Brushes.Black;
                DifficultyStatusBar.Text = DifficultyComboBox.Text;
            }
        }

        private void PlayerNumberComboBox_OnDropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PlayerNumberComboBox.Text))
            {
                PlayerStatusBar.Foreground = Brushes.Red;
                PlayerStatusBar.Text = "??";
            }
            else
            {
                PlayerStatusBar.Foreground = Brushes.Black;
                PlayerStatusBar.Text = PlayerNumberComboBox.Text;
            }
        }

        private void CharacterNumberByPlayerComboBox_OnDropDownClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CharacterNumberByPlayerComboBox.Text))
            {
                CharacterStatusBar.Foreground = Brushes.Red;
                CharacterStatusBar.Text = "??";
            }
            else
            {
                CharacterStatusBar.Foreground = Brushes.Black;
                CharacterStatusBar.Text = CharacterNumberByPlayerComboBox.Text;
            }
        }
    }
}
