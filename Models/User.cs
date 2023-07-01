using System;

namespace Clients.Models;
public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public User(Guid id, string username, string password)
    {
        Id = id;
        Username = username;
        Password = password;
    }
}
