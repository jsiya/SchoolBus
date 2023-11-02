using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SchoolBusProject.Views.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

public class CarsViewModel : ViewModelBase, INotifyPropertyChanged
{
    public ICommand? AddCar { get; set; }

    public CarsViewModel()
    {
        AddCar = new RelayCommand(OpenCreateCarWindow, true);
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
