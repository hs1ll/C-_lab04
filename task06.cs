using System;
using System.Windows.Forms;

namespace C__lab04
{
    public partial class task06 : Form
    {
        enum FIGURES
        {
            Rectangle,
            Ellipse,
        }

        enum FIGURE_NUMBER
        {
            Single = 1,
            Pair = 2,
        }

        enum INTERVALS
        {
            Slow = 3000,
            Medium = 1000,
            Fast = 100,
        }

        public task06()
        {
            InitializeComponent();
            RecCheckbox.Tag = FIGURES.Rectangle;
            EllipseCheckbox.Tag = FIGURES.Ellipse;

            SingleFigureRadiobutton.Tag = FIGURE_NUMBER.Single;
            PairFiguresRadiobutton.Tag = FIGURE_NUMBER.Pair;

            SlowSpeedRadiobutton.Tag = INTERVALS.Slow;
            MediumSpeedRadiobutton.Tag = INTERVALS.Medium;
            FastSpeedRadiobutton.Tag = INTERVALS.Fast;
        }

        private void task06_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                task06Screensaver screensaver = new task06Screensaver();

                foreach (CheckBox cb in FigureBox.Controls)
                {
                    if (cb.Checked)
                    {
                        switch (cb.Tag)
                        {
                            case FIGURES.Rectangle:
                                {
                                    screensaver.hasRectangles = true;
                                    break;
                                }
                            case FIGURES.Ellipse:
                                {
                                    screensaver.hasEllipses = true;
                                    break;
                                }
                            default:
                                break;
                        }
                    }
                }

                if (!screensaver.hasEllipses && !screensaver.hasRectangles)
                    throw new Exception("Выберите фигуру для заставки");

                foreach (RadioButton rb in FigureCountBox.Controls)
                {
                    if (rb.Checked)
                        screensaver.figureNumber = (int)rb.Tag;

                    break;
                }

                foreach (RadioButton rb in IntervalGroup.Controls)
                {
                    if (rb.Checked)
                        screensaver.interval = (int)rb.Tag;
                    break;
                }
                
                screensaver.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
