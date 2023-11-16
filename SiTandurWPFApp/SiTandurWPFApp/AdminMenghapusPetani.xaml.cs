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
    /// Interaction logic for AdminMenghapusPetani.xaml
    /// </summary>
    public partial class AdminMenghapusPetani : Window
    {
        public DataTable dtDataPetani;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private NpgsqlConnection conn;
        public int idPetani;

        public AdminMenghapusPetani(int IDPetani)
        {
            InitializeComponent();

            string connstring = "Host=localhost;port=5432;Username=adminsitandur;Password=halo123;Database=sitandur";
            conn = new NpgsqlConnection(connstring);
            idPetani = IDPetani;
        }

        private void HapusDataBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();

                string queryDeletePetani = @"SELECT * FROM st_delete_petani(:_petaniID)";
                cmd = new NpgsqlCommand(queryDeletePetani, conn);

                cmd.Parameters.AddWithValue("_petaniID", idPetani);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Petani Berhasil Dihapus!");
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

        private void TidakBtn_Click(object sender, RoutedEventArgs e)
        {
            AdminDasbor adminDasbor = new AdminDasbor();
            adminDasbor.Show();
            this.Close();
        }
    }
}
