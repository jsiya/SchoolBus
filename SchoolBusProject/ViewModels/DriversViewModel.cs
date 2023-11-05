using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SchoolBusDataAccess.Repositories.Abstracts;
using SchoolBusDataAccess.Repositories.Concretes;
using SchoolBusModels.Concretes;
using SchoolBusProject.Views.Windows;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

class DriversViewModel: ViewModelBase
{
    public ICommand? AddDriver { get; set; }
    public ObservableCollection<Driver> Drivers { get; set; }
    public IRepository<Driver> DriverRepo { get; set; }

    public DriversViewModel()
    {
        AddDriver = new RelayCommand(OpenCreateNewDriverWindow, true);
        DriverRepo = new Repository<Driver>();


        Drivers = new ObservableCollection<Driver>(DriverRepo?.GetAll());
    }

    private void OpenCreateNewDriverWindow()
    {
        CreateDriverWindow createDriverWindow = new CreateDriverWindow();
        createDriverWindow.Show();
    }
}
