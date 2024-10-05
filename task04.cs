using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        Graphics Graph;
        Font MyFont = new Font("Arial", 32);
        Random Rand = new Random();
        DateTime start;

        public task04()
        {
            InitializeComponent();
            Graph = CreateGraphics();
        }

        private void task04_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar == 13) && (count == 0))
            {
                start = DateTime.Now;
                CurrentIndex = Rand.Next(TargetString.Length);
                Graph.DrawString(TargetString.Substring(CurrentIndex, 1), MyFont, Brushes.Black, 160, 75);
                count = 1;
            }
            else if ((count > 0) && (e.KeyChar == TargetString[CurrentIndex]))
            {
                if (count == MaxCount)
                {
                    int time = DateTime.Now.Subtract(start).Seconds;
                    MessageBox.Show($"Время выполнения = {time.ToString()} секунд\n" +
                        $"Количество ошибок = {mistakes}\n");
                    Close();
                }
                else
                {
                    Graph.Clear(BackColor);
                    CurrentIndex = Rand.Next(TargetString.Length);
                    Graph.DrawString(TargetString[CurrentIndex].ToString(), MyFont, Brushes.Black, 160, 75);
                    count++;
                }
            }
            else 
                ++mistakes;
        }
    }
}
