using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenadueWeatherProgram
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private object weatherData;
        private double temperature;
        private double humidity;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
        }

        public void update(double temp, double humidity, double pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            display();
        }
    }
}
