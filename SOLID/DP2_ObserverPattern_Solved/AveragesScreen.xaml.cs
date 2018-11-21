using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace WeatherStation
{
    /// <summary>
    /// Interaction logic for AveragesScreen.xaml
    /// </summary>
    public partial class AveragesScreen : UserControl
    {
        private readonly List<int> temperatures = new List<int>();
        private readonly List<int> humidities = new List<int>();
        private readonly List<int> pressures = new List<int>();

        public AveragesScreen()
        {
            InitializeComponent();
        }

        public void Update(int temperature, int humidity, int pressure)
        {
            temperatures.Add(temperature);
            humidities.Add(humidity);
            pressures.Add(pressure);

            LblAverageTemperature.Content = $"Temperature: {Math.Round(temperatures.Average(), 1)}";
            LblAverageHumidity.Content = $"Humidity: {Math.Round(humidities.Average(), 1)}";
            LblAveragePressure.Content = $"Pressure: {Math.Round(pressures.Average(), 1)}";
        }
    }
}
