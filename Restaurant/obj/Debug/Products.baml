   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Restaurant
Restaurant  5   	       Restaurant.Products   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Restaurant     5   	     � Title$  Products��5   	   $	��450��6   $	��800��6'    � WindowStyle$ 
ToolWindow=�63   $	��800��6L   $	��450��6[   $	��800��6k   $	��450��6z   
���   � � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       '�� M     �� 5
   
   " ��6   .�5      ��  � ��$ 14(�6)   66   5      �� 5   
   " ��6   .�5      ��  � ��$ 16(�6)   66   5      5      .��5      � ���	#FF232323.+�5   
   �� -   5         ��Name$ listBoxProducts��5      $��10,51,417,10q�6v    J� OpacityMask
 �   ����	#FF232323���	#FF232323
���������6+   �� *
Products+ �� SelectedItem 6L   �� *SelectedProducts+��5      �� 5      .R�5      �� .+�5      �� ��6$   �� 	 �� Path$	 Title�6B   �� 5      ��6$   �� $	 Count�6B   �� 5      ��6$   �� $	 Price�6B   5      5      5      �� 5   
   ���	#FF232323$��
380,0,10,0q�6T   
 � DataContext
 6   �� *SelectedProduct+.+�5      �� -   5         ��Name$ labelId��5      
���������6%   �� *Id+ �� UpdateSourceTrigger$ PropertyChanged=�6v   �� 5      $��20(�6   $��Продукт��6&   
�������$��0,0,0,0q�6H   �� 5       $��17(�6   $��Название��6&   
�������$��0,0,0,0q�6I   6\   �� 5!      -   5         ��Name$ textBoxTitle��5!       �� SelectionBrush �	#FF035FFF$��0,0,0,0q�6�    �� 	IsEnabled . ��6,   �� *Title+$ PropertyChanged=�6�   �� 5"      $��17(�6   $��Количество��6&   
�������$��0,0,0,0q�6K   6^   �� 5#      -   5        $ textBoxCount��5#       �	#FF035FFF$��0,0,0,0q�6�   ��6,   �� *Count+$ PropertyChanged=�6�   �� 5$      $��17(�6   $��Стоимость��6&   
�������$��0,0,0,0q�6J   6]   �� 5%      -   5        $ textBoxPrice��5%       �	#FF035FFF$��0,0,0,0q�6�   ��6,   �� *Price+$ PropertyChanged=�6�   5&      �� 5'   
   -   5         ��Name$ 
buttonHome��5'      $��Главная��6%   $��10,10,692,373q�67   ���	#FF8B8B8B6c   �� 5(   
   -   5        $ buttonMainWindow��5(      $��Сотрудники��6+   $��105,10,592,373q�6@   ���	#FF8B8B8B6m   �� 5)   
   -   5        $ 
buttonMenu��5)      $��Меню��6%   $��205,10,502,373q�64   ���	#FF8B8B8B6a   �� 5*   
   -	   5        $ buttonOrder��5*      $��
Заказ��6&   $��295,10,417,373q�66   ���	#FF8B8B8B6c   5+      5,      