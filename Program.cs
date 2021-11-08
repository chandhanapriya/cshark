using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections;


namespace deserialization
{
         public class WeatherForecast
        {
            public DateTimeOffset Date { get; set; }
            public int TemperatureCelsius { get; set; }
            public string Summary { get; set; }
        }

        public class Program
        {
            public static void Main()
            {
                string fileName = "WeatherForecast.json";
                string jsonString = File.ReadAllText(fileName);
                WeatherForecast weatherForecast = JsonSerializer.Deserialize<WeatherForecast>(jsonString);

                Console.WriteLine($"Date: {weatherForecast.Date}");
                Console.WriteLine($"TemperatureCelsius: {weatherForecast.TemperatureCelsius}");
                Console.WriteLine($"Summary: {weatherForecast.Summary}");
            }
        }
    }
