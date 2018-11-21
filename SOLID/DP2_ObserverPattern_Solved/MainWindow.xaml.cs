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

            

            CurrentsScreen currents = new CurrentsScreen();
            Grid.SetColumn(currents, 0);
            Grid.SetRow(currents, 1);
            GridOverview.Children.Add(currents);

            AveragesScreen averages = new AveragesScreen();
            Grid.SetColumn(averages, 1);
            Grid.SetRow(averages, 1);
            GridOverview.Children.Add(averages);

            MaximaScreen maxima = new MaximaScreen();
            Grid.SetColumn(maxima, 2);
            Grid.SetRow(maxima, 1);
            GridOverview.Children.Add(maxima);

            weatherData = new WeatherData(currents, averages, maxima);
        }

        private void BtnNewTemperature_Click(object sender, RoutedEventArgs e)
        {
            weatherData.UpdateWeatherData();
        }
    }
}
