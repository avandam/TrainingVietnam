using System;
using System.Collections.Generic;
using System.Windows.Documents;
using DP2_ObserverPattern_Solved;

namespace WeatherStation
{
    class WeatherData : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        private readonly Random generator = new Random();

        public WeatherData()
        {
        }

        public void UpdateWeatherData()
        {
            int temperature = generator.Next(-10, 40);
            int humidity = generator.Next(20, 100);
            int pressure = generator.Next(950, 1050);

            Notify(temperature, humidity, pressure);
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(int temperature, int humidity, int pressure)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }
    }
}
