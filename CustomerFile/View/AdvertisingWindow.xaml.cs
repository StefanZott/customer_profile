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
using System.Windows.Threading;

namespace CustomerFile
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class AdvertisingWindow : Window
    {

        private DispatcherTimer timer;
        private int increment;
        private MainWindow mW;
        public AdvertisingWindow()
        {
            InitializeComponent();

        }

        private void windowLoaded(object sender, EventArgs e)
        {
            // Erstelle ein Object DispatchTimer
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timerTicker;
            timer.Start();
        }

        private void timerTicker(object sender, EventArgs e)
        {
            increment++;

            if(increment == 5)
            {
                this.Hide();
                mW = new MainWindow();
                mW.Show();
                this.Close();
            }
        }
    }
}
