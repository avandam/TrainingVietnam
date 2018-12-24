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
using DP2_ObserverPattern_Solved;

namespace WeatherStation
{
    /// <summary>
    /// Interaction logic for MaximaScreen.xaml
    /// </summary>
    public partial class MinimumScreen : UserControl, IObserver
    {
        private int maxTemperature = int.MaxValue;
        private int maxHumidity = int.MaxValue;
        private int maxPressure = int.MaxValue;

        public MinimumScreen(ISubject subject)
        {
            InitializeComponent();
            subject.Attach(this);
        }

        public void Update(int temperature, int humidity, int pressure)
        {
            if (maxTemperature > temperature)
            {
                maxTemperature = temperature;
                LblMaximumTemperature.Content = $"Temperature: {maxTemperature}";
            }

            if (maxHumidity > humidity)
            {
                maxHumidity = humidity;
                LblMaximumHumidity.Content = $"Humidity: {maxHumidity}";
            }

            if (maxPressure > pressure)
            {
                maxPressure = pressure;
                LblMaximumPressure.Content = $"Pressure: {maxPressure}";
            }
        }

    }
}
