   M S B A M L   `   `   `  ����K  GSchoolBusProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:SchoolBusProject.Views.WindowsSchoolBusProject.Views.Windows  5   	   /    )SchoolBusProject.Views.Windows.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:SchoolBusProject.Views.Windows     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	   	   $	��600��6   $
��1000��6)    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency$
 True��5   	   .��5      �� ���#E9E9EB �� CornerRadius$ 20��5      ._�5   
   � $��5q�6    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      ��5      �� 5       �� ImageSource$g a\StaticFiles\Images\vecteezy_cute-yellow-school-bus-car-flat-design-cartoon-for-shirt_8480856.png��5       j� Stretch$ UniformToFill=�5      .+�5      �� $��
School Bus��6    !  PrimaryHueDarkForegroundBrush#���   5      $��20(�5       $��SemiBold"�5!      $��	30 15 0 0q�5"      �� 5#      $��0��6   	 �� Orientation$	 
Horizontal=�5$      $��RightToLeft=�5%      .+�5'      �� -   5         . *MaterialDesignFloatingActionMiniDarkButton#��[ 5(      
 � ToolTip$
 Close��5)      $	��5 0q�5+      .��5,      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6/   5-      �� 5.      -   5         7 3MaterialDesignFloatingActionMiniSecondaryDarkButton#��[ 5/      $
 Minimize��50      .��52        $ Minimize=�6/   53      54      � 57      $��1��6   
������ .+�58       � -   5          �Name$ 	MainFrame��59      $��1��5:        � NavigationUIVisibility$ Hidden=�5;      $��
-5 0 -5 -5q�5<      5>      5@      5A      5B      