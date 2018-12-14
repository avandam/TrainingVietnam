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
        private int maxTemperature = int.MinValue;
        private int maxHumidity = int.MinValue;
        private int maxPressure = int.MinValue;

        public MaximaScreen()
        {
            InitializeComponent();
        }

        public void Update(int temperature, int humidity, int pressure)
        {
            if (maxTemperature < temperature)
            {
                maxTemperature = temperature;
                LblMaximumTemperature.Content = $"Temperature: {maxTemperature}";
            }

            if (maxHumidity < humidity)
            {
                maxHumidity = humidity;
                LblMaximumHumidity.Content = $"Humidity: {maxHumidity}";
            }

            if (maxPressure < pressure)
            {
                maxPressure = pressure;
                LblMaximumPressure.Content = $"Pressure: {maxPressure}";
            }
        }

    }
}
