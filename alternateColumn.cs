using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergePOSReports
{
    public partial class alternateColumn : Form
    {
        public alternateColumn()
        {
            InitializeComponent();
        }

        public void addAlternateColumnToList(string text)
        {
            alternateColumns.Items.Add(text);
        }

        public int getSelectedAlternateColumn()
        {
            return alternateColumns.SelectedIndex+1;
        }
    }
}
