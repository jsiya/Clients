using Clients.Commands;
using Clients.DB;
using Clients.Models;
using Clients.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Clients.ViewModels;

public class AllClientsViewModel
{
    public ObservableCollection<Client> CurrentClients { get; set; }
    public ObservableCollection<Client> AllClients { get; set; }
    public ICommand? CreateClientCommand { get; set; }
    public ICommand? ClientProfileCommand { get; set; }
    public User CurrentUser { get; set; }
    public Client SelectedClient { get; set; }
    public AllClientsViewModel(User user, ObservableCollection<Client> clients, ObservableCollection<Client> allients)
	{
        CurrentClients = clients;
        CurrentUser = user;
        AllClients = allients;
        ClientProfileCommand = new RelayCommand(ClientProfile, CheckClient);
	}
    public bool CheckClient(object? parametr)
    {
        if (SelectedClient == null) return true;
        return false;
    }
    public void ClientProfile(object? parametr)
    {
        ClientProfileView clientProfile = new();
        clientProfile.DataContext = new CientProfileViewModel();
        clientProfile.ShowDialog();

    }
}
