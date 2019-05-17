using LiveCharts;
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
    /// Interaction logic for ChartCard.xaml
    /// </summary>
    public partial class ChartCard : UserControl
    {


        public ChartCard()
        {
            InitializeComponent();
            ChartGrid.DataContext = this;
        }

        public SeriesCollection CardChartData
        {
            get { return null; }
            set { SetValue(ChartSeriesData, value); }
        }
        
        public static readonly DependencyProperty ChartSeriesData =
            DependencyProperty.Register(
                "CardChartData",       // XAML/PropertyName
                typeof(SeriesCollection),     // the property's value type
                typeof(ChartCard), // Bound to this custom control
                new PropertyMetadata(null)
            );


        public string CardTitle
        {
            set { SetValue(TitleText, value); }
        }

        public static readonly DependencyProperty TitleText =
            DependencyProperty.Register(
                "CardTitle",       // XAML/PropertyName
                typeof(string),     // the property's value type
                typeof(ChartCard), // Bound to this custom control
                new PropertyMetadata(null)
            );
    }
}
