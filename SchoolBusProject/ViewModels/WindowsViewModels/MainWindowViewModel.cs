using GalaSoft.MvvmLight;
using System.Windows.Controls;

namespace SchoolBusProject.ViewModels.WindowsViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public Frame ViewFrame { get; set; }
    public MainWindowViewModel(Frame View)
    {
        ViewFrame = View;
        ViewFrame.Content = new LoginViewModel(ViewFrame);
    }

}
