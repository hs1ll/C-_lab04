namespace C__lab04
{
    partial class task09
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
            this.ResetButton = new System.Windows.Forms.Button();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.StepsTextbox = new System.Windows.Forms.TextBox();
            this.StepsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(27, 392);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(200, 46);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Изобразить новый треугольник";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(585, 392);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(203, 46);
            this.ExecuteButton.TabIndex = 1;
            this.ExecuteButton.Text = "Начать";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // StepsTextbox
            // 
            this.StepsTextbox.Location = new System.Drawing.Point(688, 366);
            this.StepsTextbox.Name = "StepsTextbox";
            this.StepsTextbox.Size = new System.Drawing.Size(100, 20);
            this.StepsTextbox.TabIndex = 2;
            this.StepsTextbox.Text = "0";
            this.StepsTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // StepsLabel
            // 
            this.StepsLabel.AutoSize = true;
            this.StepsLabel.Location = new System.Drawing.Point(582, 369);
            this.StepsLabel.Name = "StepsLabel";
            this.StepsLabel.Size = new System.Drawing.Size(100, 13);
            this.StepsLabel.TabIndex = 3;
            this.StepsLabel.Text = "Количество шагов";
            // 
            // task09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StepsLabel);
            this.Controls.Add(this.StepsTextbox);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.ResetButton);
            this.Name = "task09";
            this.Text = "Task09";
            this.Shown += new System.EventHandler(this.task09_Shown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.task09_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.TextBox StepsTextbox;
        private System.Windows.Forms.Label StepsLabel;
    }
}