   M S B A M L   `   `   `  ����F  BClubTennis2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ClubTennis2ClubTennis2  5      "    ClubTennis2.AddTeamMatchPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:ClubTennis2     5        N� Title$  AddTeamMatchPage��5	       N� 
Background
 �����.��5      � -   5         �Name$ mainGrid��5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��35 �6   .+�5   
   �  5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5       $
��Auto �6#   .+�5#      �� $��
Joueur 1: ��6   $��0��6)   $��0��66   $��Center=�6F   $��20,20,20,20q�6h   �� 5$      -   5         ��Name$ j1��5$      $��Inconnu��6    $��0��62   $��1��6?   $
��Bold"�6O   $��Center=�6a   $��Center=�6�   �� 5%      -   5         ��Name$ 
modifierJ1��5%      $��Modifier��6)   $��0��6O   $��2��6\   $��
0,35,10,35q�6l   �� 5'      $��
Joueur 2: ��6   $��1��6)   $��0��66   $��Center=�6F   $��20,20,20,20q�6h   �� 5(      -   5        $ j2��5(      $��Inconnu��6    $��1��62   $��1��6?   $
��Bold"�6O   $��Center=�6a   $��Center=�6�   �� 5)      -   5        $ 
modifierJ2��5)      $��Modifier��6)   $��1��6O   $��2��6\   $��
0,35,10,35q�6l   �� 5+      $��Type de Jeu: ��6   $��2��6,   $��0��69   $��Center=�6I   $��20,20,20,20q�6k   �� 5,      -   5         ��Name$ typeJeuComboBox��5,      $��2��60   $��1��6=   $��Center=�6M   $��
0,35,10,35q�6o   .@�5-      �� -   5         ��Name$ simple��5-      $��	2 Simples��6/   	 �� 
IsSelected	 . 6C   �� 5.      -   5        $ double��5.      $��1 Double��6/   5/      �� 51      $��Date de la rencontre: ��6   $��0��65   $��3��6B   $��Center=�6R   $��Center=�6o   �� 53      -	   5        $ 	dateLabel��53      $y�Hidden=�6'   $��1��6;   $��3��6H   $��Center=�6X   $��Center=�6z   �� 54      -
   5        $ modifierDate��54      $y�Hidden=�6+   $��Modifier la Date��6?   $��10,35,10,35q�6Z   $��2��6�   $��3��6�   &   System.Windows.Controls.Calendar  56      -   5        
  Name$
 dateCalendar��56      $��1��6-   $��3��6:   $��2��6J   $��	50,0,50,0q�6[   �� 57      -   5        $ validerDate��57      $��Valider la Date��6*   $��10,35,10,35q�6X   $��3��6m   $��3��6z   58      � 5:   
   $��2��6    5<      �� 5=      $��* �6#   �� 5>      $��* �6#   .+�5A      �� -   5        $ AddTeamB��5A      $��0��67   $��Ajouter��6G   �� 5B      -   5        $ CancelTeamB��5B      $��1��6:   $��Annuler��6J   5C      5D      5E      