using Clients.Models;
using System;
using System.Collections.ObjectModel;

namespace Clients.DB;

public class UsersDB
{
    public ObservableCollection<User> Users { get; set; }

    public UsersDB()
    {
        Users = new() {
            new User(Guid.NewGuid(), "siya", "salam123"),
            new User(Guid.NewGuid(), "hesen", "salam1234")
        };
    }
}
