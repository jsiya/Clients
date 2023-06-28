using Clients.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Clients.DB;

public class OrdersDB: IRepository<Order>
{
    public ObservableCollection<Order> Orders { get; set; }

    public void Add(Order entity)
    {
        throw new NotImplementedException();
    }

    public Order? Get(Func<Order, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IList<Order>? GetList(Func<Order, bool>? predicate = null)
    {
        throw new NotImplementedException();
    }

    public void Remove(Order entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Order entity)
    {
        throw new NotImplementedException();
    }
}
