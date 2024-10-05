namespace C__lab04
{
    partial class task04
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
            this.MedumDifficulty = new System.Windows.Forms.RadioButton();
            this.HardDifficulty = new System.Windows.Forms.RadioButton();
            this.EasyDifficulty = new System.Windows.Forms.RadioButton();
            this.DifficultyBox = new System.Windows.Forms.GroupBox();
            this.DifficultyBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MedumDifficulty
            // 
            this.MedumDifficulty.AutoSize = true;
            this.MedumDifficulty.Location = new System.Drawing.Point(10, 42);
            this.MedumDifficulty.Name = "MedumDifficulty";
            this.MedumDifficulty.Size = new System.Drawing.Size(183, 17);
            this.MedumDifficulty.TabIndex = 2;
            this.MedumDifficulty.Tag = "Medium";
            this.MedumDifficulty.Text = "Средний (1 секунда на символ)";
            this.MedumDifficulty.UseVisualStyleBackColor = true;
            // 
            // HardDifficulty
            // 
            this.HardDifficulty.AutoSize = true;
            this.HardDifficulty.Location = new System.Drawing.Point(10, 65);
            this.HardDifficulty.Name = "HardDifficulty";
            this.HardDifficulty.Size = new System.Drawing.Size(198, 17);
            this.HardDifficulty.TabIndex = 3;
            this.HardDifficulty.Tag = "Hard";
            this.HardDifficulty.Text = "Сложный (0,5 секунды на символ)";
            this.HardDifficulty.UseVisualStyleBackColor = true;
            // 
            // EasyDifficulty
            // 
            this.EasyDifficulty.AutoSize = true;
            this.EasyDifficulty.Checked = true;
            this.EasyDifficulty.Location = new System.Drawing.Point(10, 19);
            this.EasyDifficulty.Name = "EasyDifficulty";
            this.EasyDifficulty.Size = new System.Drawing.Size(179, 17);
            this.EasyDifficulty.TabIndex = 11;
            this.EasyDifficulty.TabStop = true;
            this.EasyDifficulty.Tag = "Easy";
            this.EasyDifficulty.Text = "Легкий (3 секунды на символ)";
            this.EasyDifficulty.UseVisualStyleBackColor = true;
            // 
            // DifficultyBox
            // 
            this.DifficultyBox.Controls.Add(this.EasyDifficulty);
            this.DifficultyBox.Controls.Add(this.HardDifficulty);
            this.DifficultyBox.Controls.Add(this.MedumDifficulty);
            this.DifficultyBox.Location = new System.Drawing.Point(68, 44);
            this.DifficultyBox.Name = "DifficultyBox";
            this.DifficultyBox.Size = new System.Drawing.Size(242, 120);
            this.DifficultyBox.TabIndex = 4;
            this.DifficultyBox.TabStop = false;
            this.DifficultyBox.Text = "Выберите сложность";
            // 
            // task04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 231);
            this.Controls.Add(this.DifficultyBox);
            this.KeyPreview = true;
            this.Name = "task04";
            this.Text = "Task04";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.task04_KeyPress);
            this.DifficultyBox.ResumeLayout(false);
            this.DifficultyBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton MedumDifficulty;
        private System.Windows.Forms.RadioButton HardDifficulty;
        private System.Windows.Forms.RadioButton EasyDifficulty;
        private System.Windows.Forms.GroupBox DifficultyBox;
    }
}