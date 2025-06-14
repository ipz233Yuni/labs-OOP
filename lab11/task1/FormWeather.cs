using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using System.Text.RegularExpressions;
using System.Net;
using static System.Net.WebRequestMethods;

namespace task1
{
    public partial class FormWeather : Form
    {
        public FormWeather()
        {
            InitializeComponent();
            Weather weather = new Weather("https://meteofor.com.ua/weather-zhytomyr-4943/now/");
            textBoxTemperature.Text = $"{weather.Temperature} °C";
            textBoxWind.Text = $"{weather.Wind} м/с";
            textBoxPress.Text = $"{weather.Press} мм рт. ст.";
            textBoxHumidity.Text = $"{weather.Humidity} %";
            textBoxWater.Text = $"{weather.Water} °C";
            pictureBoxWeather.ImageLocation = weather.Image;
            labelWeather.Text = $"{weather.Text}";

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            Weather weather = new Weather("https://meteofor.com.ua/weather-zhytomyr-4943/now/");
            textBoxTemperature.Text=$"{weather.Temperature} °C";
            textBoxWind.Text=$"{weather.Wind} м/с";
            textBoxPress.Text= $"{weather.Press} мм рт. ст.";
            textBoxHumidity.Text=$"{weather.Humidity} %";
            textBoxWater.Text = $"{weather.Water} °C";
            pictureBoxWeather.ImageLocation = weather.Image;
            labelWeather.Text = $"{weather.Text}";
        }

        private void labelNameSurname_Click(object sender, EventArgs e)
        {

        }
    }
}
