using OxyPlot.Series;
using OxyPlot.Wpf;
using OxyPlot;
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

namespace task2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var model = new PlotModel { Title = "График функции y=√x" };
            var series = new FunctionSeries(Math.Sqrt, 0, 10, 0.1, "√x");
            model.Series.Add(series);
            plotView.Model = model;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double step;
            if (double.TryParse(textBox.Text, out step))
            {
                plotView.Model.Series.Clear();
                var series = new FunctionSeries(Math.Sqrt, 0, 10, step, "√x");
                plotView.Model.Series.Add(series);
                plotView.InvalidatePlot(true);
            }
            else
            {
                textBlock.Text = "Неверный шаг!";
            }
        }
    }
}
