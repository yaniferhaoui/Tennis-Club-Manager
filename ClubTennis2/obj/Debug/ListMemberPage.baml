   M S B A M L   `   `   `  ����F  BClubTennis2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ClubTennis2ClubTennis2  5           ClubTennis2.ListMemberPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:ClubTennis2     5        N� 
Background
  ����� N� Title$ ListMemberPage��5
      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � $��50, 10, 50, 10q�6   $��0��6'    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#    5      �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5       $��* �6    .+�5$      �� $
��Bold"�6   $��0��6&   $��0��66   .��6C   	Ordre :6L   	� 5%      -   5         	�Name$ az��5%       	� 	GroupName$ c2��6&    d� 	IsChecked$
 TrueY�65   $��Center=�6]   $��1��6   $��0��6�   $��2,0,12,0q�6�   .��6�   A-Z6�   	� 5&      -   5        $ ranking��5&      $ c2��6+   $��Center=�6Q   $��2��6s   $��0��6�   $��2,0,12,0q�6�   .��6�   
Classement6�   	� 5'      -   5        $ gender��5'      $ c2��6*   $��Center=�6P   $��3��6r   $��0��6�   $��2,0,12,0q�6�   .��6�   Sexe6�   �� 5*      $
��Bold"�6   $��0��6&   $��1��66   .��6C   Filtre N°1 :6Q   	� 5+      -   5        $ c1��5+      $
 TrueY�6)   $��Center=�6Q   $��1��6s   $��1��6�   $��2,0,12,0q�6�   .��6�   Tous6�   	� 5,      -   5        $ competition��5,      $ c1��6/   $��Center=�6U   $��2��6w   $��1��6�   $��2,0,12,0q�6�   .��6�   Compétition6�   	� 5-      -   5        $ leisure��5-      $ c1��6+   $��Center=�6Q   $��3��6s   $��1��6�   $��2,0,12,0q�6�   .��6�   Loisir6�   �� 50      $
��Bold"�6   $��0��6&   $��2��66   .��6C   Filtre N°2 :6Q   	� 51      -   5        $ c3��51      $
 TrueY�6)   $��Center=�6Q   $��1��6s   $��2��6�   $��2,0,12,0q�6�   .��6�   Tous6�   	� 52      -   5        $
 paid��52      $ c3��6(   $��Center=�6N   $��2��6p   $��2��6�   $��2,0,12,0q�6�   .��6�   Cotisation Payé6�   	� 53      -	   5        $ notPaid��53      $ c3��6+   $��Center=�6Q   $��3��6s   $��2��6�   $��2,0,12,0q�6�   .��6�   Cotisation Non-Payé6�   �� 56      $
��Bold"�6   $��0��6&   $��3��66   .��6C   Filtre N°3 :6Q   	� 57      -
   5        $ c4��57      $
 TrueY�6)   $��Center=�6Q   $��1��6s   $��3��6�   $��2,0,12,0q�6�   .��6�   Tous6�   	� 58      -   5        $ onlyMembers��58      $ c4��6/   $��Center=�6U   $��2��6w   $��3��6�   $��2,0,12,0q�6�   .��6�   Membres Simples6�   	� 59      -   5        $ 	employees��59      $ c4��6-   $��Center=�6S   $��3��6u   $��3��6�   $��2,0,12,0q�6�   .��6�   
Personnels6�   5:      &   System.Windows.Controls.DataGrid  5<   
   -   5          Name$ members��5<         AutoGenerateColumns .  ��. $
��Auto=�5>      $
��Auto=�5?      $��1��5@      	   
IsReadOnly	 . 
   Columns
 5C      4  .System.Windows.Controls.DataGridTemplateColumn  5E      ,  &System.Windows.Controls.DataGridColumn   Header$ Modifier��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6;      CellTemplate 5F      �� 5G      .R�5H      �� -   5        $��Modifier��5H   %   $��5,5,5,5q�6I   5I      5K      0  *System.Windows.Controls.DataGridTextColumn  5M      $ Prenom��6%   $
 Auto 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *	FirstName+6S     5O      $	 Nom��6%   $
 Auto 6O    62   �� *
LastName+6O     5Q      $
 Sexe��6%   $ * 6N    63   �� *Gender+6N     5S      $ Niveau��6%   $ * 6Z    65   �� *LevelDescription+6Z     5U      $	 Age��6%   $ * 6J    62   �� *Age+6J     5W      $
 Type��6%   $ * 6L    63   �� *Type+6L     5Y      $ Cotisation Payé��6%   $
 Auto 6k    6>   �� *SubscriptionPaidThidYear+6k     5[      $ Type de Licence��6%   $
 Auto 6d    6>   �� *RegistrationType+6d   5_      � 5a   
   $��2��6    5c      �� 5d      $��* �6#   .+�5g      �� -   5        $��1��5g   3   $��Supprimer sélectionnés��6C   $	��200��6d   5h      5k      5l      