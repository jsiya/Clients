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
}
