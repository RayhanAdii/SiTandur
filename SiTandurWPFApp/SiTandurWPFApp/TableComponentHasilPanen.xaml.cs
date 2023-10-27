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
    /// Interaction logic for TableComponentHasilPanen.xaml
    /// </summary>
    public partial class TableComponentHasilPanen : Window
    {
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