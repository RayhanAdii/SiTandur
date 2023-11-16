using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for AdminLoginPage.xaml
    /// </summary>
    public partial class AdminLoginPage : Window
    {
        public AdminLoginPage()
        {
            InitializeComponent();
        }

        private void PetaniButton_Click(object sender, RoutedEventArgs e)
        {
            // Create a new instance of the UserLoginPage window
            PetaniLoginPage petaniLoginPage = new PetaniLoginPage();

            //close current window
            this.Close();

            // Show the new window
            petaniLoginPage.Show();

        }

        private NpgsqlConnection conn;
        string connstring = "Host=34.121.118.139;port=5432;Username=adminsitandur;Password=halo123;Database=sitandur";
        private DataTable dt;
        private NpgsqlCommand cmd;
        private string sql = null;

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn = new NpgsqlConnection(connstring);

                conn.Open();
                sql = @"select * from adminlogin(:_emailadministrator,:_passwordadministrator)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_emailadministrator", txtName.Text);
                cmd.Parameters.AddWithValue("_passwordadministrator", passwordBox.Password);

                int result = (int)cmd.ExecuteScalar();

                conn.Close();

                if (result == 1)
                {
                    AdminDasbor admindashboard = new AdminDasbor();
                    this.Hide();
                    admindashboard.Show();

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
    }
}
