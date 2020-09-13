using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForecast
{
    public partial class Form1 : Form
    {

        const string APIKey = "afc9770c22aa76c0d9f2327533776ef9";
        string cityName = "Topeka";
        public Form1()
        {
            InitializeComponent();
            getWeather(cityName);
            getForecast(cityName);
        }
        
        void getWeather(string city)
        {
            using(WebClient w = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=imperial", city, APIKey);
                var json = w.DownloadString(url);
                var result = JsonConvert.DeserializeObject<Info.root>(json);
                Info.root output = result;
                uxState.Text = string.Format("{0}", output.name);
                uxCountry.Text = string.Format("{0}", output.sys.country);
                uxTemp.Text = string.Format("{0}\u00B0 F", output.main.temp);
            }
        }

        void getForecast(string city)
        {
            int day = 5;
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&cnt={1}&appid={2}&units=imperial", city, day, APIKey);
            using(WebClient w = new WebClient())
            {
                var json = w.DownloadString(url);
                var Object = JsonConvert.DeserializeObject<Forecast>(json);

                Forecast forecast = Object;

                uxConditions.Text = string.Format("{0}", forecast.list[1].weather[0].main);
                uxDescription.Text = string.Format("{0}", forecast.list[1].weather[0].description);
                uxForecastTemp.Text = string.Format("{0}", forecast.list[1].temp);
                uxWindSpeed.Text = string.Format("{0}", forecast.list[1].wind);



            }
        }









        private void uxLocation_Click(object sender, EventArgs e)
        {

        }
    }
}
