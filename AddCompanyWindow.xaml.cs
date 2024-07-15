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
    /// Interaction logic for AddCompanyWindow.xaml
    /// </summary>
    public partial class AddCompanyWindow : Window
    {
        public AddCompanyWindow()
        {
            InitializeComponent();
        }

        private void addCompany_Button_Click(object sender, RoutedEventArgs e)
        {
            using (PsmgrContext context = new PsmgrContext())
            {
                context.Companies.Add(new Company(companyName_TextBox.Text));
                context.SaveChanges();
                this.Close();
            }
        }
    }
}
