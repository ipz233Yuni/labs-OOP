namespace task1
{
    partial class FormWeather
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
            this.pictureBoxWeather = new System.Windows.Forms.PictureBox();
            this.labelNameSurname = new System.Windows.Forms.Label();
            this.textBoxWater = new System.Windows.Forms.TextBox();
            this.labelWater = new System.Windows.Forms.Label();
            this.textBoxHumidity = new System.Windows.Forms.TextBox();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.textBoxPress = new System.Windows.Forms.TextBox();
            this.labelPress = new System.Windows.Forms.Label();
            this.textBoxWind = new System.Windows.Forms.TextBox();
            this.labelWind = new System.Windows.Forms.Label();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelWeather = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWeather
            // 
            this.pictureBoxWeather.ImageLocation = "";
            this.pictureBoxWeather.Location = new System.Drawing.Point(44, 60);
            this.pictureBoxWeather.Name = "pictureBoxWeather";
            this.pictureBoxWeather.Size = new System.Drawing.Size(165, 131);
            this.pictureBoxWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeather.TabIndex = 27;
            this.pictureBoxWeather.TabStop = false;
            // 
            // labelNameSurname
            // 
            this.labelNameSurname.AutoSize = true;
            this.labelNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameSurname.Location = new System.Drawing.Point(186, 612);
            this.labelNameSurname.Name = "labelNameSurname";
            this.labelNameSurname.Size = new System.Drawing.Size(276, 29);
            this.labelNameSurname.TabIndex = 26;
            this.labelNameSurname.Text = "Юр\'єв Нікіта ІПЗ-23-3(2)";
            this.labelNameSurname.Click += new System.EventHandler(this.labelNameSurname_Click);
            // 
            // textBoxWater
            // 
            this.textBoxWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWater.Location = new System.Drawing.Point(253, 395);
            this.textBoxWater.Name = "textBoxWater";
            this.textBoxWater.Size = new System.Drawing.Size(195, 35);
            this.textBoxWater.TabIndex = 25;
            // 
            // labelWater
            // 
            this.labelWater.AutoSize = true;
            this.labelWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWater.Location = new System.Drawing.Point(12, 398);
            this.labelWater.Name = "labelWater";
            this.labelWater.Size = new System.Drawing.Size(235, 29);
            this.labelWater.TabIndex = 24;
            this.labelWater.Text = "Температура води:";
            // 
            // textBoxHumidity
            // 
            this.textBoxHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHumidity.Location = new System.Drawing.Point(253, 345);
            this.textBoxHumidity.Name = "textBoxHumidity";
            this.textBoxHumidity.Size = new System.Drawing.Size(195, 35);
            this.textBoxHumidity.TabIndex = 23;
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHumidity.Location = new System.Drawing.Point(115, 345);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(132, 29);
            this.labelHumidity.TabIndex = 22;
            this.labelHumidity.Text = "Вологість:";
            // 
            // textBoxPress
            // 
            this.textBoxPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPress.Location = new System.Drawing.Point(253, 295);
            this.textBoxPress.Name = "textBoxPress";
            this.textBoxPress.Size = new System.Drawing.Size(195, 35);
            this.textBoxPress.TabIndex = 21;
            // 
            // labelPress
            // 
            this.labelPress.AutoSize = true;
            this.labelPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPress.Location = new System.Drawing.Point(164, 295);
            this.labelPress.Name = "labelPress";
            this.labelPress.Size = new System.Drawing.Size(74, 29);
            this.labelPress.TabIndex = 20;
            this.labelPress.Text = "Тиск:";
            // 
            // textBoxWind
            // 
            this.textBoxWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWind.Location = new System.Drawing.Point(253, 245);
            this.textBoxWind.Name = "textBoxWind";
            this.textBoxWind.Size = new System.Drawing.Size(195, 35);
            this.textBoxWind.TabIndex = 19;
            // 
            // labelWind
            // 
            this.labelWind.AutoSize = true;
            this.labelWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWind.Location = new System.Drawing.Point(157, 245);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(81, 29);
            this.labelWind.TabIndex = 18;
            this.labelWind.Text = "Вітер:";
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTemperature.Location = new System.Drawing.Point(253, 194);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.Size = new System.Drawing.Size(195, 35);
            this.textBoxTemperature.TabIndex = 17;
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.Location = new System.Drawing.Point(93, 513);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(295, 68);
            this.buttonResult.TabIndex = 16;
            this.buttonResult.Text = "Оновити";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTemp.Location = new System.Drawing.Point(65, 194);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(173, 29);
            this.labelTemp.TabIndex = 15;
            this.labelTemp.Text = "Температура:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(86, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(310, 37);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Погода в Житомирі";
            // 
            // labelWeather
            // 
            this.labelWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWeather.ForeColor = System.Drawing.Color.Blue;
            this.labelWeather.Location = new System.Drawing.Point(215, 93);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(257, 54);
            this.labelWeather.TabIndex = 28;
            this.labelWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.pictureBoxWeather);
            this.Controls.Add(this.labelNameSurname);
            this.Controls.Add(this.textBoxWater);
            this.Controls.Add(this.labelWater);
            this.Controls.Add(this.textBoxHumidity);
            this.Controls.Add(this.labelHumidity);
            this.Controls.Add(this.textBoxPress);
            this.Controls.Add(this.labelPress);
            this.Controls.Add(this.textBoxWind);
            this.Controls.Add(this.labelWind);
            this.Controls.Add(this.textBoxTemperature);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelName);
            this.MaximumSize = new System.Drawing.Size(500, 700);
            this.MinimumSize = new System.Drawing.Size(500, 700);
            this.Name = "FormWeather";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.buttonResult_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWeather;
        private System.Windows.Forms.Label labelNameSurname;
        private System.Windows.Forms.TextBox textBoxWater;
        private System.Windows.Forms.Label labelWater;
        private System.Windows.Forms.TextBox textBoxHumidity;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.TextBox textBoxPress;
        private System.Windows.Forms.Label labelPress;
        private System.Windows.Forms.TextBox textBoxWind;
        private System.Windows.Forms.Label labelWind;
        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWeather;
    }
}

