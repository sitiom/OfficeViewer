using System;
using System.Collections.Generic;
using System.Linq;
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
            Text = $"Office Viewer {Assembly.GetExecutingAssembly().GetName().Version}";
        }

        private void inputFilePathTextBox_IconRightClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    inputFilePathTextBox.Text = string.Join("; ", openFileDialog1.FileNames);
                    filesListBox.Items.Clear();
                    outputFolderButton.Enabled = false;
                    inputFilePathTextBox.Enabled = false;
                    guna2ProgressBar1.Value = 0;
                    oleBackgroundWorker.RunWorkerAsync();
                }
            }
        }

        private void outputFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start(_recentOutputPath);
        }

        #region oleBackgroundWorker
        private void oleBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
            {
                try
                {
                    string file = openFileDialog1.FileNames[i];
                    string outputFileDirectory = Path.Combine(folderBrowserDialog1.SelectedPath,
                        Path.GetFileNameWithoutExtension(file));
                    if (!Directory.Exists(outputFileDirectory))
                    {
                        Directory.CreateDirectory(outputFileDirectory);
                    }

                    var extractor = new OfficeExtractor.Extractor();
                    var oleFiles = extractor.Extract(file, outputFileDirectory);
                    filesListBox.Items.Add(Path.GetFileName(file));
                    for (int j = 1; j <= oleFiles.Count; j++)
                    {
                        if (j != oleFiles.Count)
                        {
                            oleBackgroundWorker.ReportProgress(
                                (int)((i + ((decimal)j / oleFiles.Count)) / openFileDialog1.FileNames.Length * 100),
                                "├───" + Path.GetFileName(oleFiles[j - 1]));
                        }
                        else
                        {
                            oleBackgroundWorker.ReportProgress(
                                (int)((i + ((decimal)j / oleFiles.Count)) / openFileDialog1.FileNames.Length * 100),
                                "└───" + Path.GetFileName(oleFiles[j - 1]));
                        }
                    }
                    _recentOutputPath = folderBrowserDialog1.SelectedPath;
                    if(!Directory.EnumerateFileSystemEntries(outputFileDirectory).Any())
                    {
                        Directory.Delete(outputFileDirectory);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void oleBackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            string oleFile = (string)e.UserState;
            filesListBox.Items.Add(oleFile);
            filesListBox.TopIndex = filesListBox.Items.Count - 1;
            if (oleFile[0] == '└')
                filesListBox.Items.Add(string.Empty);
            guna2ProgressBar1.Value = e.ProgressPercentage;
        }

        private void oleBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            inputFilePathTextBox.Enabled = true;
            outputFolderButton.Enabled = filesListBox.Items.Count != 0;
            guna2ProgressBar1.Value = 100;
        }
        #endregion
    }
}
