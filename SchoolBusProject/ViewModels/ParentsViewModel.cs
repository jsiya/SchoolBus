using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusProject.Views.Windows;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

class ParentsViewModel: ViewModelBase
{
    public ICommand? AddParent { get; set; }

    public ParentsViewModel()
    {
        AddParent = new RelayCommand(OpenCreateNewParentWindow, true);
    }

    private void OpenCreateNewParentWindow()
    {
        CreateParentWindow createParentWindow = new CreateParentWindow();
        createParentWindow.Show();
    }
}
