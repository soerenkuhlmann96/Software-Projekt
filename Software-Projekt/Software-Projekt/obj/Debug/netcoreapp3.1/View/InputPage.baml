   M S B A M L   `   `   `  ����K  GSoftware-Projekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Software_Projekt.ViewSoftware_Projekt.View  5      %    Software_Projekt.View.InputPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Software_Projekt.View     5        N� Title$  	InputPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� $��Manuelle Eingabe��6   $��32(�6,   $��Center=�6:   $��0,0,0,10q�6W   �� 5   
   $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��Anzahl Zahlenreihen: ��6   �� 5      -   5         ��Name$ ComboboxAmount��5   -    �� SelectedIndex$ 0��6   $	��100��6E   $
��Left=�6Q   .@�5      �� $��1��6#   �� 5      $��2��6#   �� 5      $��3��6#   �� 5      $��4��6#   5       5!      �� 5#      $ 
Horizontal=�6   $��	0,10,0,10q�62   .+�5$      �� $��Zahlenreihe eingeben:��6   $��0,0,5,0q�69   �� 5%      -   5         ��Name$ TextBox1��5%   &   $	��300��6    � ToolTip$ Werte mit ' ; ' trennen��68   5&      �� 5(      -   5         ��Name$ Stackpanel1��5(   \   $ 
Horizontal=�6   $��	0,10,0,10q�62   $y�	Collapsed=�6E   .+�5)      �� $��Zahlenreihe eingeben:��6   $��0,0,5,0q�69   �� 5*      -   5        $ TextBox2��5*   &   $	��300��6   $ Werte mit ' ; ' trennen��68   5+      �� 5-      -   5        $ Stackpanel2��5-   \   $ 
Horizontal=�6   $��	0,10,0,10q�62   $y�	Collapsed=�6E   .+�5.      �� $��Zahlenreihe eingeben:��6   $��0,0,5,0q�69   �� 5/      -   5        $ TextBox3��5/   &   $	��300��6   $ Werte mit ' ; ' trennen��68   50      �� 52      -   5        $ Stackpanel3��52   \   $ 
Horizontal=�6   $��	0,10,0,10q�62   $y�	Collapsed=�6E   .+�53      �� $��Zahlenreihe eingeben:��6   $��0,0,5,0q�69   �� 54      -   5        $ TextBox4��54   &   $	��300��6   $ Werte mit ' ; ' trennen��68   56      58      �� 59   
   $��2��6   .+�5:      �� -	   5        $��Weiter��5:      $��Center=�6&   6C   �� 5;      $��Center=�6   $ 
Horizontal=�66   $��0,30,0,0q�6O   .+�5<      �� -
   5        $��Zurück��5<      $��
0,10,10,10q�6*   6>   �� 5=      -   5        $��Beenden��5=      $��
10,10,0,10q�6+   6?   5>      5?      5@      5A      