using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SchoolBusDataAccess.Repositories.Abstracts;
using SchoolBusDataAccess.Repositories.Concretes;
using SchoolBusModels.Concretes;
using SchoolBusProject.Views.Windows;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

class ClassesViewModel : ViewModelBase, INotifyPropertyChanged
{
    public ICommand? AddClass { get; set; }
    public ObservableCollection<Class_> Classes { get; set; }
    public IRepository<Class_> ClassRepo { get; set; }

    public ClassesViewModel()
    {
        AddClass = new RelayCommand(OpenCreateNewCarWindows, true);
        ClassRepo = new Repository<Class_>();


        Classes = new ObservableCollection<Class_>(ClassRepo?.GetAll());
        var a = Classes.First().Students;
    }

    private void OpenCreateNewCarWindows()
    {
        CreateClassWindow createClassWindow = new CreateClassWindow();
        createClassWindow.Show();
    }

    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public event PropertyChangedEventHandler? PropChanged;
}
