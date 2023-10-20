using System;
using Lib1;
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


namespace пр
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// разобраться с меню
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int K, value, sum, kol;
            string manyvalue;
            K = Convert.ToInt32(valK.Text);
            Class1.Function(K, out kol, out sum, out manyvalue);
            value1.Text = manyvalue.ToString() + " ," + sum.ToString() + " ," + kol.ToString();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
