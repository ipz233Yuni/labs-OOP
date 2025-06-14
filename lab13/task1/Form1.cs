using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibrary1;


namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    listBoxFiles.Items.Add(fileName);
                }
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            listBoxFiles.Items.Clear();
            listBoxResult.Items.Clear();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (listBoxResult.SelectedItem != null)
            {
                string selectedFile = listBoxResult.SelectedItem.ToString();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = Path.GetFileName(selectedFile); 
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialog.FileName;
                    File.Copy(selectedFile, savePath, true);
                }
            }
            else
            {
                MessageBox.Show("Виберіть файл для завантаження!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void encryption_Click(object sender, EventArgs e)
        {
            foreach (string selectedFile in listBoxFiles.Items)
            {
                Encryption.Encrypt(selectedFile);
                listBoxResult.Items.Add(selectedFile + ".crypt"); 
            }
        }
        private void unencryption_Click(object sender, EventArgs e)
        {
            foreach (string selectedFile in listBoxFiles.Items)
            {
                Encryption.Decrypt(selectedFile);
                listBoxResult.Items.Add(Path.GetFileNameWithoutExtension(selectedFile)); 
            }
        }

        private void archiving_Click(object sender, EventArgs e)
        {
            foreach (string selectedFile in listBoxFiles.Items)
            {
                Archiving.CompressFile(selectedFile);
                listBoxResult.Items.Add(selectedFile + ".gzar");
            }
        }

        private void unarchiving_Click(object sender, EventArgs e)
        {
            foreach (string selectedFile in listBoxFiles.Items)
            {
                string outputFileName = Path.GetFileNameWithoutExtension(selectedFile);
                string outputFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, outputFileName);
                Archiving.DecompressFile(selectedFile, outputFilePath);
                listBoxResult.Items.Add(outputFilePath); 
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                if (Directory.Exists(file))
                {

                    string[] folderFiles = Directory.GetFiles(file);
                    foreach (string folderFile in folderFiles)
                    {
                        listBoxFiles.Items.Add(folderFile);
                    }
                }
                else if (File.Exists(file))
                {
                    listBoxFiles.Items.Add(file);
                }
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
