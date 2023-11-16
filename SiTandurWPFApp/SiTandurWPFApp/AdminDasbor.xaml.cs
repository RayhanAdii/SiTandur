using Microsoft.VisualBasic;
using Npgsql;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using System.Xml.Linq;

namespace SiTandurWPFApp
{
    /// <summary>
    /// Interaction logic for AdminDasbor.xaml
    /// </summary>
    public partial class AdminDasbor : Window
    {
        public DataTable dtDataPetani;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private NpgsqlConnection conn;

        public AdminDasbor()
        {
            InitializeComponent();

            string connstring = "Host=34.121.118.139;port=5432;Username=adminsitandur;Password=halo123;Database=sitandur";
            conn = new NpgsqlConnection(connstring);


            try
            {
                conn.Open();

                //Show Petani
                DataTable dataTableShowPetani = new DataTable();
                string queryShowPetani = @"select petaniid, namapetani, kelompoktani, alamatpetani, usiapetani from petani";
                NpgsqlCommand cmdPetani = new NpgsqlCommand(queryShowPetani, conn);
                var readerPetani = cmdPetani.ExecuteReader();
                dataTableShowPetani.Load (readerPetani);

                List<Petani> petaniList = ConvertDataTableToListPetani(dataTableShowPetani);
                
                petaniDataGrid.ItemsSource = petaniList;


                //Show Tanaman
                DataTable dataTableShowTanaman = new DataTable();
                string queryShowTanaman = @"select tanamanid, namatanaman, hargapasar from tanaman";
                NpgsqlCommand cmdTanaman = new NpgsqlCommand(queryShowTanaman, conn);
                var readerTanaman= cmdTanaman.ExecuteReader();
                dataTableShowTanaman.Load(readerTanaman);

                List<Tanaman> tanamanList = ConvertDataTableToListTanaman(dataTableShowTanaman);

                tanamanDataGrid.ItemsSource = tanamanList;

                // Show AvgPetani
                string queryShowAvgPetani = @"select AVG(usiapetani) AS average_age FROM petani";
                NpgsqlCommand cmdAvg = new NpgsqlCommand(queryShowAvgPetani, conn);
                var averageAge = cmdAvg.ExecuteScalar();

                // Use 'averageAge' as needed, for example, display it in a label
                if (averageAge != DBNull.Value)
                {
                    int avgAge = Convert.ToInt32(averageAge);
                    // Do something with avgAge, e.g., display it in a label
                    RerataUsiaPetani.Content = avgAge.ToString();
                }

                // Show JumlahKelompokTani
                string queryShowJumlahKelompok = @"SELECT DISTINCT COUNT(kelompoktani) AS jumlahKelompokTani FROM petani";
                NpgsqlCommand cmdJumlah = new NpgsqlCommand(queryShowJumlahKelompok, conn);
                var JumlahKelompok = cmdJumlah.ExecuteScalar();

                if (JumlahKelompok != DBNull.Value)
                {
                    JumlahKelompokPetani.Content = JumlahKelompok.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Pak " + ex) ;
            }


        }


        private List<Petani> ConvertDataTableToListPetani(DataTable dataTable)
        {
            List<Petani> petaniList = new List<Petani>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Petani petani = new Petani
                {
                    IDPetani = (int)dr["petaniid"],
                    NamaPetani = dr["NamaPetani"].ToString(),
                    KelompokTani = dr["KelompokTani"].ToString(),
                    AlamatPetani = dr["AlamatPetani"].ToString(),
                    UsiaPetani = (int)dr["UsiaPetani"]

                };
                petaniList.Add(petani);
            }
            return petaniList;
        }

        private List<Tanaman> ConvertDataTableToListTanaman(DataTable dataTable)
        {
            List<Tanaman> tanamanList = new List<Tanaman>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Tanaman tanaman = new Tanaman
                {
                    IDTanaman = (int)dr["tanamanid"],
                    NamaTanaman = dr["namatanaman"].ToString(),
                    HargaPasar = (int)dr["hargapasar"]

                };
                tanamanList.Add(tanaman);
            }
            return tanamanList;
        }


        private void BtnAdminMenambahPetani_Click(object sender, RoutedEventArgs e)
        {
            AdminMenambahPetani adminMenambahPetani = new AdminMenambahPetani();
            this.Close();
            adminMenambahPetani.Show();
        }

        private void BtnTableUbahPetani_Click(object sender, RoutedEventArgs e)
        {
            object IDPetani = ((Button)sender).CommandParameter;

            AdminMengeditPetani adminEditPetani = new AdminMengeditPetani((int)IDPetani);
            adminEditPetani.Show();
        }

        private void petaniDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnTabelHapusPetani_Click(object sender, RoutedEventArgs e)
        {
            object IDPetani = ((Button)sender).CommandParameter;

            AdminMenghapusPetani adminMenghapusPetani = new AdminMenghapusPetani((int)IDPetani);
            this.Close();
            adminMenghapusPetani.Show();
        }

        public void Admin_Window_Loaded(object sender, RoutedEventArgs e)
        {


        }

        private void btnAdminMenambahTanaman_Click(object sender, RoutedEventArgs e)
        {
            AdminMenambahTanamanWindow adminMenambahTanamanWindow = new AdminMenambahTanamanWindow();
            this.Close();
            adminMenambahTanamanWindow.Show();
        }

 
        private void BtnTableUbahTanaman_Click(object sender, RoutedEventArgs e)
        {
            object IDTanaman = ((Button)sender).CommandParameter;

            AdminMengeditTanaman adminEditTanaman = new AdminMengeditTanaman((int)IDTanaman);
            adminEditTanaman.Show();
        }

        private void BtnTabelHapusTanaman_Click(object sender, RoutedEventArgs e)
        {
            object IDTanaman = ((Button)sender).CommandParameter;

            AdminMenghapusTanaman adminMenghapusTanaman = new AdminMenghapusTanaman((int)IDTanaman);
            this.Close();
            adminMenghapusTanaman.Show();
        }
    }
    
}

public class Petani
{
    public int IDPetani { get; set; }
    public string NamaPetani { get; set; }
    public string KelompokTani { get; set; }
    public string AlamatPetani { get; set; }
    public int UsiaPetani { get; set; }
}

public class Tanaman
{
    public int IDTanaman { get; set; }
    public string NamaTanaman { get; set; }
    public int HargaPasar { get; set; }
}