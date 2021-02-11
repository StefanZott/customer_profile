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

namespace CustomerFile
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Variable
        private CustomerView customer;

        public MainWindow()
        {
            InitializeComponent();
        }

// _____________________________________________________________________________________________________
// |                                                                                                    |
// |                                       Menu Logic                                                   |
// |____________________________________________________________________________________________________|

        private void FileExit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

// _____________________________________________________________________________________________________
// |                                                                                                    |
// |                                       Buttons Logic                                                |
// |____________________________________________________________________________________________________|

        private void customer_Click(object sender, RoutedEventArgs e)
        {
            // Aktuelle Breite und Höhe des Frames loadNewContent.
            // diese Parameter übergebe ich dann den Objekten
            double width = loadNewContent.ActualWidth;
            double height = loadNewContent.ActualHeight;

            if(customer == null)
            {
                this.customer = new CustomerView(width, height);
                loadNewContent.Content = customer;
                
            }
        }
    }
}
