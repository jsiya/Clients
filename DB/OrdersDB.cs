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
        Orders.Add(entity);
    }

    public Order? Get(Func<Order, bool> predicate)
    {
        foreach (var item in Orders)
        {
            if (predicate(item)) return item;
        }
        return null;
    }

    public IList<Order>? GetList(Func<Order, bool>? predicate = null)
    {
        if(predicate == null) return Orders;
        IList<Order>? orders = new List<Order>();
        foreach (var item in Orders)
        {
            if(predicate(item)) orders.Add(item);
        }
        return orders;
    }

    public void Remove(Order entity)
    {
        Orders.Remove(entity);
    }

    public void Update(Order entity)
    {
        foreach(var item in Orders)
        {
            if(item.Id == entity.Id)
            {
                item.Name = entity.Name;
                item.IsDelivered = entity.IsDelivered;
                item.OpeningDate = entity.OpeningDate;
                item.DeliveryDate = entity.DeliveryDate;
                item.Quantity = entity.Quantity;
            }
        }
    }
}
