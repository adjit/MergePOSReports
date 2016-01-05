namespace MergePOSReports
{
    partial class SelectColumns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectColumns));
            this.leftBox = new System.Windows.Forms.ListBox();
            this.rightBox = new System.Windows.Forms.ListBox();
            this.oneToRight = new System.Windows.Forms.Button();
            this.allToRight = new System.Windows.Forms.Button();
            this.allToLeft = new System.Windows.Forms.Button();
            this.oneToLeft = new System.Windows.Forms.Button();
            this.upToTop = new System.Windows.Forms.Button();
            this.downToBottom = new System.Windows.Forms.Button();
            this.downOne = new System.Windows.Forms.Button();
            this.upOne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leftBox
            // 
            this.leftBox.FormattingEnabled = true;
            this.leftBox.Location = new System.Drawing.Point(12, 25);
            this.leftBox.Name = "leftBox";
            this.leftBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.leftBox.Size = new System.Drawing.Size(150, 329);
            this.leftBox.TabIndex = 0;
            // 
            // rightBox
            // 
            this.rightBox.FormattingEnabled = true;
            this.rightBox.Location = new System.Drawing.Point(222, 25);
            this.rightBox.Name = "rightBox";
            this.rightBox.Size = new System.Drawing.Size(150, 329);
            this.rightBox.TabIndex = 1;
            // 
            // oneToRight
            // 
            this.oneToRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneToRight.Location = new System.Drawing.Point(177, 114);
            this.oneToRight.Name = "oneToRight";
            this.oneToRight.Size = new System.Drawing.Size(30, 30);
            this.oneToRight.TabIndex = 2;
            this.oneToRight.Text = ">";
            this.oneToRight.UseVisualStyleBackColor = true;
            this.oneToRight.Click += new System.EventHandler(this.oneToRight_Click);
            // 
            // allToRight
            // 
            this.allToRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allToRight.Location = new System.Drawing.Point(177, 150);
            this.allToRight.Name = "allToRight";
            this.allToRight.Size = new System.Drawing.Size(30, 30);
            this.allToRight.TabIndex = 3;
            this.allToRight.Text = "»";
            this.allToRight.UseVisualStyleBackColor = true;
            this.allToRight.Click += new System.EventHandler(this.allToRight_Click);
            // 
            // allToLeft
            // 
            this.allToLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allToLeft.Location = new System.Drawing.Point(177, 186);
            this.allToLeft.Name = "allToLeft";
            this.allToLeft.Size = new System.Drawing.Size(30, 30);
            this.allToLeft.TabIndex = 4;
            this.allToLeft.Text = "«";
            this.allToLeft.UseVisualStyleBackColor = true;
            this.allToLeft.Click += new System.EventHandler(this.allToLeft_Click);
            // 
            // oneToLeft
            // 
            this.oneToLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneToLeft.Location = new System.Drawing.Point(177, 222);
            this.oneToLeft.Name = "oneToLeft";
            this.oneToLeft.Size = new System.Drawing.Size(30, 30);
            this.oneToLeft.TabIndex = 5;
            this.oneToLeft.Text = "<";
            this.oneToLeft.UseVisualStyleBackColor = true;
            this.oneToLeft.Click += new System.EventHandler(this.oneToLeft_Click);
            // 
            // upToTop
            // 
            this.upToTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upToTop.Image = global::MergePOSReports.Properties.Resources.move_to_top;
            this.upToTop.Location = new System.Drawing.Point(177, 37);
            this.upToTop.Name = "upToTop";
            this.upToTop.Size = new System.Drawing.Size(30, 30);
            this.upToTop.TabIndex = 9;
            this.upToTop.UseVisualStyleBackColor = true;
            this.upToTop.Click += new System.EventHandler(this.upToTop_Click);
            // 
            // downToBottom
            // 
            this.downToBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downToBottom.Image = global::MergePOSReports.Properties.Resources.move_to_bottom;
            this.downToBottom.Location = new System.Drawing.Point(177, 299);
            this.downToBottom.Name = "downToBottom";
            this.downToBottom.Size = new System.Drawing.Size(30, 30);
            this.downToBottom.TabIndex = 8;
            this.downToBottom.UseVisualStyleBackColor = true;
            this.downToBottom.Click += new System.EventHandler(this.downToBottom_Click);
            // 
            // downOne
            // 
            this.downOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downOne.Image = global::MergePOSReports.Properties.Resources.arrow_Down_16xMD;
            this.downOne.Location = new System.Drawing.Point(177, 261);
            this.downOne.Name = "downOne";
            this.downOne.Size = new System.Drawing.Size(30, 30);
            this.downOne.TabIndex = 7;
            this.downOne.UseVisualStyleBackColor = true;
            this.downOne.Click += new System.EventHandler(this.downOne_Click);
            // 
            // upOne
            // 
            this.upOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upOne.Image = global::MergePOSReports.Properties.Resources.arrow_Up_16xMD;
            this.upOne.Location = new System.Drawing.Point(177, 75);
            this.upOne.Name = "upOne";
            this.upOne.Size = new System.Drawing.Size(30, 30);
            this.upOne.TabIndex = 6;
            this.upOne.UseVisualStyleBackColor = true;
            this.upOne.Click += new System.EventHandler(this.upOne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Available Columns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Columns to Use";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(297, 360);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            // 
            // SelectColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 389);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upToTop);
            this.Controls.Add(this.downToBottom);
            this.Controls.Add(this.downOne);
            this.Controls.Add(this.upOne);
            this.Controls.Add(this.oneToLeft);
            this.Controls.Add(this.allToLeft);
            this.Controls.Add(this.allToRight);
            this.Controls.Add(this.oneToRight);
            this.Controls.Add(this.rightBox);
            this.Controls.Add(this.leftBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectColumns";
            this.Text = "Select Columns";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox leftBox;
        private System.Windows.Forms.ListBox rightBox;
        private System.Windows.Forms.Button oneToRight;
        private System.Windows.Forms.Button allToRight;
        private System.Windows.Forms.Button allToLeft;
        private System.Windows.Forms.Button oneToLeft;
        private System.Windows.Forms.Button upOne;
        private System.Windows.Forms.Button downOne;
        private System.Windows.Forms.Button downToBottom;
        private System.Windows.Forms.Button upToTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okButton;
    }
}