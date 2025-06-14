using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazedForms
{
    public partial class GlazedForms : Form
    {
        public GlazedForms()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMaterial.SelectedIndex = 0;
            textBoxResult.BorderStyle = BorderStyle.None;
            textBoxResult.BackColor = BackColor;
        }

        GlazedFormsClass glforms = new GlazedFormsClass();

 
        private void calculateButton_Click_1(object sender, EventArgs e)
        {
            int typeofwindow = radioButtonSingleChamber.Checked ? 1 : 2;
            int material = comboBoxMaterial.SelectedIndex + 1;
            double width;
            double height;

            if (!double.TryParse(textBoxWidth.Text, out width))
            {
                MessageBox.Show("Будь ласка, введіть коректну ширину склопакету.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(textBoxHeight.Text, out height))
            {
                MessageBox.Show("Будь ласка, введіть коректну висоту склопакету.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool needWindowSill = checkBox.Checked;

            double calculateResult = glforms.Calculate(material, typeofwindow, width, height, needWindowSill);

            textBoxResult.Text = calculateResult.ToString("C2");
        }
    }
}
