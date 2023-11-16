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
using System.Windows.Shapes;

namespace SiTandurWPFApp
{
    /// <summary>
    /// Interaction logic for ConfirmLogOut.xaml
    /// </summary>
    public partial class ConfirmLogOut : Window
    {
        public ConfirmLogOut()
        {
            InitializeComponent();
        }

        private void KeluarBtn_Click(object sender, RoutedEventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();

            var openWindows = Application.Current.Windows.OfType<Window>().ToList();

            // Close each window
            foreach (var window in openWindows)
            {
                if (window != welcomePage)
                {
                    window.Close();
                }
            }

            welcomePage.Show();


        }

        private void TidakBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
