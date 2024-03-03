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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void Window_ClickArrow(object sender, KeyEventArgs e)
        {
            double step = 50;
            switch (e.Key)
            {
                case Key.Up:
                    Canvas.SetTop(lb1, Canvas.GetTop(lb1) - step);
                    break;
                case Key.Down:
                    Canvas.SetTop(lb1, Canvas.GetTop(lb1) + step);
                    break;
                case Key.Left:
                    Canvas.SetLeft(lb1, Canvas.GetLeft(lb1) - step);
                    break;
                case Key.Right:
                    Canvas.SetLeft(lb1, Canvas.GetLeft(lb1) + step);
                    break;
            }
            Point point = lb1.PointToScreen(new Point(0,0));
            double x = point.X;
            double y = point.Y;
            if (point.X < 250 || point.X > 1000 || point.Y < 200 || point.Y > 502)
            {
                Canvas.SetTop(lb1, 175);
                Canvas.SetLeft(lb1, 380);
            }
            lb2.Content = point.X;
            lb3.Content = point.Y;


        }
    }
}
