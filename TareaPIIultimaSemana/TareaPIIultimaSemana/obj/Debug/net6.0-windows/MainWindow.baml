   M S B A M L   `   `   `  ����O  KTareaPIIultimaSemana, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:TareaPIIultimaSemanaTareaPIIultimaSemana  5   	   %    TareaPIIultimaSemana.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:TareaPIIultimaSemana     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6:     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   .+�5   
   � $��0��6   .+�5      o� -   5         o�Name$
 menu��5       o� 
IsMainMenu$
 True��6!   $��20q�63   
���2͚�   MaterialDesignMenu#��[  6X   .@�5      m� $��
Aplicacion��6   $��15(�6/     MaterialDesignMenuItem#��[ 6=   .@�5      m� -   5        $��BtnConfigurar��5       $��
Configurar��65   #��[ 6I    m� Icon 5      '  !MaterialDesignThemes.Wpf.PackIcon  5         Kind$ Tools=�66   5      m� 5      -   5         m�Name$ BtnSalir��5      $��Salir��61   #��[ 6@    5        5      $ 	ExitToApp=�66   6I   5      5      m� 5      $��
Miscelaneo��6   $��15(�6/   .@�5      m� -   5        $��TextMenuItem��5      $��Texto��63   6D   m� 5       -   5        $��ConversorMenuItem��5       $��Convertidor de Monedas��68   6Z   5!      5"      5#      � 5$   
   $��1��6   5%      5&      5'      