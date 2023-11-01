using SchoolBusProject.ViewModels;
using System.Windows.Controls;

namespace SchoolBusProject.Views.Pages
{
    /// <summary>
    /// Interaction logic for NavRailView.xaml
    /// </summary>
    public partial class NavRailView : Page
    {
        public NavRailView()
        {
            InitializeComponent();
            
        }

        private void Page_DataContextChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is NavRailViewModel datacontext) datacontext.InnerFrame = this.InnerFrame;
        }
    }
}
