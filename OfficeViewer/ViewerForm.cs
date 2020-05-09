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
                Multiselect = true
            };

            // Process input if the user clicked OK.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inputFilePathTextBox.Text = string.Join("; ",openFileDialog1.FileNames);
                // Open the selected file to read.
                var folderBrowserDialog1 = new VistaFolderBrowserDialog()
                {
                    ShowNewFolderButton = true,
                    Description = @"Select output folder",
                    UseDescriptionForTitle = true
                };
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    FilesListBox.Items.Clear();
                    foreach(string file in openFileDialog1.FileNames)
                    {
                        try
                        {
                            var extractor = new OfficeExtractor.Extractor();
                            var oleFiles = extractor.Extract(file, folderBrowserDialog1.SelectedPath);

                            if (oleFiles == null)
                            {
                            outputFolderButton.Enabled = false;
                            return;
                            }
                            foreach (var oleFile in oleFiles)
                                FilesListBox.Items.Add(Path.GetFileName(oleFile));
                            _recentOutputPath = folderBrowserDialog1.SelectedPath;
                        }
                        catch (Exception ex)
                        {
                            outputFolderButton.Enabled = false;
                            MessageBox.Show(ex.Message);
                        }
                    }
                    outputFolderButton.Enabled = true;
                }
            }
        }

        private void outputFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start(_recentOutputPath);
        }
    }
}
