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

public class CarsViewModel : ViewModelBase, INotifyPropertyChanged
{
    private Car _selectedItem;

    public Car SelectedItem
    {
        get { return _selectedItem; }
        set { _selectedItem = value; OnPropertyChanged(); }
    }
    //for create
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; OnPropertyChanged(); }
    }
    private string _number;

    public string Number
    {
        get { return _number; }
        set { _number = value; OnPropertyChanged(); }
    }
    private string _seatCount;

    public string SeatCount
    {
        get { return _seatCount; }
        set { _seatCount = value; OnPropertyChanged(); }
    }
    public CreateCarWindow CreateWindow { get; set; }
    public ICommand? DeleteCar { get; set; }
    public ICommand? UpdateCar { get; set; }
    public ICommand? AddCar { get; set; }
    public ICommand? CreateCar { get; set; }
    public ObservableCollection<Car> Cars { get; set; }
    public ObservableCollection<Ride> Rides { get; set; }
    public IRepository<Car> CarsRepo { get; set; }
    public IRepository<Ride> RideRepo { get; set; }

    public CarsViewModel()
    {
        AddCar = new RelayCommand(OpenCreateCarWindow, true);
        CarsRepo = new Repository<Car>();
        RideRepo = new Repository<Ride>();
        Rides = new(RideRepo.GetAll());
        Cars = new(CarsRepo.GetAll());

        CreateCar = new RelayCommand(CreateCarMethod, Check);
        DeleteCar = new RelayCommand(DeleteCarMethod);
        UpdateCar = new RelayCommand(UpdateMethod);
    }


    private void UpdateMethod()
    {
        if (SelectedItem != null)
        {
            try
            {
                CarsRepo.Update(SelectedItem);
                CarsRepo.SaveChanges();
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
                CarsRepo.Remove(SelectedItem);
                CarsRepo.SaveChanges();
                Cars.Remove(SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


    private void OpenCreateCarWindow()
    {
        CreateWindow = new CreateCarWindow();
        CreateWindow.DataContext = this;
        CreateWindow.Show();
    }

    //create
    private bool Check()
    {
        if (string.IsNullOrEmpty(Name) && string.IsNullOrEmpty(Number) && string.IsNullOrEmpty(SeatCount)) return false;
        return true;
    }
    private void CreateCarMethod()
    {
        int res;
        Car car = new();
        car.Name = _name;
        car.Number = Number;
        if (int.TryParse(SeatCount, out res))
        {
            car.SeatCount = res;
            var str = CarsRepo.Add(car);
            MessageBox.Show(str);
            if (str == "Succesfully added!") Cars.Add(car);
            CreateWindow.Close();
        }
        else MessageBox.Show("Seat count must be number!"); 
    }

    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public event PropertyChangedEventHandler? PropChanged;
}
