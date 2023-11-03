using System;
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
using Npgsql;

namespace SiTandurWPFApp
{
    /// <summary>
    /// Interaction logic for PetaniLoginPage.xaml
    /// </summary>
    public partial class PetaniLoginPage : Window
    {
        
        public PetaniLoginPage()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=postgres123;Database=sitandur";
        private DataTable dt;
        private NpgsqlCommand cmd;
        private string sql = null;

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(passwordBox.Password))
            //{
            //    PetaniDashboard petanidashboard = new PetaniDashboard();
            //    this.Close();
            //    petanidashboard.Show();
            //}
            try
            {
                conn.Open();
                sql = @"select * from userlogin(:_emailpetani,:_passwordpetani)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_emailpetani", txtName.Text);
                cmd.Parameters.AddWithValue("_passwordpetani", passwordBox.Password);

                int result = (int)cmd.ExecuteScalar();

                conn.Close();

                if (result == 1)
                {
                    PetaniDashboard dashboard = new PetaniDashboard();
                    DataHasilPanenPage datahasilpanen = new DataHasilPanenPage();
                    dashboard.Email = txtName.Text;
                    datahasilpanen.Email = txtName.Text;
                    this.Hide();
                    dashboard.Show();

                }
                else
                {
                    MessageBox.Show("Mohon cek email atau password", "Login Gagal", MessageBoxButton.OK);
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Something went wrong", MessageBoxButton.OK);
                conn.Close();
            }
        }

            private void txtName_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
            {
                if (!string.IsNullOrEmpty(txtName.Text) && txtName.Text.Length > 0)
                    textName.Visibility = Visibility.Collapsed;
                else
                    textName.Visibility = Visibility.Visible;
            }

            private void AdminButton_Click(object sender, RoutedEventArgs e)
            {
                AdminLoginPage adminLoginPage = new AdminLoginPage();
                this.Close();
                adminLoginPage.Show();
            }

            private void textName_MouseDown(object sender, MouseButtonEventArgs e)
            {
                txtName.Focus();
            }

            private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
            {
                passwordBox.Focus();
            }
            private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
            {
                if (!string.IsNullOrEmpty(passwordBox.Password) && passwordBox.Password.Length > 0)
                    textPassword.Visibility = Visibility.Collapsed;
                else
                    textPassword.Visibility = Visibility.Visible;
            }

        public void PetaniLoginPage_Load(object sender, RoutedEventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }


        } 
}
