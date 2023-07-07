using Clients.Models;
using Clients.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

namespace Clients.DB;

public class ClientsDB: IRepository<Client>
{
    public ObservableCollection<Client> Clients { get; set; }
    public ClientsDB()
    {
        string folderPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "SourceDataFiles", "Clients.json");
        Clients = JsonManager<Client>.Deserializer(folderPath, Clients);
    }

    public void Add(Client entity)
    {
        Clients.Add(entity);
    }

    public Client? Get(Func<Client, bool> predicate)
    {
        foreach (Client client in Clients)
        {
            if (predicate(client))  return client;
        }
        return null;
    }

    public IList<Client>? GetList(Func<Client, bool>? predicate = null)
    {
        if(predicate == null) return Clients;
        IList<Client>? list = new List<Client>();
        foreach (Client client in Clients)
        {
            if(predicate(client)) list.Add(client);
        }
        return list;
    }

    public void Remove(Client entity)
    {
        Clients.Remove(entity);
    }

    public void Update(Client entity)
    {
        foreach(Client client in Clients)
        {
            if(client.Id == entity.Id)
            {
                client.Name = entity.Name;
                client.Surname = entity.Surname;
                client.Phone = entity.Phone;
                client.About = entity.About;
                client.Place = entity.Place;
                client.Company = entity.Company;
                client.UndeliveredOrderCount = entity.UndeliveredOrderCount;
                return;
            }
        }
    }
    
}
