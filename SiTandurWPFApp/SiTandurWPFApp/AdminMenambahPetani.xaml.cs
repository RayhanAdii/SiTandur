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
    /// Interaction logic for AdminMenambahPetani.xaml
    /// </summary>
    public partial class AdminMenambahPetani : Window
    {
        public AdminMenambahPetani()
        {
            InitializeComponent();
        }

        private void AdminAddKelompokPetani_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnAdminSimpanTambahPetani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAdminBatalTambahPetani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
