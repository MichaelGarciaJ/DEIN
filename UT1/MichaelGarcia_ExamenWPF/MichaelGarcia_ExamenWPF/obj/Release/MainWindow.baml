   M S B A M L   `   `   `  ���� R  NMichaelGarcia_ExamenWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:MichaelGarcia_ExamenWPFMichaelGarcia_ExamenWPF  (    "MichaelGarcia_ExamenWPF.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     7local%clr-namespace:MichaelGarcia_ExamenWPF       � Title$  Examen_MichaelGarcia��$	��600��$	��900�� � 
ResizeMode$ NoResize=� � 	Resources  �� 
TargetType   TituloTextBlock �� Property �� Value  FormularioGrid  GuardarBoton �� 
TargetType �� CornerRadius  LimpiarBoton��%L  &	        &	 �     &	 �     &	 {    �� " ��.���  � ��$ 24(���  � ��$
 Bold"���  � �� �#007ACC��  � ��$ Center=���  � ��$ 0,0,0,10q��� " �.���  � �� �#bfbfbf��  � ��$ 10,0,0,0q��� " ��.���  � �� �#519138��  � ��
 �   ���  � �� �� " ��.R��� #��z��$ 10��
���   �$��0q�._��� $��Center=�$��Center=��� " ��.���  � �� �#b77e88��  � ��
 �   ���  � �� �� " ��.R��� #��z��$ 10��
���   �$��0q�._��� $��Center=�$��Center=�.���  � ColumnDefinitions �� $��2* ��� $��* �	 � RowDefinitions	 �� $��* �.+�� $��1��#��[ $��	0,0,10,10q� �� $
��Auto ��� $��* �	 �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� #��[  $��0��$��2��$��Detalles del Producto���� $��ID��$��1��$��0��$��10,10,10,10q��� -   
 ��Name$
 txtID��$��1��$��1��$��10,10,10,10q� �� 
IsReadOnly . �� $��2��$��0��$��Producto��$��10,10,10,10q��� -   $
 txtProducto��$��1��$��2��$��10,10,10,10q��� $��3��$��0��$��Precio��$��10,10,10,10q��� -   $
 	txtPrecio��$��1��$��3��$��10,10,10,10q��� $��4��$��0��$��Cantidad��$��10,10,10,10q��� -    ��Name$ sliderControl�� � Minimum$ 0Q� � Maximum$	 100Q� � Value$ 0Q� �� IsSnapToTickEnabled .  �� TickFrequency$ 1Q�$��1��$��4��$��
62,10,0,10q�$
��Left=�$	��150���� $��4��$��0��$
��Left=�$��Center=�$��16��$��63,0,0,0q�$��23�� J� RenderTransformOrigin$ -0.903,0.687&�$��2������  �� ElementName$ sliderControl�� �� Path$ Value� �� Mode$ TwoWay=��� $��5��$��2�� �� Orientation$ 
Horizontal=�$��Center=�$��0,10,0,0q�.+��� -    ��Name$ Guardar��$��Guardar��#��[ $	��100��$��10q�$��32���� -   $ Cancelar��$��Limpiar��#��[ $	��100��$��10q�� $��0��$��0,0,5,0q�	 �� $
��Auto ��� $��* �.+��� $��0��#��[  $��0,0,5,0q�$"��Lista de Producto Recuperado��&   System.Windows.Controls.DataGrid  -     Name$ dataGridProductos��$��1��$��Center=�$��
0,22,0,178q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ID+  $ Producto��$	 200  �� *
Producto+  $ Precio��$	 100  �� *Precio+  $ Cantidad��$	 100  �� *
Cantidad+