using ClassLibrary;
using System;
using System.Windows.Forms;

namespace TravelForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            destinationComboBox.SelectedIndex = 0;
            totalPriceTextBox.BorderStyle = BorderStyle.None;
            totalPriceTextBox.BackColor = BackColor;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int travelers = (int)travelersNumericUpDown.Value;
            int days = (int)daysNumericUpDown.Value;
            string country = destinationComboBox.SelectedItem.ToString();
            string season = summerRadioButton.Checked ? "літо" : "зима";
            bool needGuide = guideCheckBox.Checked;

            double totalCost = TravelFormsClass.CalculateTripCost(travelers, days, country, season, needGuide);

            totalPriceTextBox.Text = totalCost.ToString("C2");
        }
    }
}
