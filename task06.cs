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
    public partial class task06 : Form
    {
        public task06()
        {
            InitializeComponent();
        }

        private void task06_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            task06Screensaver screensaver = new task06Screensaver();

            screensaver.Show();
        }
    }
}
