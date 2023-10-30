using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for AdminDasbor.xaml
    /// </summary>
    public partial class AdminDasbor : Window
    {
        public AdminDasbor()
        {
            InitializeComponent();

            ObservableCollection<Petani> petani = new ObservableCollection<Petani>();

            petani.Add(new Petani { IDPetani = 1, NamaPetani = "John Doe", KelompokTani = "Farmers Group A", AlamatPetani = "123 Main St", UsiaPetani = "35" });
            petani.Add(new Petani { IDPetani = 2, NamaPetani = "Jane Smith", KelompokTani = "Farmers Group B", AlamatPetani = "456 Elm St", UsiaPetani = "28" });
            petani.Add(new Petani { IDPetani = 3, NamaPetani = "Bob Johnson", KelompokTani = "Farmers Group A", AlamatPetani = "789 Oak St", UsiaPetani = "42" });
            petani.Add(new Petani { IDPetani = 4, NamaPetani = "Alice Brown", KelompokTani = "Farmers Group C", AlamatPetani = "101 Pine St", UsiaPetani = "55" });
            petani.Add(new Petani { IDPetani = 5, NamaPetani = "Charlie Lee", KelompokTani = "Farmers Group B", AlamatPetani = "202 Cedar St", UsiaPetani = "30" });
            petani.Add(new Petani { IDPetani = 6, NamaPetani = "Handoko", KelompokTani = "Umbul Makmur", AlamatPetani = "Umbul Makmur No 12", UsiaPetani = "32" });

            petaniDataGrid.ItemsSource = petani;
        }

        private void BtnAdminMenambahPetani_Click(object sender, RoutedEventArgs e)
        {
            AdminMenambahPetaniWindow adminMenambahPetaniWindow = new AdminMenambahPetaniWindow();
            adminMenambahPetaniWindow.Show();
        }

        private void BtnTableUbahPetani_Click(object sender, RoutedEventArgs e)
        {
            AdminMengeditPetaniWindow adminEditPetaniWindow = new AdminMengeditPetaniWindow();
            adminEditPetaniWindow.Show();
        }

        private void petaniDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnTabelHapusPetani_Click(object sender, RoutedEventArgs e)
        {
            AdminHapusData adminHapusData = new AdminHapusData();
            adminHapusData.Show();
        }


    }
    
}

public class Petani
{
    public int IDPetani { get; set; }
    public string NamaPetani { get; set; }
    public string KelompokTani { get; set; }
    public string AlamatPetani { get; set; }
    public string UsiaPetani { get; set; }
}