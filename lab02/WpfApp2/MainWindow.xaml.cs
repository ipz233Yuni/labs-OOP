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

        private void wpf_Loaded(object sender, RoutedEventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void buttom_Click(object sender, RoutedEventArgs e)
        {
            bool ok;
            string[] numbersAsString = TextBox1.Text.Split(',');
            double[] numbers = new double[numbersAsString.Length];
            for (int i = 0; i < numbersAsString.Length; i++)
            {
                ok = double.TryParse(numbersAsString[i], out numbers[i]);
                if (!ok)
                {
                    MessageBox.Show("Помилка введення значення", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            int maxLength = 1;
            int currentLength = 1;
            double lastNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == lastNumber)
                {
                    currentLength++;
                    maxLength = Math.Max(maxLength, currentLength);
                }
                else
                {
                    currentLength = 1;
                    lastNumber = numbers[i];
                }
            }
            if (maxLength <= 2)
            {
                label4.Visibility = Visibility.Visible;
                image.Visibility = Visibility.Visible;
            }
            else
            {
                label4.Visibility = Visibility.Hidden;
                image.Visibility = Visibility.Hidden;
            }
            TextBox2.Text = maxLength.ToString();
        }
    }
}
