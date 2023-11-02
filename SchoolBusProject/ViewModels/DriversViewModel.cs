using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SchoolBusProject.Views.Windows;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

class DriversViewModel: ViewModelBase
{
    public ICommand? AddDriver { get; set; }

    public DriversViewModel()
    {
        AddDriver = new RelayCommand(OpenCreateNewDriverWindow, true);
    }

    private void OpenCreateNewDriverWindow()
    {
        CreateDriverWindow createDriverWindow = new CreateDriverWindow();
        createDriverWindow.Show();
    }
}
