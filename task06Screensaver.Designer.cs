namespace C__lab04
{
    partial class task06Screensaver
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
            this.ScreensaverTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ScreensaverTimer
            // 
            this.ScreensaverTimer.Tick += new System.EventHandler(this.ScreensaverTimer_Tick);
            // 
            // task06Screensaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "task06Screensaver";
            this.Text = "task06Screensaver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.task06Screensaver_FormClosing);
            this.Shown += new System.EventHandler(this.task06Screensaver_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.task06Screensaver_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ScreensaverTimer;
    }
}