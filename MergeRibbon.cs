using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace MergePOSReports
{
    public partial class MergeRibbon
    {
        private void MergeRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            //this.mergeButton.Click += new RibbonControlEventHandler(this.button1_Click);
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            MergeReportInterface ui = new MergeReportInterface();
            ui.ShowDialog();
        }
    }
}
