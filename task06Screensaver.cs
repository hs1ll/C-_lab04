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
        }

        private void drawFigure(FIGURES figure, uint x, uint y, uint width, uint height)
        {
            graphics = CreateGraphics();
            brush.Color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
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

        private void figureRandomize(ref uint x, ref uint y, ref uint width, ref uint height)
        {
            width = (uint)random.Next(ClientSize.Width);
            height = (uint)random.Next(ClientSize.Height);

            x = (uint)random.Next(ClientSize.Width - (int)width - (int)pen.Width * 2);
            y = (uint)random.Next(ClientSize.Height - (int)height - (int)pen.Width * 2);
        }

        private void task06Screensaver_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }

        private void task06Screensaver_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Закрыть приложение?", "", MessageBoxButtons.OKCancel);
        }

        private void ScreensaverTimer_Tick(object sender, EventArgs e)
        {
            graphics = CreateGraphics();
            graphics.Clear(BackColor);
            uint x = 0, y = 0, width = 0, height = 0;
            for (int i = 0; i < figureNumber; ++i)
            {
                figureRandomize(ref x, ref y, ref width, ref height);

                if (hasRectangles && hasEllipses)
                {
                    if ((x + y) % 2 == 0)
                        drawFigure(FIGURES.Rectangle, x, y, width, height);
                    else
                        drawFigure(FIGURES.Ellipse, x, y, width, height);
                }
                else if (hasRectangles)
                    drawFigure(FIGURES.Rectangle, x, y, width, height);
                else
                    drawFigure(FIGURES.Ellipse, x, y, width, height);
            }
        }

        private void task06Screensaver_Shown(object sender, EventArgs e)
        {
            ScreensaverTimer.Interval = interval;
            ScreensaverTimer.Start();
        }
    }
}
