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
            // Create an instance of the open file dialog box.
            var openFileDialog1 = new OpenFileDialog
            {
                // ReSharper disable once LocalizableElement
                Filter = "Microsoft Office files|*.ODT;*.DOC;*.DOCM;*.DOCX;*.DOT;*.DOTM;*.DOTX;*.RTF;*.XLS;*.XLSB;*.XLSM;*.XLSX;*.XLT;" +
                         "*.XLTM;*.XLTX;*.XLW;*.POT;*.PPT;*.POTM;*.POTX;*.PPS;*.PPSM;*.PPSX;*.PPTM;*.PPTX",
                FilterIndex = 1,
                Multiselect = false
            };

            // Process input if the user clicked OK.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputFilePathTextBox.Text = openFileDialog1.FileName;
                // Open the selected file to read.
                var folderBrowserDialog1 = new VistaFolderBrowserDialog()
                {
                    ShowNewFolderButton = true,
                    Description = @"Select output folder",
                    UseDescriptionForTitle = true
                };
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var extractor = new OfficeExtractor.Extractor();
                        var files = extractor.Extract(openFileDialog1.FileName, folderBrowserDialog1.SelectedPath);
                        FilesListBox.Items.Clear();

                        if (files == null)
                        {
                            outputFolderButton.Enabled = false;
                            return;
                        }
                        foreach (var file in files)
                            FilesListBox.Items.Add(Path.GetFileName(file));
                        _recentOutputPath = folderBrowserDialog1.SelectedPath;
                        outputFolderButton.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        outputFolderButton.Enabled = false;
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void outputFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start(_recentOutputPath);
        }
    }
}
