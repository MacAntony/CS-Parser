using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Parser
{
    public partial class WeatherForm : Form
    {
        public WeatherForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new OpenWeatherAPI.OpenWeatherAPI("ce531910882f15ceff62669249965998");

                var city = input.Text;
                var results = client.Query(city);

                Console.WriteLine($"Температура в {city}  {results.Main.Temperature.FahrenheitCurrent}F. Прошло времени {results.Wind.SpeedFeetPerSecond} ");
                output.Text = results.Main.Temperature.FahrenheitCurrent.ToString();
                SystemSounds.Beep.Play();
            }
            catch (Exception ex)
            {
                if (input.Text == "")
                {
                    MessageBox.Show("Вы не ввели свой город.", "Ошибка!");
                }
                MessageBox.Show($"У вас произошла ошибка №{ex.HResult}. Обратитесь к администратору для исправления данной ошибки.", "Ошибка!");
            }
            
        }
    }
}
