using Clients.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Clients.UserControls;

/// <summary>
/// Interaction logic for ClientInfoCard.xaml
/// </summary>
public partial class ClientInfoCard : UserControl
{
    public ICommand MoreCommand
    {
        get { return (ICommand)GetValue(MoreCommandProperty); }
        set { SetValue(MoreCommandProperty, value); }
    }

    // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty MoreCommandProperty =
        DependencyProperty.Register("MoreCommand", typeof(int), typeof(ClientInfoCard));


    public string Fullname
    {
        get { return (string)GetValue(FullnameProperty); }
        set { SetValue(FullnameProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty FullnameProperty =
        DependencyProperty.Register("Fullname", typeof(string), typeof(ClientInfoCard));

    public string Company
    {
        get { return (string)GetValue(CompanyProperty); }
        set { SetValue(CompanyProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty CompanyProperty =
        DependencyProperty.Register("Company", typeof(string), typeof(ClientInfoCard));

    public string Phone
    {
        get { return (string)GetValue(PhoneProperty); }
        set { SetValue(PhoneProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty PhoneProperty =
        DependencyProperty.Register("Phone", typeof(string), typeof(ClientInfoCard));

    public string Order
    {
        get { return (string)GetValue(OrderProperty); }
        set { SetValue(OrderProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty OrderProperty =
        DependencyProperty.Register("Order", typeof(string), typeof(ClientInfoCard));

    public string UndeliveredOrderCount
    {
        get { return (string)GetValue(UndeliveredOrderCountProperty); }
        set { SetValue(UndeliveredOrderCountProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty UndeliveredOrderCountProperty =
        DependencyProperty.Register("UndeliveredOrderCount", typeof(string), typeof(ClientInfoCard));

    public Client SelectedClient
    {
        get { return (Client)GetValue(SelectedClientProperty); }
        set { SetValue(SelectedClientProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty SelectedClientProperty =
        DependencyProperty.Register("SelectedClient", typeof(Client), typeof(ClientInfoCard));

    public ClientInfoCard()
    {
        InitializeComponent();
    }
}
