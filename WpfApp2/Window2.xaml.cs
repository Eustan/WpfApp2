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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
      
        public Window2()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ComboBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            DisplayImage.Source = new BitmapImage(new Uri(@"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\richard_mg\Desktop\Новая папка\images\thezdox.jpg"));

        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            DisplayImage.Source = new BitmapImage(new Uri(@"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\richard_mg\Desktop\Новая папка\images\vsratycafiin.jpg"));
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            DisplayImage.Source = new BitmapImage(new Uri(@"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\richard_mg\Desktop\Новая папка\images\Belphegor.jpg"));
        }
    }
}
