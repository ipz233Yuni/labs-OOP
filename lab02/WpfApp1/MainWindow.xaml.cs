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

namespace WpfApp1
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void butto1_Click(object sender, RoutedEventArgs e)
        {
            textBoxR.Clear();
            double a, b, h;
            bool ok;
            ok = double.TryParse(textBoxA.Text, out a);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ok = double.TryParse(textBoxB.Text, out b);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ok = double.TryParse(textBoxH.Text, out h);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення h!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (a > b)
            {
                MessageBox.Show("Помилка введення (a не може бути більше за b)", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string result = $"x\ty\t\n";
            for (double x = a; x <= b; x += h)
            {
                double y = (Math.Pow(x, 3) + 2 * x) / (3 * Math.Cos(Math.Sqrt(x)) + 1);
                result += $"{x:F3}\t{y:F3}\r\n";
            }
            textBoxR.Text = result;
        }

        private void wpf_Loaded(object sender, RoutedEventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.Show();

        }
    }
}
