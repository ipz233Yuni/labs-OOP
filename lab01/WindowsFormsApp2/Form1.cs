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

namespace WindowsFormsApp2
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
            label6.Visible = false;
            label7.Visible = false;
            textBoxX1.Visible = false;
            textBoxX2.Visible = false;
            int a, b, c;
            bool ok;
            ok = int.TryParse(textBoxA.Text, out a);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення a!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ok = int.TryParse(textBoxB.Text, out b);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення b!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ok = int.TryParse(textBoxC.Text, out c);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення c!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (a == 0) MessageBox.Show("Рівняння неквадратне!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                double D = b * b - 4 * a * c;
                textBoxD.Text = D.ToString("F2");
                double x1, x2;
                if (D == 0)
                {
                    x1 = -b / (2 * a);
                    textBoxX1.Visible = true;
                    label6.Visible = true;
                    textBoxX1.Text = x1.ToString("F2");
                }
                if (D > 0)
                {
                    x1 = (-b - Math.Sqrt(D)) / (2 * a);
                    textBoxX1.Visible = true;
                    label6.Visible = true;
                    textBoxX1.Text = x1.ToString("F2");
                    x2 = (-b + Math.Sqrt(D)) / (2 * a);
                    textBoxX2.Visible = true;
                    label7.Visible = true;
                    textBoxX2.Text = x2.ToString("F2");

                }
                if (D < 0) MessageBox.Show("Рівняння немає розв'язків", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
