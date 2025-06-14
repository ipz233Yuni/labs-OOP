using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxR.Clear();
            double a, b, h;
            bool ok;
            ok = double.TryParse(textBoxA.Text, out a);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ok = double.TryParse(textBoxB.Text, out b);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ok = double.TryParse(textBoxH.Text, out h);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення h!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (a > b)
            {
                MessageBox.Show("Помилка введення (a не може бути більше за b)", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string result = $"x\ty\t\t";
            for(double x = a; x <= b; x += h)
            {
                double y = (Math.Pow(x,3) + 2 * x) / (3 * Math.Cos(Math.Sqrt(x))+1);
                result += $"{x:F3}\t{y:F3}\r\n";
            }
            textBoxR.Text = result;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
