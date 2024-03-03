using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private System.Windows.Threading.DispatcherTimer timer1;
        private Random random = new Random();
        public Window1()
        {
            InitializeComponent();
            timer1 = new System.Windows.Threading.DispatcherTimer();
            timer1.Interval = TimeSpan.FromSeconds(1);
            timer1.Tick += Timer1_Tick;
        }
        
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            Color rndclr1, rndclr2, rndclr3, rndclr4, rndclr5;
            do
            {
                rndclr1 = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
                rndclr2 = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
                rndclr3 = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
                rndclr4 = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
                rndclr5 = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            } 
            while (rndclr1 == rndclr2 || rndclr2 == rndclr3 || rndclr3 == rndclr4 || rndclr4 == rndclr5 || rndclr5 == rndclr1);
            b1.Background = new SolidColorBrush(rndclr1);
            b2.Background = new SolidColorBrush(rndclr2);
            b3.Background = new SolidColorBrush(rndclr3);
            b4.Background = new SolidColorBrush(rndclr4);
            b5.Background = new SolidColorBrush(rndclr5);
            color++;
        
            if (color == 255)
            {
                timer1.Stop();
                Continue();
            }
        }

        private void Continue()
        {

        }
        private byte color = 0;
    }
}
