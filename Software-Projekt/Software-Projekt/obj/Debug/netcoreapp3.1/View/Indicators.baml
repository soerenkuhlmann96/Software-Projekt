   M S B A M L   `   `   `  ����K  GSoftware-Projekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Software_ProjektSoftware_Projekt  5   	   G(clr-namespace:Software_Projekt.ViewModelSoftware_Projekt.ViewModel  5   	   !    Software_Projekt.Indicators   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Software_Projekt     5   	   7vm(clr-namespace:Software_Projekt.ViewModel     5   	     � Title$  
Indicators��5	   	   $	��700��6   $
��1200��6)   $
��1050��66   $	��600��6F    � DataContext 5      *  $Software_Projekt.ViewModel.ViewModel  5   
    � 	Resources 5         TextBlockStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6'   .�5      ��  � ��$ 24(�6*   �� 5       � ��$ Center=�64   �� 5       � ��$ 20q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   $	��350��6)   �� 5      $��* �6   $	��350��6)   �� 5       $��* �6   $	��350��6)   .+�5#   
   �� #��[  6   $��Nominal��6H   �� 5$   
   #��[  6   $��Ordinal��6H   $��1��6W   �� 5%   
   #��[  6   $��Metrisch��6H   $��2��6X   �� 5'   
   $��1��6   $��Stretch=�6O   ��6    ��  �� Path$ IndicatorsNominal���5(      �� 5)      .R�5*      �� -   5        ��5*      �� $
 Name�6;   5+      5-      �� 5.   
   $��1��6   $��1��6    $��Stretch=�6_   ��60   �� $ IndicatorsOrdinal���5/      �� 50      .R�51      �� -   5        ��51      �� $
 Name�6;   52      54      �� 55   
   $��1��6   $��2��6    $��Stretch=�6`   ��60   �� $ IndicatorsMetrisch���56      �� 57      .R�58      �� -   5        ��58      �� $
 Name�6;   59      5;      �� 5<   
   $��2��6   $��3��6"   $��Center=�66   	 �� Orientation$	 
Horizontal=�6S   $��	0,10,0,10q�6l   .+�5>      �� -   5        $��Zurück��5>      $��0,0,5,0q�6:   �� 5?      -   5        $��Beenden��5?      $��5,0,0,0q�6:   5@      5A      5B      