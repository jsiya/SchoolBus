using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SchoolBusDataAccess.Repositories.Abstracts;
using SchoolBusDataAccess.Repositories.Concretes;
using SchoolBusModels.Concretes;
using SchoolBusProject.Views.Windows;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

public class CarsViewModel : ViewModelBase, INotifyPropertyChanged
{
    public ICommand? AddCar { get; set; }
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
    }

    private void OpenCreateCarWindow()
    {
        CreateCarWindow createCarWindow = new CreateCarWindow();
        createCarWindow.Show();
    }

    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public event PropertyChangedEventHandler? PropChanged;
}
