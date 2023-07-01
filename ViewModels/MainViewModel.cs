using Clients.Commands;
using Clients.DB;
using Clients.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Clients.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    public ObservableCollection<User> Users { get; set; }
    private string _username;

    public string Username
    {
        get { return _username; }
        set 
        { 
            _username = value; 
            OnPropertyChanged();
        }
    }
    private string _password;
    public string Password
    {
        get { return _password; }
        set
        {
            _password = value;
            OnPropertyChanged();
        }
    }
    public ICommand LoginCommand { get; set; }

    public UsersDB usersDB;

    public event PropertyChangedEventHandler? PropertyChanged;

    public User SelectedUser { get; set; }
    public MainViewModel() 
    { 
        usersDB = new UsersDB();
        Users = usersDB.Users;
        LoginCommand = new RelayCommand(LogIn, checkUser);
    }

    public bool checkUser(object? parametr)
    {
        foreach (User user in Users)
        {
            if(user.Username == Username &&  user.Password == Password)
            {
                return true;
            }
        }
        return false;
    }

    public void LogIn(object? parametr)
    {
        foreach (User user in Users)
        {
            if (user.Username == Username && user.Password == Password)
            {
                SelectedUser = user;
            }
        }
    }
    private void OnPropertyChanged([CallerMemberName]  string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
