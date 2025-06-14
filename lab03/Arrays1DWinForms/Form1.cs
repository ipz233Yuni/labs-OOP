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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Arrays1DWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        double[] arr;

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            int n;
            n = (int)numericUpDownCount.Value;
            dataGridViewArray.ColumnCount = n;
            dataGridViewArray.RowCount = 1;
            dataGridViewArray.RowHeadersWidth = 50;
            for (int i = 0; i < dataGridViewArray.ColumnCount; i++)
            {
                dataGridViewArray.Columns[i].HeaderText = i.ToString();
                dataGridViewArray.Columns[i].Width = 80;
            }
            for (int i = 0; i < dataGridViewArray.RowCount; i++)
            {
                dataGridViewArray.Rows[i].HeaderCell.Value = i.ToString();

            }
            Random rnd = new Random();
            for (int i = 0; i < dataGridViewArray.RowCount; i++)
                for (int j = 0; j < dataGridViewArray.ColumnCount; j++)
                {
                    dataGridViewArray[j, i].Value = Math.Round(-158.403 + (rnd.NextDouble() * (123.908 + 158.403)), 3);
                }
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            double[] arr = new double[dataGridViewArray.ColumnCount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(dataGridViewArray[i, 0].Value.ToString());
            }
            int maxi = 0, mini = 0;
            double max = 0, min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxi = i;
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    mini = i;
                }
            }
            double S = 0;
            for (int i = Math.Min(maxi, mini) + 1; i < Math.Max(maxi, mini); i++)
            {
                S += Math.Abs(arr[i]);
            }
            textBoxS.Text = S.ToString();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            double[] arr = new double[dataGridViewArray.ColumnCount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(dataGridViewArray[i, 0].Value.ToString());
            }
            dataGridViewSort.ColumnCount = dataGridViewArray.ColumnCount;
            dataGridViewSort.RowCount = 1;
            for (int i = 0; i < dataGridViewSort.ColumnCount; i++)
            {
                dataGridViewSort.Columns[i].HeaderText = i.ToString();
                dataGridViewSort.Columns[i].Width = 80;
            }
            for (int i = 0; i < dataGridViewSort.RowCount; i++)
            {
                dataGridViewSort.Rows[i].HeaderCell.Value = i.ToString();

            }
            int maxi = 0, mini = 0;
            double max = 0, min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxi = i;
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                    mini = i;
                }
            }
            double[] newarr = new double[arr.Length - maxi - 1];
            for (int i = 0, j = maxi + 1; i < arr.Length - maxi - 1; i++, j++)
            {
                newarr[i] = arr[j];
            }
            Array.Sort(newarr);
            Array.Reverse(newarr);
            for (int i = maxi + 1, j = 0; i < arr.Length; i++, j++)
            {
                arr[i] = newarr[j];
            }
            for (int i = 0; i < dataGridViewSort.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewSort.ColumnCount; j++)
                {
                    dataGridViewSort[j, i].Value = arr[j];
                }
            }

        }
    }
}
