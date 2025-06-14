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

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                       System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            label5.Visibility = Visibility.Hidden;
            label6.Visibility = Visibility.Hidden;
            TextBoxX1.Visibility = Visibility.Hidden;
            TextBoxX2.Visibility = Visibility.Hidden;
            int a, b, c;
            bool ok;
            ok = int.TryParse(TextBoxA.Text, out a);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ok = int.TryParse(TextBoxB.Text, out b);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ok = int.TryParse(TextBoxC.Text, out c);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення c!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (a == 0) MessageBox.Show("Рівняння неквадратне!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                double D = b * b - 4 * a * c;
                TextBoxD.Text = D.ToString("F2");
                double x1, x2;
                if (D == 0)
                {
                    x1 = -b / (2 * a);
                    label5.Visibility = Visibility.Visible;
                    TextBoxX1.Visibility = Visibility.Visible;
                    TextBoxX1.Text = x1.ToString("F2");
                }
                if (D > 0)
                {
                    x1 = (-b - Math.Sqrt(D)) / (2 * a);
                    label5.Visibility = Visibility.Visible;
                    TextBoxX1.Visibility = Visibility.Visible;
                    TextBoxX1.Text = x1.ToString("F2");
                    x2 = (-b + Math.Sqrt(D)) / (2 * a);
                    label6.Visibility = Visibility.Visible;
                    TextBoxX2.Visibility = Visibility.Visible;
                    TextBoxX2.Text = x2.ToString("F2");

                }
                if (D < 0) MessageBox.Show("Рівняння немає розв'язків", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
