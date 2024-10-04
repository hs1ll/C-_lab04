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
    public partial class task01 : Form
    {
        
        public task01()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string inputType = "";
                foreach (RadioButton rb in InputMeasureGroup.Controls)
                {
                    if (rb.Checked)
                        inputType = rb.Text;
                }

                double inputValue = double.Parse(InputText.Text);
                if (inputValue < 0)
                    throw new ArgumentOutOfRangeException();

                double inputInMeters = inputValue;
                switch (inputType)
                {
                    case "Дюйм":
                        {
                            inputInMeters = inputValue * 0.0254;
                            break;
                        }
                    case "Фут":
                        {
                            inputInMeters = inputValue * 0.3048;
                            break;
                        }
                    case "Ярд":
                        {
                            inputInMeters = inputValue * 0.9144;
                            break;
                        }
                    case "Сантиметр":
                        {
                            inputInMeters = inputValue * 0.01;
                            break;
                        }

                    default: break;
                }

                string outputType = "";
                foreach (RadioButton rb in OutputMeasureGroup.Controls)
                {
                    if (rb.Checked)
                        outputType = rb.Text;
                }

                double outputValue = inputInMeters;
                switch (outputType)
                {
                    case "Дюйм":
                        {
                            outputValue = inputInMeters * 39.3701;
                            break;
                        }
                    case "Фут":
                        {
                            outputValue = inputInMeters * 3.28084;
                            break;
                        }
                    case "Ярд":
                        {
                            outputValue = inputInMeters * 1.09361;
                            break;
                        }
                    case "Сантиметр":
                        {
                            outputValue = inputInMeters * 100;
                            break;
                        }

                    default: break;
                }

                OutputText.Text = $"{outputValue:0.00}";
            }
            catch
            {
                MessageBox.Show("Некорректный ввод исходных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InputText.Text = "0";
                OutputText.Text = "0";
            }

        }
    }
}
