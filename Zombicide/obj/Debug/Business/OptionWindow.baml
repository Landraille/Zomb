   M S B A M L   `   `   `  ����D  @Zombicide, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Zombicide	Zombicide  5   	   5clr-namespace:Zombicide.CommandZombicide.Command  5   	       Zombicide.OptionWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Zombicide     5   	   4commandsclr-namespace:Zombicide.Command     5   	     � Title$  OptionWindow��5	   	   $	��800��6   $	��800��6+    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$% commands:StartGameCommand.Start��5      6e   .��5      ]� .+�5   
   �� $��Bottom=�6   $��Center=�6,   .@�5      �� .��5      �� -   5        $��ModeStatusBar��5      Mode: Standard6A   5      �� 5      �� 5      .��5      �� -   5        $��DifficultyStatusBar��5      
���  ��Difficulté: ??6X   5      �� 5      �� 5      .��5      �� -   5        $��PlayerStatusBar��5      
���  ��Joueurs: ??6Q   5      �� 5      �� 5      .��5      �� -   5        $��CharacterStatusBar��5      
���  ��Personnages: ??5      5      5      �� 5    
   .+�5"   
   ��    Header1Style#��[  6   $��OPTIONS��6:   � 5%   
    � RowDefinitions 5&      �� 5'      $
��Auto �6    �� 5(      $
��Auto �6     � ColumnDefinitions 5*      �� 5+      $��* �6#   �� 5,      $	��120 �6#   �� 5-      $��* �6#   .+�5/      �� $��0��6   $��Center=�6)   .+�50      ��   Header2Style#��[ 6   Mode de jeu6O   	� 51      -   5        $��StandardGame��51   H   $��15, 0, 0, 0q�6    d� 	IsChecked$
 TrueY�6\    	� 	GroupName$ GameModeGroup��6m   $��Standard��6�   	� 52      -   5        $��CustomizedGame��52   H   $��15, 0, 0, 0q�6   $ GameModeGroup��6^   $��Personnalisé��6x   �� 53      -   5        $��FurtiveOption��53   1   $��30, 0, 0, 0q�6    ^� ShowOnDisabled . {�6F   ��  �� ElementName$ CustomizedGame��	 �� Path$	 	IsChecked�.��6�   Mode Furtif
 � ToolTip
 54      �� 55      $L��FA chaque action bruyante, des zombies arrivent des cotés du plateau !��6$   57      �� 58      -	   5        $��FogOfWarOption��58   r   $��30, 0, 0, 0q�6    . {�6�   �� $ CustomizedGame��$	 	IsChecked�.��6�   
Fog of War
 59      �� 5:      $����Seuls les zombies se trouvant dans le champ de vision des personnages sont visibles sur le plateau. Attention lorsque vous tournez au coin d'une rue !��6$   6�   5<      	� 5=      -
   5        $��DayFogOfWarOption��5=   3   $��45, 0, 0, 0q�6   $ FogOfWarGroup��6�    . {�6L   �� $ FogOfWarOption��$	 	IsChecked�.��6�   Jour
 5>      �� 5?      $=��7(Fog of War) Pas de restriction sur le champ de vision.��6$   6e   5A      	� 5B      -   5        $��NightFogOfWarOption��5B   3   $��45, 0, 0, 0q�6   $ FogOfWarGroup��6�    . {�6N   �� $ FogOfWarOption��$	 	IsChecked�.��6�   Nuit
 5C      �� 5D      $d��^(Fog of War) Le champ de vision est limité à 2 cases. N'avancez pas trop vite ni tout seul !��6$   6�   5F      5G      �� 5H      $��1��6   $4��./WpfLibrary;component/Assets/Images/zombie.jpg��6$   �� 5J      $��2��6   $��Center=�6)   .+�5K      �� #��[ 6   Difficulté6N   �� 5L      -   5         ��Name$ DifficultyComboBox��5L   1   $��15, 0, 0, 0q�6   $	��100��6M   $
��Left=�6�   .@�5M      �� .��6#   Facile6+   �� 5N      .��6#   Moyen6*   �� 5O      .��6#   	Difficile6.   �� 5P      .��6#   	Cauchemar6.   5Q      5R      5S      �� 5V   
   #��[ 6    �� TextAlignment$ Center=�6:   Personnages6^   � 5W   
   $��Center=�6    5X      �� 5Y      $��* �6    �� 5Z      $��* �6     5\      �� 5]      $��2* �6#   �� 5^      $��50 �6#   �� 5_      $��* �6#   .+�5b      ��   Header3Style#��[ 6   Nombre de joueur(s)6T   �� 5c      -   5        $ PlayerNumberComboBox��5c      $��1��65   $��40��6B   .@�5d      �� .��6   16"   �� 5e      .��6   26"   �� 5f      .��6   36"   5g      �� 5i      $��2��6   #��[ 6(   $"Nombre de personnage(s) par joueur6s   �� 5j      -   5        $% CharacterNumberByPlayerComboBox��5j      $��1��6@   $��2��6M   $��40��6^   .@�5k      �� .��6   16"   �� 5l      .��6   26"   5m      5n      &   System.Windows.Controls.DataGrid  5p   
   -   5        $��DgCharacters��5p   #   $��20, 10q�6      AutoGenerateColumns .  $	��800��6S      CanUserAddRows .  $
��Left=�6v      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6�      Columns 5q      4  .System.Windows.Controls.DataGridCheckBoxColumn  5r      -   5        IsSelectedCharacter��,  &System.Windows.Controls.DataGridColumn   Width$
 Auto 5r   �   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *
IsSelected+ �� UpdateSourceTrigger$ PropertyChanged=�   	CellStyle 5s      �� 5t      .�5u      -   5        5w      5y      0  *System.Windows.Controls.DataGridTextColumn  5{         Header$
 Name��6%   $ * 6L      
IsReadOnly .  63   �� *Name+6V     5|      $ Description��6%   $ * 6_    .  6:   �� *ShortDescription+6i      RowDetailsTemplate 5~      �� 5      .R�5�      ]� 
�������.+�5�      ��  ��Name$ 	CardImage��6    $
��Left=�63   $��64��6g   $��10q�6s   ��6I   �� *
BoardImage+
 5�      �� 5�   "   ��6(   �� *
BoardImage+5�      �� 5�      $	��500��6$   $
��Wrap=�60   ��6D   �� *LongDescription+ �� StringFormat$ d��5�      5�      5�      �� 5�   
   $��30q�6     DefaultButton#��[ 6   $%��commands:StartGameCommand.Start��6D   $	��100��6o   .��6{   
Start Game6�   5�      5�      5�      