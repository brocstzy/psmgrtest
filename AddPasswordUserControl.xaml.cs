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
    /// Interaction logic for AddPasswordUserControl.xaml
    /// </summary>
    public partial class AddPasswordUserControl : UserControl
    {
        public AddPasswordUserControl()
        {
            InitializeComponent();
        }

        private void addPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            new AddPasswordWindow(Application.Current.Windows.OfType<MainWindow>().FirstOrDefault()!.SelectedCompany) { Owner = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault()!}.ShowDialog();
        }
    }
}
