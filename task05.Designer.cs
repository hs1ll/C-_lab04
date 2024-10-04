namespace C__lab04
{
    partial class task05
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
            this.InputA = new System.Windows.Forms.TextBox();
            this.ALabel = new System.Windows.Forms.Label();
            this.BLabel = new System.Windows.Forms.Label();
            this.InputB = new System.Windows.Forms.TextBox();
            this.CLabel = new System.Windows.Forms.Label();
            this.InputC = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputA
            // 
            this.InputA.Location = new System.Drawing.Point(199, 65);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(85, 20);
            this.InputA.TabIndex = 0;
            this.InputA.Text = "0";
            this.InputA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(177, 68);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(16, 13);
            this.ALabel.TabIndex = 1;
            this.ALabel.Text = "a:";
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(177, 94);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(16, 13);
            this.BLabel.TabIndex = 3;
            this.BLabel.Text = "b:";
            // 
            // InputB
            // 
            this.InputB.Location = new System.Drawing.Point(199, 91);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(85, 20);
            this.InputB.TabIndex = 2;
            this.InputB.Text = "0";
            this.InputB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(177, 120);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(16, 13);
            this.CLabel.TabIndex = 5;
            this.CLabel.Text = "c:";
            // 
            // InputC
            // 
            this.InputC.Location = new System.Drawing.Point(199, 117);
            this.InputC.Name = "InputC";
            this.InputC.Size = new System.Drawing.Size(85, 20);
            this.InputC.TabIndex = 4;
            this.InputC.Text = "0";
            this.InputC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(392, 64);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(396, 20);
            this.Output.TabIndex = 6;
            this.Output.Text = "None";
            this.Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(199, 159);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteButton.TabIndex = 7;
            this.ExecuteButton.Text = "Посчитать";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // task05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.InputC);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.InputB);
            this.Controls.Add(this.ALabel);
            this.Controls.Add(this.InputA);
            this.Name = "task05";
            this.Text = "Task05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputA;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.TextBox InputB;
        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.TextBox InputC;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button ExecuteButton;
    }
}