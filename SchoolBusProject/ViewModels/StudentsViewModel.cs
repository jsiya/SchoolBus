using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusDataAccess.Repositories.Abstracts;
using SchoolBusDataAccess.Repositories.Concretes;
using SchoolBusModels.Concretes;
using SchoolBusProject.ViewModels.WindowsViewModels;
using SchoolBusProject.Views.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

class StudentsViewModel : ViewModelBase, INotifyPropertyChanged
{
    private Student _selectedItem;

    public Student SelectedItem
    {
        get { return _selectedItem; }
        set { _selectedItem = value; OnPropertyChanged(); }
    }

    private Class_ _selectedClass;

    public Class_ SelectedClass
    {
        get { return _selectedClass; }
        set { _selectedClass = value; OnPropertyChanged(); }
    }
    public CreateStudentWindow CreateWindow { get; set; }
    public ICommand? DeleteStudent { get; set; }
    public ICommand? UpdateStudent { get; set; }
    public ICommand? CreateStudent { get; set; }
    public ICommand? AddStudent { get; set; }
    public ObservableCollection<Student> Students { get; set; }
    public IRepository<Student> StudentsRepo { get; set; }
    public ObservableCollection<Ride> Rides { get; set; }
    public IRepository<Ride> RideRepo { get; set; }
    public ObservableCollection<Parent> Parents { get; set; }
    public IRepository<Parent> ParentsRepo { get; set; }
    public IRepository<Class_> ClassRepo { get; set; }
    public ObservableCollection<Class_> CLasses { get; set; }

    //for create
    private string _firstName;
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; OnPropertyChanged(); }
    }

    private string _lastName;
    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; OnPropertyChanged(); }
    }
    private object _parentId;
    public object ParentId
    {
        get { return _parentId; }
        set { _parentId = value; OnPropertyChanged(); }
    }

    private string _address1;
    public string Address1
    {
        get { return _address1; }
        set { _address1 = value; OnPropertyChanged(); }
    }

    private string _address2;
    public string Address2
    {
        get { return _address2; }
        set { _address2 = value; OnPropertyChanged(); }
    }


    public StudentsViewModel()
    {
        AddStudent = new RelayCommand(OpenCreateNewStudentWindow, true);
        StudentsRepo = new Repository<Student>();
        Students = new ObservableCollection<Student>(StudentsRepo?.GetAll());
        ParentsRepo = new Repository<Parent>();
        Parents = new ObservableCollection<Parent>(ParentsRepo?.GetAll());
        RideRepo = new Repository<Ride>();
        Rides = new(RideRepo.GetAll());

        CreateStudent = new RelayCommand(CreateMethod, true);
        UpdateStudent = new RelayCommand(UpdateMethod);
        DeleteStudent = new RelayCommand(DeleteMethod);
    }

    //bax
    private bool Check()
    {
        if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || ParentId == null
             || SelectedClass == null || string.IsNullOrEmpty(Address1) || string.IsNullOrEmpty(Address2)) return false;
        return true;
    }

    private void UpdateMethod()
    {
        if (SelectedItem != null)
        {
            try
            {
                StudentsRepo.Update(SelectedItem);
                StudentsRepo.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
    private void DeleteMethod()
    {
        if (SelectedItem != null)
        {
            try
            {
                StudentsRepo.Remove(SelectedItem);
                StudentsRepo.SaveChanges();
                Students.Remove(SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


    private void CreateMethod()
    {
        int pId;
        if(int.TryParse(ParentId.ToString(), out pId))
        {
            Student student = new();
            student.FirstName = FirstName;
            student.LastName = LastName;
            student.Parents = new List<Parent>();
            student.Parents.Add(ParentsRepo?.GetById(pId));
            student.Address1 = Address1;
            student.Address2 = Address2;
            student.ClassId = SelectedClass.Id;
            var str = StudentsRepo.Add(student);
            MessageBox.Show(str);
            if (str == "Succesfully added!") Students.Add(student);
            CreateWindow.Close();
        }
        else
        {
            MessageBox.Show("Invalid Parent Id! Id must be an intager");
        }

    }

    private void OpenCreateNewStudentWindow()
    {
        ClassRepo = new Repository<Class_>();
        CLasses = new ObservableCollection<Class_>(ClassRepo.GetAll());
        CreateWindow = new CreateStudentWindow();
        CreateWindow.DataContext = this;
        CreateWindow.Show();
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
