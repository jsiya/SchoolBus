using System.Windows;

namespace SchoolBusProject.Views.Windows;

public partial class CreateClassWindow : Window
{
    public CreateClassWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}
