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
    public partial class task09 : Form
    {
        int dotNumber = 0;
        int gap = 50;

        Point a = new Point(0, 0);
        Point b = new Point(0, 0);
        Point c = new Point(0, 0);
        Point dot = new Point(0, 0);
        int steps = 0;

        Random random = new Random();
        Graphics graphics;
        Pen pen = new Pen(Color.Black);

        public task09()
        {
            InitializeComponent();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            dotNumber = 0;

            pen.Width = 1;
            graphics = CreateGraphics();
            graphics.Clear(BackColor);

            a.X = random.Next(gap, (ClientSize.Width - gap) / 3);
            a.Y = random.Next(ClientSize.Height - gap * 5, ClientSize.Height - gap * 4);

            b.X = random.Next(gap + ClientSize.Width / 3, (ClientSize.Width - gap) / 3 * 2);
            b.Y = random.Next(gap, gap * 2);

            c.X = random.Next(gap + ClientSize.Width / 3 * 2, ClientSize.Width - gap);
            c.Y = random.Next(ClientSize.Height - gap * 5, ClientSize.Height - gap * 4);

            graphics.DrawPolygon(pen, new Point[3] { a, b, c });
        }

        private void task09_MouseClick(object sender, MouseEventArgs e)
        {
            if (dotNumber == 0)
            {
                ++dotNumber;
                pen.Width = 1;
                dot.X = e.X; dot.Y = e.Y;
                graphics.DrawEllipse(pen, dot.X, dot.Y, pen.Width, pen.Width);
            }
        }

        private void task09_Shown(object sender, EventArgs e)
        {
            ResetButton.PerformClick();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                steps = int.Parse(StepsTextbox.Text);
                for (int i = 0; i < steps; ++i)
                {
                    int dotPosition = random.Next(1, 4);
                    switch (dotPosition)
                    {
                        case 1:
                            {
                                dot.X = (dot.X + a.X) / 2; dot.Y = (dot.Y + a.Y) / 2;
                                break;
                            }
                        case 2:
                            {
                                dot.X = (dot.X + b.X) / 2; dot.Y = (dot.Y + b.Y) / 2;
                                break;
                            }
                        case 3:
                            {
                                dot.X = (dot.X + c.X) / 2; dot.Y = (dot.Y + c.Y) / 2;
                                break;
                            }
                        default: break;
                    }
                    graphics.DrawEllipse(pen, dot.X, dot.Y, pen.Width, pen.Width);
                }
            }
            catch
            {
                StepsTextbox.Text = "0";
                MessageBox.Show("Неправильный ввод");
            }
        }
    }
}
