using GalaSoft.MvvmLight;
using SchoolBusDataAccess.Repositories.Abstracts;
using SchoolBusDataAccess.Repositories.Concretes;
using SchoolBusModels.Concretes;
using System.Collections.ObjectModel;

namespace SchoolBusProject.ViewModels;

class RidesViewModel : ViewModelBase
{
    public ObservableCollection<Ride> Rides { get; set; }
    public IRepository<Ride> RidesRepo { get; set; }
    public RidesViewModel()
    {
        RidesRepo = new Repository<Ride>();


        Rides = new ObservableCollection<Ride>(RidesRepo?.GetAll());
    }
}
