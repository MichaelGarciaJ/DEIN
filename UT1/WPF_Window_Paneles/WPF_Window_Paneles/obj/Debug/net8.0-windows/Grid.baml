   M S B A M L   `   `   `  ����M  IWPF_Window_Paneles, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WPF_Window_PanelesWPF_Window_Paneles  5   	       WPF_Window_Paneles.Grid   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WPF_Window_Paneles     5   	     � Title$  Garcia_Michael��5   	   $	��400��6    $	��800��6-   $	��400��5	   	   $	��800��6   $	��600��5
   	   $
��1000��6    � 
ResizeMode$ CanResizeWithGrip=�5   	    � SizeToContent$ WidthAndHeight=�5   	    � WindowState$ Normal=�5   	   .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��2��6   $��25(�6$   $��Center=�62   .��5      �� .�6   Login6   5      �� 5!   
   $��1��6   .��6   	Nombre:6&   �� 5"   
   $��1��6   $��2��6   $��0,0,0,10q�6/   �� 5#   
   $��2��6   .��6   
Apellidos:6)   �� 5$   
   $��2��6   $��1��6   $��0,0,0,10q�6/   �� 5%   
   $��3��6   .��6   	E-mail:6&   �� 5&   
   $��3��6   $��1��6   $��0,0,0,10q�6/   �� 5'   
   $��4��6   .��6   Observaciones:6-   �� 5(   
   $��4��6   $��1��6    �� AcceptsReturn$
 True��6/   �� 5)   
   -   5        $��	btnEntrar��5)      $��60,30q�6"   $��5��5*      $��2��6   
��� ���
���   �$��50��6U   .��6y   Entrar6�   5,      5-      