using Npgsql;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for AdminMenambahPetani.xaml
    /// </summary>
    public partial class AdminMenambahPetani : Window
    {

        public DataTable dtDataPetani;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private NpgsqlConnection conn;

        public AdminMenambahPetani()
        {
            InitializeComponent();

            string connstring = "Host=localhost;port=5432;Username=adminsitandur;Password=halo123;Database=sitandur";
            conn = new NpgsqlConnection(connstring);
        }

        private void AdminAddKelompokPetani_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnAdminSimpanTambahPetani_Click(object sender, RoutedEventArgs e)
        {

            try 
            {
                conn.Open();
                string queryInsertPetani = @"select * from st_insert_petani(:_namapetani, :_emailpetani, :_alamatpetani, :_kelompoktani, :_usiapetani, :_passwordpetani)";
                cmd = new NpgsqlCommand(queryInsertPetani, conn);
                cmd.Parameters.AddWithValue("_namapetani", AdminAddNamaPetani.Text);
                cmd.Parameters.AddWithValue("_emailpetani", AdminAddEmailPetani.Text);
                cmd.Parameters.AddWithValue("_alamatpetani", AdminAddAlamatPetani.Text);
                cmd.Parameters.AddWithValue("_kelompoktani", AdminAddKelompokPetani.Text);
                int usiaPetani;
                if (int.TryParse(AdminAddUsiaPetani.Text, out usiaPetani))
                {
                    cmd.Parameters.AddWithValue("_usiapetani", usiaPetani);
                }
                cmd.Parameters.AddWithValue("_passwordpetani", AdminAddPasswordPetani.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Petani Berhasil Diinputkan!");
                }
                conn.Close();

                AdminDasbor adminDasbor = new AdminDasbor();
                adminDasbor.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void BtnAdminBatalTambahPetani_Click(object sender, RoutedEventArgs e)
        {
            AdminDasbor adminDasbor = new AdminDasbor();
            adminDasbor.Show();
            this.Close();
        }
    }
}
