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
using LiveCharts;

namespace SiTandurWPFApp
{
    /// <summary>
    /// Interaction logic for PetaniDashboard.xaml
    /// </summary>
    public partial class PetaniDashboard : Window
    {
        public PetaniDashboard()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string Email { get; set; }

        private void DataHasilPanen_Checked(object sender, RoutedEventArgs e)
        {
            DataHasilPanenPage dataHasilPanen = new DataHasilPanenPage();
            dataHasilPanen.Email = Email;
            this.Close();
            dataHasilPanen.Show();
        }

        private void radioBtnLogOut_Checked(object sender, RoutedEventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            this.Close();
            welcomePage.Show();
        }
    }
}
