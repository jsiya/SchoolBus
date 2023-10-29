using GalaSoft.MvvmLight;
using System.ComponentModel;
using System.Windows.Controls;

namespace SchoolBusProject.ViewModels;

class LoginViewModel : ViewModelBase, INotifyPropertyChanged
{
    public Frame ViewFrame { get; set; }
    public LoginViewModel(Frame frame)
    {
        ViewFrame = frame;
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
