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
        NewCar = new();
        AddCar = new RelayCommand(AddNewCar, Check);
    }

    private void AddNewCar()
    {
        Repository<Car> carRepository = new Repository<Car>();
        carRepository.Add(_car);
    }

    private bool Check()
    {
        if (!string.IsNullOrEmpty(_car.Name) && !string.IsNullOrEmpty(_car.Number) && _car.SeatCount > 0)
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
