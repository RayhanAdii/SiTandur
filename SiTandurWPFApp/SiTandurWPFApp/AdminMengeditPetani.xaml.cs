using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for AdminMengeditPetani.xaml
    /// </summary>
    public partial class AdminMengeditPetani : Window
    {

        public DataTable dtDataPetani;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private NpgsqlConnection conn;
        public int idPetani;

        //public static int IDPetani { get; private set; }

        public AdminMengeditPetani(int IDPetani)
        {
            InitializeComponent();

            string connstring = "Host=34.121.118.139;port=5432;Username=adminsitandur;Password=halo123;Database=sitandur";
            conn = new NpgsqlConnection(connstring);
            idPetani = IDPetani;
    }

    
    
        private void BtnAdminSimpanEditPetani_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
                conn.Open();

                string queryUpdatePetani = @"SELECT * FROM st_update_petani(:_petaniid, :_namapetani, :_emailpetani, :_alamatpetani, :_kelompoktani, :_usiapetani, :_passwordpetani)";
                cmd = new NpgsqlCommand(queryUpdatePetani, conn);

                cmd.Parameters.AddWithValue("_petaniid", idPetani);
                cmd.Parameters.AddWithValue("_namapetani", AdminEditNamaPetani.Text);
                cmd.Parameters.AddWithValue("_emailpetani", AdminEditEmailPetani.Text);
                cmd.Parameters.AddWithValue("_alamatpetani", AdminEditAlamatPetani.Text);
                cmd.Parameters.AddWithValue("_kelompoktani", AdminEditKelompokPetani.Text);
                int usiaPetani;
                if (int.TryParse(AdminEditUsiaPetani.Text, out usiaPetani))
                {
                    cmd.Parameters.AddWithValue("_usiapetani", usiaPetani);
                }
                cmd.Parameters.AddWithValue("_passwordpetani", AdminEditPasswordPetani.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Petani Berhasil Diedit!");
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

        private void BtnAdminBatalEditPetani_Click(object sender, RoutedEventArgs e)
        {
            AdminDasbor adminDasbor = new AdminDasbor();
            adminDasbor.Show();
            this.Close();
        }
    }
}
