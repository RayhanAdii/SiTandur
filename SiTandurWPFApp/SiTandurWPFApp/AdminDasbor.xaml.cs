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

            string connstring = "Host=localhost;port=5432;Username=adminsitandur;Password=halo123;Database=sitandur";
            conn = new NpgsqlConnection(connstring);
            
            

            try
            {
                conn.Open();

                DataTable dataTable = new DataTable();
                //string query = @"select * from st_select_petani()";
                string query = @"select petaniid, namapetani, kelompoktani, alamatpetani, usiapetani from petani";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                var reader = cmd.ExecuteReader();
                dataTable.Load (reader);

                List<Petani> petaniList = ConvertDataTableToList(dataTable);
                
                petaniDataGrid.ItemsSource = petaniList;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Pak" + ex) ;
            }


        }



        private List<Petani> ConvertDataTableToList(DataTable dataTable)
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

        //private DataGridView r;

        private void BtnAdminMenambahPetani_Click(object sender, RoutedEventArgs e)
        {
            AdminMenambahPetani adminMenambahPetani = new AdminMenambahPetani();
            adminMenambahPetani.Show();
        }

        private void BtnTableUbahPetani_Click(object sender, RoutedEventArgs e)
        {
            AdminMengeditPetaniWindow adminEditPetaniWindow = new AdminMengeditPetaniWindow();
            adminEditPetaniWindow.Show();
        }

        private void petaniDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnTabelHapusPetani_Click(object sender, RoutedEventArgs e)
        {
            AdminHapusData adminHapusData = new AdminHapusData();
            adminHapusData.Show();
        }

        public void Admin_Window_Loaded(object sender, RoutedEventArgs e)
        {


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