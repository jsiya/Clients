using Clients.Models;
using Clients.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Clients.DB;

public class UsersDB
{
    public ObservableCollection<User> Users { get; set; }

    public UsersDB()
    {
        string folderPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "SourceDataFiles", "Users.json");
        Users = JsonManager<User>.Deserializer(folderPath, Users);
    }
}
