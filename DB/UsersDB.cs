using Clients.Models;
using System.Collections.ObjectModel;

namespace Clients.DB;

public class UsersDB
{
    public ObservableCollection<User> Users { get; set; }
}
