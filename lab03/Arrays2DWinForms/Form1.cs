using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays2DWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            int n;
            int m;
            n = (int)numericUpDownN.Value;
            m = (int)numericUpDownM.Value;
            dataGridViewMatrix.ColumnCount = n;
            dataGridViewMatrix.RowCount = m;
            for (int i = 0; i < dataGridViewMatrix.ColumnCount; i++)
            {
                dataGridViewMatrix.Columns[i].HeaderText = i.ToString();
            }
            for (int i = 0; i < dataGridViewMatrix.RowCount; i++)
            {
                dataGridViewMatrix.Rows[i].HeaderCell.Value = i.ToString();

            }
            Random rnd = new Random();
            for (int i = 0; i < dataGridViewMatrix.RowCount; i++)
                for (int j = 0; j < dataGridViewMatrix.ColumnCount; j++)
                {
                    dataGridViewMatrix[j, i].Value = Math.Round(-8.541 + (rnd.NextDouble() * (3.530 + 8.541)), 3);
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
           System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        private void dataGridViewMatrix_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex == -1 && e.RowIndex > -1)
            {
                e.PaintBackground(e.CellBounds, true);
                using (SolidBrush br = new SolidBrush(Color.Black))
                {
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(e.RowIndex.ToString(),
                   e.CellStyle.Font, br, e.CellBounds, sf);
                }
                e.Handled = true;
            }

        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            double[,] matr = new double[dataGridViewMatrix.ColumnCount, dataGridViewMatrix.RowCount];
            for (int i = 0; i < dataGridViewMatrix.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewMatrix.ColumnCount; j++)
                {
                    matr[j, i] = double.Parse(dataGridViewMatrix[j, i].Value.ToString());
                }
            }
            double minS = 0, mini = 0;
            string result = "Сума елементів кожного рядка\r\n";
            for (int i = 0; i < matr.GetLength(1); i++)
            {
                double S = 0;
                for (int j = 0; j < matr.GetLength(0); j++)
                {
                    S += matr[j, i];
                }
                result += $"Сума елементів {i + 1} рядка = {S:F3}\r\n";
                if (S < minS)
                {
                    minS = S;
                    mini = i;
                }
            }
            result += $"Найменша сума {mini + 1} рядка = {minS:F3}\r\n";
            textBoxR.Text = result;
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            double[,] matr = new double[dataGridViewMatrix.RowCount, dataGridViewMatrix.ColumnCount];
            for (int i = 0; i < dataGridViewMatrix.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewMatrix.ColumnCount; j++)
                {
                    matr[i,j] = double.Parse(dataGridViewMatrix[j, i].Value.ToString());
                }
            }
            dataGridViewSort.ColumnCount = dataGridViewMatrix.ColumnCount;
            dataGridViewSort.RowCount = dataGridViewMatrix.RowCount;

            for (int i = 0; i < dataGridViewSort.ColumnCount; i++)
            {
                dataGridViewSort.Columns[i].HeaderText = i.ToString();
            }
            for (int i = 0; i < dataGridViewSort.RowCount; i++)
            {
                dataGridViewSort.Rows[i].HeaderCell.Value = i.ToString();
            }
            for (int j = 1; j < matr.GetLength(1); j += 2)
            {
                for (int i = 0; i < matr.GetLength(0); i++)
                {
                    if (matr[i, j] < 0)
                    {
                        for (int k = i; k > 0; k--)
                        {
                            double temp = matr[k, j];
                            matr[k, j] = matr[k - 1, j];
                            matr[k - 1, j] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < dataGridViewSort.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewSort.ColumnCount; j++)
                {
                    dataGridViewSort[j, i].Value = matr[i, j];
                }
            }
        }

        private void dataGridViewSort_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex > -1)
            {
                e.PaintBackground(e.CellBounds, true);
                using (SolidBrush br = new SolidBrush(Color.Black))
                {
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(e.RowIndex.ToString(),
                   e.CellStyle.Font, br, e.CellBounds, sf);
                }
                e.Handled = true;
            }
        }
    }
}
