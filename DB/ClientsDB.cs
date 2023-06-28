using Clients.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Clients.DB;

public class ClientsDB: IRepository<Client>
{
    public ObservableCollection<Client> Clients { get; set; }

    public void Add(Client entity)
    {
        throw new NotImplementedException();
    }

    public Client? Get(Func<Client, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IList<Client>? GetList(Func<Client, bool>? predicate = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(Client entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Client entity)
    {
        throw new NotImplementedException();
    }
}
