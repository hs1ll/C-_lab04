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
        int gap = 50;

        Point a = new Point(0, 0);
        Point b = new Point(0, 0);
        Point c = new Point(0, 0);

        Random random = new Random();
        Graphics graphics;
        Pen pen = new Pen(Color.Black);

        public task09()
        {
            InitializeComponent();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
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
    }
}
