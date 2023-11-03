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
    /// Interaction logic for DataHasilPanenPage.xaml
    /// </summary>
    public partial class DataHasilPanenPage : Window
    {
        private void DasborBtn_Checked(object sender, RoutedEventArgs e)
        {

            PetaniDashboard petaniDashboard = new PetaniDashboard();
            petaniDashboard.Email = Email;
            this.Close();
            petaniDashboard.Show();
        }

        
        public DataHasilPanenPage()
        {
            InitializeComponent();
            this.DataContext = this;

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
            });


            hasilPanenDataGrid.ItemsSource = hasilPanen;
        }

        public string Email { get; set; }

        private void BtnTabelTambahHasilPanen_Click(object sender, RoutedEventArgs e)
        {
            AddHasilPanen addHasilPanen = new AddHasilPanen();
            addHasilPanen.Show();
        }

        private void BtnTabelUbahHasilPanen_Click(object sender, RoutedEventArgs e)
        {
            AddHasilPanen addHasilPanen = new AddHasilPanen();
            addHasilPanen.Show();
        }

        private void BtnTabelHapusPetani_Click(object sender, RoutedEventArgs e)
        {
            AddHasilPanen addHasilPanen = new AddHasilPanen();
            addHasilPanen.Show();
        }

        private void petaniDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnTambahHasilPanen_Click(object sender, RoutedEventArgs e)
        {
            AddHasilPanen addHasilPanen = new AddHasilPanen();
            addHasilPanen.Show();
        }

        private void BtnPetaniMenambahHasilPanen_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void radioBtnLogOut_Checked(object sender, RoutedEventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            this.Close();
            welcomePage.Show();
        }
    }
}

public class HasilPanen
{
    public int NoPanen { get; set; }
    public string TanggalPanen { get; set; }
    public string IDPanen { get; set; }
    public string NamaTanaman { get; set; }
    public string LokasiPanen { get; set; }
    public string NamaPetani { get; set; }
    public string BeratHasilPanen { get; set; }
    public string CatatanHasilPanen { get; set; }
}
