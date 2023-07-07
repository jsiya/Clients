using Clients.Commands;
using Clients.Models;
using Clients.Services;
using Clients.UserControls;
using Clients.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Clients.ViewModels;

public class RegisterViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    public User CurrentUser { get; set; }
    public ObservableCollection<Client> AllClients { get; set; }

    private TextBox1 _nameTextBox;
    public TextBox1 NameTextBox
    {
        get { return _nameTextBox; }
        set 
        {
            _nameTextBox = value;
            OnPropertyChanged();
        }
    }
    private TextBox1 _surnameTextBox;
    public TextBox1 SurnameTextBox
    {
        get { return _surnameTextBox; }
        set
        {
            _surnameTextBox = value;
            OnPropertyChanged();
        }
    }
    private TextBox1 _phoneTextBox;
    public TextBox1 PhoneTextBox
    {
        get { return _phoneTextBox; }
        set
        {
            _phoneTextBox = value;
            OnPropertyChanged();
        }
    }

    private TextBox1 _companyTextBox;
    public TextBox1 CompanyTextBox
    {
        get { return _companyTextBox; }
        set
        {
            _companyTextBox = value;
            OnPropertyChanged();
        }
    }

    private TextBox1 _placeTextBox;
    public TextBox1 PlaceTextBox
    {
        get { return _placeTextBox; }
        set
        {
            _placeTextBox = value;
            OnPropertyChanged();
        }
    }

    private TextBox1 _dayTextBox;
    public TextBox1 DayTextBox
    {
        get { return _dayTextBox; }
        set
        {
            _dayTextBox = value;
            OnPropertyChanged();
        }
    }

    private TextBox1 _monthTextBox;
    public TextBox1 MonthTextBox
    {
        get { return _monthTextBox; }
        set
        {
            _monthTextBox = value;
            OnPropertyChanged();
        }
    }

    private TextBox1 _yearTextBox;
    public TextBox1 YearTextBox
    {
        get { return _yearTextBox; }
        set
        {
            _yearTextBox = value;
            OnPropertyChanged();
        }
    }

    private TextBox1 _descriptionTextBox;
    public TextBox1 DescriptionTextBox
    {
        get { return _descriptionTextBox; }
        set
        {
            _descriptionTextBox = value;
            OnPropertyChanged();
        }
    }

    public ICommand? RegisterCommand { get; set; }
    public ICommand? BackToHomePageCommand { get; set; }

    public RegisterViewModel(User user, ObservableCollection<Client> clients)
    {
        AllClients = clients;
        CurrentUser = user;

        NameTextBox = new();
        SurnameTextBox = new();
        PhoneTextBox = new();
        CompanyTextBox = new();
        PhoneTextBox = new();
        PlaceTextBox = new();
        DayTextBox = new();
        MonthTextBox = new();
        YearTextBox = new();
        DescriptionTextBox = new();

        NameTextBox.Placeholder = "What is the name of the client?";
        SurnameTextBox.Placeholder = "What is the surname of the client?";
        PhoneTextBox.Placeholder = "What is the phone number of the client?";
        CompanyTextBox.Placeholder = "Which company does the person belong to?";
        PlaceTextBox.Placeholder = "Where did he/she found me?";
        DayTextBox.Placeholder = "Day";
        MonthTextBox.Placeholder = "Month";
        YearTextBox.Placeholder = "Year";
        DescriptionTextBox.Placeholder = "Write how do you know him/her";
        RegisterCommand = new RelayCommand(CreateNewClient, IsAllSectionsFilled);
        BackToHomePageCommand = new RelayCommand(BackToHome, HomeBtnCheck);
    }
    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    bool HomeBtnCheck(object? parametr)
    {
        return true;
    }
    public void BackToHome(object? parametr)
    {
        HomeView homeView = new HomeView();
        homeView.DataContext = new HomeViewModel(CurrentUser);
        homeView.ShowDialog();
    }

    public bool IsAllSectionsFilled(object? parametr)
    {
        if (string.IsNullOrEmpty(NameTextBox.UserInput) || string.IsNullOrEmpty(SurnameTextBox.UserInput) || string.IsNullOrEmpty(PhoneTextBox.UserInput)
            || string.IsNullOrEmpty(CompanyTextBox.UserInput) || string.IsNullOrEmpty(PlaceTextBox.UserInput) || string.IsNullOrEmpty(DayTextBox.UserInput)
            || string.IsNullOrEmpty(MonthTextBox.UserInput) || string.IsNullOrEmpty(YearTextBox.UserInput) || string.IsNullOrEmpty(DescriptionTextBox.UserInput)) return false;
        return true;
    }
    public void CreateNewClient(object? parametr)
    {
        Client newClient = new(Guid.NewGuid(), CurrentUser.Id, NameTextBox.UserInput, SurnameTextBox.UserInput, PhoneTextBox.UserInput, CompanyTextBox.UserInput, PlaceTextBox.UserInput, DescriptionTextBox.UserInput, 0);
        AllClients.Add(newClient);
        string folderPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "SourceDataFiles", "Clients.json");
        JsonManager<Client>.Serializer(folderPath, AllClients);

        NameTextBox.UserInput = "";
        SurnameTextBox.UserInput = "";
        PhoneTextBox.UserInput = "";
        CompanyTextBox.UserInput = "";
        PlaceTextBox.UserInput = "";
        DayTextBox.UserInput = "";
        MonthTextBox.UserInput = "";
        YearTextBox.UserInput = "";
        DescriptionTextBox.UserInput = "";
    }
}
