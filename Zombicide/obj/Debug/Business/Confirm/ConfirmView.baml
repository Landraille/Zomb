   M S B A M L   `   `   `  ����D  @Zombicide, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Zombicide.Business.ConfirmZombicide.Business.Confirm  5      ,    &Zombicide.Business.Confirm.ConfirmView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Zombicide.Business.Confirm     5      -   5        $��ConfirmControl��5      $	��400��5
      $	��150��5      $��1q�5         
BlackBrush#��[  5      .��5      �   MainBackgroundColor#��[ 6     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��20,0,0,0q�5        SubHeaderLabelStyle#��[ 5      ��5      �� *Title+5      �� 5   
   $��1��6     
GrayBrush8#��[ 5      |�.  5      � 5   
   $��2��6   $��10q�5       � ColumnDefinitions 5       �� 5!      $
��Auto �6#   �� 5"      $��* �6#   .+�5$      F� $��0��6     ConfirmContentPathStyle#��[ 5%        QuestionMark#��[ 5&      �� 5'      $��1��6   $��20,0,0,0q�5(        DefaultTextBlock#��[ 5)       �� TextAlignment$
 Left=�5+      $	��600��5,      ��5*      �� *Label+5,      5-      �� 5.   
   $��3��6   $��10q�5/       �� Orientation$ 
Horizontal=�50      $��Right=�51      |�.  .+�53      �� -   5         ��Name$ Ok��53        ModalButton#��[ 54       �� 	IsDefault . .��56      F� $��0��6     ValidatePathButton#��[ 57       	 	CheckMark#��[	 58      59      �� 5:      -   5        $ Close��5:      $��20 0 0 0q�5;      #��[ 5<       �� IsCancel . .��5>      F� $��0��6    
 CancelPathButton#��[
 5?      $��	-20 0 0 0q�5@       
 Cancel#��[ 5A      5B      5C      5D      5E      