   M S B A M L   `   `   `  ����O  KTareaPIIultimaSemana, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:TareaPIIultimaSemana.ViewsTareaPIIultimaSemana.Views  5   	   0    *TareaPIIultimaSemana.Views.ConversorMoneda   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:TareaPIIultimaSemana.Views     5   	     � Title$  ConversorMoneda��5   	   $	��620��6!   $	��800��6.   .��5	      � $��2q�6    � RowDefinitions 5
   
   �� 5      $��80 �6   6*   �� 5      $��50 �6   6*   �� 5      $��40 �6   6*   �� 5      $��50 �6   6*   �� 5      $��65 �6   6*   �� 5      $��* �6   6)   .+�5   
   � $��0��6   $��10q�6    � ColumnDefinitions 5      �� 5      $��* �6#   6/   �� 5      $��* �6#   6/   5      �� 5   
   -   5        $��fecha��5      $��0��6   $��0��6*   $��Center=�6:   $��25(�6W   $
��Bold"�6e   $��5q�6w   .��6�   Fecha6�   �� 5   
   $��1��6   $��0��6   $	��Top=�6-   $��180,0q�6E   $��15(�6T   .��6b   Moneda que tengo6t   �� 5   
   $��1��6   $��1��6   $��Center=�6-   $��Right=�6H   $��	0,0,180,0q�6d   $��15(�6w   .��6�   Moneda que deseo6�   �� 5   
   -   5        $��
CmbPrimero��5      $��2��6%   $��0��62   $
��Left=�6B   $��	150,0,0,0q�6]   $	��200��6p   
�������$��Center=�6�   $��30��6�   .@�5      �� $��Center=�6   $��Stretch=�68   $��Cordobas��6T   6i   �� 5      $��Center=�6   $��Stretch=�68   $��Dolares��6T   6h   �� 5      $��Center=�6   $��Stretch=�68   $��Euros��6T   6f   5      �� 5    
   -   5        $��
CmbSegundo��5       $��2��6%   $��1��62   $��Right=�6B   $��	0,0,150,0q�6^   $	��200��6q   
�������$��Center=�6�   $��30��6�   $��Center=�6�   .@�5!      �� $��Center=�6   $��Stretch=�68   $��Cordobas��6T   6i   �� 5"      $��Center=�6   $��Stretch=�68   $��Dolares��6T   6h   �� 5#      $��Center=�6   $��Stretch=�68   $��Euros��6T   6f   5$      �� 5%   
   $��3��6   $��0��6   $	��Top=�6-   $��	210,0,0,0q�6E   $��15(�6X   .��6f   Monto6m   �� 5&   
   $��3��6   $��1��6   $	��Top=�6-   $��Right=�6E   $��	0,0,230,0q�6a   $��15(�6t   .��6�   Monto6�   �� 5'   
   -   5        $��txtMontoACalcular��5'      $��4��6+   $��0��68   $	��200��6H   
�������$��
150,30,0,0q�6n   $
��Left=�6�   $��Center=�6�   6�   �� 5(   
   -   5        $��txtResultado��5(      $��4��6&   $��1��63   $	��200��6C   
�������$��150,30,150,0q�6i   $��Right=�6   $��Center=�6�   6�   �� 5)   
   -   5         ��Name$ BtnCalcular��5)   [   $��5��6   $	��250��6   $��Center=�6*   $��20,-70,20,40q�6E   .��6p   
Calcular6z   5*      5+      