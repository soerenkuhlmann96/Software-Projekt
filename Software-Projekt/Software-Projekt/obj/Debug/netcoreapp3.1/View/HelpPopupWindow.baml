   M S B A M L   `   `   `  ����K  GSoftware-Projekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Software_Projekt.ViewSoftware_Projekt.View  5   	   +    %Software_Projekt.View.HelpPopupWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Software_Projekt.View     5   	     � Title$  HelpPopupWindow��5   	   $	��450��6!   $	��800��6.   
�������.��5
      �� $��Center=�6   $��Center=�6.   .+�5   
   �� $7��1Sind die Merkmalsausprägungen Namen oder Zahlen?��6   $��14(�6L   �� 5   
   -   5         ��Name$ 	Combobox1��5   L    �� SelectedIndex$ 0��6   $	��150��6%   $
��Left=�61   .@�5      �� $��Zahlen��6   �� 5      $��Namen��6   5      �� 5   
   -   5         ��Name$ 	Question2��5   ,   $y�	Collapsed=�6   .+�5      �� $V��PSind die Abstände zwischen den Merkmalsausprägungen sinnvoll interpretierbar? ��6   $��0,10,0,0q�6n   $��14(�6�   �� 5      -   5        $ 	Combobox2��5   Q   $ 0��6   $	��150��6)   $
��Left=�65   .@�5      �� $
��Nein��6   �� 5      $��Ja��6   5      5      �� 5   
   -   5        $ 	Question3��5   ,   $y�	Collapsed=�6   .+�5      �� $-��'Haben sie einen natürlichen Nullpunkt?��6   $��0,10,0,0q�6F   $��14(�6X   �� 5      -   5        $ 	Combobox3��5   P   $ 0��6   $	��150��6)   $
��Left=�65   .@�5      �� $
��Nein��6   �� 5      $��ja��6   5      5      �� 5!   
   -   5        $ 	Question4��5!   ,   $y�	Collapsed=�6   .+�5"      �� $)��#Haben sie eine natürliche Einheit?��6   $��0,10,0,0q�6B   $��14(�6T   �� 5#      -   5        $ 	Combobox4��5#   Q   $ 0��6   $	��150��6)   $
��Left=�65   .@�5$      �� $��Ja��6   �� 5%      $
��Nein��6   5&      5'      �� 5)   
   -   5        $��OK��5)      $��50��6   $��	50,20,0,0q�6)   $
��Left=�6S   5*      5+      