   M S B A M L   `   `   `  ����K  GSchoolBusProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:SchoolBusProject.Views.WindowsSchoolBusProject.Views.Windows  5   	   7    1SchoolBusProject.Views.Windows.CreateDriverWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:SchoolBusProject.Views.Windows     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � 
ResizeMode$  NoResize=�5	   	    � WindowStyle$
 None=�5
   	   
������  � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��5   	    � Title$ CreateCarWindow��5   	   $	��650��6!   $	��440��6.   .��5      �� ���#E9E9EB �� CornerRadius$ 20��5      ._�5   
   � $��6q�6    � RowDefinitions 5      �� 5      �� 5      $��7* �6    .+�5      �� -   5        $��CloseBtn��5      $��Right=�5       .  *MaterialDesignFloatingActionMiniDarkButton#��[  5       � ToolTip$ Close��5      $	��5 0q�5      .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6+   5      �� 5       $��1��6   .+�5"      �� $��
New Driver��6    ! PrimaryHueDarkForegroundBrush#���  5#      $��35(�5$      $��DemiBold"�5%      $
��Left=�5&      $��50 20q�5'      �� 5(      -   5        	 ��Name$	 FirstnameTextBox��5(      $
��50 5q�5)      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 	FirstName��5*      $��40��5+      $��Center=�5,      .  (MaterialDesignThemes.Wpf.TextFieldAssist   TextFieldCornerRadius$ 5��5.      ��5-      �� *	FirstName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5.      �� 50      -   5        $	 LastnameTextBox��50      $
��50 5q�51      $
 Lastname��52      $��40��53      $��Center=�54      $ 5��56      ��55      �� *
LastName+$ TwoWay=�$ PropertyChanged=�56      �� 58      -   5        $	 PhoneTextBox��58      $
��50 5q�59      $
 Phone��5:      $��40��5;      $��Center=�5<      $ 5��5>      ��5=      �� *Phone+$ TwoWay=�$ PropertyChanged=�5>      �� 5@      -   5        $	 UsernameTextBox��5@      $
��50 5q�5A      $
 Username��5B      $��40��5C      $��Center=�5E      $ 5��5F      ��5D      �� *
Username+$ TwoWay=�$ PropertyChanged=�5F      �� 5H      -   5        $	 PasswordTextBox��5H      $
��50 5q�5I      $
 Password��5J      $��40��5K      $��Center=�5M      $ 5��5N      ��5L      �� *
Password+$ TwoWay=�$ PropertyChanged=�5N      �� 5P      -   5        $	 HomeAddressTextBox��5P      $
��50 5q�5Q      $
 Home Address��5R      $��40��5S      $��Center=�5U      $ 5��5V      ��5T      �� *	Address+$ TwoWay=�$ PropertyChanged=�5V      �� 5X      -   5        $	 LicenceTextBox��5X      $
��50 5q�5Y      $
 License��5Z      $��40��5[      $��Center=�5]      $ 5��5^      ��5\      �� *	License+$ TwoWay=�$ PropertyChanged=�5^      �� 5`      $��Create��6   $	��100��5a      $��20q�5c      ��5b      �� *CreateDriver+5c      5d      5e      5f      5g      