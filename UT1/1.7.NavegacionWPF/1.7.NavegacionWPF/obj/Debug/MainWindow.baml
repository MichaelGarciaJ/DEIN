   M S B A M L   `   `   `  ����L  H1.7.NavegacionWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:_1._7.NavegacionWPF_1._7.NavegacionWPF  5   	   $    _1._7.NavegacionWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:_1._7.NavegacionWPF     5   	     � Title$  
MainWindow��5   	   $	��550��6   $	��800��6)    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency . .��5      ��  �� CornerRadius$ 12��6   ��5   
   �� 5       �� ImageSource$ \Images\back-image.jpg��6    j� Stretch$
 none=�6>   ._�5   
   �� $ 10��6   $��5q�6#    J� Opacity$
 0.95Q�67   ��5      �� 5      	 �� 
StartPoint$		 0,0&�6&   
 �� EndPoint$	
 1,1&�67   .��5      �  � Color$ #462AD8��6#    � Offset$ 0Q�63   � 5      $ #DA34AE��6#   $
 0.75Q�63   � 5      $ #8a16C1��6#   $ 1Q�63   5      ��5      �� 5      $		 0,2&�6&   $	
 1,0&�67   .��5      � $ #060531��6#   $ 0Q�63   � 5       $ #1B1448��6#   $ 1Q�63   5!      ._�5$      � $��Center=�6    � ColumnDefinitions 5%      �� 5&      $��30 �6'   �� 5'      $
��Auto �6'   �� 5(      $
��Auto �6'   �� 5)      $
��Auto �6'   �� 5*      $��30 �6'    � RowDefinitions 5,      �� 5-      $	��200 �6$   �� 5.      $
��Auto �6$   �� 5/      $
��Auto �6$   .+�52      �� $��MENÚ PRINCIPAL��6   
�������$��40(�6E   $��Medium"�53      $��
Montserrat)�60   $��0��6H   $��2��6U   $��	0,100,0,0q�6e   �� 55      -   5        $��Boton1_MainWindow��55      $��Ir a ventana 1��62   $	��150��6K   $	��200��6X   $��1��56      $��1��6&   
����  �
�������$��20(�57      $��
Montserrat)�6'    � Cursor$
 Hand��6?   6M   �� 58      -   5        $��Boton2_MainWindow��58      $��Ir a ventana 2��62   $	��150��6K   $	��200��6X   $��1��59      $��2��6&   
����  �
�������$��20(�5:      $��
Montserrat)�6'   $
 Hand��6?   6M   �� 5;      -   5        $��Boton3_MainWindow��5;      $��Salir��62   $	��150��6B   $	��200��6O   $��1��5<      $��3��6&   
����� �
�������$��20(�5=      $��
Montserrat)�6'   $
 Hand��6?   6M   5>      5?      5@      5B      