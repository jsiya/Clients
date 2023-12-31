﻿using Clients.Commands;
using Clients.DB;
using Clients.Models;
using Clients.UserControls;
using Clients.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Clients.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    public ObservableCollection<User> Users { get; set; }
    private TextBox1 _textboxUsername;

    public TextBox1 TextBoxUsername
    {
        get { return _textboxUsername; }
        set 
        { 
            _textboxUsername = value;
            OnPropertyChanged();
        }
    }

    private TextBox1 _textboxPassword;

    public TextBox1 TextBoxPassword
    {
        get { return _textboxPassword; }
        set
        {
            _textboxPassword = value;
            OnPropertyChanged();
        }
    }
    public ICommand? LoginCommand { get; set; }

    public UsersDB usersDB;

    public event PropertyChangedEventHandler? PropertyChanged;

    public User SelectedUser { get; set; }
    public MainViewModel() 
    { 
        usersDB = new UsersDB();
        Users = usersDB.Users;
        TextBoxUsername = new TextBox1();
        TextBoxUsername.Placeholder = "please enter username";
        TextBoxUsername.UserInput = "";
        TextBoxPassword = new TextBox1();
        TextBoxPassword.Placeholder = "please enter password";
        TextBoxPassword.UserInput = "";
        LoginCommand = new RelayCommand(LogIn, checkUser);
    }

    public bool checkUser(object? parametr)
    {
        if (string.IsNullOrEmpty(TextBoxUsername.UserInput) || string.IsNullOrEmpty(TextBoxPassword.UserInput)) return false;
        return true;
    }

    public void LogIn(object? parametr)
    {
        foreach (User user in Users)
        {
            if (user.Username == TextBoxUsername.UserInput && user.Password == TextBoxPassword.UserInput)
            {
                SelectedUser = user;
                HomeView homeView = new HomeView();
                homeView.DataContext = new HomeViewModel(SelectedUser);
                homeView.ShowDialog();
                
            }
        }
        
    }
    private void OnPropertyChanged([CallerMemberName]  string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
