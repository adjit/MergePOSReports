namespace MergePOSReports
{
    partial class MergeReportInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergeReportInterface));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reportPrefix = new System.Windows.Forms.TextBox();
            this.rootFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserButton = new System.Windows.Forms.Button();
            this.rootFolderText = new System.Windows.Forms.TextBox();
            this.MergeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.endDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.startDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.reportPrefix);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Properties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ending Month + Year";
            // 
            // endDate
            // 
            this.endDate.CustomFormat = "MM/yyyy";
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.Location = new System.Drawing.Point(127, 71);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(118, 20);
            this.endDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Starting Month + Year";
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "MM/yyyy";
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(127, 45);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(118, 20);
            this.startDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Report Company Prefix";
            // 
            // reportPrefix
            // 
            this.reportPrefix.AcceptsTab = true;
            this.reportPrefix.Location = new System.Drawing.Point(127, 19);
            this.reportPrefix.Name = "reportPrefix";
            this.reportPrefix.Size = new System.Drawing.Size(118, 20);
            this.reportPrefix.TabIndex = 0;
            this.reportPrefix.Text = "(ie HON, POS etc.)";
            // 
            // folderBrowserButton
            // 
            this.folderBrowserButton.Location = new System.Drawing.Point(157, 146);
            this.folderBrowserButton.Name = "folderBrowserButton";
            this.folderBrowserButton.Size = new System.Drawing.Size(113, 23);
            this.folderBrowserButton.TabIndex = 1;
            this.folderBrowserButton.Text = "Select Root Folder";
            this.folderBrowserButton.UseVisualStyleBackColor = true;
            this.folderBrowserButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // rootFolderText
            // 
            this.rootFolderText.BackColor = System.Drawing.SystemColors.Window;
            this.rootFolderText.Location = new System.Drawing.Point(13, 120);
            this.rootFolderText.Name = "rootFolderText";
            this.rootFolderText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rootFolderText.Size = new System.Drawing.Size(257, 20);
            this.rootFolderText.TabIndex = 3;
            this.rootFolderText.Text = "[ Root Folder Path ] (ie. ...\\POSReports)";
            // 
            // MergeButton
            // 
            this.MergeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MergeButton.Location = new System.Drawing.Point(71, 187);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(141, 31);
            this.MergeButton.TabIndex = 4;
            this.MergeButton.Text = "Merge Reports";
            this.MergeButton.UseVisualStyleBackColor = true;
            // 
            // MergeReportInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 230);
            this.Controls.Add(this.MergeButton);
            this.Controls.Add(this.rootFolderText);
            this.Controls.Add(this.folderBrowserButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MergeReportInterface";
            this.Text = "Merge POS Reports Interface";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reportPrefix;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog rootFolderBrowser;
        private System.Windows.Forms.Button folderBrowserButton;
        private System.Windows.Forms.TextBox rootFolderText;
        private System.Windows.Forms.Button MergeButton;
    }
}