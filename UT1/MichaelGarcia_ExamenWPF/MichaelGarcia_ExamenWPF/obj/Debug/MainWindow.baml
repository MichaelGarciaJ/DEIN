   M S B A M L   `   `   `  ����R  NMichaelGarcia_ExamenWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MichaelGarcia_ExamenWPFMichaelGarcia_ExamenWPF  5   	   (    "MichaelGarcia_ExamenWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:MichaelGarcia_ExamenWPF     5   	     � Title$  Examen_MichaelGarcia��5   	   $	��600��6&   $	��900��63    � 
ResizeMode$ NoResize=�6?   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��600 �6   �� 5      $	��300 �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   .+�5   
   � $��1��6   $��0��6   ���#bfbfbf$��0,0,10,0q�6A    5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5#      �� $��0��6   $��2��6%   $��Expanded&�69   $��30,0,-31,10q�6P   $��24(�6e   $��Detalles del Producto��6s   $
��Bold"�6�   ���#007ACC6�   �� 5%      $��0��6   $��1��6(   $��10q�65   $��ID��6A   �� 5&      -   5         ��Name$ txtID��5&      $��1��6%   $��1��65   $��
10,5,-34,5q�6B   �� 5)      $��2��6   $��0��6%   $��Producto��65   $��10q�6E   �� 5*      -   5        $ txtProducto��5*      $��1��6+   $��2��6;   $��
10,5,-34,5q�6H   �� 5-      $��3��6   $��0��6%   $��Precio��65   $��10q�6C   �� 5.      -   5        $ 	txtPrecio��5.      $��1��6)   $��3��69   $��
10,5,-34,5q�6F   �� 51      $��4��6   $��0��6%   $��Cantidad��65   $��10q�6E   �� 52      $��4��6\   $��0��6i   $��Right=�6y   $��Center=�6�   ��6   ��  �� ElementName$ sliderControl�� �� Path$ Value� �� Mode$ TwoWay=�6�   �� 55      -   5         ��Name$ sliderControl��55      	 � Minimum$	 0Q�6,   
 � Maximum$	
 100Q�68    � Value$ 0Q�6F   $��41,10,-31,0q�6Q   $��1��6f   $��4��6v   $	��Top=�6�   �� 59      -   5        $��Guardar��59      $��Guardar��6$   $��70��66   $��40��6A   $��
7,41,3,304q�6d   ���#519138$��0��6�   $��5��6�   �� 5<      -   5        $��Cancelar��5<      $��Cancelar��6%   $��70��68   $��40��6C   $��
7,41,3,304q�6g   ���#b77e88$��1��6�   $��5��6�   $��Right=�6�   5=      � 5@   
   $��0��6   $��0��6    $��	0,0,5,161q�6-    5A      �� 5B      $
��Auto �6    �� 5C      $
��Auto �6    .+�5H      �� $��0��6   $��Center=�6%   $��Expanded&�6B   $��0,0,5,0q�6Y   $��24(�6j   $��Lista de Productos��6x   $
��Bold"�6�   ���#007ACC6�   �� 5J      $��1��6   $��1��6&    �� Orientation$ Vertical=�66   $��10q�6M   .+�5K      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridProductos��5K      $	��548��66   $	��348��6B      Columns 5L      0  *System.Windows.Controls.DataGridTextColumn  5M      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *ID+  5N      $ Producto��6-   $	 200 6?    6K   �� *
Producto+  5O      $ Precio��6-   $	 100 6=    6I   �� *Precio+  5P      $ Cantidad��6-   $	 150 6?    6K   �� *
Cantidad+5R      5S      5U      5V      5X      