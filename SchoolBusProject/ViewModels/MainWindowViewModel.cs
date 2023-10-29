using GalaSoft.MvvmLight;
using System.ComponentModel;
using System.Windows.Controls;

namespace SchoolBusProject.ViewModels;

public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
{
    //MainWindowun backinde vermisem datacontext kimi - S
    public Frame ViewFrame { get; set; }
    public MainWindowViewModel(Frame View, Page page)
    {
        ViewFrame = View;//bu viewdaki frame deyise bilmek ucun bunu elemiyib ancaq bind eliyende nese error verir - S
        page.DataContext = new LoginViewModel(ViewFrame); // buda frame-e vereciyimiz page ucun datacontext vere bilek deye -S
        ViewFrame.Content = page;
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
