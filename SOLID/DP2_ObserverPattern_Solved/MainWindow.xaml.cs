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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WeatherData weatherData;
        public MainWindow()
        {
            InitializeComponent();

            weatherData = new WeatherData();

            CurrentsScreen currents = new CurrentsScreen(weatherData);
            Grid.SetColumn(currents, 0);
            Grid.SetRow(currents, 1);
            GridOverview.Children.Add(currents);

            AveragesScreen averages = new AveragesScreen(weatherData);
            Grid.SetColumn(averages, 1);
            Grid.SetRow(averages, 1);
            GridOverview.Children.Add(averages);

            MaximaScreen maxima = new MaximaScreen(weatherData);
            Grid.SetColumn(maxima, 2);
            Grid.SetRow(maxima, 1);
            GridOverview.Children.Add(maxima);

            MinimumScreen minimum = new MinimumScreen(weatherData);
            Grid.SetColumn(minimum, 3);
            Grid.SetRow(minimum, 1);
            GridOverview.Children.Add(minimum);
        }

        private void BtnNewTemperature_Click(object sender, RoutedEventArgs e)
        {
            weatherData.UpdateWeatherData();
        }
    }
}
