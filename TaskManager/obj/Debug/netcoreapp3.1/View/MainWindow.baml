   M S B A M L   `   `   `  ����F  BTaskManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TaskManagerTaskManager  5   	   5clr-namespace:TaskManager.ModelTaskManager.Model  61   =#clr-namespace:TaskManager.ViewModelTaskManager.ViewModel  6_   !    TaskManager.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TaskManager     5   	   1modelclr-namespace:TaskManager.Model     61   9	viewmodel#clr-namespace:TaskManager.ViewModel     6_     � Title$!  Менеджер задач��5   	   $	��530��6    $	��620��6-    � Icon$' !/Resources/icon/icon_tasklist.png��69   ���	#FF1C1E23 � DataContext 5	      /  )TaskManager.ViewModel.MainWindowViewModel  5
   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �� .+�5      o� $��20��6   $	��Top=�6   ���	#FF313641.@�5      m� $��Файл��6   
�������.@�5      m� $��Сохранить��6   �� 5      m� 5      $��
Выход��6K    m� Command 6   �� *CloseApplicationCommand+6K   5      m� 5      $��Правка��6   
�������6+   m� 5      $��О программе��6   
�������60   5      5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5       6%   �� 5!      6%   .+�5$      �� $��0��6   .+�5%      �� $��
20,20,20,0q�6?   $��Stretch=�6S   ��6   �� *MyDayTaskCommand+ � 	Resources 5&       �� 
TargetType �� Property	 �� Value��%^   '��       �� 5'      " ��6    .�5(      ��  �@��CornerRadius$	 5��6=   5)      5*      ��5+      �� 5,      
 �� Color$
 	#FF15A0BF��6*    �� Opacity$	 0.7Q�6<   .��5.      ��  �� Orientation$ 
Horizontal=�6!   .+�5/      �� $"��/Resources/icon/icon_sun.png��6    $��24��6F   �� 50      .��6    Мой день6*   51      52      �� 53      -   5         ��Name$ btnFavorite��53      $��
20,20,20,0q�6.    54      ��%^   '��       �� 55      " ��6    .�56      ��  �@��CornerRadius$	 5��6=   57      58      ��59      �� 5:      $
 	#FF15A0BF��6*   $	 0.7Q�6<   .��5<      �� $��Stretch=�6!   $ 
Horizontal=�6?   .+�5=      �� $#��/Resources/icon/icon_star.png��6    $��24��6G   5>      �� 5?      .��6    
Важно6'   5@      5A      �� 5B      -   5        $ 	btnPlaned��5B      $��20,20,20,-2q�6,    5C      ��%^   '��       �� 5D      " ��6    .�5E      ��  �@��CornerRadius$	 5��6=   5F      5G      ��5H      �� 5I      $
 	#FF15A0BF��6*   $	 0.7Q�6<   .��5K      �� $��Stretch=�6!   $ 
Horizontal=�6?   .+�5L      �� $'��!/Resources/icon/icon_calendar.png��6    $��24��6K   5M      �� 5N      .��6    Запланировано6/   5O      5P      �� 5Q      -   5        $ btnTaskDone��5Q      $��
20,20,20,0q�6.    5R      ��%^   '��       �� 5S      " ��6    .�5T      ��  �@��CornerRadius$	 5��6=   5U      5V      ��5W      �� 5X      $
 	#FF15A0BF��6*   $	 0.7Q�6<   .��5Z      �� $��Stretch=�6!   $ 
Horizontal=�6?   .+�5[      �� $(��"/Resources/icon/icon_completed.png��6    $��24��6L   5\      �� 5]      .��6    Завершенные6-   5^      5_      �� 5`      $��20q�6    5a      ��%^   '��       �� 5b      " ��6    .�5c      ��  �@��CornerRadius$	 5��6=   5d      5e      ��5f      �� 5g      $
 	#FF15A0BF��6*   $	 0.7Q�6<   .��5i      �� $��Stretch=�6!   $ 
