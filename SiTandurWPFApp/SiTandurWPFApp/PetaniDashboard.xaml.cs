using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using LiveCharts;
using Newtonsoft.Json;

namespace SiTandurWPFApp
{
    /// <summary>
    /// Interaction logic for PetaniDashboard.xaml
    /// </summary>
    public partial class PetaniDashboard : Window
    {
        public PetaniDashboard()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string Email { get; set; }

        private void DataHasilPanen_Checked(object sender, RoutedEventArgs e)
        {
            DataHasilPanenPage dataHasilPanen = new DataHasilPanenPage();
            this.Close();
            dataHasilPanen.Show();
        }

        private void radioBtnLogOut_Checked(object sender, RoutedEventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            this.Close();
            welcomePage.Show();
        }

        string APIKey = "de654bfa63689994c449fc63b93ef46a";
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            getWeather();
        }
        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TbCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                lblConditions.Text = Info.weather[0].main;
                lblDetail.Text = Info.weather[0].description;
                lblSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
                lblSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();
                lblWindSpeed.Text = Info.wind.speed.ToString();
                lblHumidity.Text = Info.main.humidity.ToString();
            }
        }
        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            day = day.AddSeconds(millisec).ToLocalTime();
            return day;
        }
    }
}
