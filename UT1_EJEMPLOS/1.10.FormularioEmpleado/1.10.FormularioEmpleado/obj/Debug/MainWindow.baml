   M S B A M L   `   `   `  ����R  N1.10.FormularioEmpleado, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:_1._10.FormularioEmpleado_1._10.FormularioEmpleado  5   	   *    $_1._10.FormularioEmpleado.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:_1._10.FormularioEmpleado     5   	     � Title$&   Introducción de Datos Empleados��5   	   $	��900��61   $	��800��6>    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ CanResizeWithGrip=�6.   .��5      � .+�5   
   �� $)��#Introducción de Datos de Empleados��6   $��25(�6>   $��Center=�5      $��	0,10,0,20q�61   �� 5   
   $��Nombre*��6   $��20,60,390,0q�6#   $	��Top=�68   $��18��6P   �� 5   
   -   5         ��Name$ 	txtNombre��5      
 � Tag$ Nombre��6%   $��80,60,390,0q�6p   $	��Top=�6�   �� 5   
   $��	Apellidos��6   $��20,90,390,0q�6%   $	��Top=�6:   $��18��6R   �� 5   
   -   5        $ txtApellidos��5      $ 	Apellidos��6(   $��80,90,390,0q�6|   $	��Top=�6�   �� 5   
   $��E-mail*��6   $��20,120,390,0q�6#   $	��Top=�69   $��18��6Q   �� 5   
   -   5        $ txtEmail��5      $ Email��6$   $��80,120,390,0q�6l   $	��Top=�6�   �� 5   
   $��	Teléfono��6   $��20,150,390,0q�6$   $	��Top=�6:   $��18��6R   �� 5   
   -   5        $ txtTelefono��5      $ Telefono��6'   $��80,150,390,0q�6x   $	��Top=�6�   �� 5   
   $��Fecha de nacimiento��6   $��20,180,390,0q�6/   $	��Top=�6E   $��18��6]   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dtPickerFechaNacimiento��5      $ FechaNacimiento��66   $��140,180,390,0q�6L   $	��Top=�6c   �� 5!   
   $	��DNI��6   $��20,215,390,0q�6   $	��Top=�65   $��18��6M   �� 5"   
   -   5        $ txtDni��5"      $	 Dni��6"   $��60,215,500,0q�6d   $	��Top=�6z   �� 5$   
   $��Adjuntar fotografía��6   $��20,280,390,0q�6/   $	��Top=�6E   $��18��6]   �� 5%   
   -   5        $��Cargar Foto��5%      $��140,270,545,0q�6=   $	��Top=�6T   $��35��6l   �� 5'   
   $��	Domicilio��6   $��20,340,390,0q�6%   $	��Top=�6;   $��18��6S   �� 5(   
   -   5        $ txtDireccion��5(      $ 
Dirección��6(   $��100,340,390,0q�6}   $	��Top=�6�   �� 5)   
   -	   5        $ 	txtCiudad��5)      $ Ciudad��6%   $��100,365,390,0q�6p   $	��Top=�6�   �� 5*   
   -
   5        $ txtProvincia��5*      $ 	Provincia��6(   $��100,390,390,0q�6|   $	��Top=�6�   �� 5+   
   -   5        $ txtCodigoPostal��5+      $ Código Postal��6+   $��100,415,390,0q�6�   $	��Top=�6�   �� 5,   
   -   5        $ txtPais��5,      $ País��6#   $��100,440,390,0q�6j   $	��Top=�6�   �� 5.   
   $��\imgs\logoFormulario.png��6   $	��200��62   $	��200��6>   $��Uniform=�6K   $��558,267,42,417q�6]   �� 50   
   $��Enlace a red social��6   $��20,480,390,0q�6/   $	��Top=�6E   $��18��6]   �� 51   
   -   5        $ txtEnlaceRedSocial��51      $ EnlaceRedSocial��6.   $��140,480,42,0q�6�   $	��Top=�6�   �� 53   
   $��
Rol actual��6   $��20,510,390,0q�6&   $	��Top=�6<   $��18��6T   �� 54   
   -   5         ��Name$ cbBoxRol��54      $��140,510,390,0q�6%   $	��Top=�6<   .@�55      �� $��Subjefe��6   �� 56      $��Empleado��6   57      �� 59   
   $0��*Descripción del puesto de trabajo actual:��6   $��20,540,390,0q�6E   $	��Top=�6[   $��18��6s   �� 5:   
   -   5        $ txtDescricpcion��5:      $ DescripcionPuesto��6+   $��20,565,42,0q�6�   $	��Top=�6�   $	��100��6�   �� 5<   
   -   5        $��Guardar��5<      $��285,675,400,0q�67   $	��Top=�6N   $��35��6f   �� 5=   
   -   5        $��Cancelar��5=      $��411,675,274,0q�69   $	��Top=�6P   $��35��6h   &   System.Windows.Controls.DataGrid  5?   
   -   5        $��dataGridEmpleados��5?         AutoGenerateColumns .  $��20,728,20,34q�6H      Columns 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Nombre��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *Nombre+  5B      $	 	Apellidos��6%   
 68   �� *	Apellidos+  5C      $	 Email��6%   
 64   �� *Email+  5D      $	 	Teléfono��6%   
 67   �� *
Telefono+5F      5I      5J      