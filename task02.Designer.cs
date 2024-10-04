namespace C__lab04
{
    partial class Task02
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
            this.InputYear = new System.Windows.Forms.TextBox();
            this.LabelYaer = new System.Windows.Forms.Label();
            this.LabelDays = new System.Windows.Forms.Label();
            this.InputDays = new System.Windows.Forms.TextBox();
            this.LabelMonth = new System.Windows.Forms.Label();
            this.InputMonth = new System.Windows.Forms.TextBox();
            this.LabelLastDays = new System.Windows.Forms.Label();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputYear
            // 
            this.InputYear.Location = new System.Drawing.Point(125, 61);
            this.InputYear.Name = "InputYear";
            this.InputYear.Size = new System.Drawing.Size(100, 20);
            this.InputYear.TabIndex = 0;
            this.InputYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelYaer
            // 
            this.LabelYaer.AutoSize = true;
            this.LabelYaer.Location = new System.Drawing.Point(94, 64);
            this.LabelYaer.Name = "LabelYaer";
            this.LabelYaer.Size = new System.Drawing.Size(25, 13);
            this.LabelYaer.TabIndex = 1;
            this.LabelYaer.Text = "Год";
            // 
            // LabelDays
            // 
            this.LabelDays.AutoSize = true;
            this.LabelDays.Location = new System.Drawing.Point(85, 116);
            this.LabelDays.Name = "LabelDays";
            this.LabelDays.Size = new System.Drawing.Size(34, 13);
            this.LabelDays.TabIndex = 3;
            this.LabelDays.Text = "День";
            // 
            // InputDays
            // 
            this.InputDays.Location = new System.Drawing.Point(125, 113);
            this.InputDays.Name = "InputDays";
            this.InputDays.Size = new System.Drawing.Size(100, 20);
            this.InputDays.TabIndex = 2;
            this.InputDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelMonth
            // 
            this.LabelMonth.AutoSize = true;
            this.LabelMonth.Location = new System.Drawing.Point(79, 90);
            this.LabelMonth.Name = "LabelMonth";
            this.LabelMonth.Size = new System.Drawing.Size(40, 13);
            this.LabelMonth.TabIndex = 5;
            this.LabelMonth.Text = "Месяц";
            // 
            // InputMonth
            // 
            this.InputMonth.Location = new System.Drawing.Point(125, 87);
            this.InputMonth.Name = "InputMonth";
            this.InputMonth.Size = new System.Drawing.Size(100, 20);
            this.InputMonth.TabIndex = 4;
            this.InputMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelLastDays
            // 
            this.LabelLastDays.AutoSize = true;
            this.LabelLastDays.Location = new System.Drawing.Point(249, 67);
            this.LabelLastDays.Name = "LabelLastDays";
            this.LabelLastDays.Size = new System.Drawing.Size(108, 13);
            this.LabelLastDays.TabIndex = 7;
            this.LabelLastDays.Text = "Дней до конца года";
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(363, 64);
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.Size = new System.Drawing.Size(100, 20);
            this.OutputText.TabIndex = 6;
            this.OutputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(713, 415);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteButton.TabIndex = 8;
            this.ExecuteButton.Text = "Вычислить";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // Task02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.LabelLastDays);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.LabelMonth);
            this.Controls.Add(this.InputMonth);
            this.Controls.Add(this.LabelDays);
            this.Controls.Add(this.InputDays);
            this.Controls.Add(this.LabelYaer);
            this.Controls.Add(this.InputYear);
            this.Name = "Task02";
            this.Text = "task02";
            this.Shown += new System.EventHandler(this.Task02_Shown);
            this.Resize += new System.EventHandler(this.Task02_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputYear;
        private System.Windows.Forms.Label LabelYaer;
        private System.Windows.Forms.Label LabelDays;
        private System.Windows.Forms.TextBox InputDays;
        private System.Windows.Forms.Label LabelMonth;
        private System.Windows.Forms.TextBox InputMonth;
        private System.Windows.Forms.Label LabelLastDays;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button ExecuteButton;
    }
}