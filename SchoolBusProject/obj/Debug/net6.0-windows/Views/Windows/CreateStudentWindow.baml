   M S B A M L   `   `   `  ����K  GSchoolBusProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:SchoolBusProject.Views.WindowsSchoolBusProject.Views.Windows  5   	   8    2SchoolBusProject.Views.Windows.CreateStudentWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:SchoolBusProject.Views.Windows     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � 
ResizeMode$  NoResize=�5	   	    � WindowStyle$
 None=�5
   	   
������  � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency$
 True��5   	    � Title$ CreateCarWindow��5   	   $	��550��6!   $	��440��6.   .��5      �� ���#E9E9EB �� CornerRadius$ 20��5      ._�5   
   � $��6q�6    � RowDefinitions 5      �� 5      �� 5      $��7* �6    .+�5      �� -   5        $��CloseBtn��5      $��Right=�5       .  *MaterialDesignFloatingActionMiniDarkButton#��[  5       � ToolTip$ Close��5      $	��5 0q�5      .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6+   5      �� 5       $��1��6   .+�5"      �� $��New Student��6    ! PrimaryHueDarkForegroundBrush#���  5#      $��35(�5$      $��DemiBold"�5%      $
��Left=�5&      $��50 20q�5'      �� 5(      -   5        	 ��Name$	 FirstnameTextBox��5(      $
��50 5q�5)      )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 	FirstName��5*      $��40��5+      $��Center=�5,      .  (MaterialDesignThemes.Wpf.TextFieldAssist   TextFieldCornerRadius$ 5��5.      ��5-      �� *	FirstName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5.      �� 50      -   5        $	 LastnameTextBox��50      $
��50 5q�51      $
 Lastname��53      $��40��54      $��Center=�55      $ 5��56      ��52      �� *
LastName+$ TwoWay=�$ PropertyChanged=�56      �� 58      -   5        $	 ParentTextBox��58      $
��50 5q�59      $
 	Parent Id��5:      $��40��5;      $��Center=�5<      $ 5��5>      ��5=      �� *
ParentId+$ TwoWay=�$ PropertyChanged=�5>      �� 5@      $��50 20q�6    �� DisplayMemberPath$
 Name��5A      ��5B      �� *	CLasses+$ TwoWay=�$ PropertyChanged=� �� SelectedItem 5C      �� *SelectedClass+$ PropertyChanged=�$ TwoWay=��� 5D      -   5        $	 HomeAddress1TextBox��5D      $
��50 5q�5E      $
 Home Address 1��5F      $��40��5G      $��Center=�5H      $ 5��5J      ��5I      �� *
Address1+$ TwoWay=�$ PropertyChanged=�5J      �� 5L      -   5        $	 HomeAddress2TextBox��5L      $
��50 5q�5M      $
 Home Address 2��5N      $��40��5O      $��Center=�5P      $ 5��5R      ��5Q      �� *
Address2+$ TwoWay=�$ PropertyChanged=�5R      �� 5T      $��Create��6   $	��100��5U      $��20q�5V      ��5W      �� *CreateStudent+5X      5Y      5Z      5[      