using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Ookii.Dialogs.WinForms;


namespace OfficeViewer
{
    public partial class ViewerForm : Form
    {
        private string _recentOutputPath;
        public ViewerForm()
        {
            InitializeComponent();
        }

        private void ViewerForm_Load(object sender, EventArgs e)
        {
            // ReSharper disable once LocalizableElement
            Text = $"Office Extractor v{Assembly.GetExecutingAssembly().GetName().Version}";
        }

        private void inputFilePathTextBox_IconRightClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    oleBackgroundWorker.RunWorkerAsync();
                }
            }
        }

        private void outputFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start(_recentOutputPath);
        }

        private void oleBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            inputFilePathTextBox.Text = string.Join("; ", openFileDialog1.FileNames);
            FilesListBox.Items.Clear();
            outputFolderButton.Enabled = false;
            inputFilePathTextBox.Enabled = false;
            for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
            {
                string file = openFileDialog1.FileNames[i];
                try
                {
                    string outputFileDirectory = Path.Combine(folderBrowserDialog1.SelectedPath,
                        Path.GetFileNameWithoutExtension(file));
                    if (!Directory.Exists(outputFileDirectory))
                    {
                        Directory.CreateDirectory(outputFileDirectory);
                    }

                    var extractor = new OfficeExtractor.Extractor();
                    var oleFiles = extractor.Extract(file, outputFileDirectory);

                    if (oleFiles == null) return;
                    FilesListBox.Items.Add(Path.GetFileName(file));
                    for (int j = 1; j <= oleFiles.Count; j++)
                    {
                        if (j != oleFiles.Count)
                        {
                            FilesListBox.Items.Add("├───" + Path.GetFileName(oleFiles[j - 1]));
                            oleBackgroundWorker.ReportProgress((i + j / oleFiles.Count) / openFileDialog1.FileNames.Length * 100);
                        }
                        else
                        {
                            FilesListBox.Items.Add("└───" + Path.GetFileName(oleFiles[j - 1]));
                            oleBackgroundWorker.ReportProgress((i + j / oleFiles.Count) / openFileDialog1.FileNames.Length * 100);
                        }
                    }

                    FilesListBox.Items.Add(string.Empty);
                    _recentOutputPath = folderBrowserDialog1.SelectedPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            inputFilePathTextBox.Enabled = true;
            outputFolderButton.Enabled = FilesListBox.Items.Count != 0;
        }

        private void oleBackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            guna2ProgressBar1.Value = e.ProgressPercentage;
        }
    }
}
