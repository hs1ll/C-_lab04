namespace C__lab04
{
    partial class task06
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
            this.FigureBox = new System.Windows.Forms.GroupBox();
            this.RecCheckbox = new System.Windows.Forms.CheckBox();
            this.EllipseCheckbox = new System.Windows.Forms.CheckBox();
            this.FigureCountBox = new System.Windows.Forms.GroupBox();
            this.SingleFigureRadiobutton = new System.Windows.Forms.RadioButton();
            this.PairFiguresRadiobutton = new System.Windows.Forms.RadioButton();
            this.IntervalGroup = new System.Windows.Forms.GroupBox();
            this.MediumSpeedRadiobutton = new System.Windows.Forms.RadioButton();
            this.SlowSpeedRadiobutton = new System.Windows.Forms.RadioButton();
            this.FastSpeedRadiobutton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.FigureBox.SuspendLayout();
            this.FigureCountBox.SuspendLayout();
            this.IntervalGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // FigureBox
            // 
            this.FigureBox.Controls.Add(this.EllipseCheckbox);
            this.FigureBox.Controls.Add(this.RecCheckbox);
            this.FigureBox.Location = new System.Drawing.Point(25, 41);
            this.FigureBox.Name = "FigureBox";
            this.FigureBox.Size = new System.Drawing.Size(137, 94);
            this.FigureBox.TabIndex = 0;
            this.FigureBox.TabStop = false;
            this.FigureBox.Text = "Вид фигуры";
            // 
            // RecCheckbox
            // 
            this.RecCheckbox.AutoSize = true;
            this.RecCheckbox.Checked = true;
            this.RecCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RecCheckbox.Location = new System.Drawing.Point(7, 20);
            this.RecCheckbox.Name = "RecCheckbox";
            this.RecCheckbox.Size = new System.Drawing.Size(106, 17);
            this.RecCheckbox.TabIndex = 0;
            this.RecCheckbox.Tag = "Rectangle";
            this.RecCheckbox.Text = "Прямоугольник";
            this.RecCheckbox.UseVisualStyleBackColor = true;
            // 
            // EllipseCheckbox
            // 
            this.EllipseCheckbox.AutoSize = true;
            this.EllipseCheckbox.Location = new System.Drawing.Point(7, 43);
            this.EllipseCheckbox.Name = "EllipseCheckbox";
            this.EllipseCheckbox.Size = new System.Drawing.Size(63, 17);
            this.EllipseCheckbox.TabIndex = 1;
            this.EllipseCheckbox.Tag = "Ellipse";
            this.EllipseCheckbox.Text = "Эллипс";
            this.EllipseCheckbox.UseVisualStyleBackColor = true;
            // 
            // FigureCountBox
            // 
            this.FigureCountBox.Controls.Add(this.PairFiguresRadiobutton);
            this.FigureCountBox.Controls.Add(this.SingleFigureRadiobutton);
            this.FigureCountBox.Location = new System.Drawing.Point(189, 41);
            this.FigureCountBox.Name = "FigureCountBox";
            this.FigureCountBox.Size = new System.Drawing.Size(137, 94);
            this.FigureCountBox.TabIndex = 2;
            this.FigureCountBox.TabStop = false;
            this.FigureCountBox.Text = "Количество фигур";
            // 
            // SingleFigureRadiobutton
            // 
            this.SingleFigureRadiobutton.AutoSize = true;
            this.SingleFigureRadiobutton.Checked = true;
            this.SingleFigureRadiobutton.Location = new System.Drawing.Point(7, 20);
            this.SingleFigureRadiobutton.Name = "SingleFigureRadiobutton";
            this.SingleFigureRadiobutton.Size = new System.Drawing.Size(51, 17);
            this.SingleFigureRadiobutton.TabIndex = 0;
            this.SingleFigureRadiobutton.TabStop = true;
            this.SingleFigureRadiobutton.Tag = "Single";
            this.SingleFigureRadiobutton.Text = "Одна";
            this.SingleFigureRadiobutton.UseVisualStyleBackColor = true;
            // 
            // PairFiguresRadiobutton
            // 
            this.PairFiguresRadiobutton.AutoSize = true;
            this.PairFiguresRadiobutton.Location = new System.Drawing.Point(7, 44);
            this.PairFiguresRadiobutton.Name = "PairFiguresRadiobutton";
            this.PairFiguresRadiobutton.Size = new System.Drawing.Size(46, 17);
            this.PairFiguresRadiobutton.TabIndex = 1;
            this.PairFiguresRadiobutton.TabStop = true;
            this.PairFiguresRadiobutton.Tag = "Pair";
            this.PairFiguresRadiobutton.Text = "Две";
            this.PairFiguresRadiobutton.UseVisualStyleBackColor = true;
            // 
            // IntervalGroup
            // 
            this.IntervalGroup.Controls.Add(this.FastSpeedRadiobutton);
            this.IntervalGroup.Controls.Add(this.MediumSpeedRadiobutton);
            this.IntervalGroup.Controls.Add(this.SlowSpeedRadiobutton);
            this.IntervalGroup.Location = new System.Drawing.Point(359, 41);
            this.IntervalGroup.Name = "IntervalGroup";
            this.IntervalGroup.Size = new System.Drawing.Size(156, 94);
            this.IntervalGroup.TabIndex = 3;
            this.IntervalGroup.TabStop = false;
            this.IntervalGroup.Text = "Скорость смены фигур";
            // 
            // MediumSpeedRadiobutton
            // 
            this.MediumSpeedRadiobutton.AutoSize = true;
            this.MediumSpeedRadiobutton.Location = new System.Drawing.Point(7, 44);
            this.MediumSpeedRadiobutton.Name = "MediumSpeedRadiobutton";
            this.MediumSpeedRadiobutton.Size = new System.Drawing.Size(62, 17);
            this.MediumSpeedRadiobutton.TabIndex = 1;
            this.MediumSpeedRadiobutton.TabStop = true;
            this.MediumSpeedRadiobutton.Tag = "Medium";
            this.MediumSpeedRadiobutton.Text = "Средне";
            this.MediumSpeedRadiobutton.UseVisualStyleBackColor = true;
            // 
            // SlowSpeedRadiobutton
            // 
            this.SlowSpeedRadiobutton.AutoSize = true;
            this.SlowSpeedRadiobutton.Checked = true;
            this.SlowSpeedRadiobutton.Location = new System.Drawing.Point(7, 20);
            this.SlowSpeedRadiobutton.Name = "SlowSpeedRadiobutton";
            this.SlowSpeedRadiobutton.Size = new System.Drawing.Size(76, 17);
            this.SlowSpeedRadiobutton.TabIndex = 0;
            this.SlowSpeedRadiobutton.TabStop = true;
            this.SlowSpeedRadiobutton.Tag = "Slow";
            this.SlowSpeedRadiobutton.Text = "Медленно";
            this.SlowSpeedRadiobutton.UseVisualStyleBackColor = true;
            // 
            // FastSpeedRadiobutton
            // 
            this.FastSpeedRadiobutton.AutoSize = true;
            this.FastSpeedRadiobutton.Location = new System.Drawing.Point(7, 67);
            this.FastSpeedRadiobutton.Name = "FastSpeedRadiobutton";
            this.FastSpeedRadiobutton.Size = new System.Drawing.Size(63, 17);
            this.FastSpeedRadiobutton.TabIndex = 2;
            this.FastSpeedRadiobutton.TabStop = true;
            this.FastSpeedRadiobutton.Tag = "Fast";
            this.FastSpeedRadiobutton.Text = "Быстро";
            this.FastSpeedRadiobutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Для запуска - двойной щелчок по форме";
            // 
            // task06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 219);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IntervalGroup);
            this.Controls.Add(this.FigureCountBox);
            this.Controls.Add(this.FigureBox);
            this.Name = "task06";
            this.Text = "task06";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.task06_MouseDoubleClick);
            this.FigureBox.ResumeLayout(false);
            this.FigureBox.PerformLayout();
            this.FigureCountBox.ResumeLayout(false);
            this.FigureCountBox.PerformLayout();
            this.IntervalGroup.ResumeLayout(false);
            this.IntervalGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FigureBox;
        private System.Windows.Forms.CheckBox EllipseCheckbox;
        private System.Windows.Forms.CheckBox RecCheckbox;
        private System.Windows.Forms.GroupBox FigureCountBox;
        private System.Windows.Forms.RadioButton SingleFigureRadiobutton;
        private System.Windows.Forms.RadioButton PairFiguresRadiobutton;
        private System.Windows.Forms.GroupBox IntervalGroup;
        private System.Windows.Forms.RadioButton FastSpeedRadiobutton;
        private System.Windows.Forms.RadioButton MediumSpeedRadiobutton;
        private System.Windows.Forms.RadioButton SlowSpeedRadiobutton;
        private System.Windows.Forms.Label label1;
    }
}