   M S B A M L   `   `   `  ����F  BClubTennis2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ClubTennis2ClubTennis2  5           ClubTennis2.TournamentPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:ClubTennis2     5        N� Title$  TournamentPage��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� -   5        $��0��5   -   $��Ajouter Tournoi��6=   �� 5      -   5        $��1��5   3   $��Supprimer sélectionnés��6C   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ tournois��5         AutoGenerateColumns .  ��. $
��Auto=�5       $
��Auto=�5!      $��1��5"         
IsReadOnly .    Columns 5&      4  .System.Windows.Controls.DataGridTemplateColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Modifier/Voir��6)   	   CellTemplate	 5(      �� 5)      .R�5*      �� -   5        $��Modifier/Voir��5*   %   $��5,5,5,5q�6N   5+      5-      0  *System.Windows.Controls.DataGridTextColumn  5/      $ ID��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+6H     51      $	 Nom��6%   $
 * 6K    62   �� *Name+6K     53      $
 Date��6%   $
 * 6f    63   �� *Start+ �� StringFormat$ 
dd/MM/yyyy��6f     55      $ Nombre Inscrit��6%   $
 * 6\      
IsReadOnly .  6=   �� *
SizeMember+6f     57      $ Nombre de Coach��6%   $
 * 6\    .  6>   �� *	SizeCoach+6f   5:      5<      5=      