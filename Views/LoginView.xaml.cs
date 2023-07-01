using Clients.ViewModels;
using System.Windows;

namespace Clients.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
