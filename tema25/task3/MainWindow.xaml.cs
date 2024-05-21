using System;
using System.Windows;
using LiveCharts;
using LiveCharts.Defaults;

namespace Task3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ChartAxisStep = 0.7;
            Values = new ChartValues<ObservablePoint>();
            for (double x = -45; x <= 45; x += ChartAxisStep)
            {
                Values.Add(new ObservablePoint(x, Math.Sqrt(x)));
            }

            LineSeries.Values = Values;
        }

        public ChartValues<ObservablePoint> Values { get; set; }
        public double ChartAxisStep { get; set; }
    }
}
