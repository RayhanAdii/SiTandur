using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiTandurWPFApp
{
    public class MyViewModel : INotifyPropertyChanged
    {
        public SeriesCollection SeriesCollection { get; set; }

        public MyViewModel()
        {
            // Initialize your SeriesCollection with data (e.g., ColumnSeries, LineSeries, etc.)
            SeriesCollection = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = "Series 1",
                        Values = new ChartValues<double> { 10, 20, 30, 40, 50 }
                    },
                    new ColumnSeries
                    {
                        Title = "Series 2",
                        Values = new ChartValues<double> { 5, 15, 25, 35, 45 }
                    }
                };

        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Implement INotifyPropertyChanged for property change notifications
    }

}