Horizontal=�6?   .+�5j      �� $#��/Resources/icon/icon_task.png��6    $��24��6G   5k      �� 5l      .��6    Задачи6(   5m      5n      5o      � 5p      $��1��6    5q      �� 5r      $��* �6$   61   �� 5s      $
��Auto �6$   64   .+�5u      �� $��0��6   .+�5v      �� $��
20,0,20,20q�5x      $
��Left=�5y      $	��360��5z      $
��Auto=�5{      $	��260��5|      ���	#FF272A31��5v      �� *Tasks+ �� SelectedItem 5w      �� *SelectedTask+��5}      �� 5~      .R�5   "   � $��2q�6'    5�   &   �� 5�   *   �� 5�   *    5�   &   �� 5�   *   $��* �6;   6G   �� 5�   *   6=   .+�5�   &   �� $ 
Horizontal=�61   $��Center=�6J   $��0��6e   .+�5�   *   �� $��0,0,5,0q�6a   $��Center=�6r    d� 	IsChecked 63   �� *
TaskIsDone+ �� Mode$ TwoWay=�6�   �� 5�   *   
���������64   ��  �� Path$ 
HeaderTask�$ TwoWay=�6w   5�   '   �� 5�   &   $��0��61   $��1��6A   $ 
Horizontal=�6N   .+�5�   *   �� 
�������.��6C   Задачи6K   �� 5�   *   $��5,0,5,0q�60   $'��!/Resources/icon/icon_calendar.png��6A   $��16��6l   $��16��6w   6�   �� 5�   *   
�������.��6C   сегодня6L   �� 5�   *   $��5,0,5,0q�60   $%��/Resources/icon/icon_repeat.png��6A   $��16��6j   $��16��6u   6�   5�   '   �� 5�   &   $��1��61   .+�5�   *   �� $��5q�63   $��Center=�6>   $��Center=�6[   ��6v   Z� ��6�   Z� .��5�   .   �� .+�5�   2   �� $/��)/Resources/icon/icon_add_to_favorites.png��68   $��24��6k   $��24��6v   6�   5�   /   5�   +   5�   '   5�   #   5�      5�      5�      �� 5�      $��1��6   $ 
Horizontal=�6*   $��Center=�6C   $��Stretch=�6`   .+�5�      �  5�      �� 5�      �� 5�      .+�5�      �� $��0��6%   .+�5�      �� $ 
Horizontal=�6)    6B   �� *SelectedTask+.+�5�   "   �� $	��260��6l   $��24��6{   $��	20,5,20,5q�6�   ���	#FF272A31
���������6*   �� *
HeaderTask+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5�      �� 5�      $ 
Horizontal=�6N   $��Center=�6g    6)   �� *SelectedTask+.+�5�   "   (  "System.Windows.Controls.DatePicker     FirstDayOfWeek$ Monday=�6~      SelectedDateFormat$ Short=�6�   $��24��6�   $��0,0,5,5q�6�   
���   �   Text 6-   �� *DateOfCreation+$ TwoWay=�$ PropertyChanged=�6�   �� 5�   "   $��5,0,0,5q�6)   ��5�   &   �� 5�   *   $
 	#FF707070��6:   $ 0Q�6L   ��5�   &   �� 5�   *   $
 	#FFDDDDDD��6:   $ 0Q�6L   .��5�   &   �� .+�5�   *   �� $+��%/Resources/icon/icon_notification.png��60   $��24��6_   5�   '   5�   #   5�      5�      �� 5�      $��1��6%   $ 
Horizontal=�62   $��Center=�6K   $��Stretch=�6h   .+�5�      �� -   5        $ 
btnAddTask��5�   %   $��0,0,0,5q�6X   ��69   �� *
AddCommand+��6i   Z� ��6   Z�  5�   "   ��%_   '��       �� 5�   &   " ��6,   .�5�   *   ��  �@��CornerRadius$	 20��6I   5�   '   5�   #   .��5�   "   �� $��Stretch=�6-   $ 
Horizontal=�6K   .+�5�   &   �� $"��/Resources/icon/icon_add.png��6,   $��32��6R   5�   #   5�      �� 5�      $��	20,0,20,5q�6M   ��6%   �� *TransferTaskCommand+��6`   Z� ��6w   Z� ��6�   Z�  5�   "   ��%_   '��       �� 5�   &   " ��6,   .�5�   *   ��  �@��CornerRadius$	 20��6I   5�   '   5�   #   .��5�   "   �� $��Stretch=�6-   $ 
Horizontal=�6K   .+�5�   &   �� $#��/Resources/icon/icon_edit.png��6,   $��32��6S   5�   #   5�      �� 5�      $��0,0,0,5q�6q    � Cursor$ Arrow��6�   ��6%   �� *RemoveCommand+��6G   �� *SelectedTask+��6�   Z� ��6�   Z�  5�   "   ��%_   '��       �� 5�   &   " ��6,   .�5�   *   ��  �@��CornerRadius$	 20��6I   5�   '   5�   #   .��5�   "   �� $��Stretch=�6-   $ 
Horizontal=�6K   .+�5�   &   �� $%��/Resources/icon/icon_delete.png��6,   $��32��6U   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      