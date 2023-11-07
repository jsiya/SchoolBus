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

class DriversViewModel : ViewModelBase, INotifyPropertyChanged
{
    private Driver _selectedItem;

    public Driver SelectedItem
    {
        get { return _selectedItem; }
        set { _selectedItem = value; OnPropertyChanged(); }
    }
    public CreateDriverWindow CreateWindow { get; set; }
    public ICommand? DeleteDriver { get; set; }
    public ICommand? UpdateDriver { get; set; }
    public ICommand? CreateDriver { get; set; }
    public ICommand? AddDriver { get; set; }
    public ObservableCollection<Driver> Drivers { get; set; }
    public ObservableCollection<Ride> Rides { get; set; }
    public IRepository<Ride> RideRepo { get; set; }
    public IRepository<Driver> DriverRepo { get; set; }

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

    private string _address;

    public string Address
    {
        get { return _address; }
        set { _address = value; OnPropertyChanged(); }
    }

    private string _license;

    public string License
    {
        get { return _license; }
        set { _license = value; OnPropertyChanged(); }
    }




    public DriversViewModel()
    {
        AddDriver = new RelayCommand(OpenCreateNewDriverWindow, true);
        DriverRepo = new Repository<Driver>();
        Drivers = new ObservableCollection<Driver>(DriverRepo?.GetAll());
        RideRepo = new Repository<Ride>();
        Rides = new(RideRepo.GetAll());

        CreateDriver = new RelayCommand(CreateDriverMethod, Check);
        UpdateDriver = new RelayCommand(UpdateMethod);
        DeleteDriver = new RelayCommand(DeleteMethod);
    }


    private void UpdateMethod()
    {
        if (SelectedItem != null)
        {
            try
            {
                DriverRepo.Update(SelectedItem);
                DriverRepo.SaveChanges();
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
                DriverRepo.Remove(SelectedItem);
                DriverRepo.SaveChanges();
                Drivers.Remove(SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


    private bool Check()
    {
        if (string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName) && string.IsNullOrEmpty(Phone)
             && string.IsNullOrEmpty(Username) && string.IsNullOrEmpty(Password) && string.IsNullOrEmpty(Address) && string.IsNullOrEmpty(License)) return false;
        return true;
    }

    private void CreateDriverMethod()
    {
        Driver driver = new();
        driver.FirstName = FirstName;
        driver.LastName = LastName;
        driver.Phone = Phone;
        driver.Username = Username;
        driver.Password = Password;
        driver.HomeAddress = Address;
        driver.License = License;
        var str = DriverRepo.Add(driver);
        MessageBox.Show(str);
        if (str == "Succesfully added!") Drivers.Add(driver);
        CreateWindow.Close();

    }



    public event PropertyChangedEventHandler? PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    private void OpenCreateNewDriverWindow()
    {
        CreateWindow = new CreateDriverWindow();
        CreateWindow.DataContext = this;
        CreateWindow.Show();
    }
}
