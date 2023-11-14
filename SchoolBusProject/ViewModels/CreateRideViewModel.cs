using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SchoolBusDataAccess.Repositories.Abstracts;
using SchoolBusDataAccess.Repositories.Concretes;
using SchoolBusModels.Concretes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

public class CreateRideViewModel : ViewModelBase, INotifyPropertyChanged
{

    private Student _selectedItem;

    public Student SelectedItem
    {
        get { return _selectedItem; }
        set { _selectedItem = value; OnPropertyChanged(); }
    }

    private Car _selectedCar;

    public Car SelectedCar
    {
        get { return _selectedCar; }
        set { _selectedCar = value; OnPropertyChanged(); }
    }

    private Driver _selectedDriver;

    public Driver SelectedDriver
    {
        get { return _selectedDriver; }
        set { _selectedDriver = value; OnPropertyChanged(); }
    }

    private DateTime _selectedDate;

    public DateTime SelectedDate
    {
        get { return _selectedDate; }
        set { _selectedDate = value; OnPropertyChanged(); }
    }

    private Ride _ride;

    public Ride Ridee
    {
        get { return _ride; }
        set { _ride = value; OnPropertyChanged(); }
    }

    private string _count;
    private int _counter = 0;

    public string Count
    {
        get { return _count; }
        set { _count = value; OnPropertyChanged(); }
    }
    public ICommand? AddStudent { get; set; }
    public ICommand? RemoveStudent { get; set; }
    public ICommand? CreateRide { get; set; }
    public ObservableCollection<Student> Students { get; set; }
    public ObservableCollection<Driver> Drivers { get; set; }
    public ObservableCollection<Car> Cars { get; set; }
    public IRepository<Ride> RidesRepo { get; set; }
    public IRepository<Student> StudentsRepo { get; set; }
    public IRepository<Driver> DriverRepo { get; set; }
    public IRepository<Car> CarRepo { get; set; }

    public CreateRideViewModel()
    {
        Ridee = new Ride();
        RidesRepo = new Repository<Ride>();
        StudentsRepo = new Repository<Student>();
        DriverRepo = new Repository<Driver>();
        CarRepo = new Repository<Car>();
        Students = new ObservableCollection<Student>(StudentsRepo.GetAll());
        Drivers = new ObservableCollection<Driver>(DriverRepo.GetAll());
        Cars = new ObservableCollection<Car>(CarRepo.GetAll());
        AddStudent = new RelayCommand(AddStudentMethod);
        RemoveStudent = new RelayCommand(RemoveStudentMethod);
    }

    private void AddStudentMethod()
    {
        Ridee.StudentRides.Add(new StudentRide() { Student = SelectedItem});
        Students.Remove(SelectedItem);

        _counter++;
        Count = _counter.ToString();
    }
    private void RemoveStudentMethod()
    {
        if(Ridee.StudentRides.Count > 0)
        {
            Ridee.StudentRides.Remove(Ridee.StudentRides.FirstOrDefault(s=>s.Student == SelectedItem));

            _counter--;
            Count = _counter.ToString();

            Students.Add(SelectedItem);
        }
    }

    private void CreateRideMethod()
    {
        Ridee.Car = SelectedCar;
        Ridee.Driver = SelectedDriver;
        Ridee.StartTime = SelectedDate;
        Ridee.EndTime = SelectedDate.AddDays(1);
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
