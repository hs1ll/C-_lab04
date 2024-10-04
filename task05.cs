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
    public partial class task05 : Form
    {
        public task05()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(InputA.Text);
                double b = double.Parse(InputB.Text);
                double c = double.Parse(InputC.Text);

                const double epsilon = 0.0001;
                if (Math.Abs(a) < epsilon && Math.Abs(b) < epsilon && Math.Abs(c) < epsilon)
                {
                    Output.Text = "Infinte roots number";
                    return;
                }


                if (Math.Abs(a) < epsilon)
                {
                    if (Math.Abs(b) < epsilon)
                    {
                        Output.Text = "No roots";
                        return;
                    }
                    else
                    {
                        double root = -c / b;
                        Output.Text = $"Root = {root}";
                        return;
                    }
                }
                else
                {
                    double D = b * b - 4 * a * c;
                    if (D < 0)
                    {
                        Output.Text = "No roots";
                        return;
                    }

                    if (D == 0)
                    {
                        double root = (-b + Math.Sqrt(D)) / (2 * a);
                        Output.Text = $"Root = {root}";
                        return;
                    }

                    double root01 = (-b + Math.Sqrt(D)) / (2 * a);
                    double root02 = (-b - Math.Sqrt(D)) / (2 * a);

                    Output.Text = $"Root 1 = {root01:0.00}, Root 2 = {root02:0.00}";
                }
            }
            catch
            {
                MessageBox.Show("Некорректный ввод исходных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InputA.Text = "0";
                InputB.Text = "0";
                InputC.Text = "0";
                Output.Text = "";
            }
        }
    }
}
