using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SiTandurWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddPetanibyAdmin_Click(object sender, RoutedEventArgs e)
        {
            AdminMenambahPetaniWindow adminAddPetaniWindow = new AdminMenambahPetaniWindow();
            adminAddPetaniWindow.Show();
        }

        private void EditPetanibyAdmin_Click(object sender, RoutedEventArgs e)
        {
            AdminMengeditPetaniWindow adminEditPetaniWindow = new AdminMengeditPetaniWindow();
            adminEditPetaniWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TableComponent tableComponent = new TableComponent();
            tableComponent.Show();
        }
    }
}
