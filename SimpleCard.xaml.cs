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
using LiveCharts;
using LiveCharts.Wpf;

namespace Custom_Control_Demo
{
    /// <summary>
    /// Interaction logic for SimpleCard.xaml
    /// </summary>
    public partial class SimpleCard : UserControl
    {
        public SimpleCard()
        {
            InitializeComponent();
            CardGrid.DataContext = this; // Allow us to acces the bindings
        }

        public string CardTitle
        {
            set { SetValue(TitleText, value); }
        }

        public static readonly DependencyProperty TitleText =
            DependencyProperty.Register(
                "CardTitle",       // XAML/PropertyName
                typeof(string),     // the property's value type
                typeof(SimpleCard), // Bound to this custom control
                new PropertyMetadata(null)
            );


        public string CardContent
        {
            set { SetValue(ContentText, value); }
        }

        public static readonly DependencyProperty ContentText =
            DependencyProperty.Register(
                "CardContent",       // XAML/PropertyName
                typeof(string),     // the property's value type
                typeof(SimpleCard), // Bound to this custom control
                new PropertyMetadata(null)
            );


        // complete the properties:
        //      CardBackground

        public string CardBackground
        {
            set { SetValue(CardBackgroundColor, value); }
        }
        public static readonly DependencyProperty CardBackgroundColor =
           DependencyProperty.Register(
               "CardBackground",       // XAML/PropertyName
               typeof(string),     // the property's value type
               typeof(SimpleCard), // Bound to this custom control
               new PropertyMetadata(null)
           );

        //      CardBorderColour

        public string CardBorderColor
        {
            set { SetValue(BorderColor, value); }
        }
        public static readonly DependencyProperty BorderColor =
           DependencyProperty.Register(
               "CardBorderColor",       // XAML/PropertyName
               typeof(string),     // the property's value type
               typeof(SimpleCard), // Bound to this custom control
               new PropertyMetadata(null)
           );

        //      CardBorderWidth

        public string CardBorderWidth
        {
            set { SetValue(BorderWidth, value); }
        }
        public static readonly DependencyProperty BorderWidth =
           DependencyProperty.Register(
               "CardBorderWidth",       // XAML/PropertyName
               typeof(string),     // the property's value type
               typeof(SimpleCard), // Bound to this custom control
               new PropertyMetadata(null)
           );

        //      CardCornerRadius

        public string CardBorderRadius
        {
            set { SetValue(BorderRadius, value); }
        }
        public static readonly DependencyProperty BorderRadius =
           DependencyProperty.Register(
               "CardBorderRadius",       // XAML/PropertyName
               typeof(string),     // the property's value type
               typeof(SimpleCard), // Bound to this custom control
               new PropertyMetadata(null)
           );

        //      Remember to change the XAML to indlude the Bindings
    }
}
