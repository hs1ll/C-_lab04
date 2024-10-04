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
    public partial class Task02 : Form
    {
        public Task02()
        {
            InitializeComponent();
        }

        private void Task02_Resize(object sender, EventArgs e)
        {
            ExecuteButton.Location = new Point(ClientSize.Width - ExecuteButton.Width - 10,
                ClientSize.Height - ExecuteButton.Height - 10);
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(InputYear.Text);
                if (year < 0 || year > 9999)
                    throw new ArgumentOutOfRangeException();

                int month = int.Parse(InputMonth.Text);
                if (month < 1 || month > 12)
                    throw new ArgumentOutOfRangeException();

                int day = int.Parse(InputDays.Text);
                if (day < 1 || day > DateTime.DaysInMonth(year, month))
                    throw new ArgumentOutOfRangeException();


                int lastDays = 0;
                for (int i = 12; i > month; --i)
                    lastDays += DateTime.DaysInMonth(year, i);

                lastDays += DateTime.DaysInMonth(year, month) - day;

                OutputText.Text = $"{lastDays}";
            }
            catch
            {
                MessageBox.Show("Некорректный ввод исходных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InputYear.Text = DateTime.Now.Year.ToString();
                InputMonth.Text = DateTime.Now.Month.ToString();
                InputDays.Text = DateTime.Now.Day.ToString();
            }
        }

        private void Task02_Shown(object sender, EventArgs e)
        {
            InputYear.Text = $"{DateTime.Now.Year.ToString()}";
            InputMonth.Text = $"{DateTime.Now.Month.ToString()}";
            InputDays.Text = $"{DateTime.Now.Day.ToString()}";
        }
    }
}
