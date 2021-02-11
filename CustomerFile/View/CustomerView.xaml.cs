using CustomerFile.Model;
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

namespace CustomerFile
{
    /// <summary>
    /// Interaktionslogik für Customer.xaml
    /// </summary>
    public partial class CustomerView : Page
    {
        public Customer c;
        public CustomerView(double widthFrame, double heightFrame)
        {
            InitializeComponent();

            // Beim bauen des Objekts werden die Breite wie Höhe von der ParentClass
            // des Frames verwendet.
            // Name vom Frame = loadNewContent
            this.Width = widthFrame;
            this.Height = heightFrame;
        }

        // Fürht 
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string name;

            c = new Customer("Zott", "Stefan", "Bachäcker", 21, 74676, "Niedernhall");
            name = c.firstName + " " + c.lastName;
            customerCB.Items.Add(name);

            c = new Customer("Zott", "Madeleine", "Bachäcker", 21, 74676, "Niedernhall");
            name = c.firstName + " " + c.lastName;
            customerCB.Items.Add(name);
        }
    }
}
