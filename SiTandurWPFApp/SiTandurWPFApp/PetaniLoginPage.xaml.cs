using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for PetaniLoginPage.xaml
    /// </summary>
    public partial class PetaniLoginPage : Window
    {
        public PetaniLoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(passwordBox.Password))
            {
                PetaniDashboard petanidashboard = new PetaniDashboard();
                this.Close();
                petanidashboard.Show();
            }
        }

        private void txtName_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && txtName.Text.Length > 0)
                textName.Visibility = Visibility.Collapsed;
            else
                textName.Visibility = Visibility.Visible;
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            AdminLoginPage adminLoginPage = new AdminLoginPage();
            this.Close();
            adminLoginPage.Show();
        }

        private void textName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtName.Focus();
        }

        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            passwordBox.Focus();
        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(passwordBox.Password) && passwordBox.Password.Length > 0)
                textPassword.Visibility = Visibility.Collapsed;
            else
                textPassword.Visibility = Visibility.Visible;
        }

        public TableComponentHasilPanen()
        {
            InitializeComponent();

            ObservableCollection<HasilPanen> hasilPanen = new ObservableCollection<HasilPanen>();

            hasilPanen.Add(new HasilPanen
            {
                NoPanen = 1,
                TanggalPanen = "2023-10-27",
                IDPanen = "P001",
                NamaTanaman = "Padi",
                LokasiPanen = "Lahan A",
                NamaPetani = "John Doe",
                BeratHasilPanen = "100 kg",
                CatatanHasilPanen = "Good quality rice."
            });

            hasilPanen.Add(new HasilPanen
            {
                NoPanen = 2,
                TanggalPanen = "2023-10-28",
                IDPanen = "P002",
                NamaTanaman = "Jagung",
                LokasiPanen = "Lahan B",
                NamaPetani = "Jane Smith",
                BeratHasilPanen = "75 kg",
                CatatanHasilPanen = "Harvested fresh corn."
            });

            hasilPanen.Add(new HasilPanen
            {
                NoPanen = 3,
                TanggalPanen = "2023-10-29",
                IDPanen = "P003",
                NamaTanaman = "Tomat",
                LokasiPanen = "Greenhouse A",
                NamaPetani = "Sarah Johnson",
                BeratHasilPanen = "20 kg",
                CatatanHasilPanen = "Fresh and ripe tomatoes."
            });

            hasilPanen.Add(new HasilPanen
            {
                NoPanen = 4,
                TanggalPanen = "2023-10-30",
                IDPanen = "P004",
                NamaTanaman = "Wortel",
                LokasiPanen = "Garden B",
                NamaPetani = "Michael Davis",
                BeratHasilPanen = "15 kg",
                CatatanHasilPanen = "Sweet and crunchy carrots."
            });

            hasilPanen.Add(new HasilPanen
            {
                NoPanen = 5,
                TanggalPanen = "2023-10-31",
                IDPanen = "P005",
                NamaTanaman = "Cabai",
                LokasiPanen = "Farmers Market",
                NamaPetani = "Lisa Brown",
                BeratHasilPanen = "10 kg",
                CatatanHasilPanen = "Spicy chili peppers."
            });


            hasilPanenDataGrid.ItemsSource = hasilPanen;
        }

        private void BtnTabelUbahHasilPanen_Click(object sender, RoutedEventArgs e)
        {
            // Ini Diganti ke winforms edit petani
            AdminMengeditPetaniWindow adminEditPetaniWindow = new AdminMengeditPetaniWindow();
            adminEditPetaniWindow.Show();
        }


    }

}
}
