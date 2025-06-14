using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Weather
    {
        private string temperature;
        private string wind;
        private string press;
        private string humidity;
        private string water;
        private string image;
        private string text;
        public string Temperature
        {
            get { return temperature; }
            private set { temperature = value; }
        }
        public string Wind
        {
            get { return wind; }
            private set { wind = value; }
        }
        public string Press
        {
            get { return press; }
            private set { press = value; }
        }
        public string Humidity
        {
            get { return humidity; }
            private set { humidity = value; }
        }
        public string Water
        {
            get { return water; }
            private set { water = value; }
        }
        public string Image
        {
            get { return image; }
            private set { image = value; }
        }
        public string Text
        {
            get { return text; }
            private set { text = value; }
        }
        public Weather(string url)
        {
            WebClient web = new WebClient();
            web.Encoding = Encoding.UTF8;
            string html = web.DownloadString(url);
            Regex reg1 = new Regex(@"<span\s+class=""unit-temperature""[^>]*>([+-]?\d+)&nbsp;°C<\/span>");
            Match m1 = reg1.Match(html);
            Regex reg2 = new Regex(@"<span\s+class=""unit-wind""[^>]*>(\d+)<\/span>");
            Match m2 = reg2.Match(html);
            Regex reg3 = new Regex(@"<span class=""unit-pressure""[^>]*>(\d+)(?=</span>)");
            Match m3 = reg3.Match(html);
            Regex reg4 = new Regex(@"<div class=""item-value"">(\d+)(?=</div><div class=""item-measure""><span>)");
            Match m4 = reg4.Match(html);
            Regex reg5 = new Regex(@"<div class=""now-info-item""><div class=""item-title"">Вода<\/div><div class=""item-information""><div class=""item-value""><span class=""unit-temperature"" data-temperature-f=""\d+"">([+-]?\d+)<\/span>");
            Match m5 = reg5.Match(html);
            Regex reg6 = new Regex(@"<link\s+rel=""apple-touch-icon""\s+sizes=""180x180""\s+href=""([^""]+)""\s*>");
            Match mImage = reg6.Match(html);
            Regex reg7 = new Regex(@"<div\s+class=""now-desc"">([^<]+)</div>");
            Match m6 = reg7.Match(html);
            if (m1.Success)
            {
                Temperature = m1.Groups[1].Value;
            }
            if (m2.Success)
            {
                Wind = m2.Groups[1].Value;
            }
            if (m3.Success)
            {
                Press = m3.Groups[1].Value;
            }
            if (m4.Success)
            {
                Humidity = m4.Groups[1].Value;
            }
            if (m5.Success)
            {
                Water = m5.Groups[1].Value;
            }
            if (mImage.Success)
            {
                Image = mImage.Groups[1].Value;
            }
            if (m6.Success)
            {
                Text = m6.Groups[1].Value;
            }
        }
    }
}
