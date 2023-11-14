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

    private Ride _selectedItem;

    public Ride SelectedItem
    {
        get { return _selectedItem; }
        set { _selectedItem = value; OnPropertyChanged(); }
    }

    private string _count;

    public string Count
    {
        get { return _count; }
        set { _count = value; OnPropertyChanged(); }
    }
    public ICommand? AddStudent { get; set; }
    public ICommand? RemoveStudent { get; set; }
    public ObservableCollection<Student> Students { get; set; }
    public ObservableCollection<Student> SelectedStudents { get; set; } = new ObservableCollection<Student>();
    public IRepository<Ride> RidesRepo { get; set; }
    public IRepository<Student> StudentsRepo { get; set; }

    public CreateRideViewModel()
    {
        RidesRepo = new Repository<Ride>();
        StudentsRepo = new Repository<Student>();
        Students = new ObservableCollection<Student>(StudentsRepo.GetAll());
        AddStudent = new RelayCommand(AddStudentMethod);
    }

    private void AddStudentMethod()
    {

    }
    private void RemoveStudentMethod()
    {

    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
