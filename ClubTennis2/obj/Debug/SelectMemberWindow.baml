   M S B A M L   `   `   `  ����F  BClubTennis2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ClubTennis2ClubTennis2  5   	   $    ClubTennis2.SelectMemberWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ClubTennis2     5   	     � Title$  SelectMemberWindow��5   	   $	��400��6$   $	��900��61   .��5	      �  � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��* �6   �� 5      $��35 �6   .+�5   
   �� -   5         ��Name$ 
listeLabel��5      $
��Bold"�6$   $>��8Liste de tout Membres, Coachs, Staffs disponible ce jour��66   $��Center=�6y   $��Center=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ members��5         AutoGenerateColumns .  ��. $
��Auto=�5      $
��Auto=�5      $��1��5         
IsReadOnly .    SelectionMode$ Single=�5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Prenom��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 Auto 6S   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *	FirstName+6S     5      $	 Nom��6%   $
	 Auto 6O   
 62   �� *
LastName+6O     5!      $
 Sexe��6%   $	 * 6N   
 63   �� *Gender+6N     5#      $ Niveau��6%   $	 * 6Z   
 65   �� *LevelDescription+6Z     5%      $	 Age��6%   $	 * 6J   
 62   �� *Age+6J     5'      $ Type de Membre��6%   $
	 Auto 6V   
 6=   �� *Type+6V     5)      $ Cotisation Payé��6%   $
	 Auto 6k   
 6>   �� *SubscriptionPaidThidYear+6k     5+      $ Type de Licence��6%   $
	 Auto 6d   
 6>   �� *RegistrationType+6d   5/      � 51   
   $��2��6    � ColumnDefinitions 53      �� 54      $��* �6#   �� 55      $��* �6#   .+�58      �� -   5         ��Name$ AddTeamB��58      $��0��67   $��Ajouter��6G   �� 59      -   5        $ CancelTeamB��59      $��1��6:   $��Annuler��6J   5:      5;      5<      