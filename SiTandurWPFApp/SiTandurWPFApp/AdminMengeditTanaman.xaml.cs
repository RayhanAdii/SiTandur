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
    /// Interaction logic for AdminMengeditTanaman.xaml
    /// </summary>
    public partial class AdminMengeditTanaman : Window
    {

        public DataTable dtDataPetani;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private NpgsqlConnection conn;
        public int idTanaman;

        public AdminMengeditTanaman(int IDTanaman)
        {
            InitializeComponent();

            string connstring = "Host=localhost;port=5432;Username=adminsitandur;Password=halo123;Database=sitandur";
            conn = new NpgsqlConnection(connstring);
            idTanaman = IDTanaman;
        }

        private void BtnAdminSimpanEditTanaman_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();

                string queryUpdateTanaman = @"SELECT * FROM st_update_tanaman(:_tanamanid, :_namatanaman, :_hargapasar)";
                cmd = new NpgsqlCommand(queryUpdateTanaman, conn);

                cmd.Parameters.AddWithValue("_tanamanid", idTanaman);
                cmd.Parameters.AddWithValue("_namatanaman", AdminEditNamaTanaman.Text);
                int hargaPasar;
                if (int.TryParse(AdminEditHargaPasar.Text, out hargaPasar))
                {
                    cmd.Parameters.AddWithValue("_hargapasar", hargaPasar);
                }
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Tanaman Berhasil Diedit!");
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

        private void BtnAdminBatalEditTanaman_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
