using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SchoolBusModels.Concretes;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

public class NavRailViewModel : ViewModelBase, INotifyPropertyChanged
{
    public Frame ViewFrame { get; set; }
    public Frame InnerFrame { get; set; }

    private ViewModelBase _currentView;

    public ViewModelBase CurrentView
    {
        get { return _currentView; }
        set 
        { 
            _currentView = value;
            OnPropertyChanged();
        }
    }


    public Admin CurrentAdmin { get; set; }
    public ICommand? RideCommand { get; set; }
    public ICommand? ClassCommand { get; set; }
    public ICommand? CarCommand { get; set; }
    public ICommand? DriverCommand { get; set; }
    public ICommand? ParentCommand { get; set; }
    public ICommand? StudentCommand { get; set; }
    public ICommand? HolidayCommand { get; set; }
    public ICommand? LogOutCommand { get; set; }
    public NavRailViewModel(Frame frame, Admin admin)
    {
        ViewFrame = frame;
        CurrentAdmin = admin;
        CurrentView = new RidesViewModel();
        RideCommand = new RelayCommand(NavigateToRidesPage, true);
        ClassCommand = new RelayCommand(NavigateToClassPage, true);
        CarCommand = new RelayCommand(NavigateToCarsPage, true);
        DriverCommand = new RelayCommand(NavigateToDriversPage, true);
        ParentCommand = new RelayCommand(NavigateToParentsPage, true);
        StudentCommand = new RelayCommand(NavigateToStudentsPage, true);
        HolidayCommand = new RelayCommand(NavigateToHolidayPage, true);
        LogOutCommand = new RelayCommand(NavigateToBack, true);
    }

    private void NavigateToRidesPage()
    {
        InnerFrame.Content = new RidesViewModel();
    }
    private void NavigateToClassPage()
    {
        InnerFrame.Content = new ClassesViewModel();
    }
    private void NavigateToDriversPage()
    {
        InnerFrame.Content = new DriversViewModel();
    }
    private void NavigateToParentsPage()
    {
        InnerFrame.Content = new ParentsViewModel();
    }
    private void NavigateToStudentsPage()
    {
        InnerFrame.Content = new StudentsViewModel();
    }

    private void NavigateToHolidayPage()
    {
        InnerFrame.Content = new HolidaysViewModel();
    }

    private void NavigateToCarsPage()
    {
        InnerFrame.Content = new CarsViewModel();
    }

    private void NavigateToBack()
    {
        //ViewFrame.NavigationService.GoBack();
        ViewFrame.Content = null;
        ViewFrame.Content = new LoginViewModel(ViewFrame);
    }

    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public event PropertyChangedEventHandler? PropChanged;
}
