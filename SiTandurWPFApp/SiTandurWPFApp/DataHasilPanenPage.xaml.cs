using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Numerics;
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
        public DataTable dtDataHasilPanen;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private NpgsqlConnection conn;

        private void DasborBtn_Checked(object sender, RoutedEventArgs e)
        {

            PetaniDashboard petaniDashboard = new PetaniDashboard();
            this.Close();
            petaniDashboard.Show();
        }

        public DataHasilPanenPage()
        {
            InitializeComponent();

            string connstring = "Host=localhost;port=5432;Username=adminsitandur;Password=halo123;Database=sitandur";
            conn = new NpgsqlConnection(connstring);


            try
            {
                conn.Open();

                //Show Hasil Panen
                DataTable dataTableShowHasilPanen = new DataTable();
                string queryShowHasilPanen = @"select hasilpanenid, tanaman.namatanaman,lokasipanen, petani.namapetani, berathasilpanen, DATE(tanggalpanen) AS tanggalonlypanen, tanaman.hargapasar,  (berathasilpanen * tanaman.hargapasar) AS hargajual from hasilpanen 
                                                                         JOIN tanaman ON hasilpanen.tanamanid = tanaman.tanamanid
                                                                         JOIN petani ON hasilpanen.petaniid = petani.petaniid";
                NpgsqlCommand cmdHasilPanen = new NpgsqlCommand(queryShowHasilPanen, conn);
                var readerHasilPanen = cmdHasilPanen.ExecuteReader();
                dataTableShowHasilPanen.Load(readerHasilPanen);

                List<HasilPanen> hasilPanenList = ConvertDataTableToListHasilPanen(dataTableShowHasilPanen);

                hasilPanenDataGrid.ItemsSource = hasilPanenList;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Pak, ini errornya: " + ex);
            }

        }

        private void BtnTabelTambahHasilPanen_Click(object sender, RoutedEventArgs e)
        {
            // Ini Diganti ke winforms edit petani
            AddHasilPanen addHasilPanen = new AddHasilPanen();
            addHasilPanen.Show();
        }

        private void BtnTabelUbahHasilPanen_Click(object sender, RoutedEventArgs e)
        {
            object IDHasilPanen = ((Button)sender).CommandParameter;

            EditHasilPanen editHasilPanen = new EditHasilPanen((int)IDHasilPanen);
            editHasilPanen.Show();
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
        private List<HasilPanen> ConvertDataTableToListHasilPanen(DataTable dataTable)
        {
            List<HasilPanen> hasilPanenList = new List<HasilPanen>();
            foreach (DataRow dr in dataTable.Rows)
            {
                HasilPanen hasilPanen = new HasilPanen
                {
                    IDHasilPanen = (int)dr["hasilpanenid"],
                    TanggalPanen = DateTime.Parse(dr["tanggalonlypanen"].ToString()),
                    NamaTanaman = dr["NamaTanaman"].ToString(),
                    LokasiPanen = dr["LokasiPanen"].ToString(),
                    NamaPetani = dr["NamaPetani"].ToString(),
                    BeratHasilPanen = (float)dr["BeratHasilPanen"],
                    HargaPasar = (int)dr["HargaPasar"],
                    HargaJual = (double)dr["HargaJual"]


                };
                hasilPanenList.Add(hasilPanen);
            }
            return hasilPanenList;
        }
    }
}

public class HasilPanen
{
    public int IDHasilPanen { get; set; }
    public DateTime TanggalPanen { get; set; }
    public string NamaTanaman { get; set; }
    public string LokasiPanen { get; set; }
    public string NamaPetani { get; set; }
    public float BeratHasilPanen { get; set; }
    public int HargaPasar { get; set; }
    public double HargaJual { get; set; }
}


