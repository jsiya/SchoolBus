using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusDataAccess.Repositories.Abstracts;
using SchoolBusDataAccess.Repositories.Concretes;
using SchoolBusModels.Concretes;
using SchoolBusProject.Views.Windows;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

class ParentsViewModel: ViewModelBase
{
    public ICommand? AddParent { get; set; }
    public ObservableCollection<Parent> Parents { get; set; }
    public IRepository<Parent> ParentsRepo { get; set; }
    public ObservableCollection<Student> Students { get; set; }
    public IRepository<Student> StudentRepo { get; set; }

    public ParentsViewModel()
    {
        AddParent = new RelayCommand(OpenCreateNewParentWindow, true);
        ParentsRepo = new Repository<Parent>();
        Parents = new ObservableCollection<Parent>(ParentsRepo?.GetAll());

        StudentRepo = new Repository<Student>();
        Students = new ObservableCollection<Student>(StudentRepo?.GetAll());
    }

    private void OpenCreateNewParentWindow()
    {
        CreateParentWindow createParentWindow = new CreateParentWindow();
        createParentWindow.Show();
    }
}
