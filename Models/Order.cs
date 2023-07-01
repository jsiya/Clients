using System;
using System.Windows.Media;

namespace Clients.Models;

public class Order
{
    public Guid Id { get; set; }
    public Guid ClientId { get; set; }
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public DateTime OpeningDate { get; set; }
    public DateTime DeliveryDate { get; set; }
    public bool IsDelivered { get; set; }
    public Order() { }
    public Order(Guid id, Guid clientId, Guid userId, string name, int quantity, DateTime openingDate, DateTime deliveryDate, bool isDelivered)
    {
        Id = id;
        ClientId = clientId;
        UserId = userId;
        Name = name;
        Quantity = quantity;
        OpeningDate = openingDate;
        DeliveryDate = deliveryDate;
        IsDelivered = isDelivered;
    }
}
