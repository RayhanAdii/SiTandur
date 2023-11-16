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
    /// Interaction logic for AdminMenghapusTanaman.xaml
    /// </summary>
    public partial class AdminMenghapusTanaman : Window
    {
        public DataTable dtDataPetani;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private NpgsqlConnection conn;
        public int idTanaman;

        public AdminMenghapusTanaman(int IDTanaman)
        {
            InitializeComponent();

            string connstring = "Host=34.121.118.139;port=5432;Username=adminsitandur;Password=halo123;Database=sitandur";
            conn = new NpgsqlConnection(connstring);
            idTanaman = IDTanaman;
        }

        private void HapusDataBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();

                string queryDeleteTanaman = @"SELECT * FROM st_delete_tanaman(:_tanamanID)";
                cmd = new NpgsqlCommand(queryDeleteTanaman, conn);

                cmd.Parameters.AddWithValue("_tanamanID", idTanaman);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Tanaman Berhasil Dihapus!");
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
