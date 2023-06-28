using System;

namespace Clients.Models;

public class Client
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public string Company { get; set; }
    public string Place { get; set; }
    public string About { get; set; }
    public int UndeliveredOrderCount { get; set; }

}
