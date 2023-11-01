using SchoolBusProject.ViewModels;
using SchoolBusProject.Views.Pages;
using System;
using System.Windows;

namespace SchoolBusProject.Views.Windows;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel(MainFrame);
    }

    private void CloseButtonClick(object sender, RoutedEventArgs e)
    {
        try
        {
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    
    private void MinimizeButtonClick(object sender, RoutedEventArgs e)
    {
        try
        {
            this.WindowState = WindowState.Minimized;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
