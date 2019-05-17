using LiveCharts;
using LiveCharts.Wpf;
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

namespace Custom_Control_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SeriesCollection ChartSeries;
        public string[] Labels;

        public MainWindow()
        {
            InitializeComponent();
            DisplayChart();
        }

        public void DisplayChart()
        {
            ChartSeries = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<int> {3,9,2,7},
                    Title="Small",
                    LineSmoothness=0
                },
                new LineSeries
                {
                    Values = new ChartValues<int> {5,11,4,9},
                    Title="Big",
                    LineSmoothness=.5,
                }
            };

            Labels = new[] { "Jan", "Feb", "Mar", "Apr" };

            ChartControl.CardChartData = ChartSeries;

            ChartSeries.Add(new LineSeries
            {
                Values = new ChartValues<int> { 1, -7, -1, 5 },
                Title = "Medium",
                LineSmoothness = 1,
                PointGeometry = DefaultGeometries.Square,
                PointGeometrySize = 15
            });

            ChartSeries[0].Values.Add(0);
            ChartSeries[1].Values.Add(10);
            ChartSeries[2].Values.Add(12);
        }
    }
}
