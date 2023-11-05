using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusDataAccess.Repositories.Abstracts;
using SchoolBusDataAccess.Repositories.Concretes;
using SchoolBusModels.Concretes;
using SchoolBusProject.ViewModels.WindowsViewModels;
using SchoolBusProject.Views.Windows;
using System.CodeDom;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

class StudentsViewModel : ViewModelBase
{
    public ICommand? AddStudent { get; set; }
    public ObservableCollection<Student> Students { get; set; }
    public IRepository<Student> StudentsRepo { get; set; }

    public StudentsViewModel()
    {
        AddStudent = new RelayCommand(OpenCreateNewStudentWindow, true);
        StudentsRepo = new Repository<Student>();

        Students = new ObservableCollection<Student>(StudentsRepo?.GetAll());
    }

    private void OpenCreateNewStudentWindow()
    {
        CreateStudentWindow createStudentWindow = new CreateStudentWindow();
        createStudentWindow.DataContext = new CreateStudentViewModel();
        createStudentWindow.Show();
    }
}
