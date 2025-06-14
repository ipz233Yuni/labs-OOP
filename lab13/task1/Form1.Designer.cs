namespace task1
{
    partial class Form1
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
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.encryption = new System.Windows.Forms.ToolStripMenuItem();
            this.unencryption = new System.Windows.Forms.ToolStripMenuItem();
            this.archiving = new System.Windows.Forms.ToolStripMenuItem();
            this.unarchiving = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.menuStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStripMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryption,
            this.unencryption,
            this.archiving,
            this.unarchiving});
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Size = new System.Drawing.Size(784, 33);
            this.menuStripMenu.TabIndex = 0;
            this.menuStripMenu.Text = "menuStrip1";
            // 
            // encryption
            // 
            this.encryption.Name = "encryption";
            this.encryption.Size = new System.Drawing.Size(145, 29);
            this.encryption.Text = "шифрування";
            this.encryption.Click += new System.EventHandler(this.encryption_Click);
            // 
            // unencryption
            // 
            this.unencryption.Name = "unencryption";
            this.unencryption.Size = new System.Drawing.Size(178, 29);
            this.unencryption.Text = "розшифрування";
            this.unencryption.Click += new System.EventHandler(this.unencryption_Click);
            // 
            // archiving
            // 
            this.archiving.Name = "archiving";
            this.archiving.Size = new System.Drawing.Size(139, 29);
            this.archiving.Text = "архівування";
            this.archiving.Click += new System.EventHandler(this.archiving_Click);
            // 
            // unarchiving
            // 
            this.unarchiving.Name = "unarchiving";
            this.unarchiving.Size = new System.Drawing.Size(172, 29);
            this.unarchiving.Text = "розархівування";
            this.unarchiving.Click += new System.EventHandler(this.unarchiving_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 20;
            this.listBoxFiles.Location = new System.Drawing.Point(12, 101);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(760, 144);
            this.listBoxFiles.TabIndex = 1;
            this.listBoxFiles.UseWaitCursor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonDownload
            // 
            this.buttonDownload.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDownload.Location = new System.Drawing.Point(12, 45);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(254, 50);
            this.buttonDownload.TabIndex = 2;
            this.buttonDownload.Text = "Завантажити файл";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClean.Location = new System.Drawing.Point(518, 45);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(254, 50);
            this.buttonClean.TabIndex = 3;
            this.buttonClean.Text = "Очистити";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.Location = new System.Drawing.Point(12, 251);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(254, 50);
            this.buttonResult.TabIndex = 4;
            this.buttonResult.Text = "Зберегти";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 20;
            this.listBoxResult.Location = new System.Drawing.Point(12, 307);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(760, 144);
            this.listBoxResult.TabIndex = 5;
            this.listBoxResult.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.menuStripMenu);
            this.MainMenuStrip = this.menuStripMenu;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №13";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.menuStripMenu.ResumeLayout(false);
            this.menuStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem encryption;
        private System.Windows.Forms.ToolStripMenuItem unencryption;
        private System.Windows.Forms.ToolStripMenuItem archiving;
        private System.Windows.Forms.ToolStripMenuItem unarchiving;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.ListBox listBoxResult;
    }
}

