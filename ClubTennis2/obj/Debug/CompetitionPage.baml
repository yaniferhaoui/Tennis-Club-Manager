   M S B A M L   `   `   `  ����F  BClubTennis2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ClubTennis2ClubTennis2  5      !    ClubTennis2.CompetitionPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:ClubTennis2     5        N� Title$  CompetitionPage��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� -   5         ��Name$ 
AddMemberB��5      $��0��6B   $��Ajouter commpétition��6R   �� 5      -   5        $ AddEmployeeB��5      $��1��6I   $��Supprimer sélectionnés��6Y   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ competitions��5         AutoGenerateColumns .  ��. $
��Auto=�5       $
��Auto=�5!      $��1��5"         
IsReadOnly .    Columns 5&      4  .System.Windows.Controls.DataGridTemplateColumn  5)      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Modifier/Voir��6)   
   CellTemplate
 5*      �� 5+      .R�5,      �� -   5        $��Modifier/Voir��5,   %   $��5,5,5,5q�6N   5-      5/      0  *System.Windows.Controls.DataGridTextColumn  51      $		 Nom��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Name+6K     53      $
	 Prix��6%   $ * 6M    63   �� *Price+6M     55      $	 Niveau��6%   $ * 6S    65   �� *	LevelDesc+6S     57      $	 Début��6%   $ * 6g    64   �� *Start+ �� StringFormat$ 
dd/MM/yyyy��6g     59      $		 Fin��6%   $ * 6c    62   �� *End+$ 
dd/MM/yyyy��6c     5;      $	 Nombre de Matchs��6%   $
 Auto 6X      
IsReadOnly .  6?   �� *Size+6e   5?      5A      5B      