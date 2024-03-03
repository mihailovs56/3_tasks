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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Click(object sender, MouseButtonEventArgs e)
        {

            Button nwBt = new Button();
            nwBt.Content = "Новая кнопка";
            nwBt.Width = 100;
            nwBt.Height = 20;

            Canvas.SetLeft(nwBt, e.GetPosition(canvas).X);
            Canvas.SetTop(nwBt, e.GetPosition(canvas).Y);



            canvas.Children.Add(nwBt);
        }
    }
}
