using Clients.Commands;
using Clients.DB;
using Clients.Models;
using Clients.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Clients.ViewModels;

public class HomeViewModel: INotifyPropertyChanged
{
    public ObservableCollection<Client> Clients { get; set; }
    public ObservableCollection<Client> CurrentClients { get; set; }
    public User SelectedUser { get; set; }
    public ICommand? CreateClientCommand { get; set; }
    public ICommand? AllClientsCommand { get; set; }
    public HomeViewModel(User user)
    {
        SelectedUser = user;
        ClientsDB clientsDB = new ClientsDB();
        Clients = new ObservableCollection<Client>(clientsDB.GetList());
        CurrentClients = new ObservableCollection<Client>(clientsDB.GetList(client => client.UserId == SelectedUser.Id));
        CreateClientCommand = new RelayCommand(CreateClient, checkUser);
        AllClientsCommand = new RelayCommand(AllClients, checkUser);
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    public bool checkUser(object? parametr)
    {
        if (SelectedUser == null) return false;
        return true;
    }
    public void CreateClient(object? parametr)
    {
        RegisterView registerView = new RegisterView();
        registerView.DataContext = new RegisterViewModel(SelectedUser, Clients);
        registerView.ShowDialog();
    }
    public void AllClients(object? parametr)
    {
        AllClients allClientsView = new();
        allClientsView.DataContext = new AllClientsViewModel(SelectedUser, CurrentClients, Clients);
        allClientsView.ShowDialog();
        
    }
}
