   M S B A M L   `   `   `  ����Q  MP1-AP1-Kelvin-20180193, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:P1_AP1_Kelvin_20180193.UI.Registro"P1_AP1_Kelvin_20180193.UI.Registro  5   	   1    +P1_AP1_Kelvin_20180193.UI.Registro.rAportes   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:P1_AP1_Kelvin_20180193.UI.Registro     5   	     � Title$  Registro de Aportes��5   	   $	��350��6%   $	��430��62   .��5	      � .+�5
   
   �� .+�5      ��  �� Orientation$ Vertical=�6   .+�5      �� $��Aporte Id: ��6   $��	20,20,0,0q�6.   �� 5      $ 
Horizontal=�6   .+�5      �� -   5         ��Name$ AporteIdTextBox��5      $	��120��67   $
��Left=�6C   $��	23,0,10,0q�6^   ��6q   �� *
AporteId+�� 5      -   5         ��Name$ BuscarIdButton��5      $��30��65   .��5      �� $,��&/Resources/search_locate_find_6278.png��6    5      5      �� 5      $��Fecha: ��6   $��20,0,0,0q�6*   �� 5      .+�5      (  "System.Windows.Controls.DatePicker  -   5          Name$ FechaDatePicker��5   !   $��23,0,0,0q�6:   $	��150��6L   $
��Left=�6X      Text 6s   �� *Fecha+5      �� 5      $��	Persona: ��6   $��20,0,0,0q�6,   �� 5      .+�5      �� -   5        $ PersonaTextBox��5      $	��400��66   $
��Left=�6B   $��23,0,0,0q�6]   ��6o   �� *	Persona+5      �� 5      $��
Concepto: ��6   $��20,0,0,0q�6-   �� 5       .+�5!      �� -   5        $ ConceptoTextBox��5!      $	��400��67   $
��Left=�6C   $��23,0,0,0q�6^   ��6p   �� *
Concepto+5"      �� 5$      $��Monto: ��6   $��20,0,0,0q�6*   �� 5%      .+�5&      �� -   5        $ MontoTextBox��5&      $��23,0,0,0q�64   $	��120��6F   $
��Left=�6R   ��6m   �� *Monto+5'      �� 5)      $ 
Horizontal=�6   $��	3,10,10,0q�66   .+�5+      �� -   5        $ NuevoButton��5+      $��90��62   $
��20,0q�6=   .��5,      �� $ 
Horizontal=�6%   .+�5.      �� $'��!/Resources/new_add_user_16734.png��6$   �� 5/      $��Nuevo��6$   51      52      �� 54      -   5        $ GuardarButton��54      $	��100��64   $
��20,0q�6@   .��55      �� $ 
Horizontal=�6%   .+�56      �� $5��//Resources/savedisk_floppydisk_guardar_1543.png��6$   �� 58      $��Guardar��6$   59      5:      �� 5<      -	   5        $ EliminarButton��5<      $	��100��65   $
��20,0q�6A   .��5=      �� $ 
Horizontal=�6%   .+�5>      �� $!��/Resources/delete_40623.png��6$   �� 5@      $��Eliminar��6$   5A      5B      5D      5E      5F      5G      5H      