namespace RegexDemo
{
    partial class FormRegex
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelNameSurname = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonPhone = new System.Windows.Forms.Button();
            this.buttonPasport = new System.Windows.Forms.Button();
            this.textBoxPasport = new System.Windows.Forms.TextBox();
            this.labelPasport = new System.Windows.Forms.Label();
            this.buttonNumber = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelNumberResult = new System.Windows.Forms.Label();
            this.labelNameResult = new System.Windows.Forms.Label();
            this.buttonName = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelNameUA = new System.Windows.Forms.Label();
            this.labelTimeResult = new System.Windows.Forms.Label();
            this.buttonTime = new System.Windows.Forms.Button();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelEmailResult = new System.Windows.Forms.Label();
            this.buttonEmail = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPasportResult = new System.Windows.Forms.Label();
            this.labelPhoneResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(10, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(775, 70);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Демонстрація роботи з регулярними виразами";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNameSurname
            // 
            this.labelNameSurname.AutoSize = true;
            this.labelNameSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameSurname.Location = new System.Drawing.Point(486, 423);
            this.labelNameSurname.Name = "labelNameSurname";
            this.labelNameSurname.Size = new System.Drawing.Size(276, 29);
            this.labelNameSurname.TabIndex = 27;
            this.labelNameSurname.Text = "Юр\'єв Нікіта ІПЗ-23-3(2)";
            this.labelNameSurname.Click += new System.EventHandler(this.labelNameSurname_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(12, 109);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(181, 24);
            this.labelPhone.TabIndex = 28;
            this.labelPhone.Text = "Номер телефону:";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhone.Location = new System.Drawing.Point(215, 106);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(251, 29);
            this.textBoxPhone.TabIndex = 29;
            // 
            // buttonPhone
            // 
            this.buttonPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPhone.Location = new System.Drawing.Point(472, 106);
            this.buttonPhone.Name = "buttonPhone";
            this.buttonPhone.Size = new System.Drawing.Size(170, 31);
            this.buttonPhone.TabIndex = 30;
            this.buttonPhone.Text = "Перевірити";
            this.buttonPhone.UseVisualStyleBackColor = true;
            this.buttonPhone.Click += new System.EventHandler(this.buttonPhone_Click);
            // 
            // buttonPasport
            // 
            this.buttonPasport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPasport.Location = new System.Drawing.Point(472, 159);
            this.buttonPasport.Name = "buttonPasport";
            this.buttonPasport.Size = new System.Drawing.Size(170, 31);
            this.buttonPasport.TabIndex = 33;
            this.buttonPasport.Text = "Перевірити";
            this.buttonPasport.UseVisualStyleBackColor = true;
            this.buttonPasport.Click += new System.EventHandler(this.buttonPasport_Click);
            // 
            // textBoxPasport
            // 
            this.textBoxPasport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPasport.Location = new System.Drawing.Point(215, 159);
            this.textBoxPasport.Name = "textBoxPasport";
            this.textBoxPasport.Size = new System.Drawing.Size(251, 29);
            this.textBoxPasport.TabIndex = 32;
            // 
            // labelPasport
            // 
            this.labelPasport.AutoSize = true;
            this.labelPasport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasport.Location = new System.Drawing.Point(12, 162);
            this.labelPasport.Name = "labelPasport";
            this.labelPasport.Size = new System.Drawing.Size(178, 24);
            this.labelPasport.TabIndex = 31;
            this.labelPasport.Text = "Номер паспорта:";
            this.labelPasport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNumber
            // 
            this.buttonNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNumber.Location = new System.Drawing.Point(472, 213);
            this.buttonNumber.Name = "buttonNumber";
            this.buttonNumber.Size = new System.Drawing.Size(170, 31);
            this.buttonNumber.TabIndex = 36;
            this.buttonNumber.Text = "Перевірити";
            this.buttonNumber.UseVisualStyleBackColor = true;
            this.buttonNumber.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumber.Location = new System.Drawing.Point(215, 213);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(251, 29);
            this.textBoxNumber.TabIndex = 35;
            // 
            // labelNumber
            // 
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(-13, 203);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(222, 68);
            this.labelNumber.TabIndex = 34;
            this.labelNumber.Text = "Число з інтервалу [10311; 89645]:";
            this.labelNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelNumberResult
            // 
            this.labelNumberResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberResult.Location = new System.Drawing.Point(648, 216);
            this.labelNumberResult.Name = "labelNumberResult";
            this.labelNumberResult.Size = new System.Drawing.Size(124, 24);
            this.labelNumberResult.TabIndex = 37;
            this.labelNumberResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNameResult
            // 
            this.labelNameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameResult.Location = new System.Drawing.Point(648, 265);
            this.labelNameResult.Name = "labelNameResult";
            this.labelNameResult.Size = new System.Drawing.Size(124, 24);
            this.labelNameResult.TabIndex = 41;
            this.labelNameResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonName
            // 
            this.buttonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonName.Location = new System.Drawing.Point(472, 262);
            this.buttonName.Name = "buttonName";
            this.buttonName.Size = new System.Drawing.Size(170, 31);
            this.buttonName.TabIndex = 40;
            this.buttonName.Text = "Перевірити";
            this.buttonName.UseVisualStyleBackColor = true;
            this.buttonName.Click += new System.EventHandler(this.buttonName_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(215, 262);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(251, 29);
            this.textBoxName.TabIndex = 39;
            // 
            // labelNameUA
            // 
            this.labelNameUA.AutoSize = true;
            this.labelNameUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameUA.Location = new System.Drawing.Point(25, 265);
            this.labelNameUA.Name = "labelNameUA";
            this.labelNameUA.Size = new System.Drawing.Size(165, 24);
            this.labelNameUA.TabIndex = 38;
            this.labelNameUA.Text = "Українське ім\'я:";
            this.labelNameUA.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTimeResult
            // 
            this.labelTimeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeResult.Location = new System.Drawing.Point(648, 314);
            this.labelTimeResult.Name = "labelTimeResult";
            this.labelTimeResult.Size = new System.Drawing.Size(124, 24);
            this.labelTimeResult.TabIndex = 45;
            this.labelTimeResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTime
            // 
            this.buttonTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTime.Location = new System.Drawing.Point(472, 311);
            this.buttonTime.Name = "buttonTime";
            this.buttonTime.Size = new System.Drawing.Size(170, 31);
            this.buttonTime.TabIndex = 44;
            this.buttonTime.Text = "Перевірити";
            this.buttonTime.UseVisualStyleBackColor = true;
            this.buttonTime.Click += new System.EventHandler(this.buttonTime_Click);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTime.Location = new System.Drawing.Point(215, 311);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(251, 29);
            this.textBoxTime.TabIndex = 43;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(65, 314);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(133, 24);
            this.labelTime.TabIndex = 42;
            this.labelTime.Text = "Введіть час:";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelEmailResult
            // 
            this.labelEmailResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmailResult.Location = new System.Drawing.Point(648, 360);
            this.labelEmailResult.Name = "labelEmailResult";
            this.labelEmailResult.Size = new System.Drawing.Size(124, 24);
            this.labelEmailResult.TabIndex = 49;
            this.labelEmailResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEmail
            // 
            this.buttonEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEmail.Location = new System.Drawing.Point(472, 357);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(170, 31);
            this.buttonEmail.TabIndex = 48;
            this.buttonEmail.Text = "Перевірити";
            this.buttonEmail.UseVisualStyleBackColor = true;
            this.buttonEmail.Click += new System.EventHandler(this.buttonEmail_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(215, 357);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(251, 29);
            this.textBoxEmail.TabIndex = 47;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(121, 360);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(75, 24);
            this.labelEmail.TabIndex = 46;
            this.labelEmail.Text = "E-mail:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelPasportResult
            // 
            this.labelPasportResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasportResult.Location = new System.Drawing.Point(648, 162);
            this.labelPasportResult.Name = "labelPasportResult";
            this.labelPasportResult.Size = new System.Drawing.Size(124, 24);
            this.labelPasportResult.TabIndex = 50;
            this.labelPasportResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPhoneResult
            // 
            this.labelPhoneResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneResult.Location = new System.Drawing.Point(648, 109);
            this.labelPhoneResult.Name = "labelPhoneResult";
            this.labelPhoneResult.Size = new System.Drawing.Size(124, 24);
            this.labelPhoneResult.TabIndex = 51;
            this.labelPhoneResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRegex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.labelPhoneResult);
            this.Controls.Add(this.labelPasportResult);
            this.Controls.Add(this.labelEmailResult);
            this.Controls.Add(this.buttonEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTimeResult);
            this.Controls.Add(this.buttonTime);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelNameResult);
            this.Controls.Add(this.buttonName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelNameUA);
            this.Controls.Add(this.labelNumberResult);
            this.Controls.Add(this.buttonNumber);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.buttonPasport);
            this.Controls.Add(this.textBoxPasport);
            this.Controls.Add(this.labelPasport);
            this.Controls.Add(this.buttonPhone);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelNameSurname);
            this.Controls.Add(this.labelName);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormRegex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Демонстрація роботи з регулярними виразами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNameSurname;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonPhone;
        private System.Windows.Forms.Button buttonPasport;
        private System.Windows.Forms.TextBox textBoxPasport;
        private System.Windows.Forms.Label labelPasport;
        private System.Windows.Forms.Button buttonNumber;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelNumberResult;
        private System.Windows.Forms.Label labelNameResult;
        private System.Windows.Forms.Button buttonName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelNameUA;
        private System.Windows.Forms.Label labelTimeResult;
        private System.Windows.Forms.Button buttonTime;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelEmailResult;
        private System.Windows.Forms.Button buttonEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPasportResult;
        private System.Windows.Forms.Label labelPhoneResult;
    }
}

