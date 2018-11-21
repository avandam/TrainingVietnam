using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeatherStation
{
    /// <summary>
    /// Interaction logic for MaximaScreen.xaml
    /// </summary>
    public partial class MaximaScreen : UserControl
    {
        private readonly List<int> temperatures = new List<int>();
        private readonly List<int> humidities = new List<int>();
        private readonly List<int> pressures = new List<int>();

        public MaximaScreen()
        {
            InitializeComponent();
        }

        public void Update(int temperature, int humidity, int pressure)
        {
            temperatures.Add(temperature);
            humidities.Add(humidity);
            pressures.Add(pressure);

            LblMaximumTemperature.Content = $"Temperature: {temperatures.Max()}";
            LblMaximumHumidity.Content = $"Humidity: {humidities.Max()}";
            LblMaximumPressure.Content = $"Pressure: {pressures.Max()}";
        }

    }
}
