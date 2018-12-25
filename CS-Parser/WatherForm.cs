using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumPhantomJSSample
{
    public partial class WatherForm : Form
    {
        public WatherForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new OpenWeatherAPI.OpenWeatherAPI("ce531910882f15ceff62669249965998");

            Console.WriteLine("OpenWeatherAPI Example Application");
            Console.WriteLine();

            Console.WriteLine("Enter city to get weather data for:");
            var city = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Fetching weather data for '{city}'");
            var results = client.Query(city);

            Console.WriteLine($"Температура в {city} имеет {results.Main.Temperature.FahrenheitCurrent}F. Прошло времени {results.Wind.SpeedFeetPerSecond} f/s wind in the {results.Wind.Direction} direction.");

            Console.ReadLine();
        }
    }
}
