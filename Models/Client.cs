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
    public Client() { }
    public Client(Guid id, string name, string surname, string phone, string company, string place, string about, int undeliveredOrderCount)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Phone = phone;
        Company = company;
        Place = place;
        About = about;
        UndeliveredOrderCount = undeliveredOrderCount;
    }
}
