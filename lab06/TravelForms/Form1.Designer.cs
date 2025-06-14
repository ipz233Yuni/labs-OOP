namespace TravelForms
{
    partial class Form1
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
            this.travelersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.informationLabel = new System.Windows.Forms.Label();
            this.travelersLabel = new System.Windows.Forms.Label();
            this.daysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.daysLabel = new System.Windows.Forms.Label();
            this.tripLabel = new System.Windows.Forms.Label();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.summerRadioButton = new System.Windows.Forms.RadioButton();
            this.winterRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.guideCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.travelersNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // travelersNumericUpDown
            // 
            this.travelersNumericUpDown.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelersNumericUpDown.Location = new System.Drawing.Point(259, 110);
            this.travelersNumericUpDown.Name = "travelersNumericUpDown";
            this.travelersNumericUpDown.Size = new System.Drawing.Size(180, 39);
            this.travelersNumericUpDown.TabIndex = 0;
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationLabel.Location = new System.Drawing.Point(27, 47);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(448, 32);
            this.informationLabel.TabIndex = 1;
            this.informationLabel.Text = "Інформація про відпочиваючих";
            // 
            // travelersLabel
            // 
            this.travelersLabel.AutoSize = true;
            this.travelersLabel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelersLabel.Location = new System.Drawing.Point(28, 112);
            this.travelersLabel.Name = "travelersLabel";
            this.travelersLabel.Size = new System.Drawing.Size(221, 32);
            this.travelersLabel.TabIndex = 2;
            this.travelersLabel.Text = "Кількість людей:";
            // 
            // daysNumericUpDown
            // 
            this.daysNumericUpDown.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysNumericUpDown.Location = new System.Drawing.Point(259, 182);
            this.daysNumericUpDown.Name = "daysNumericUpDown";
            this.daysNumericUpDown.Size = new System.Drawing.Size(180, 39);
            this.daysNumericUpDown.TabIndex = 3;
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysLabel.Location = new System.Drawing.Point(28, 184);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(191, 32);
            this.daysLabel.TabIndex = 4;
            this.daysLabel.Text = "Кількість днів:";
            // 
            // tripLabel
            // 
            this.tripLabel.AutoSize = true;
            this.tripLabel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tripLabel.Location = new System.Drawing.Point(594, 47);
            this.tripLabel.Name = "tripLabel";
            this.tripLabel.Size = new System.Drawing.Size(117, 32);
            this.tripLabel.TabIndex = 5;
            this.tripLabel.Text = "Поїздка";
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.Items.AddRange(new object[] {
            "Болгарія",
            "Німеччина",
            "Польща"});
            this.destinationComboBox.Location = new System.Drawing.Point(795, 117);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(193, 40);
            this.destinationComboBox.TabIndex = 6;
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationLabel.Location = new System.Drawing.Point(595, 120);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(185, 32);
            this.destinationLabel.TabIndex = 7;
            this.destinationLabel.Text = "Призначення:";
            // 
            // summerRadioButton
            // 
            this.summerRadioButton.AutoSize = true;
            this.summerRadioButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summerRadioButton.Location = new System.Drawing.Point(601, 185);
            this.summerRadioButton.Name = "summerRadioButton";
            this.summerRadioButton.Size = new System.Drawing.Size(96, 36);
            this.summerRadioButton.TabIndex = 8;
            this.summerRadioButton.TabStop = true;
            this.summerRadioButton.Text = "Літо";
            this.summerRadioButton.UseVisualStyleBackColor = true;
            // 
            // winterRadioButton
            // 
            this.winterRadioButton.AutoSize = true;
            this.winterRadioButton.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winterRadioButton.Location = new System.Drawing.Point(733, 185);
            this.winterRadioButton.Name = "winterRadioButton";
            this.winterRadioButton.Size = new System.Drawing.Size(110, 36);
            this.winterRadioButton.TabIndex = 9;
            this.winterRadioButton.TabStop = true;
            this.winterRadioButton.Text = "Зима";
            this.winterRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(28, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Вартість:";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceTextBox.ForeColor = System.Drawing.Color.Red;
            this.totalPriceTextBox.Location = new System.Drawing.Point(218, 259);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(257, 44);
            this.totalPriceTextBox.TabIndex = 12;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(601, 248);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(216, 55);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Розрахувати";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // guideCheckBox
            // 
            this.guideCheckBox.AutoSize = true;
            this.guideCheckBox.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guideCheckBox.Location = new System.Drawing.Point(870, 186);
            this.guideCheckBox.Name = "guideCheckBox";
            this.guideCheckBox.Size = new System.Drawing.Size(83, 36);
            this.guideCheckBox.TabIndex = 14;
            this.guideCheckBox.Text = "Гід";
            this.guideCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 347);
            this.Controls.Add(this.guideCheckBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winterRadioButton);
            this.Controls.Add(this.summerRadioButton);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.destinationComboBox);
            this.Controls.Add(this.tripLabel);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.daysNumericUpDown);
            this.Controls.Add(this.travelersLabel);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.travelersNumericUpDown);
            this.Name = "Form1";
            this.Text = "TravelForms";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelersNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown travelersNumericUpDown;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Label travelersLabel;
        private System.Windows.Forms.NumericUpDown daysNumericUpDown;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label tripLabel;
        private System.Windows.Forms.ComboBox destinationComboBox;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.RadioButton summerRadioButton;
        private System.Windows.Forms.RadioButton winterRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.CheckBox guideCheckBox;
    }
}

