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
using System.Windows;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

class ClassesViewModel : ViewModelBase, INotifyPropertyChanged
{
    public ICommand? AddClass { get; set; }
    public ObservableCollection<Class_> Classes { get; set; }
    public ObservableCollection<Student> Students { get; set; }
    public IRepository<Student> StudentRepo { get; set; }
    public IRepository<Class_> ClassRepo { get; set; }

    //createclass
    private string _name;

    public string Classname
    {
        get { return _name; }
        set { _name = value; OnPropertyChanged(); }
    }
    public ICommand? CreateClass { get; set; }

    public ClassesViewModel()
    {
        AddClass = new RelayCommand(OpenCreateNewCarWindows, true);
        ClassRepo = new Repository<Class_>();
        StudentRepo = new Repository<Student>();    

        Classes = new ObservableCollection<Class_>(ClassRepo?.GetAll());
        Students = new ObservableCollection<Student>(StudentRepo?.GetAll());

        //create class

        CreateClass = new RelayCommand(CreateClassMethod, Check);
    }

    private void OpenCreateNewCarWindows()
    {
        CreateClassWindow createClassWindow = new CreateClassWindow();
        createClassWindow.DataContext = this;
        createClassWindow.Show();
    }

    private bool Check()
    {
        if (string.IsNullOrEmpty(Classname)) return false;
        return true;
    }

    private void CreateClassMethod()
    {
        Class_ clas = new();
        clas.Name = _name;
        var str = ClassRepo.Add(clas);
        MessageBox.Show(str);
        if(str == "Succesfully added!") Classes.Add(clas);
        ClassRepo.SaveChanges();
    }


    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public event PropertyChangedEventHandler? PropChanged;
}
