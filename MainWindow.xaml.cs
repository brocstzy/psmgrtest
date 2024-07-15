using psmgrtest.Model;
using System.Windows;
using System.Windows.Controls;

namespace psmgrtest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Company SelectedCompany = null;
        public MainWindow()
        {
            InitializeComponent();
            RefreshCompanies();
        }

        private void RefreshCompanies()
        {
            groups_ListBox.Items.Clear();
            using (PsmgrContext context = new PsmgrContext())
            {
                var companies = context.Companies.ToList();
                foreach (var  companiesItem in companies)
                {
                    groups_ListBox.Items.Add(new CompanyUserControl(companiesItem));
                }
                Button addButton = new Button()
                {
                    Content = "Добавить компанию",
                };
                addButton.Click += AddButton_Click;
                groups_ListBox.Items.Add(addButton);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            new AddCompanyWindow().Show();
        }

        public void RefreshPasswords()
        {
            if (SelectedCompany != null)
            {
                passwords_ListBox.Items.Clear();
                using (PsmgrContext context = new PsmgrContext())
                {
                    var entries = context.CompanyPasswords.Where(x => x.CompanyId == SelectedCompany.Id).ToList();
                    foreach (var entry in entries)
                    {
                        passwords_ListBox.Items.Add(new UserUserControl(entry));
                    }
                    passwords_ListBox.Items.Add(new AddPasswordUserControl());
                }
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            RefreshCompanies();
            RefreshPasswords();
        }
    }
}