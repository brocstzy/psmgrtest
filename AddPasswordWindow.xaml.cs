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
using System.Windows.Shapes;

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
    }
}
