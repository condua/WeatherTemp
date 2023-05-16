using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Timers;
namespace WeatherTemp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "440a00ddf7631534cb2a256cd7db532f"; // API code take by : apiweather.org
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            getWeather();
            getForeCast();
            
        }
        // create variable lon , lat
        public double lon;
        public double lat;
        DateTime convertDateTime(long sec) // convert time
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }
        //create getWeather function
        void getWeather()
        {
            FLP.Controls.Clear(); //Restore
            using (WebClient web = new WebClient())
            {
                
                // create string with info address web
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", textBox1.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);


                //create variable lon and lat strore lon , lat
                lon = Info.coord.lon;
                lat = Info.coord.lat;



                // icon image stored from website
                picIcon.ImageLocation = "http://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";


                labCondition.Text = Info.weather[0].main;
                labDetails.Text = Info.weather[0].description;

                //convert miliseconds to day
                labSunset.Text    = convertDateTime ( Info.sys.sunset).ToShortTimeString();
                labelSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                //convert temp kelvin to c
                labTemp.Text =  ((int)(Info.main.temp - 273)).ToString() + " °C";
                labNation.Text = Info.sys.country.ToString();

                //wind speed , convert m/s to km/h

                labWindSpeed.Text = (3.6*Info.wind.speed).ToString() + " km/h";

                //output pressure
                labPress.Text = Info.main.pressure.ToString() + " mb";

               
            }
        }
       
        // create getforecast function 
        void getForeCast()
        {

            using (WebClient web = new WebClient())
            {
                //create url string stored address api openweather
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current.minutely.hourly.daily&appid={2}", lat,lon, APIKey);
                var json = web.DownloadString(url);
                WeatherForecast.ForecastInfo ForecastInfo = JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);
               
                ForecastUC FUC;
                // day loop 
                for(int i=0; i < 8; i++)
                {
                    FUC = new ForecastUC();
                    //image of weather icon stored from api weather 
                    FUC.picWeatherIcon.ImageLocation = "http://openweathermap.org/img/w/" + ForecastInfo.daily[i].weather[0].icon + ".png";
                    FUC.labMainWeather.Text = ForecastInfo.daily[i].weather[0].main;

                    FUC.labWeatherDescription.Text = ForecastInfo.daily[i].weather[0].description;

                    //convert time to day
                    FUC.labDT.Text = convertDateTime(ForecastInfo.daily[i].dt).DayOfWeek.ToString();
                    FUC.labDAY.Text = convertDateTime(ForecastInfo.daily[i].dt).ToString("d");

                    //output min and max temp 
                    //corvert kelvin temp to c temp
                    FUC.labTempMin.Text = ((int)(ForecastInfo.daily[i].temp.min) - 273).ToString() + " °C";
                    FUC.labTempMax.Text = ((int)(ForecastInfo.daily[i].temp.max) - 273).ToString() + " °C";

                    //add fuc to flp object
                    FLP.Controls.Add(FUC);
                    
                }
                 

            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void labTemp_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FLP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labPressure_Click(object sender, EventArgs e)
        {

        }
    }
}
