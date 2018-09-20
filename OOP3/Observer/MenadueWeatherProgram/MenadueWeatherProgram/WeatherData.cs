using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenadueWeatherProgram
{
    public class WeatherData : Subject
    {
        private List<Observer> observers;
        private double temperature;
        private double humidity;
        private double pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);

        }

        public void removeObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.RemoveAt(i);
            }
        }

        public void notifyObserver()
        {
            foreach (Observer observer in observers)
            {
                observer.update(Temperature, Humidity, Pressure);
            }
            
        }

        public void setMeasurements(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }

        public void measurementsChanged()
        {
            this.notifyObserver();
        }

        public double Temperature { get { return temperature; } }

        public double Humidity { get { return humidity; } }

        public double Pressure { get { return pressure; } }
    }
}
