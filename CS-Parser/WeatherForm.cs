using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Parser
{
    public partial class WeatherForm : Form
    {
        OpenWeatherAPI.OpenWeatherAPI client;
        string city;
        OpenWeatherAPI.Query results;
        string pubIp;
        public WeatherForm()
        {
            InitializeComponent();
            client = new OpenWeatherAPI.OpenWeatherAPI("ce531910882f15ceff62669249965998");
            pubIp = new WebClient().DownloadString("https://api.ipify.org");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                city = input.Text;
                results = client.Query(city);

                outputF.Text = results.Main.Temperature.FahrenheitCurrent.ToString();
                outputC.Text = Convert.ToString(Formula(results.Main.Temperature.FahrenheitCurrent));
                timer.Enabled = true;
                SystemSounds.Beep.Play();
            }
            catch (Exception ex)
            {
                if (input.Text == "")
                    MessageBox.Show("Вы не ввели свой город.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"У вас произошла ошибка №{ex.HResult}Обратитесь к администратору для исправления данной ошибки.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            outputF.Text = results.Main.Temperature.FahrenheitCurrent.ToString();
            outputC.Text = Convert.ToString(Formula(results.Main.Temperature.FahrenheitCurrent));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CS_Parser.SettingsForm settingsForm = new CS_Parser.SettingsForm();
            settingsForm.Show(this);
        }

        private double Formula(double F)
        {
            return (F - 32) * 5 / 9;
        }

        public static string GetUserCountryByIp(string ip)
        {
            IpInfo ipInfo = new IpInfo();
            try
            {
                string info = new WebClient().DownloadString("http://ipinfo.io/" + ip);
                ipInfo = JsonConvert.DeserializeObject<IpInfo>(info);
                RegionInfo myRI1 = new RegionInfo(ipInfo.Country);
                ipInfo.Country = myRI1.EnglishName;
            }
            catch (Exception)
            {
                ipInfo.Country = null;
            }

            return ipInfo.City;
        }

        private void WeatherForm_Load(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send("216.58.209.68");
            if (reply.Status != IPStatus.Success)
            {
                MessageBox.Show("У вас нет подключения к интренету! Приложение автоматически закроетсья.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            notifyIcon1.BalloonTipTitle = "Погода";
            notifyIcon1.BalloonTipText = "Приложение свернуто";
            notifyIcon1.Text = "Погода";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void WeatherForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) //Если в вашей ОС(Windows) есть центр уведомлений то у вас должно появитья увидомление о сворачивании приложения. Обычно данная функцыя есть по умалчаню в Windows 10.
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
            { notifyIcon1.Visible = false; }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            input.Text = GetUserCountryByIp(pubIp);
        }
    }
}
