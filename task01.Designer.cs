namespace C__lab04
{
    partial class task01
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputGroup = new System.Windows.Forms.GroupBox();
            this.OutputGroup = new System.Windows.Forms.GroupBox();
            this.InputText = new System.Windows.Forms.TextBox();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.InputInchRadioButton = new System.Windows.Forms.RadioButton();
            this.InputFootRadioButton = new System.Windows.Forms.RadioButton();
            this.InputYardRadioButton = new System.Windows.Forms.RadioButton();
            this.InputCentimeterRadioButton = new System.Windows.Forms.RadioButton();
            this.InputMeterRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.InputMeasureGroup = new System.Windows.Forms.GroupBox();
            this.OutputMeasureGroup = new System.Windows.Forms.GroupBox();
            this.InputGroup.SuspendLayout();
            this.OutputGroup.SuspendLayout();
            this.InputMeasureGroup.SuspendLayout();
            this.OutputMeasureGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputGroup
            // 
            this.InputGroup.Controls.Add(this.InputMeasureGroup);
            this.InputGroup.Controls.Add(this.InputText);
            this.InputGroup.Location = new System.Drawing.Point(12, 47);
            this.InputGroup.Name = "InputGroup";
            this.InputGroup.Size = new System.Drawing.Size(390, 144);
            this.InputGroup.TabIndex = 0;
            this.InputGroup.TabStop = false;
            this.InputGroup.Text = "Исходные данные";
            // 
            // OutputGroup
            // 
            this.OutputGroup.Controls.Add(this.OutputMeasureGroup);
            this.OutputGroup.Controls.Add(this.OutputText);
            this.OutputGroup.Location = new System.Drawing.Point(408, 47);
            this.OutputGroup.Name = "OutputGroup";
            this.OutputGroup.Size = new System.Drawing.Size(380, 144);
            this.OutputGroup.TabIndex = 1;
            this.OutputGroup.TabStop = false;
            this.OutputGroup.Text = "Результат";
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(284, 19);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(100, 20);
            this.InputText.TabIndex = 0;
            this.InputText.Text = "0";
            this.InputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(274, 22);
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.Size = new System.Drawing.Size(100, 20);
            this.OutputText.TabIndex = 1;
            this.OutputText.Text = "0";
            this.OutputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InputInchRadioButton
            // 
            this.InputInchRadioButton.AutoSize = true;
            this.InputInchRadioButton.Location = new System.Drawing.Point(6, 19);
            this.InputInchRadioButton.Name = "InputInchRadioButton";
            this.InputInchRadioButton.Size = new System.Drawing.Size(56, 17);
            this.InputInchRadioButton.TabIndex = 1;
            this.InputInchRadioButton.TabStop = true;
            this.InputInchRadioButton.Text = "Дюйм";
            this.InputInchRadioButton.UseVisualStyleBackColor = true;
            this.InputInchRadioButton.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // InputFootRadioButton
            // 
            this.InputFootRadioButton.AutoSize = true;
            this.InputFootRadioButton.Location = new System.Drawing.Point(6, 42);
            this.InputFootRadioButton.Name = "InputFootRadioButton";
            this.InputFootRadioButton.Size = new System.Drawing.Size(46, 17);
            this.InputFootRadioButton.TabIndex = 2;
            this.InputFootRadioButton.TabStop = true;
            this.InputFootRadioButton.Text = "Фут";
            this.InputFootRadioButton.UseVisualStyleBackColor = true;
            this.InputFootRadioButton.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // InputYardRadioButton
            // 
            this.InputYardRadioButton.AutoSize = true;
            this.InputYardRadioButton.Location = new System.Drawing.Point(6, 65);
            this.InputYardRadioButton.Name = "InputYardRadioButton";
            this.InputYardRadioButton.Size = new System.Drawing.Size(45, 17);
            this.InputYardRadioButton.TabIndex = 3;
            this.InputYardRadioButton.TabStop = true;
            this.InputYardRadioButton.Text = "Ярд";
            this.InputYardRadioButton.UseVisualStyleBackColor = true;
            this.InputYardRadioButton.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // InputCentimeterRadioButton
            // 
            this.InputCentimeterRadioButton.AutoSize = true;
            this.InputCentimeterRadioButton.Location = new System.Drawing.Point(6, 88);
            this.InputCentimeterRadioButton.Name = "InputCentimeterRadioButton";
            this.InputCentimeterRadioButton.Size = new System.Drawing.Size(80, 17);
            this.InputCentimeterRadioButton.TabIndex = 4;
            this.InputCentimeterRadioButton.TabStop = true;
            this.InputCentimeterRadioButton.Text = "Сантиметр";
            this.InputCentimeterRadioButton.UseVisualStyleBackColor = true;
            this.InputCentimeterRadioButton.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // InputMeterRadioButton
            // 
            this.InputMeterRadioButton.AutoSize = true;
            this.InputMeterRadioButton.Location = new System.Drawing.Point(6, 111);
            this.InputMeterRadioButton.Name = "InputMeterRadioButton";
            this.InputMeterRadioButton.Size = new System.Drawing.Size(51, 17);
            this.InputMeterRadioButton.TabIndex = 5;
            this.InputMeterRadioButton.TabStop = true;
            this.InputMeterRadioButton.Text = "Метр";
            this.InputMeterRadioButton.UseVisualStyleBackColor = true;
            this.InputMeterRadioButton.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 112);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Метр";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 89);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Сантиметр";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ярд";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(19, 43);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(46, 17);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Фут";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(19, 20);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(56, 17);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Дюйм";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(336, 212);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(140, 37);
            this.ExecuteButton.TabIndex = 2;
            this.ExecuteButton.Text = "Перевести";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // InputMeasureGroup
            // 
            this.InputMeasureGroup.Controls.Add(this.InputInchRadioButton);
            this.InputMeasureGroup.Controls.Add(this.InputMeterRadioButton);
            this.InputMeasureGroup.Controls.Add(this.InputFootRadioButton);
            this.InputMeasureGroup.Controls.Add(this.InputCentimeterRadioButton);
            this.InputMeasureGroup.Controls.Add(this.InputYardRadioButton);
            this.InputMeasureGroup.Location = new System.Drawing.Point(137, 0);
            this.InputMeasureGroup.Name = "InputMeasureGroup";
            this.InputMeasureGroup.Size = new System.Drawing.Size(130, 144);
            this.InputMeasureGroup.TabIndex = 6;
            this.InputMeasureGroup.TabStop = false;
            this.InputMeasureGroup.Text = "Меры";
            // 
            // OutputMeasureGroup
            // 
            this.OutputMeasureGroup.Controls.Add(this.radioButton5);
            this.OutputMeasureGroup.Controls.Add(this.radioButton1);
            this.OutputMeasureGroup.Controls.Add(this.radioButton4);
            this.OutputMeasureGroup.Controls.Add(this.radioButton3);
            this.OutputMeasureGroup.Controls.Add(this.radioButton2);
            this.OutputMeasureGroup.Location = new System.Drawing.Point(123, 0);
            this.OutputMeasureGroup.Name = "OutputMeasureGroup";
            this.OutputMeasureGroup.Size = new System.Drawing.Size(130, 144);
            this.OutputMeasureGroup.TabIndex = 11;
            this.OutputMeasureGroup.TabStop = false;
            this.OutputMeasureGroup.Text = "Меры";
            // 
            // task01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 291);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.OutputGroup);
            this.Controls.Add(this.InputGroup);
            this.Name = "task01";
            this.Text = "Task01";
            this.InputGroup.ResumeLayout(false);
            this.InputGroup.PerformLayout();
            this.OutputGroup.ResumeLayout(false);
            this.OutputGroup.PerformLayout();
            this.InputMeasureGroup.ResumeLayout(false);
            this.InputMeasureGroup.PerformLayout();
            this.OutputMeasureGroup.ResumeLayout(false);
            this.OutputMeasureGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InputGroup;
        private System.Windows.Forms.RadioButton InputYardRadioButton;
        private System.Windows.Forms.RadioButton InputFootRadioButton;
        private System.Windows.Forms.RadioButton InputInchRadioButton;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.GroupBox OutputGroup;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.RadioButton InputMeterRadioButton;
        private System.Windows.Forms.RadioButton InputCentimeterRadioButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.GroupBox InputMeasureGroup;
        private System.Windows.Forms.GroupBox OutputMeasureGroup;
    }
}

