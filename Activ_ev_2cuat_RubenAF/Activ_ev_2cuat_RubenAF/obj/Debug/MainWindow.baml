   M S B A M L   `   `   `  ����Q  MActiv_ev_2cuat_RubenAF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Activ_ev_2cuat_RubenAFActiv_ev_2cuat_RubenAF  5   	   '    !Activ_ev_2cuat_RubenAF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:Activ_ev_2cuat_RubenAF     5   	     � Topmost  .  � Title$ 	La gaceta��5	   	   $	��600��6   $	��800��6(    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Close��5      6W   .��5      �  � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $	��11* �6   .+�5   
   �� 
����� �$��Center=�6"   $��0��6F   .��5      �� -   5        $��MiTitulo��5      $'��!La Gaceta de la Pesca Cantábrica��6(    � ToolTip$= 7Tiene animación y un trigger doble con MouseOver+Click��6P   $��32(�5      $
��Bold"�6'    �� TextAlignment$ Center=�69    �� Padding$ 10q�6P   ��5      �� 5       �� 
TargetType" ��6   	 �� Triggers	 5      :� 5      
 :� RoutedEvent$
 
MouseEnter��6+   [�5   "   �� 5   &   .��5   *   �� .��5   .   W�  g� Duration$ 	0:0:0.300D�6>    �� TargetProperty$ FontSize�6S   	 W� To$ 36X�6x   5   +   5    '   5"      :� 5#      $
 
MouseLeave��6+   [�5$   "   �� 5%   &   .��5&   *   �� .��5'   .   W� $ 	0:0:0.400D�6>   $ FontSize�6S   $ 32X�6x   5(   +   5)   '   5+      5-      5/      51      �� 53   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $	��Top=�6;   $��Center=�6P   $��10q�6m   .+�55      �� -   5         ��Name$ btnNoticias��55      $��Noticias��6*   $	��120��6=   $��5q�6I   57      �� 58      -   5        $ btnPescadores��58      $��
Pescadores��6,   $	��120��6A   $��5q�6M   6X   �� 59      -   5        $ btnPrediccion��59      $��
Prediccion��6,   $	��120��6A   $��5q�6M   6X   5:      �� 5;   
   $��2��6   $ 
Horizontal=�5<      $	��Top=�6&   $��Center=�6;   $��10q�6X   .+�5=      �� -   5        $��Abrir��5=      $��80��6%   $��5q�60   6;   �� 5>      -   5        $��Guardar��5>      $��80��6'   $��5q�62   6=   �� 5?      -   5        $��Borrar��5?      $��80��6&   $��5q�61   6<   �� 5@      -	   5        $��Imprimir��5@      $��80��6(   $��5q�63   6>   �� 5A      -
   5        $��ApplicationCommands.Close��5A      $��Salir��69   $��80��6I   $��5q�6T   6_   5B      -� 5C   
   -   5        $��flowDocReader��5C   *   $��3��6   $��20q�6?    -� IsFindEnabled .  -� IsPrintEnabled . .��5D      /� .T�5E      J� .*�6   .*�5F      �� $��16(�6    primer parrafo5H      5I      5J      5K      5L      5N      