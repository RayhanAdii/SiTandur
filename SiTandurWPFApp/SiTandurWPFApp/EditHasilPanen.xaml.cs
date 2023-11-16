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
    /// Interaction logic for EditHasilPanen.xaml
    /// </summary
    /// 
    public partial class EditHasilPanen : Window
    {
        public DataTable dtDataPetani;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private NpgsqlConnection conn;
        public int idHasilPanen;

        public EditHasilPanen(int IDHasilPanen)
        {
            InitializeComponent();

            string connstring = "Host=34.121.118.139;port=5432;Username=adminsitandur;Password=halo123;Database=sitandur";
            conn = new NpgsqlConnection(connstring);
            idHasilPanen = IDHasilPanen;

            string comboBoxPetaniQuery = @"SELECT namapetani FROM petani ";

            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(comboBoxPetaniQuery, conn))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the DataTable to the ComboBox
                UserEditPetani.ItemsSource = dataTable.DefaultView;
                UserEditPetani.DisplayMemberPath = "namapetani";
            }

            string comboBoxTanamanQuery = @"SELECT namatanaman FROM tanaman ";

            using (NpgsqlDataAdapter adapterTanaman = new NpgsqlDataAdapter(comboBoxTanamanQuery, conn))
            {
                DataTable dataTable = new DataTable();
                adapterTanaman.Fill(dataTable);

                // Bind the DataTable to the ComboBox
                UserEditTanaman.ItemsSource = dataTable.DefaultView;
                UserEditTanaman.DisplayMemberPath = "namatanaman";
            }
        }

        private void BtnSimpanEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();

                string queryUpdateHasilPanen = @"SELECT * FROM st_update_hasilpanen(:_hasilpanenid, :_namatanaman, :_namapetani, :_berathasilpanen, :_lokasipanen)";
                cmd = new NpgsqlCommand(queryUpdateHasilPanen, conn);

                cmd.Parameters.AddWithValue("_hasilpanenid", idHasilPanen);
                cmd.Parameters.AddWithValue("_namatanaman", UserEditTanaman.Text);
                cmd.Parameters.AddWithValue("_namapetani", UserEditPetani.Text);
                int beratHasilPanen;
                if (int.TryParse(UserEditWeight.Text, out beratHasilPanen))
                {
                    cmd.Parameters.AddWithValue("_berathasilpanen", beratHasilPanen);
                }
                cmd.Parameters.AddWithValue("_lokasipanen", UserEditLocation.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Tanaman Berhasil Diedit!");
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

        private void BtnBatalEdit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
