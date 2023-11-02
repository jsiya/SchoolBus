using System.Windows;

namespace SchoolBusProject.Views.Windows;
public partial class CreateDriverWindow : Window
{
    public CreateDriverWindow()
    {
        InitializeComponent();
    }

    private void CloseBtn_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}
