   M S B A M L   `   `   `  ����@  <WPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFUIWPFUI  5   	       WPFUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:WPFUI     5   	   $
��11pt(�5   	     � Title$  Gord's Adventure��5	   	   $	��768��6"   $
��1024��6/   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $	��225 �6    � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��2��6-   $
��Menu��6A   
�������6P   � 5   
   $��1��6   $��0��6   
������ 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5       $
��Auto �6     5#      �� 5$      $
��Auto �6#   �� 5%      $
��Auto �6#   .+�5(      �� $��0��6   $��0��6!   $��Name:��61   �� 5)      $��0��6   $��1��6!   ��61   �� *CurrentPlayer.Name+�� 5*      $��1��6   $��0��6!   $��Class:��61   �� 5+      $��1��6   $��1��6!   ��61   �� *CurrentPlayer.CharacterClass+�� 5,      $��2��6   $��0��6!   $��Hit points:��61   �� 5-      $��2��6   $��1��6!   ��61   �� *CurrentPlayer.HitPoints+�� 5.      $��3��6   $��0��6!   $��Gold:��61   �� 5/      $��3��6   $��1��6!   ��61   �� *CurrentPlayer.Gold+�� 50      $��4��6   $��0��6!   $	��XP:��61   �� 51      $��4��6   $��1��6!   ��61   �� * CurrentPlayer.ExperiencePoints+�� 52      $��5��6   $��0��6!   $��Level:��61   �� 53      $��5��6   $��1��6!   ��61   �� *CurrentPlayer.Level+54      � 56   
   $��1��6   $��1��6   
������� 58      �� 59      $��* �6    �� 5:      $��* �6     5=      �� 5>      $��3* �6#   �� 5?      $��2* �6#   .+�5B      �� $��0��6   $��1��6"   
�������$��1q�5D      ._�5E      � $��3q�6    5F      �� 5G      $
��Auto �6(   �� 5H      $��* �6(   �� 5I      $
��Auto �6(   .+�5L      �� $��0��6    $��Center=�5M       ��5N       �� *CurrentLocation.LocationName+�� 5P      $��1��6   $��Center=�5Q      $��Center=�5R      $	��125��5S      $	��125��5T      ��5U      �� *CurrentLocation.ImageName+�� 5W      $��2��6    $��Center=�5X       ��5Y       �� *%#CurrentLocation.LocationDescription+5Z      5[      5\      �� 5^   
   $��2��6   $��0��6   $��Inventory/Quests��6-   
�������6H   � 5_   
   $��2��6   $��1��6   
������� 5b      �� 5c      $��* �6     5f      �� 5g      $��* �6#   �� 5h      $	��255 �6#   .+�5k      � $��0��6   $��1��6     5m      �� 5n      $��* �6$   �� 5o      $��* �6$   �� 5p      $��* �6$    5s      �� 5t      $��* �6'   �� 5u      $��* �6'   �� 5v      $��* �6'   .+�5y      �� -   5        $��0��5y      $��1��6&   $��25��5z      $��65��6%   $��10q�60   $��North��5|      �� 5}      -   5        $��1��5}      $��0��6&   $��25��5~      $��65��6%   $��10q�60   $
��West��5�      �� 5�      -   5        $��1��5�      $��2��6&   $��25��5�      $��65��6%   $��10q�60   $
��East��5�      �� 5�      -   5        $��2��5�      $��1��6&   $��25��5�      $��65��6%   $��10q�60   $��South��5�      5�      5�      5�      5�      