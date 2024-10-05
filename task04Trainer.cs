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
    public partial class task04Trainer : Form
    {
        int mistakes = 0;
        int missed = 0;

        Graphics Graph;
        Font MyFont = new Font("Arial", 32);
        Random Rand = new Random();
        DateTime start;

        string TargetString = " абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        int CurrentIndex;
        const int MaxCount = 10;
        int count = 0;

        public task04Trainer(int interval)
        {
            InitializeComponent();
            Graph = CreateGraphics();
            TrainerTimer.Interval = interval;
        }

        private void task04Trainer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == TargetString[CurrentIndex])
            {
                if (count == MaxCount)
                {
                    TrainerTimer.Stop();
                    int time = DateTime.Now.Subtract(start).Seconds;
                    MessageBox.Show($"Время выполнения = {time.ToString()} секунд\n" +
                        $"Количество ошибок = {mistakes}\n" +
                        $"Количество пропущенных = {missed}\n");
                    Close();
                }
                else
                {
                    TrainerTimer.Stop();
                    TrainerTimer.Start();
                    Graph.Clear(BackColor);
                    CurrentIndex = Rand.Next(TargetString.Length);
                    Graph.DrawString(TargetString[CurrentIndex].ToString(), MyFont, Brushes.Black, 160, 75);
                    count++;
                }
            }
            else
                ++mistakes;
        }

        private void TrainerTimer_Tick(object sender, EventArgs e)
        {
            ++missed;
            ++count;

            if (count > MaxCount)
            {
                TrainerTimer.Stop();
                int time = DateTime.Now.Subtract(start).Seconds;
                MessageBox.Show($"Время выполнения = {time.ToString()} секунд\n" +
                    $"Количество ошибок = {mistakes}\n" +
                    $"Количество пропущенных = {missed}");
                Close();
            }

            Graph.Clear(BackColor);
            CurrentIndex = Rand.Next(TargetString.Length);
            Graph.DrawString(TargetString[CurrentIndex].ToString(), MyFont, Brushes.Black, 160, 75);
            TrainerTimer.Stop();
            TrainerTimer.Start();
        }

        private void task04Trainer_Shown(object sender, EventArgs e)
        {
            ++count;
            Thread.Sleep(1000);
            CurrentIndex = Rand.Next(TargetString.Length);
            Graph.DrawString(TargetString.Substring(CurrentIndex, 1), MyFont, Brushes.Black, 160, 75);
            TrainerTimer.Start();
            start = DateTime.Now;
        }
    }
}
