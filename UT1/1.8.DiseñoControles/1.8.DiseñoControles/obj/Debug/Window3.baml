   M S B A M L   `   `   `  ����O  K1.8.DiseñoControles, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:_1._8.DiseñoControles_1._8.DiseñoControles  5   	   $    _1._8.DiseñoControles.Window3   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:_1._8.DiseñoControles     5   	     � Title$  Window3��5   	   $	��550��6   $	��800��6&   $	��550��5	   	   $	��800��6    � 
ResizeMode$ 	CanResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � SizeToContent$ WidthAndHeight=�5   	   
������ .��5      �� ._�5   
   �� $��5q�6    J� Opacity$
 0.95Q�6%   ��5      �� 5       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�67   .��5      �  � Color$ #462AD8��6#    � Offset$ 0Q�63   � 5      $ #DA34AE��6#   $
 0.75Q�63   � 5      $ #8a16C1��6#   $ 1Q�63   5      ��5      �� 5      $	 1,0&�6&   $	 1,0&�67   .��5      � $ #060531��6#   $ 0Q�63   � 5      $ #1B1448��6#   $ 1Q�63   5      ._�5       � $��Center=�6   $��Center=�60   	 � ColumnDefinitions	 5!      �� 5"      $��* �6'   �� 5#      $
��Auto �6'   �� 5$      $��* �6'   
 � RowDefinitions
 5&      �� 5'      $	��200 �6$   �� 5(      $
��Auto �6$   �� 5)      $	��150 �6$   .+�5,      �� $��COMPAÑEROS CLASE��6   
�������$��40(�6G   $��Center=�6U   $��Medium"�5-      $��Arial)�6%   $��0��68   $��1��6E   $��	0,100,0,0q�6U   &   System.Windows.Controls.DataGrid  5/      -   5        $��dtGridCompaneros��5/         AutoGenerateColumns .  $	��378��6O   $	��200��6[   $��1��6h   $��1��6x      Columns 50      0  *System.Windows.Controls.DataGridTextColumn  51      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *ID+6L     52      $ Nombre��6)   $	 100 6T    69   �� *Nombre+6T     53      $ 
Apellido 1��6)   $	 100 6[    6=   �� *	Apellido1+6[     54      $ 
Apellido 2��6)   $	 100 6[    6=   �� *	Apellido2+6[   56      �� 58      -   5        $��Menu_principal��58      $��Ir a Menú Principal��6/   $	��200��6M   $��50��6Y   $��Center=�59      $��Center=�66   
������$��2��6e   $��1��6r   
���� ��$��20(�5:   1   $��Arial)�6?    � Cursor$
 Hand��6R   6`   5<      5=      5>      5?      