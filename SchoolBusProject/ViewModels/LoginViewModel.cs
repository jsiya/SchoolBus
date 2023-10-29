using GalaSoft.MvvmLight;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

class LoginViewModel : ViewModelBase, INotifyPropertyChanged
{
    //Properties
    public Frame ViewFrame { get; set; }
    public ICommand? LoginCommand { get; set; }


    private string? _username;
    public string Username
    {
        get { return _username; }
        set
        {
            _username = value;
            OnPropertyChanged();
        }
    }


    private string? _password;
    public string Password
    {
        get { return _password; }
        set
        {
            _password = value;
            OnPropertyChanged();
        }
    }


    //Ctor
    public LoginViewModel(Frame frame)
    {
        ViewFrame = frame;
    }



    //Methods
    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
