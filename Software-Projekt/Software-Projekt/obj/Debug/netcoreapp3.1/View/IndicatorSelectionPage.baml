   M S B A M L   `   `   `  ����K  GSoftware-Projekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Software_Projekt.ViewSoftware_Projekt.View  5      G(clr-namespace:Software_Projekt.ViewModelSoftware_Projekt.ViewModel  5      2    ,Software_Projekt.View.IndicatorSelectionPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Software_Projekt.View     5      7vm(clr-namespace:Software_Projekt.ViewModel     5      -   5          N�Name$  IndicatorSelection��5
       N� Title$ IndicatorSelectionPage��5      .��5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� .+�5      �� $��Kennzahlenauswahl��6   $��Center=�60   $��28(�6M   5      �� 5   
   -   5         ��Name$ ListBox��5   ]   $��1��6   $��Stretch=�6   
������ 6]   �� 5   
   $��2��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5       �� $��Ausgewählte Kennzahl:��6   $��Center=�69   $��20(�6T   �� 5!      ��6   ��  �� ElementName$ IndicatorSelection��.@�5"      �� 
���   �$��1q�6-   $��Center=�6A   $��10,10,10,10q�6^   ._�5#      �� $��Center=�6g   $��10,10,10,10q�6�   ��6    �� $ IndicatorSelection�� �� Path$ ChoosenIndicator�6�   5$      5%      5&      �� 5'      -   5        $��Weiter��5'      $��60��6&   61   5(      �� 5)   
   $��3��6   $��Center=�6"   $ 
Horizontal=�6?   .+�5*      �� -   5        $��Zurück��5*      $��
0,10,10,10q�6&   6:   �� 5+      -   5        $��Beenden��5+      $��
10,10,0,10q�6'   6;   5,      5-      5.      