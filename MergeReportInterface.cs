using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSDialog = Microsoft.WindowsAPICodePack.Dialogs;

namespace MergePOSReports
{
    public partial class MergeReportInterface : Form
    {
        public MergeReportInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DialogResult rootFolder = rootFolderBrowser.ShowDialog();
            MSDialog.CommonOpenFileDialog folderDialog = new MSDialog.CommonOpenFileDialog();
            folderDialog.IsFolderPicker = true;
            MSDialog.CommonFileDialogResult rootDialog = folderDialog.ShowDialog();

            if(rootDialog == MSDialog.CommonFileDialogResult.Ok)
            {
                System.Windows.Forms.MessageBox.Show("Folder found: " + folderDialog.FileName.ToString(), "Message");
                rootFolderText.Text = folderDialog.FileName.ToString();
            }

            /*if (rootFolder == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(rootFolderBrowser.SelectedPath);
                System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }*/
        }
    }
}
