using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public partial class FormRegex : System.Windows.Forms.Form
    {
        public FormRegex()
        {
            InitializeComponent();
        }

        private void buttonPhone_Click(object sender, EventArgs e)
        {
            string str = textBoxPhone.Text;
            Regex regex = new Regex(@"[+]?38[-( ]?0(6\d{1}|50|9\d{1})[ )-]?\d{3}[ -]?\d{2}[- ]?\d{2}$");
            if (regex.IsMatch(str))
            {
                labelPhoneResult.ForeColor = Color.Green;
                labelPhoneResult.Text = $"Ок";
            }
            else
            {
                labelPhoneResult.ForeColor = Color.Red;
                labelPhoneResult.Text = $"Помилка";
            }
        }

        private void buttonPasport_Click(object sender, EventArgs e)
        {
            string str = textBoxPasport.Text;
            Regex regex = new Regex(@"(\d{9})|([А-Я]{2}-?\d{6})$");
            if (regex.IsMatch(str))
            {
                labelPasportResult.ForeColor = Color.Green;
                labelPasportResult.Text = $"Ок";
            }
            else
            {
                labelPasportResult.ForeColor = Color.Red;
                labelPasportResult.Text = $"Помилка";
            }
        }



        private void buttonNumber_Click(object sender, EventArgs e)
        {
            string str =textBoxNumber.Text;
            Regex regex = new Regex(@"(1031[1-9]|103[2-9]\d|10[4-9]\d{2}|1[1-9]\d{3}|[2-7]\d{4}|[8][0-8]\d{3}|89[0-5]\d{2}|896[0-3]\d|8964[0-5])");
            if (regex.IsMatch(str))
            {
                labelNumberResult.ForeColor = Color.Green;
                labelNumberResult.Text = $"Ок";
            }
            else
            {
                labelNumberResult.ForeColor = Color.Red;
                labelNumberResult.Text = $"Помилка";
            }

        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            string str = textBoxName.Text;
            Regex regex = new Regex(@"[АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЮЯ][']?[абвгґдеєжзиіїйклмнопрстуфхцчшщюя]+['-]?[АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЮЯ]?[абвгґдеєжзиіїйклмнопрстуфхцчшщюя]+");
            if (regex.IsMatch(str))
            {
                labelNameResult.ForeColor = Color.Green;
                labelNameResult.Text = $"Ок";
            }
            else
            {
                labelNameResult.ForeColor = Color.Red;
                labelNameResult.Text = $"Помилка";
            }
        }

        private void buttonTime_Click(object sender, EventArgs e)
        {
            string str = textBoxTime.Text;
            Regex regex = new Regex(@"([0-1]\d|[2][0-3]):([0-5]\d)");
            if (regex.IsMatch(str))
            {
                labelTimeResult.ForeColor = Color.Green;
                labelTimeResult.Text = $"Ок";
            }
            else
            {
                labelTimeResult.ForeColor = Color.Red;
                labelTimeResult.Text = $"Помилка";
            }
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            string str = textBoxEmail.Text;
            Regex regex = new Regex(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}");
            if (regex.IsMatch(str))
            {
                labelEmailResult.ForeColor = Color.Green;
                labelEmailResult.Text = $"Ок";
            }
            else
            {
                labelEmailResult.ForeColor = Color.Red;
                labelEmailResult.Text = $"Помилка";
            }
        }

        private void labelNameSurname_Click(object sender, EventArgs e)
        {

        }
    }
}
