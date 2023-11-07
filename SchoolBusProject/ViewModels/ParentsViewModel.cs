using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
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

class ParentsViewModel: ViewModelBase, INotifyPropertyChanged
{
    private Parent _selectedItem;

    public Parent SelectedItem
    {
        get { return _selectedItem; }
        set { _selectedItem = value; OnPropertyChanged(); }
    }
    public CreateParentWindow CreateWindow { get; set; }
    public ICommand? DeleteParent { get; set; }
    public ICommand? UpdateParent { get; set; }
    public ICommand? CreateParent { get; set; }
    public ICommand? AddParent { get; set; }
    public ObservableCollection<Parent> Parents { get; set; }
    public IRepository<Parent> ParentsRepo { get; set; }
    public ObservableCollection<Student> Students { get; set; }
    public IRepository<Student> StudentRepo { get; set; }

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

    private string _phone;

    public string Phone
    {
        get { return _phone; }
        set { _phone = value; OnPropertyChanged(); }
    }

    private string _username;

    public string Username
    {
        get { return _username; }
        set { _username = value; OnPropertyChanged(); }
    }

    private string _password;

    public string Password
    {
        get { return _password; }
        set { _password = value; OnPropertyChanged(); }
    }

    public ParentsViewModel()
    {
        AddParent = new RelayCommand(OpenCreateNewParentWindow, true);
        ParentsRepo = new Repository<Parent>();
        Parents = new ObservableCollection<Parent>(ParentsRepo?.GetAll());

        StudentRepo = new Repository<Student>();
        Students = new ObservableCollection<Student>(StudentRepo?.GetAll());

        CreateParent = new RelayCommand(CreateMethod, true);
        DeleteParent = new RelayCommand(DeleteMethod);
        UpdateParent = new RelayCommand(UpdateMethod);
    }

    private void UpdateMethod()
    {
        if (SelectedItem != null)
        {
            try
            {
                ParentsRepo.Update(SelectedItem);
                ParentsRepo.SaveChanges();
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
                ParentsRepo.Remove(SelectedItem);
                ParentsRepo.SaveChanges();
                Parents.Remove(SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    //nese bu check islemir
    private bool Check()
    {
        if (string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName) && string.IsNullOrEmpty(Phone)
             && string.IsNullOrEmpty(Username) && string.IsNullOrEmpty(Password)) return false;
        return true;
    }

    private void CreateMethod()
    {
        Parent parent = new();
        parent.FirstName = FirstName;
        parent.LastName = LastName;
        parent.Phone = Phone;
        parent.Username = Username;
        parent.Password = Password;
        var str = ParentsRepo.Add(parent);
        MessageBox.Show(str);
        if (str == "Succesfully added!") Parents.Add(parent);
        CreateWindow.Close();

    }



    private void OpenCreateNewParentWindow()
    {
        CreateWindow = new CreateParentWindow();
        CreateWindow.DataContext = this;
        CreateWindow.Show();
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

}
