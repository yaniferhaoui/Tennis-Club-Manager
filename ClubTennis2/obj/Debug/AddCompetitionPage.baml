   M S B A M L   `   `   `  ����F  BClubTennis2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ClubTennis2ClubTennis2  5      $    ClubTennis2.AddCompetitionPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:ClubTennis2     5        N� Title$  CompetitionPage��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��35 �6   .+�5   
   � $��0��6   $��10q�6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#    5      �� 5      $
��Auto �6    �� 5       $
��Auto �6    �� 5!      $
��Auto �6    .+�5$      �� $��Nom: ��6   $��0��6$   $��0��61   $��Center=�6A   $��20,20,20,20q�6c   �� 5%      -   5         ��Name$ 
nomTextBox��5%      $��0��6*   $��1��67   $��Center=�6G   $��
0,20,40,20q�6i   �� 5'      $��Prix: ��6   $��1��6%   $��0��62   $��Center=�6B   $��20,20,20,20q�6d   �� 5(      -   5        $ prixTextBox��5(      $��1��6,   $��1��69   $��Center=�6t   $��
0,20,40,20q�6�   �� 5*      -   5         ��Name$ 
levelLabel��5*      $��Niveau: ��6(   $��2��6;   $��0��6H   $��Center=�6X   $��20,20,20,20q�6z   �� 5+      -   5         ��Name$ levelComboBox��5+      $��2��6.   $��1��6;   $��Center=�6K   $��
0,20,40,20q�6m   �� 5-      -   5         ��Name$ AddTeamB��5-      $��2��69   $��1��6I   $��Ajouter une équipe��6V   $��20,20,20,20q�6s   �� 5.      -   5        $ RemoveTeamB��5.      $��2��6H   $��2��6X   $��Supprimer sélectionnés��6e   $��20,20,20,20q�6�   5/      &   System.Windows.Controls.DataGrid  51   
   -   5          Name$ teamMatches��51      	   AutoGenerateColumns	 .  ��. $
��Auto=�53      $
��Auto=�54      $��1��55      
   
IsReadOnly
 .    Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ Joueur 1��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Member1String+6Y     5=      $ Joueur 2��6%   $ 1* 6Y    67   �� *Member2String+6Y     5?      $
 Date��6%   $ * 6e    63   �� *Date+ �� StringFormat$ 
dd/MM/yyyy��6e     5A      $ Résultat Totale��6%   $ * 6[    6>   �� *
Resultat+6[     5C      $
 Type��6%   $ * 6L    63   �� *Type+6L   5G      � 5I   
   $��2��6    5K      �� 5L      $��* �6#   �� 5M      $��* �6#   .+�5P      �� -   5        $ valider��5P      $��Valider��6&   $��4��6P   $��0��6]   �� 5Q      -	   5        $ AnnulerB��5Q      $��Annuler��67   $��4��6I   $��1��6V   5T      5U      5V      