using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using SchoolBusDataAccess.Repositories.Abstracts;
using SchoolBusDataAccess.Repositories.Concretes;
using SchoolBusModels.Concretes;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace SchoolBusProject.ViewModels;

class RidesViewModel : ViewModelBase, INotifyPropertyChanged
{
    private Ride _selectedItem;

    public Ride SelectedItem
    {
        get { return _selectedItem; }
        set { _selectedItem = value; OnPropertyChanged(); }
    }
    public ObservableCollection<Ride> Rides { get; set; }
    public IRepository<Ride> RidesRepo { get; set; }

    public ICommand? DeleteRide { get; set; }
    public RidesViewModel()
    {
        RidesRepo = new Repository<Ride>();


        Rides = new ObservableCollection<Ride>(RidesRepo?.GetAll());

        DeleteRide = new RelayCommand(DeleteMethod);
    }

    private void DeleteMethod()
    {
        if (SelectedItem != null)
        {
            try
            {
                RidesRepo.Remove(SelectedItem);
                RidesRepo.SaveChanges();
                Rides.Remove(SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

}
