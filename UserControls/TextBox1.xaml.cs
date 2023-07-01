using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Clients.UserControls 
{
    /// <summary>
    /// Interaction logic for TextBox1.xaml
    /// </summary>
    public partial class TextBox1 : UserControl
    {
        public TextBox1()
        {
            InitializeComponent();
        }

        private string _placeholder;

        public string Placeholder
        {
            get { return _placeholder; }
            set 
            { 
                _placeholder = value;
                tbPlaceholder.Text = _placeholder;
            }
        }
        private string _text;

        public string UserInput
        {
            get { return _text; }
            set
            {
                _text = value;
                txtInput.Text = _text;
            }
        }



        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text))
                tbPlaceholder.Visibility = Visibility.Visible;
            else tbPlaceholder.Visibility = Visibility.Hidden;
        }
    }
}
