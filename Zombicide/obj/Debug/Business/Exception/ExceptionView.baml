   M S B A M L   `   `   `  ����D  @Zombicide, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Zombicide.Business.ExceptionZombicide.Business.Exception  5      3clr-namespace:Zombicide.AssetsZombicide.Assets  5      0    *Zombicide.Business.Exception.ExceptionView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Zombicide.Business.Exception     5      1assetsclr-namespace:Zombicide.Assets     5      -   5        $	��500��5      $	��400��5      $��1q�5         
BlackBrush#��[  5      .��5      �   � RowDefinitions  5   
   �� 5      $��30 �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6     SubHeaderLabelStyle#��[ 5      ��5      �� *DisplayName+5      �� 5   
   $��1��6     
GrayBrush8#��[ 5      |�.  5      � 5   
   $��2��6     5      �� 5       $
��Auto �6    �� 5!      $��* �6     � ColumnDefinitions 5#      �� 5$      $
��Auto �6#   �� 5%      $��* �6#   .+�5'      F� $��0��6   $��0��5(        ExceptionPathStyle#��[ 5)       	 Error#��[ 5*      �� 5+      $��0��6   $��1��5,      $��10,0,0,0q�5-      #��[ 5.      #   Zombicide.Assets.Translations!   EXCEPTION_AN_ERROR_OCCURED#��Z 5/      $	��350��50      �� 51      $��1��6   $��0��52      $��2��53      $��10q�54      $
��Auto=�55      $
��Auto=�56      
������ .��58      �� 
������ ��6   �� *
Messages+59      5:      5;      �� 5=   
   $��3��6   $��10q�5>       �� Orientation$ 
Horizontal=�5?      $��Right=�5@      |�.  .+�5B      �� -   5         ��Name$ Close��5B       �� 	IsDefault .   ModalButton#��[ 5D      .��5E      F� $��0��6     CancelPathButton#��[ 5F       
 Cancel#��[ 5G      5H      5I      5J      5K      