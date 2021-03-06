﻿namespace OfficeViewer
{
    partial class ViewerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewerForm));
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputFilePathTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.outputFolderButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.oleBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new Ookii.Dialogs.WinForms.VistaFolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressDialog1 = new Ookii.Dialogs.WinForms.ProgressDialog(this.components);
            this.SuspendLayout();
            // 
            // filesListBox
            // 
            this.filesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.filesListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.ItemHeight = 25;
            this.filesListBox.Location = new System.Drawing.Point(11, 89);
            this.filesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(516, 304);
            this.filesListBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "File path:";
            // 
            // inputFilePathTextBox
            // 
            this.inputFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFilePathTextBox.Animated = true;
            this.inputFilePathTextBox.AutoRoundedCorners = true;
            this.inputFilePathTextBox.BorderColor = System.Drawing.Color.Silver;
            this.inputFilePathTextBox.BorderRadius = 16;
            this.inputFilePathTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputFilePathTextBox.DefaultText = "";
            this.inputFilePathTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputFilePathTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputFilePathTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputFilePathTextBox.DisabledState.Parent = this.inputFilePathTextBox;
            this.inputFilePathTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputFilePathTextBox.FocusedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.inputFilePathTextBox.FocusedState.Parent = this.inputFilePathTextBox;
            this.inputFilePathTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.inputFilePathTextBox.HoverState.Parent = this.inputFilePathTextBox;
            this.inputFilePathTextBox.IconRight = global::OfficeViewer.Properties.Resources.folder_96px;
            this.inputFilePathTextBox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.inputFilePathTextBox.IconRightSize = new System.Drawing.Size(25, 25);
            this.inputFilePathTextBox.Location = new System.Drawing.Point(103, 14);
            this.inputFilePathTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputFilePathTextBox.Name = "inputFilePathTextBox";
            this.inputFilePathTextBox.PasswordChar = '\0';
            this.inputFilePathTextBox.PlaceholderText = "";
            this.inputFilePathTextBox.ReadOnly = true;
            this.inputFilePathTextBox.SelectedText = "";
            this.inputFilePathTextBox.ShadowDecoration.Parent = this.inputFilePathTextBox;
            this.inputFilePathTextBox.Size = new System.Drawing.Size(418, 35);
            this.inputFilePathTextBox.TabIndex = 9;
            this.inputFilePathTextBox.IconRightClick += new System.EventHandler(this.inputFilePathTextBox_IconRightClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Extracted files:";
            // 
            // outputFolderButton
            // 
            this.outputFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFolderButton.Animated = true;
            this.outputFolderButton.AutoRoundedCorners = true;
            this.outputFolderButton.BorderRadius = 19;
            this.outputFolderButton.CheckedState.Parent = this.outputFolderButton;
            this.outputFolderButton.CustomImages.Parent = this.outputFolderButton;
            this.outputFolderButton.Enabled = false;
            this.outputFolderButton.FillColor = System.Drawing.Color.DodgerBlue;
            this.outputFolderButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputFolderButton.ForeColor = System.Drawing.Color.White;
            this.outputFolderButton.HoverState.Parent = this.outputFolderButton;
            this.outputFolderButton.Location = new System.Drawing.Point(346, 400);
            this.outputFolderButton.Name = "outputFolderButton";
            this.outputFolderButton.ShadowDecoration.Parent = this.outputFolderButton;
            this.outputFolderButton.Size = new System.Drawing.Size(180, 41);
            this.outputFolderButton.TabIndex = 11;
            this.outputFolderButton.Text = "Go to Output";
            this.outputFolderButton.Click += new System.EventHandler(this.outputFolderButton_Click);
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ProgressBar1.AutoRoundedCorners = true;
            this.guna2ProgressBar1.BorderRadius = 14;
            this.guna2ProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(12, 405);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(201)))), ((int)(((byte)(139)))));
            this.guna2ProgressBar1.ShadowDecoration.Parent = this.guna2ProgressBar1;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(328, 30);
            this.guna2ProgressBar1.TabIndex = 0;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // oleBackgroundWorker
            // 
            this.oleBackgroundWorker.WorkerReportsProgress = true;
            this.oleBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.oleBackgroundWorker_DoWork);
            this.oleBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.oleBackgroundWorker_ProgressChanged);
            this.oleBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.oleBackgroundWorker_RunWorkerCompleted);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select output folder";
            this.folderBrowserDialog1.UseDescriptionForTitle = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Microsoft Office files|*.ODT;*.DOC;*.DOCM;*.DOCX;*.DOT;*.DOTM;*.DOTX;*.RTF;*.XLS;" +
    "*.XLSB;*.XLSM;*.XLSX;*.XLT;*.XLTM;*.XLTX;*.XLW;*.POT;*.PPT;*.POTM;*.POTX;*.PPS;*" +
    ".PPSM;*.PPSX;*.PPTM;*.PPTX";
            this.openFileDialog1.Multiselect = true;
            // 
            // progressDialog1
            // 
            this.progressDialog1.Text = "progressDialog1";
            // 
            // ViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 448);
            this.Controls.Add(this.guna2ProgressBar1);
            this.Controls.Add(this.outputFolderButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputFilePathTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ViewerForm";
            this.Text = "OfficeViewer";
            this.Load += new System.EventHandler(this.ViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox inputFilePathTextBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button outputFolderButton;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.ComponentModel.BackgroundWorker oleBackgroundWorker;
        private Ookii.Dialogs.WinForms.VistaFolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Ookii.Dialogs.WinForms.ProgressDialog progressDialog1;
    }
}

