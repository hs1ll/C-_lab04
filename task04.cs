using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__lab04
{
    public partial class task04 : Form
    {
        public task04()
        {
            InitializeComponent();
        }

        private void task04_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13))
            {
                task04Trainer trainer = new task04Trainer(3000);
                foreach (RadioButton rb in DifficultyBox.Controls)
                {
                    if (rb.Checked)
                    {
                        switch (rb.Tag)
                        {
                            case "Easy":
                                {
                                    trainer = new task04Trainer(3000);
                                    break;
                                }
                            case "Medium":
                                {
                                    trainer = new task04Trainer(1000);
                                    break;
                                }
                            case "Hard":
                                {
                                    trainer = new task04Trainer(500);
                                    break;
                                }
                            default: break;
                        }

                        break;
                    }
                }

                trainer.ShowDialog();
            }
        }
    }
}
