using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void WeatherMap()
        {
            var client = new HttpClient();

            var key = "69db26a1f6fd6710ac205201a261f6d3";
            Console.WriteLine("Enter a city to find temperature:");
            var city = Console.ReadLine();

            //var weatherURL = "https://api.openweathermap.org/data/2.5/weather?lat=57&lon=-2.15&appid={API key}&units=imperial";
            var weatherURL   = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid="+key+"&units=imperial";

            try 
            {

                var response = client.GetStringAsync(weatherURL).Result;

                JObject formattedResponse = JObject.Parse(response);

                var temp = formattedResponse["main"]["temp"];
                //Console.WriteLine(temp);
                Console.WriteLine($"Current temperature in {char.ToUpper(city[0]) + city.Substring(1)}: {temp}°F");

            }
            catch ( Exception ex )
            {
                Console.WriteLine( ex.Message );
            }
        }
    }
}
