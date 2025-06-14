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

        private void button1_Click(object sender, EventArgs e)
        {
            bool ok;
            string[] numbersAsString = textBox1.Text.Split(',');
            double[] numbers = new double[numbersAsString.Length];
            for (int i = 0; i < numbersAsString.Length; i++)
            {
                ok=double.TryParse(numbersAsString[i], out numbers[i]);
                if (!ok)
                {
                    MessageBox.Show("Помилка введення значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                label3.Visible = true;
                pictureBox1.Visible = true;
            }
            else
            {
                label3.Visible = false;
                pictureBox1.Visible = false;
            }
            textBox2.Text = maxLength.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                       System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
