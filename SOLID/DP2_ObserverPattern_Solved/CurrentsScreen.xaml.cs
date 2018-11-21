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
    /// Interaction logic for CurrentsScreen.xaml
    /// </summary>
    public partial class CurrentsScreen : UserControl
    {
        public CurrentsScreen()
        {
            InitializeComponent();
        }

        public void Update(int temperature, int humidity, int pressure)
        {
            LblCurrentTemperature.Content = $"Temperature: {temperature}";
            LblCurrentHumidity.Content = $"Humidity: {humidity}";
            LblCurrentPressure.Content = $"Pressure: {pressure}";

        }
    }
}
