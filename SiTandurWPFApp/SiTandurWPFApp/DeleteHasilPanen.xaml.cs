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
    /// Interaction logic for DeleteHasilPanen.xaml
    /// </summary>
    public partial class DeleteHasilPanen : Window
    {
        public DataTable dtDataPetani;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private NpgsqlConnection conn;
        public int idHasilPanen;

        public DeleteHasilPanen(int IDHasilPanen)
        {
            InitializeComponent();

            string connstring = "Host=34.121.118.139;port=5432;Username=adminsitandur;Password=halo123;Database=sitandur";
            conn = new NpgsqlConnection(connstring);
            idHasilPanen = IDHasilPanen;
        }

        private void HapusDataBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();

                string queryDeleteHasilPanen = @"SELECT * FROM st_delete_hasilpanen(:_hasilpanenID)";
                cmd = new NpgsqlCommand(queryDeleteHasilPanen, conn);

                cmd.Parameters.AddWithValue("_hasilpanenID", idHasilPanen);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Tanaman Berhasil Dihapus!");
                }

                conn.Close();

                PetaniDashboard petaniDashboard = new PetaniDashboard();
                petaniDashboard.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void TidakBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
