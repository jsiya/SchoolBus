using SchoolBusProject.ViewModels.WindowsViewModels;
using System.Windows;

namespace SchoolBusProject.Views.Windows;
public partial class CreateCarWindow : Window
{
    public CreateCarWindow()
    {
        InitializeComponent();
    }
    private void CloseBtn_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}
