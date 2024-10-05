namespace C__lab04
{
    partial class task04Trainer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TrainerTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TrainerTimer
            // 
            this.TrainerTimer.Tick += new System.EventHandler(this.TrainerTimer_Tick);
            // 
            // task04Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 231);
            this.Name = "task04Trainer";
            this.Text = "task04Trainer";
            this.Shown += new System.EventHandler(this.task04Trainer_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.task04Trainer_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TrainerTimer;
    }
}