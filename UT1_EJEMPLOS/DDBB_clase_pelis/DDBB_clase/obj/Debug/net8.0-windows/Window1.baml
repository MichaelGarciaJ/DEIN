   M S B A M L   `   `   `  ����E  ADDBB_clase, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DDBB_clase
DDBB_clase  5   	       DDBB_clase.Window1   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:DDBB_clase     5   	     � Title$  Top 10 Pixar Movies��5   	   $	��700��6%   $	��400��62   
�������.��5	      � $��20q�6   .+�5
   
   �� $
��Auto=�6   .��5      �� .+�5      �� ��6   �� *Movies+��5      �� 5      .R�5      �� ���	#FF7E57C2$��2q�6=    �� CornerRadius$ 10��6Q   $��10q�6c    �� Padding$ 15q�6o   
�������._�5   "   �  � ColumnDefinitions 5   &   �� 5   *   $��* �6;   �� 5   *   $��* �6;    � RowDefinitions 5   &   �� 5   *   $
��Auto �68   �� 5   *   $
��Auto �68   �� 5   *   $
��Auto �68   �� 5   *   $
��Auto �68   �� 5   *   $
��Auto �68   �� 5   *   $
��Auto �68   .+�5   &   �� $
��Bold"�6G   $��22(�6Y   ���	#FF7E57C2$��0��6~   $��2��6�   $
��Wrap=�6�   $	��350��6�   ��60   �� *Title+6�   �� 5   &   $��	Director:��60   $
��Bold"�6A   $��1��6S   $��0��6`   $��0,5,0,0q�6p   �� 5   &   $��1��6J   $��1��6W   $��0,5,0,0q�6g   
���OO/�$
��Wrap=�6�   $	��200��6�   ��60   �� *
Director+6�   �� 5    &   $��Fecha de Lanzamiento:��60   $
��Bold"�6M   $��2��6_   $��0��6l   $��0,5,0,0q�6|   �� 5!   &   $��2��6r   $��1��6   $��0,5,0,0q�6�   
���������60   �� *DateReleased+ �� StringFormat$ {0:MMMM dd, yyyy}��6�   �� 5"   &   $��
Duración:��60   $
��Bold"�6A   $��3��6S   $��0��6`   $��0,5,0,0q�6p   �� 5#   &   $��3��6e   $��1��6r   $��0,5,0,0q�6�   
���������60   �� *	LengthMin+$ {0} min��6�   �� 5$   &   $��Género:��60   $
��Bold"�6?   $��4��6Q   $��0��6^   $��0,5,0,0q�6n   �� 5%   &   $��4��6L   $��1��6Y   $��0,5,0,0q�6i   
�������$
��Wrap=�6�   $	��200��6�   ��60   �� *
MovieGenre+6�   �� 5&   &   $��IMDb Rating:��60   $
��Bold"�6D   $��5��6V   $��0��6c   $��0,5,0,0q�6s   �� 5'   &   $��5��6L   $��1��6Y   $��0,5,0,0q�6i   
���������60   �� *
ImdbRating+6z   5(   #   5)      5*      5,      5-      5.      5/      50      