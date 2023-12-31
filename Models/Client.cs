﻿using System;

namespace Clients.Models;

public class Client
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public string Company { get; set; }
    public string Place { get; set; }
    public string About { get; set; }
    public int UndeliveredOrderCount { get; set; }
    public Client() { }
    public Client(Guid id, Guid userId, string name, string surname, string phone, string company, string place, string about, int undeliveredOrderCount)
    {
        Id = id;
        UserId = userId;
        Name = name;
        Surname = surname;
        Phone = phone;
        Company = company;
        Place = place;
        About = about;
        UndeliveredOrderCount = undeliveredOrderCount;
    }
}
