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
    /// Interaction logic for AdminMengeditPetaniWindow.xaml
    /// </summary>
    public partial class AdminMengeditPetaniWindow : Window
    {
        public AdminMengeditPetaniWindow(int IDPetani)
        {
            InitializeComponent();
        }

        private void BtnAdminSimpanEditPetani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAdminBatalEditPetani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
