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

namespace SiTandurWPFApp
{
    /// <summary>
    /// Interaction logic for DataHasilPanenPage.xaml
    /// </summary>
    public partial class DataHasilPanenPage : Window
    {
        public DataHasilPanenPage()
        {
            InitializeComponent();
        }

        private void DasborBtn_Checked(object sender, RoutedEventArgs e)
        {
            PetaniDashboard petaniDashboard = new PetaniDashboard();
            this.Close();
            petaniDashboard.Show();
        }
    }
}
