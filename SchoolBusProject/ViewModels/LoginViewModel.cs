using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SchoolBusDataAccess.Contexts;
using SchoolBusDataAccess.Repositories.Abstracts;
using SchoolBusDataAccess.Repositories.Concretes;
using SchoolBusModels.Concretes;
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
    public IRepository<Admin> AdminRepo { get; set; }
    public Admin? CurrentAdmin { get; set; }

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
        AdminRepo = new Repository<Admin>();
        ViewFrame = frame;
        LoginCommand = new RelayCommand(LoginToAccount, CheckUsernameAndPasswordIsNotEmpty);
    }



    //methods
    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public event PropertyChangedEventHandler? PropChanged;


    private bool CheckUsernameAndPasswordIsNotEmpty()
    {
        if (string.IsNullOrEmpty(Username) && string.IsNullOrEmpty(Password))
            return false;
        return true;
    }

    private void LoginToAccount()
    {
        foreach (var item in AdminRepo.GetAll())
        {
            if (Username == item.Username && Password == item.Password)
            {
                CurrentAdmin = item;
                ViewFrame.Content = new NavRailViewModel(ViewFrame, CurrentAdmin);
                return;
            }
        }
    }
}
