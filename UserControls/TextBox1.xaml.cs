using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Clients.UserControls
{
    /// <summary>
    /// Interaction logic for TextBox1.xaml
    /// </summary>
    public partial class TextBox1 : UserControl
    {
        public string Placeholder
        {
            get { return (string)GetValue(PlaceholderProperty); }
            set { SetValue(PlaceholderProperty, value); }
        }

        public static readonly DependencyProperty PlaceholderProperty =
            DependencyProperty.Register("Placeholder", typeof(string), typeof(TextBox1));

        public string UserInput
        {
            get { return (string)GetValue(UserInputProperty); }
            set { SetValue(UserInputProperty, value); }
        }

        public static readonly DependencyProperty UserInputProperty =
            DependencyProperty.Register("UserInput", typeof(string), typeof(TextBox1));


        public TextBox1()
        {
            InitializeComponent();
            //DataContext = this;
        }
        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
                tbPlaceholder.Visibility = Visibility.Visible;
            else tbPlaceholder.Visibility = Visibility.Hidden;
        }

    }
}
