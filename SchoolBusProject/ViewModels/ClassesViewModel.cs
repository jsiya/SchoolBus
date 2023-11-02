using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SchoolBusProject.ViewModels.WindowsViewModels;
using SchoolBusProject.Views.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

class ClassesViewModel : ViewModelBase, INotifyPropertyChanged
{
    public ICommand? AddClass { get; set; }

    public ClassesViewModel()
    {
        AddClass = new RelayCommand(OpenCreateNewCarWindows, true);
    }

    private void OpenCreateNewCarWindows()
    {
        CreateClassWindow createClassWindow = new CreateClassWindow();
        createClassWindow.Show();
    }

    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public event PropertyChangedEventHandler? PropChanged;
}
