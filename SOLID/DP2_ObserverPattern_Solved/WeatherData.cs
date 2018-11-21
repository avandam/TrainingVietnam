using System;

namespace WeatherStation
{
    class WeatherData
    {
        private readonly CurrentsScreen currents;
        private readonly AveragesScreen averages;
        private readonly MaximaScreen maxima;

        private readonly Random generator = new Random();

        public WeatherData(CurrentsScreen currents, AveragesScreen averages, MaximaScreen maxima)
        {
            this.currents = currents;
            this.averages = averages;
            this.maxima = maxima;
        }

        public void UpdateWeatherData()
        {
            int temperature = generator.Next(-10, 40);
            int humidity = generator.Next(20, 100);
            int pressure = generator.Next(950, 1050);

            currents.Update(temperature, humidity, pressure);
            averages.Update(temperature, humidity, pressure);
            maxima.Update(temperature, humidity, pressure);
        }
    }
}
