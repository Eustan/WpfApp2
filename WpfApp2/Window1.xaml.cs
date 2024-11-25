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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            byte red = (byte)random.Next(255);
            byte green = (byte)random.Next(255);
            byte blue = (byte)random.Next(255);

            Color randomcolor = Color.FromRgb(red, green, blue);
            Background = new SolidColorBrush(randomcolor);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Image ImageContainer = new Image();
            ImageSource image = new BitmapImage(new Uri(Environment.CurrentDirectory + "/image/print/gerb.jpg", UriKind.Absolute));
            ImageContainer.Source = image;
        }
    }
}

