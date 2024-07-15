using psmgrtest.Model;
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

namespace psmgrtest
{
    /// <summary>
    /// Interaction logic for UserUserControl.xaml
    /// </summary>
    public partial class UserUserControl : UserControl
    {
        public CompanyPassword cp1;
        public UserUserControl(CompanyPassword cp)
        {
            InitializeComponent();
            cp1 = cp;
            RefreshThis();
        }

        private void RefreshThis()
        {
            login_TextBox.Text = cp1.Login;
            password_PasswordBox.Password = cp1.Password;
            password_TextBox.Text = cp1.Password;
        }

        private void copyLogin_Button_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(login_TextBox.Text);
        }

        private void copyPassword_Button_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(password_PasswordBox.Password);
        }

        private void togglePassword_Button_Click(object sender, RoutedEventArgs e)
        {
            if (password_TextBox.Visibility == Visibility.Collapsed)
            {
                password_PasswordBox.Visibility = Visibility.Collapsed;
                password_TextBox.Visibility = Visibility.Visible;
                
            }
            else
            {
                password_PasswordBox.Visibility = Visibility.Visible;
                password_TextBox.Visibility = Visibility.Collapsed;
            }
        }
    }
}
