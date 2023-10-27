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
    /// Interaction logic for AddHasilPanen.xaml
    /// </summary>
    public partial class AddHasilPanen : Window
    {
        public AddHasilPanen()
        {
            InitializeComponent();
        }

        private void BtnSimpanRecord_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnBatalRecord_Click(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
