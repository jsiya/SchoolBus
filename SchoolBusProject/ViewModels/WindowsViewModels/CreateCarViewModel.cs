using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusDataAccess.Repositories.Concretes;
using SchoolBusModels.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels.WindowsViewModels;

class CreateCarViewModel : ViewModelBase, INotifyPropertyChanged
{
    public ICommand? AddCar { get; set; }

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

    private int _seatCount;

    public int SeatCount
    {
        get { return _seatCount; }
        set { _seatCount = value; OnPropertyChanged(); }
    }

    private Car _car;

    public Car NewCar
    {
        get { return _car; }
        set { 
                _car = value;
                OnPropertyChanged();
            }
    }

    public CreateCarViewModel()
    {
        AddCar = new RelayCommand(AddNewCar, Check);
    }

    private void AddNewCar()
    {
        Repository<Car> carRepository = new Repository<Car>();
        NewCar = new() { Name = Name, Number = Number, SeatCount = SeatCount, Rides = new List<Ride>() };
        carRepository.Add(NewCar);
    }

    private bool Check()
    {
        if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Number) && SeatCount > 0)
        {
            return true;
        }
        return false;
    }

    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
