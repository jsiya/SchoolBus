   M S B A M L   `   `   `  ����K  GSchoolBusProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:SchoolBusProject.Views.PagesSchoolBusProject.Views.Pages  5      .    (SchoolBusProject.Views.Pages.DriversView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:SchoolBusProject.Views.Pages     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  DriversView��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      .+�5   
   �� $��0��6    �� CornerRadius$ 5��5      $��5q�5         PrimaryHueLightBrush#���   5      ._�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      ��  " MaterialDesignRaisedDarkButton#��[ 5       � ToolTip$ 
Add Driver��5      $
��15 0q�5      ��5      0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$
 Plus=���5      �� *	AddDriver+�� 5      -   5        $��UsernameTextBox��5      $��1��5      $	��280��5      $��50��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search��5       ! MaterialDesignOutlinedTextBox#��[ 5       5!      5"      &   System.Windows.Controls.DataGrid  5#   
   $��1��6   $��5q�5$         AutoGenerateColumns$ False��5'         CanUserDeleteRows$
 True��5(      $��Center=�5)      	 �� IsTextSearchEnabled$
	 True��5*      ��5%      �� *	Drivers+
 �� UpdateSourceTrigger$
 PropertyChanged=� �� Mode$ TwoWay=� �� SelectedItem 5&      �� *SelectedItem+$
 PropertyChanged=�$ TwoWay=�   Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+$
 PropertyChanged=�$ TwoWay=�  5-      $ 	Firstname��6%    68   �� *	FirstName+$
 PropertyChanged=�$ TwoWay=�  5.      $ Lastname��6%    67   �� *
LastName+$
 PropertyChanged=�$ TwoWay=�  5/      $ Phone��6%    64   �� *Phone+$
 PropertyChanged=�$ TwoWay=�  50      $ Username��6%    67   �� *
Username+$
 PropertyChanged=�$ TwoWay=�  51      $ Password��6%    67   �� *
Password+$
 PropertyChanged=�$ TwoWay=�  52      $ Lisense��6%    66   �� *	License+$
 PropertyChanged=�$ TwoWay=�4  .System.Windows.Controls.DataGridTemplateColumn  53      $ Rides��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 68      CellTemplate 54      �� 55      .R�56      �� $��0��6'    �� DisplayMemberPath$ 	StartTime��57   '    �� SelectedValuePath$ Id��58   '    �� SelectedIndex$ 0��59   '   ��5:   '   �� *Rides+5<      5>        5?       5@      �� 5A      .R�5B      � $��80��6#   $��30��6.    � ColumnDefinitions 5C   "   �� 5D   &   �� 5E   &   .+�5G   "   �� $��0��6)   $��2q�5H   )   $��25��5I   )   $��25��5J   )   $��-3q�5K   )   ���#97a97c���#97a97c#��[ 5P   )   ��5N   )   ��  �� Path$ DataContext.UpdateDriver� �� RelativeSource �� *FindAncestor+ �� AncestorType"  ��5O   )     $
 Edit=�5P   )   �� 5Q   "   $��1��6)   $��2q�5R   )   $��25��5S   )   $��25��5T   )   $��-3q�5U   )   ���#C66263���#C66263#��[ 5Z   )   ��5V   )   �� $ DataContext.DeleteDriver� �� *FindAncestor+"  ��5Y   )     $ Delete=�5Z   )   5[      5\      5^      5`      5a      5b      