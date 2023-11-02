using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusProject.ViewModels.WindowsViewModels;
using SchoolBusProject.Views.Windows;
using System.CodeDom;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

class StudentsViewModel : ViewModelBase
{
    public ICommand? AddStudent { get; set; }

    public StudentsViewModel()
    {
        AddStudent = new RelayCommand(OpenCreateNewStudentWindow, true);
    }

    private void OpenCreateNewStudentWindow()
    {
        CreateStudentWindow createStudentWindow = new CreateStudentWindow();
        createStudentWindow.DataContext = new CreateStudentViewModel();
        createStudentWindow.Show();
    }
}
