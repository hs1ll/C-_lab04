using System;
using System.Drawing;
using System.Windows.Forms;
using Task06Settings;

namespace C__lab04
{
    public partial class task06Screensaver : Form
    {
        public bool hasRectangles = false;
        public bool hasEllipses = false;

        public int figureNumber = 1;

        public int interval = 5000;

        Graphics graphics;
        Pen pen = new Pen(Color.Black);
        SolidBrush brush = new SolidBrush(Color.Black);

        Random random = new Random();

        public task06Screensaver()
        {
            InitializeComponent();
            ScreensaverTimer.Interval = interval;
        }

        private void drawFigure(FIGURES figure, uint x, uint y, uint width, uint height)
        {
            graphics = CreateGraphics();

            switch (figure)
            {
                case FIGURES.Rectangle:
                    {
                        graphics.DrawRectangle(pen, x, y, width, height);
                        graphics.FillRectangle(brush, x, y, width, height);
                        break;
                    }
                case FIGURES.Ellipse:
                    {
                        graphics.DrawEllipse(pen, x, y, width, height);
                        graphics.FillEllipse(brush, x, y, width, height);
                        break;
                    }
                default: break;
            }
        }

        private void task06Screensaver_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }

        private void task06Screensaver_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Закрыть приложение?", "", MessageBoxButtons.OKCancel);
        }
    }
}
