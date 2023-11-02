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
    /// Interaction logic for AdminMenambahTanamanWindow.xaml
    /// </summary>
    public partial class AdminMenambahTanamanWindow : Window
    {
        public DataTable dtDataPetani;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private NpgsqlConnection conn;

        public AdminMenambahTanamanWindow()
        {
            InitializeComponent();

            string connstring = "Host=localhost;port=5432;Username=adminsitandur;Password=halo123;Database=sitandur";
            conn = new NpgsqlConnection(connstring);
        }

        private void BtnAdminSimpanTambahTanaman_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                string queryInsertTanaman = @"select * from st_insert_tanaman(:_namatanaman, :_hargapasar)";
                cmd = new NpgsqlCommand(queryInsertTanaman, conn);
                cmd.Parameters.AddWithValue("_namatanaman", AdminAddNamaTanaman.Text);
                int hargaPasar;
                if (int.TryParse(AdminAddHargaPasar.Text, out hargaPasar))
                {
                    cmd.Parameters.AddWithValue("_hargapasar", hargaPasar);
                }

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Tanaman Berhasil Diinputkan!");
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

        private void BtnAdminBatalTambahTanaman_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
