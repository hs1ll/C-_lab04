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
    public partial class task06Screensaver : Form
    {
        public bool hasRectangles = false;
        public bool hasEllipses = false;

        public int figureNumber = 1;

        public int interval = 5000;

        Graphics graphics;
        Pen pen = new Pen(Color.Black);
        SolidBrush brush = new SolidBrush(Color.Black);

        public task06Screensaver()
        {
            InitializeComponent();
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
