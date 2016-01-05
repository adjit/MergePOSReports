namespace MergePOSReports
{
    partial class alternateColumn
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
            this.alternateColumns = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columnNotFound = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alternateColumns
            // 
            this.alternateColumns.FormattingEnabled = true;
            this.alternateColumns.Location = new System.Drawing.Point(12, 55);
            this.alternateColumns.Name = "alternateColumns";
            this.alternateColumns.Size = new System.Drawing.Size(260, 21);
            this.alternateColumns.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select alternate column";
            // 
            // columnNotFound
            // 
            this.columnNotFound.AutoSize = true;
            this.columnNotFound.Location = new System.Drawing.Point(12, 31);
            this.columnNotFound.Name = "columnNotFound";
            this.columnNotFound.Size = new System.Drawing.Size(95, 13);
            this.columnNotFound.TabIndex = 2;
            this.columnNotFound.Text = "Column Not Found";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(197, 82);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // alternateColumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 117);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.columnNotFound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alternateColumns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alternateColumn";
            this.Text = "Select Alternate Column";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox alternateColumns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label columnNotFound;
        private System.Windows.Forms.Button okButton;
    }
}