using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tamagotchi
{
    public partial class Form1 : Form
    {
        /*
            ░░░░░██╗░█████╗░░██████╗░█████╗░███╗░░██╗  ██╗░░██╗██████╗░░█████╗░███╗░░░███╗
            ░░░░░██║██╔══██╗██╔════╝██╔══██╗████╗░██║  ██║░██╔╝██╔══██╗██╔══██╗████╗░████║
            ░░░░░██║███████║╚█████╗░██║░░██║██╔██╗██║  █████═╝░██████╔╝██║░░██║██╔████╔██║
            ██╗░░██║██╔══██║░╚═══██╗██║░░██║██║╚████║  ██╔═██╗░██╔══██╗██║░░██║██║╚██╔╝██║
            ╚█████╔╝██║░░██║██████╔╝╚█████╔╝██║░╚███║  ██║░╚██╗██║░░██║╚█████╔╝██║░╚═╝░██║
            ░╚════╝░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚══╝  ╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝░░░░░╚═╝

            ██╗░░██╗██╗░░░░░░█████╗░░██████╗██╗    ░░███╗░░██████╗░
            ██║░██╔╝██║░░░░░██╔══██╗██╔════╝╚═╝    ░████║░░██╔══██╗
            █████═╝░██║░░░░░███████║╚█████╗░░░░    ██╔██║░░██████╦╝
            ██╔═██╗░██║░░░░░██╔══██║░╚═══██╗░░░    ╚═╝██║░░██╔══██╗
            ██║░╚██╗███████╗██║░░██║██████╔╝██╗    ███████╗██████╦╝
            ╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═════╝░╚═╝    ╚══════╝╚═════╝░
        */



        // Startwaardes
        private int _welzijn = 1000;
        private int _eten = 1000;
        private int _drinken = 1000;

        // Droprates
        private int _welzijnRate = 14;
        private int _etenRate = 7;
        private int _drinkenRate = 3;

        // Overige variabelen
        private bool _welzijnHoog = false;
        private bool _etenOp = false;
        private bool _drinkenOp = false;
        private DateTime _startTime;
        private int _etenUsed = 0;
        private int _drinkenUsed = 0;
        private int _medkitUsed = 0;
        private bool _etenOn = true;
        private bool _drinkenOn = true;
        private bool _medkitOn = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chartUpdate(chartWelzijn, 2);

            // Grafiek Icons op de juiste plek zetten
            pictureBox1.Parent = chartWelzijn;
            pictureBox1.Location = new Point(pictureBox1.Parent.Width / 2 - pictureBox1.Width / 2, pictureBox1.Parent.Height / 2 - pictureBox1.Height / 2 + 16);
            pictureBox2.Parent = chartEten;
            pictureBox2.Location = new Point(pictureBox1.Parent.Width / 2 - pictureBox1.Width / 2, pictureBox1.Parent.Height / 2 - pictureBox1.Height / 2 + 8);
            pictureBox3.Parent = chartDrinken;
            pictureBox3.Location = new Point(pictureBox1.Parent.Width / 2 - pictureBox1.Width / 2, pictureBox1.Parent.Height / 2 - pictureBox1.Height / 2 + 18);

            // Starttijd onthouden
            _startTime = DateTime.Now;

            // Timers klaarmaken
            timer1.Interval = _welzijnRate;
            timer2.Interval = _etenRate;
            timer3.Interval = _drinkenRate;
            timer1.Start();
            timer2.Start();
            timer3.Start();

            // Tooltip linken
            toolTip1.SetToolTip(buttonEten, "Geef je tamagotchi een lekkere burger\n\nCooldown:\t2.5sec\nEten:\t\t+125\nWelzijn:\t\t+25");
            toolTip1.SetToolTip(buttonDrinken, "Geef je tamagotchi een glas mineraalwater\n\nCooldown:\t2sec\nDrinken:\t\t+100\nWelzijn:\t\t+20");
            toolTip1.SetToolTip(buttonMedkit, "Geef je tamagotchi medische hulp in geval van nood\n\nCooldown:\t10min\nWelzijn:\t\t+500");
        }


        // Welzijn droprate functie
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_welzijn > 0)
            {
                _welzijnHoog = (_eten > 750 && _drinken > 750) ? true : false;
                _welzijn -= ((_welzijnHoog ? 0 : 1) + (_etenOp ? 1 : 0) + (_drinkenOp ? 1 : 0));
                _welzijn = (_welzijn >= 0) ? _welzijn : 0;
                chartUpdate(chartWelzijn, _welzijn);
            }
            else
            {
                timer1.Stop();
                gameOver();
            }
        }


        // Eten droprate functie
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (_eten >= 0)
            {
                _etenOp = false;
                _eten--;
                chartUpdate(chartEten, _eten);
            }
            else
            {
                _etenOp = true;
            }
        }


        // Drinken droprate functie
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (_drinken >= 0)
            {
                _drinkenOp = false;
                _drinken--;
                chartUpdate(chartDrinken, _drinken);
            }
            else
            {
                _drinkenOp = true;
            }
        }


        // Grafiek bijwerken functie
        private void chartUpdate(Chart chart, int value)
        {
            double green = (255d / 1000d * value);
            double red = 255 - (255d / 1000d * value);
            chart.Series[0].Points.ElementAt(0).SetValueY(value);
            chart.Series[0].Points.ElementAt(1).SetValueY(1000 - value);
            chart.Series[0].Points.ElementAt(0).Color = Color.FromArgb(255, Convert.ToInt32(red), Convert.ToInt32(green), 0);
            chart.Refresh();
            moodChange();
        }


        // Eten / Drinken / Welzijn update functie
        private void statsUpdate(int welzijn, int eten, int drinken)
        {
            _welzijn = (_welzijn + welzijn <= 1000) ? (_welzijn += welzijn) : 1000;
            _eten = (_eten + eten <= 1000) ? (_eten += eten) : 1000;
            _drinken = (_drinken + drinken <= 1000) ? (_drinken += drinken) : 1000;
            chartUpdate(chartWelzijn, _welzijn);
            chartUpdate(chartEten, _eten);
            chartUpdate(chartDrinken, _drinken);
        }


        // Humeur/foto van tamagotchi updaten
        private void moodChange()
        {
            if (_welzijn >= 750)
            {
                pictureBox4.BackgroundImage = Properties.Resources.a;
            }
            else if (_welzijn >= 500)
            {
                pictureBox4.BackgroundImage = Properties.Resources.b;
            }
            else if (_welzijn >= 250)
            {
                pictureBox4.BackgroundImage = Properties.Resources.c;
            }
            else if (_welzijn > 0)
            {
                pictureBox4.BackgroundImage = Properties.Resources.d;
            }
            else
            {
                pictureBox4.BackgroundImage = Properties.Resources.e;
            }
            pictureBox4.Refresh();
        }


        // Game over functie
        private void gameOver()
        {
            // Game over bericht met stats en leeftijd
            TimeSpan duration = DateTime.Now - _startTime;
            MessageBox.Show("Je tamagotchi is overleden :(\n\nLeeftijd:\t\t"+Math.Floor(duration.TotalSeconds).ToString()+" seconden\nGegeten:\t\t"+_etenUsed.ToString()+" burgers\nGedronken:\t"+_drinkenUsed.ToString()+" glazen water\nGenezen:\t"+_medkitUsed.ToString()+" medische kits");
            this.Close();
        }


        // Drinken button
        private async void buttonDrinken_Click(object sender, EventArgs e)
        {
            if (_drinkenOn)
            {
                _drinkenOn = false;
                buttonDrinken.BackColor = Color.FromArgb(255, 150, 150, 255);

                _drinkenUsed++;
                statsUpdate(20, 0, 200);
                await Task.Delay(2000);

                buttonDrinken.BackColor = Color.FromArgb(255, 50, 50, 255);
                _drinkenOn = true;
            }
        }


        // Eten button
        private async void buttonEten_Click(object sender, EventArgs e)
        {
            if (_etenOn)
            {
                _etenOn = false;
                buttonEten.BackColor = Color.FromArgb(255, 255, 200, 100);

                _etenUsed++;
                statsUpdate(25, 250, 0);
                await Task.Delay(2500);

                buttonEten.BackColor = Color.FromArgb(255, 255, 125, 0);
                _etenOn = true;
            }
        }

        // Medische hulp button
        private async void buttonMedkit_Click(object sender, EventArgs e)
        {
            if (_medkitOn)
            {
                _medkitOn = false;
                buttonMedkit.BackColor = Color.FromArgb(255, 255, 150, 150);

                _medkitUsed++;
                statsUpdate(500, 0, 0);
                await Task.Delay(600000);

                buttonMedkit.BackColor = Color.FromArgb(255, 255, 50, 50);
                _medkitOn = true;
            }
        }
    }
}
