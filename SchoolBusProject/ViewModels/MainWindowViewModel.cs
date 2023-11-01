using GalaSoft.MvvmLight;
using SchoolBusProject.Views.Pages;
using System.ComponentModel;
using System.Windows.Controls;

namespace SchoolBusProject.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public Frame ViewFrame { get; set; }
    public MainWindowViewModel(Frame View)
    {
        ViewFrame = View;
        ViewFrame.Content = new LoginViewModel(ViewFrame);
    }

}
