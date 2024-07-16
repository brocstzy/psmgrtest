using psmgrtest.Model;
using System.Windows;
using System.Windows.Input;

namespace psmgrtest
{
    /// <summary>
    /// Interaction logic for AddPasswordWindow.xaml
    /// </summary>
    public partial class AddPasswordWindow : Window
    {
        public Company Company;
        public AddPasswordWindow(Company company)
        {
            InitializeComponent();
            Company = company;
            company_TextBox.Text = Company.Name;
        }

        private void addPassword_Button_Click(object sender, RoutedEventArgs e)
        {
            using (PsmgrContext context = new PsmgrContext())
            {
                context.CompanyPasswords.Add(new CompanyPassword(Company.Id, login_TextBox.Text, password_TextBox.Text));
                context.SaveChanges();
                this.Close();
            }
        }

        private void password_TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                addPassword_Button_Click(null, null);
            }
        }
    }
}
