using System.Windows;
using System.Windows.Controls;

namespace Clients.UserControls;

/// <summary>
/// Interaction logic for ClientInfoCard.xaml
/// </summary>
public partial class ClientInfoCard : UserControl
{
    public string Name
    {
        get { return (string)GetValue(NameProperty); }
        set { SetValue(NameProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty NameProperty =
        DependencyProperty.Register("Name", typeof(string), typeof(ClientInfoCard));

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

    public ClientInfoCard()
    {
        InitializeComponent();
    }
}
