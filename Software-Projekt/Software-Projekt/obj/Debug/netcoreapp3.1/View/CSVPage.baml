   M S B A M L   `   `   `  ����K  GSoftware-Projekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Software_Projekt.ViewSoftware_Projekt.View  5      #    Software_Projekt.View.CSVPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Software_Projekt.View     5      -   5          N�Name$  CSVInputPage��5       N� Title$ CSVPage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� $��CSV Einlesen��6   $��Center=�6(   $��32(�6E   $��0,10,0,0q�6S   �� 5   
   $��1��6   $��Center=�6"   $��Center=�6?   $��	0,20,0,20q�6Z   .+�5      �� $��Anzahl Zahlenreihen:��6   $��0,0,0,10q�64   �� 5      -   5         ��Name$ Amount��5   )    �� SelectedIndex$ 0��6   .@�5      �� $��1��6   �� 5      $��2��6   �� 5      $��3��6   �� 5      $��4��6   5      �� 5      -   5        $��Datei öffnen��5      $��	0,10,0,10q�6?   �� 5       $��
Dateipfad:��6   �� 5!      ��6   ��  �� ElementName$ CSVInputPage��.@�5"      ��  �� 
IsReadOnly$
 True��6O   $	��200��6a   ��6   �� $ CSVInputPage�� �� Path$
 Path�6a   5#      5$      �� 5%   
   $��2��6   $��Center=�6"   .+�5&      �� -   5        $��Weiter��5&      $��	0,10,0,10q�6&   69   �� 5'      	 �� Orientation$	 
Horizontal=�6   .+�5(      �� -   5        $��Zurück��5(      $��
0,10,10,10q�6*   6>   �� 5)      -   5        $��Beenden��5)      $��
10,10,0,10q�6+   6?   5*      5+      5,      5-      