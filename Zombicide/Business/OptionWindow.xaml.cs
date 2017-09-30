using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace Zombicide
{
    /// <summary>
    /// Logique d'interaction pour OptionWindow.xaml
    /// </summary>
    public partial class OptionWindow : Window
    {
        public OptionWindow()
        {
            InitializeComponent();
            Style = (Style)FindResource(typeof(Window));
            this.DataContext = this;

            //List<Character.Character> characters = new List<Character.Character>();

            //characters.Add(new Character.Character()
            //{
            //    IsSelected = false,
            //    Name = "Raoul",
            //    ShortDescription = "Médecin militaire",
            //    LongDescription = "Raoul est un ancien médicin militaire. Il a fait son boulot chez dans une boîte d’ambulanciers locaux en tant que chef d’équipe médicale… blasé. Il pensait avoir tout vu. En tout cas, jusqu’à ce que ses amis et collègues se fassent grignoter par la horde de zombies alors qu’ils composaient les numéros d’urgence au début de l’épidémie. Les naïfs. Désormais dénué d’empathie et de bandages, Raoul est en quête de revanche. Il est équipé, prêt à descendre dans la rue, et embarque tout les « médicaments » dont auront besoin les sacs à viande mangeurs qui se mettront en travers de sa route.",              
            //    BoardImage = "/WpfLibrary;component/Assets/Images/sic-raoul.jpg"
            //});
            //characters.Add(new Character.Character()
            //{
            //    IsSelected = false,
            //    Name = "Doug",
            //    ShortDescription = "Fonctionnaire à la mitraillette",
            //    LongDescription = "4 heures dans les transports, 12 heures de travail par jour, des collègues peu coopératifs et un patron indifférent appartiennent tous au passé de Doug. C’est certain, faire face aux zombies est un peu stressant mais pour être franc, c’est quand même mieux que le train-train quotidien. Un Uzi dans chaque main, c’est utile pour négocier avec les ex-collègues et les ex-patrons. De toute manière, Doug est persuadé qu’ils étaient déjà des zombies avant toute cette histoire.",
            //    BoardImage = "/WpfLibrary;component/Assets/Images/sic-doug.jpg"
            //});
            //characters.Add(new Character.Character()
            //{
            //    IsSelected = false,
            //    Name = "Elsa",
            //    ShortDescription = "Voleuse silencieuse",
            //    LongDescription = "Jolie fille née dans une famille pauvre, Elsa a appris que l’agilité, l’apparence et la subtilité pouvaient sont autant de voies vers la richesse. Voler des bien précieux était sa dose quotidienne d’adrénaline, surtout si cela comprenait quelques acrobaties et un vrai défi au niveau de la sécurité. Elsa était poursuivie par les policiers sur les toits quand les zombies sont apparus et ont changé sa vie. L’or n’a plus aucune valeur désormais mais les abris blindés dissimulent toujours des biens précieux.Joueuse et souriante au milieu du chaos,le chat se rie de l’apocalypse. Les barrières sociales sont tombées, seul compte le talent. Et Elsa est si talentueuse !",
            //    BoardImage = "/WpfLibrary;component/Assets/Images/sic-elsa.jpg"
            //});
            //characters.Add(new Character.Character()
            //{
            //    IsSelected = false,
            //    Name = "Grindlock",
            //    ShortDescription = "Métalleux avant tout",
            //    LongDescription = "Le Heavy Metal n’est pas un genre musical, c’est une hygiène de vie, et c’est la voie que Grindlock a choisie. C’est certain, cette armoire à glace n’entrait pas vraiment dans le moule, mais il s’en moquait. Le travail devait être fait, la musique devait être forte, et tout le reste n’était que vanité. Grindlock n’a pas cillé quand les zombies sont venus le chercher. Il les a slammés comme des mouches, s’est emparé d’une tronçonneuse et s’en est allé voir l’apocalypse droit dans les yeux avec un petit sourire. Il attend désormais un adversaire assez fort pour lui faire dire que la vie est vraiment devenue métal.",
            //    BoardImage = "/WpfLibrary;component/Assets/Images/sic-grindlock.jpg"
            //});
            //characters.Add(new Character.Character()
            //{
            //    IsSelected = false,
            //    Name = "Wanda",
            //    ShortDescription = "Serveuse à roller",
            //    LongDescription = "Wanda servait de la bière et des hamburgers au drive-in du coin. L’apocalypse zombie n’a pas vraiment changé ses habitudes : elle esquive toujours des mains avides de chair, file sur ses rollers et repousse les prétendants un peu trop hardis. La tronçonneuse, par contre, c’est un bonus.",
            //    BoardImage = "/WpfLibrary;component/Assets/Images/sic-wanda.jpg"
            //});

            //characters.Add(new Character.Character()
            //{
            //    IsSelected = false,
            //    Name = "Derek",
            //    ShortDescription = "Bricoleur",
            //    LongDescription = "Derek arpentait le Grand Nord pour établir les limites des propriétés et trouver tout ce qu’on pourrait vouloir trouver là-bas. Œil d’aigle et nerfs d’acier, Derek n’a pas attendu les zombies pour être un survivant.Les zombies n’ont changé qu’une seule chose dans sa vie.Lorsque la civilisation s’est effondrée,il a pris la direction du sud et d’une vie plus facile.Il a marché sur mille ou deux mille kilomètres sans problème.Rien n’est difficile quand on sait survivre à un blizzard !",
            //    BoardImage = "/WpfLibrary;component/Assets/Images/sic-derek.jpg"
            //});

            //DgCharacters.ItemsSource = characters;
            //CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(DgCharacters.ItemsSource);
            //view.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));

        }


        private void Game_OnClick(object sender, RoutedEventArgs e)
        {
            string mode = "";
            ModeStatusBar.Foreground = Brushes.Black;

            if (StandardGame.IsChecked.Value)
            {
                mode = "Standard";
                FurtiveOption.IsChecked = false;
                FogOfWarOption.IsChecked = false;
            }
            else if (CustomizedGame.IsChecked.Value)
            {
                mode = "Personnalisé";
            }
            else
            {
                mode = "...";
                ModeStatusBar.Foreground = Brushes.Red;
            }

            ModeStatusBar.Text = "Mode: " + mode;
        }

        private void Selector_Difficulty(object sender, SelectionChangedEventArgs e)
        {
            DifficultyStatusBar.Text = "Difficulté: " + ((ComboBoxItem)DifficultyComboBox.SelectedItem).Content.ToString();
            DifficultyStatusBar.Foreground = Brushes.Black;
        }

        private void PlayerNumberComboBox_OnDropDownClosed(object sender, EventArgs e)
        {
            if (((ComboBoxItem) PlayerNumberComboBox.SelectedItem) != null)
            {
                PlayerStatusBar.Text = "Joueurs: " + ((ComboBoxItem)PlayerNumberComboBox.SelectedItem).Content.ToString();
                PlayerStatusBar.Foreground = Brushes.Black;
                SetCharacterStatusBar();
            }

        }

        private void CharacterNumberByPlayerComboBox_OnDropDownClosed(object sender, EventArgs e)
        {
            SetCharacterStatusBar();
        }

        private void StartGame_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            int selectedCharacterCount = GetSelectedCharacterNumber();
            if (!string.IsNullOrWhiteSpace(DifficultyComboBox.Text) 
                && !string.IsNullOrWhiteSpace(PlayerNumberComboBox.Text) 
                && !string.IsNullOrWhiteSpace(CharacterNumberByPlayerComboBox.Text) 
                && selectedCharacterCount == int.Parse(PlayerNumberComboBox.Text) * int.Parse(CharacterNumberByPlayerComboBox.Text)
                )
            {
                e.CanExecute = true;
            }
        }

        private void StartGame_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            this.Close();
        }

        private void EventCharacterSelection_OnHandler(object sender, RoutedEventArgs e)
        {
            SetCharacterStatusBar();
        }

        private void SetCharacterStatusBar()
        {
            if (!string.IsNullOrWhiteSpace(PlayerNumberComboBox.Text) &&
                !string.IsNullOrWhiteSpace(CharacterNumberByPlayerComboBox.Text))
            {
                int characterNumber = int.Parse(PlayerNumberComboBox.Text)*
                                      int.Parse(CharacterNumberByPlayerComboBox.Text);
                CharacterStatusBar.Foreground = Brushes.Red;

                int selectedCharacterCount = GetSelectedCharacterNumber();               

                if (selectedCharacterCount == characterNumber)
                {
                    CharacterStatusBar.Foreground = Brushes.Black;
                }

                CharacterStatusBar.Text = "Personnages: " + selectedCharacterCount + "/" + characterNumber;
                
            }
        }

        private int GetSelectedCharacterNumber()
        {
            //if (DgCharacters.ItemsSource != null)
            //{
            //    var itemsSource = DgCharacters.ItemsSource;
            //    int count = 0;

            //    foreach (Character.Character item in itemsSource)
            //    {
            //        if (item.IsSelected)
            //        {
            //            count++;
            //        }
            //    }
            //    return count;
            //}
            return 0;
        }

        private void FogOfWarOption_OnClick(object sender, RoutedEventArgs e)
        {
            if (FogOfWarOption.IsChecked.Value)
            {
                DayFogOfWarOption.IsChecked = true;
            }
            else
            {
                DayFogOfWarOption.IsChecked = false;
                NightFogOfWarOption.IsChecked = false;
            }
        }
    }
}