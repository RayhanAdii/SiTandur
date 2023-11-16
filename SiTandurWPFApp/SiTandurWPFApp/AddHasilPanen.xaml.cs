using Npgsql;
using System;
using System.Collections;
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
    /// Interaction logic for AddHasilPanen.xaml
    /// </summary>
    public partial class AddHasilPanen : Window
    {
        public DataTable dtDataPetani;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private NpgsqlConnection conn;

        public AddHasilPanen()
        {
            InitializeComponent();

            string connstring = "Host=34.121.118.139;port=5432;Username=adminsitandur;Password=halo123;Database=sitandur";
            conn = new NpgsqlConnection(connstring);
            conn.Open();

            string comboBoxPetaniQuery = @"SELECT namapetani FROM petani ";

            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(comboBoxPetaniQuery, conn))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind the DataTable to the ComboBox
                UserAddPetani.ItemsSource = dataTable.DefaultView;
                UserAddPetani.DisplayMemberPath = "namapetani";
            }

            string comboBoxTanamanQuery = @"SELECT namatanaman FROM tanaman ";

            using (NpgsqlDataAdapter adapterTanaman = new NpgsqlDataAdapter(comboBoxTanamanQuery, conn))
            {
                DataTable dataTable = new DataTable();
                adapterTanaman.Fill(dataTable);

                // Bind the DataTable to the ComboBox
                UserAddTanaman.ItemsSource = dataTable.DefaultView;
                UserAddTanaman.DisplayMemberPath = "namatanaman";
            }
        }


        private void BtnSimpanRecord_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                string queryInsertHasilPanen = @"select * from st_insert_hasilpanen(:_namatanaman, :_namapetani, :_berathasilpanen, :_lokasipanen)";
                cmd = new NpgsqlCommand(queryInsertHasilPanen, conn);
                cmd.Parameters.AddWithValue("_namatanaman", UserAddTanaman.Text);
                cmd.Parameters.AddWithValue("_namapetani", UserAddPetani.Text);
                Single beratHasilPanen;
                if (Single.TryParse(UserAddWeight.Text, out beratHasilPanen))
                {
                    cmd.Parameters.AddWithValue("_berathasilpanen", beratHasilPanen);
                }
                cmd.Parameters.AddWithValue("_lokasipanen", UserAddLocation.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Hasil Panen Berhasil Diinputkan!");
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

            this.Close();
        }

        private void BtnBatalRecord_Click(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
