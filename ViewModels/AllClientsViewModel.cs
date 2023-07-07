using Clients.DB;
using Clients.Models;
using System.Collections.ObjectModel;

namespace Clients.ViewModels;

public class AllClientsViewModel
{
    public ObservableCollection<Client> CurrentClients { get; set; }
    public ObservableCollection<Client> AllClients { get; set; }
    public User CurrentUser { get; set; }
    public AllClientsViewModel(User user, ObservableCollection<Client> clients, ObservableCollection<Client> allients)
	{
        CurrentClients = clients;
        CurrentUser = user;
        AllClients = allients;
	}
}
