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
using PhysProject_Kirgof.ViewModels;

namespace PhysProject_Kirgof
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Line myLineR1no = new Line
        {
            Visibility = Visibility.Hidden,
            Stroke = System.Windows.Media.Brushes.Black,
            X1 = 245,
            X2 = 285,
            Y1 = 150,
            Y2 = 150
        };

        Line myLineR1yes1 = new Line
        {
            Stroke = System.Windows.Media.Brushes.Black,
            X1 = 245,
            X2 = 245,
            Y1 = 140,
            Y2 = 160
        };

        Line myLineR1yes2 = new Line
        {
            Stroke = System.Windows.Media.Brushes.Black,
            X1 = 285,
            X2 = 285,
            Y1 = 140,
            Y2 = 160
        };

        Line myLineR1yes3 = new Line
        {
            Stroke = System.Windows.Media.Brushes.Black,
            X1 = 244,
            X2 = 286,
            Y1 = 160,
            Y2 = 160
        };

        Line myLineR1yes4 = new Line
        {
            Stroke = System.Windows.Media.Brushes.Black,
            X1 = 244,
            X2 = 286,
            Y1 = 140,
            Y2 = 140
        };

        Line myLineR3no = new Line
        {
            Visibility = Visibility.Hidden,
            Stroke = System.Windows.Media.Brushes.Black,
            X1 = 300,
            X2 = 300,
            Y1 = 180,
            Y2 = 220
        };

        Line myLineR3yes1 = new Line
        {
            Stroke = System.Windows.Media.Brushes.Black,
            X1 = 290,
            X2 = 310,
            Y1 = 180,
            Y2 = 180
        };

        Line myLineR3yes2 = new Line
        {
            Stroke = System.Windows.Media.Brushes.Black,
            X1 = 290,
            X2 = 310,
            Y1 = 220,
            Y2 = 220
        };

        Line myLineR3yes3 = new Line
        {
            Stroke = System.Windows.Media.Brushes.Black,
            X1 = 291,
            X2 = 291,
            Y1 = 180,
            Y2 = 220
        };

        Line myLineR3yes4 = new Line
        {
            Stroke = System.Windows.Media.Brushes.Black,
            X1 = 309,
            X2 = 309,
            Y1 = 180,
            Y2 = 220
        };

        Line myLineR2no = new Line
        {
            Visibility = Visibility.Hidden,
            Stroke = System.Windows.Media.Brushes.Black,
            X1 = 315,
            X2 = 355,
            Y1 = 250,
            Y2 = 250
        };

        Line myLineR2yes1 = new Line
        {
            Stroke = System.Windows.Media.Brushes.Black,
            X1 = 315,
            X2 = 315,
            Y1 = 240,
            Y2 = 260
        };

        Line myLineR2yes2 = new Line
        {
            Stroke = System.Windows.Media.Brushes.Black,
            X1 = 355,
            X2 = 355,
            Y1 = 240,
            Y2 = 260
        };

        Line myLineR2yes3 = new Line
        {
            Stroke = System.Windows.Media.Brushes.Black,
            X1 = 314,
            X2 = 356,
            Y1 = 240,
            Y2 = 240
        };

        Line myLineR2yes4 = new Line
        {
            Stroke = System.Windows.Media.Brushes.Black,
            X1 = 314,
            X2 = 356,
            Y1 = 260,
            Y2 = 260
        };
       
        public MainWindow()
        {

            InitializeComponent();
            myCanvas.Children.Add(myLineR1no);
            myCanvas.Children.Add(myLineR1yes1);
            myCanvas.Children.Add(myLineR1yes2);
            myCanvas.Children.Add(myLineR1yes3);
            myCanvas.Children.Add(myLineR1yes4);
            myCanvas.Children.Add(myLineR2no);
            myCanvas.Children.Add(myLineR2yes1);
            myCanvas.Children.Add(myLineR2yes2);
            myCanvas.Children.Add(myLineR2yes3);
            myCanvas.Children.Add(myLineR2yes4);
            myCanvas.Children.Add(myLineR3no);
            myCanvas.Children.Add(myLineR3yes1);
            myCanvas.Children.Add(myLineR3yes2);
            myCanvas.Children.Add(myLineR3yes3);
            myCanvas.Children.Add(myLineR3yes4);

        }

        private void CheckBoxR1_Checked(object sender, RoutedEventArgs e)
        {
            myLineR1no.Visibility = Visibility.Hidden;
            myLineR1yes1.Visibility = Visibility.Visible;
            myLineR1yes2.Visibility = Visibility.Visible;
            myLineR1yes3.Visibility = Visibility.Visible;
            myLineR1yes4.Visibility = Visibility.Visible;
            if (label1 != null) label1.Visibility = Visibility.Visible;
            R1.IsEnabled = true;
        }

        private void CheckBoxR1_UnChecked(object sender, RoutedEventArgs e)
        {
            myLineR1no.Visibility = Visibility.Visible;
            myLineR1yes1.Visibility = Visibility.Hidden;
            myLineR1yes2.Visibility = Visibility.Hidden;
            myLineR1yes3.Visibility = Visibility.Hidden;
            myLineR1yes4.Visibility = Visibility.Hidden;
            if (label1 != null) label1.Visibility = Visibility.Hidden;
            R1.IsEnabled = false;
        }

        private void CheckBoxR2_Checked(object sender, RoutedEventArgs e)
        {
            myLineR2no.Visibility = Visibility.Hidden;
            myLineR2yes1.Visibility = Visibility.Visible;
            myLineR2yes2.Visibility = Visibility.Visible;
            myLineR2yes3.Visibility = Visibility.Visible;
            myLineR2yes4.Visibility = Visibility.Visible;
            if (label2 != null) label2.Visibility = Visibility.Visible;
            R2.IsEnabled = true;
        }

        private void CheckBoxR2_UnChecked(object sender, RoutedEventArgs e)
        {
            myLineR2no.Visibility = Visibility.Visible;
            myLineR2yes1.Visibility = Visibility.Hidden;
            myLineR2yes2.Visibility = Visibility.Hidden;
            myLineR2yes3.Visibility = Visibility.Hidden;
            myLineR2yes4.Visibility = Visibility.Hidden;
            if (label2 != null) label2.Visibility = Visibility.Hidden;
            R2.IsEnabled = false;
        }

        private void CheckBoxR3_Checked(object sender, RoutedEventArgs e)
        {
            myLineR3no.Visibility = Visibility.Hidden;
            myLineR3yes1.Visibility = Visibility.Visible;
            myLineR3yes2.Visibility = Visibility.Visible;
            myLineR3yes3.Visibility = Visibility.Visible;
            myLineR3yes4.Visibility = Visibility.Visible;
            if (label != null) label.Visibility = Visibility.Visible;
            R3.IsEnabled = true;
        }

        private void CheckBoxR3_UnChecked(object sender, RoutedEventArgs e)
        {
            myLineR3no.Visibility = Visibility.Visible;
            myLineR3yes1.Visibility = Visibility.Hidden;
            myLineR3yes2.Visibility = Visibility.Hidden;
            myLineR3yes3.Visibility = Visibility.Hidden;
            myLineR3yes4.Visibility = Visibility.Hidden;
            if (label != null) label.Visibility = Visibility.Hidden;
            R3.IsEnabled = false;
        }
    }
}
