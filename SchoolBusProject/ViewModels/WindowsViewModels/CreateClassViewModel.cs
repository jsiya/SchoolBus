using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SchoolBusDataAccess.Repositories.Concretes;
using SchoolBusModels.Concretes;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels.WindowsViewModels;

class CreateClassViewModel: ViewModelBase ,INotifyPropertyChanged
{
    private string _name;

    public string Classname
    {
        get { return _name; }
        set { _name = value; OnPropertyChanged(); }
    }
    public ICommand? CreateClass { get; set; }
    public Repository<Class_> Classes { get; set; }

    public CreateClassViewModel()
    {
        Classes = new Repository<Class_>();
        CreateClass = new RelayCommand(CreateClassMethod, Check);
    }

    private bool Check()
    {
        if(string.IsNullOrEmpty(Classname)) return false;
        return true;
    }

    private void CreateClassMethod()
    {
            Class_ clas = new();
            clas.Name = _name;
            Classes.Add(clas);
            Classes.SaveChanges();
    }

    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public event PropertyChangedEventHandler? PropChanged;
}
