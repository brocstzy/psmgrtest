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
    /// Interaction logic for CompanyUserControl.xaml
    /// </summary>
    public partial class CompanyUserControl : UserControl
    {
        public Company Company;
        public CompanyUserControl(Company company)
        {
            InitializeComponent();
            Company = company;
            RefreshThis();
        }

        private void RefreshThis()
        {
            company_Label.Content = Company.Name;
        }

        private void UserControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Windows.OfType<MainWindow>().FirstOrDefault()!.SelectedCompany = Company;
            Application.Current.Windows.OfType<MainWindow>().FirstOrDefault()!.RefreshPasswords();
        }
    }
}
