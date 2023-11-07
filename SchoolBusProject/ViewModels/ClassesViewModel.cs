using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SchoolBusDataAccess.Repositories.Abstracts;
using SchoolBusDataAccess.Repositories.Concretes;
using SchoolBusModels.Concretes;
using SchoolBusProject.Views.Windows;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

class ClassesViewModel : ViewModelBase, INotifyPropertyChanged
{
    private Class_ _selectedItem;

    public Class_ SelectedItem
    {
        get { return _selectedItem; }
        set { _selectedItem = value; OnPropertyChanged(); }
    }

    public CreateClassWindow CreateWindow { get; set; }
    public ICommand? AddClass { get; set; }
    public ICommand? DeleteClass { get; set; }
    public ICommand? UpdateClassCommand { get; set; }
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
        DeleteClass = new RelayCommand(DeleteCarMethod);
        UpdateClassCommand = new RelayCommand(UpdateMethod);
    }

    private void UpdateMethod()
    {
        if(SelectedItem != null)
        {
            try
            {
                ClassRepo.Update(SelectedItem);
                ClassRepo.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
    private void DeleteCarMethod()
    {
        if (SelectedItem != null)
        {
            try
            {
                ClassRepo.Remove(SelectedItem);
                ClassRepo.SaveChanges();
                Classes.Remove(SelectedItem);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       
    }

    private void OpenCreateNewCarWindows()
    {
        CreateWindow= new CreateClassWindow();
        CreateWindow.DataContext = this;
        CreateWindow.Show();
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
        CreateWindow.Close();
    }


    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public event PropertyChangedEventHandler? PropChanged;
}
