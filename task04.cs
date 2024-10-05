using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__lab04
{
    public partial class task04 : Form
    {
        string TargetString = " абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        int CurrentIndex;
        const int MaxCount = 10;
        int count = 0;

        int mistakes = 0;
        int missed = 0;

        DateTime seconds = new DateTime();

        Graphics Graph;
        Font MyFont = new Font("Arial", 32);
        Random Rand = new Random();
        DateTime start;

        public task04()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            TrainerTimer.Interval = 1000;
        }

        private void task04_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) && (count == 0))
            {
                TrainerTimer.Start();
                CurrentIndex = Rand.Next(TargetString.Length);
                Graph.DrawString(TargetString.Substring(CurrentIndex, 1), MyFont, Brushes.Black, 160, 75);
                start = DateTime.Now;
                count = 1;
            }
            else if ((count > 0) && (e.KeyChar == TargetString[CurrentIndex]))
            {
                if (count == MaxCount)
                {
                    TrainerTimer.Stop();
                    int time = DateTime.Now.Subtract(start).Seconds;
                    MessageBox.Show($"Время выполнения = {time.ToString()} секунд\n" +
                        $"Количество ошибок = {mistakes}\n" +
                        $"Количество пропущенных = {missed}");
                    Close();
                }
                else
                {
                    seconds = new DateTime();
                    Graph.Clear(BackColor);
                    CurrentIndex = Rand.Next(TargetString.Length);
                    Graph.DrawString(TargetString[CurrentIndex].ToString(), MyFont, Brushes.Black, 160, 75);
                    count++;
                }
            }
            else if (e.KeyChar != TargetString[CurrentIndex])
                ++mistakes;
        }

        private void TrainerTimer_Tick(object sender, EventArgs e)
        {
            seconds = seconds.AddSeconds(1);
            if (seconds.Second > 1)
            {
                ++missed;
                ++count;

                Graph.Clear(BackColor);
                CurrentIndex = Rand.Next(TargetString.Length);
                Graph.DrawString(TargetString[CurrentIndex].ToString(), MyFont, Brushes.Black, 160, 75);
                seconds = new DateTime();
            }
            if (count > MaxCount)
            {
                TrainerTimer.Stop();
                int time = DateTime.Now.Subtract(start).Seconds;
                MessageBox.Show($"Время выполнения = {time.ToString()} секунд\n" +
                    $"Количество ошибок = {mistakes}\n" +
                    $"Количество пропущенных = {missed}");
                Close();
            }
            Text = seconds.ToLongTimeString();
        }
    }
}
