using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CinsAptServer
{
    public class Weather
    {

        string api;
        string connection;
        string temp;
        string city;
        string weather;
        XDocument document;
      

        public string getWeather()
        {
            api = "f827c5fad1a139ce107907bf10388168";
            connection = "http://api.openweathermap.org/data/2.5/weather?q=izmir&mode=xml&lang=tr&units=metric&appid=" + api;
            document = XDocument.Load(connection);
            temp = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            city = document.Descendants("city").ElementAt(0).Attribute("name").Value;
            weather = document.Descendants("weather").ElementAt(0).Attribute("value").Value;

            return "Degree : " + temp + "\n" + "City : " + city + "\n" + "Weather : " + weather.ToUpper();
        }
        



        

    }
}
