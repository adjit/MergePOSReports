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
    public partial class SelectColumns : Form
    {
        public SelectColumns()
        {
            InitializeComponent();
        }

        public List<String> getSelectedColumns()
        {
            return rightBox.Items.Cast<object>()
                                 .Select(x => x.ToString())
                                 .ToList();
        }

        public void setAvailableColumns(List<String> cols)
        {
            leftBox.Items.Clear();
            foreach(string s in cols)
            {
                leftBox.Items.Add(s);
            }
        }

        private int getSelectedIndexOf(ListBox list)
        {
            if (list.SelectedItems == null) return -1;
            else return list.SelectedIndex;
        }

        private void upOne_Click(object sender, EventArgs e)
        {
            int si = getSelectedIndexOf(rightBox);
            if(si > 0)
            {
                rightBox.Items.Insert(si - 1, rightBox.SelectedItem);
                rightBox.SelectedIndex = si - 1;
                rightBox.Items.RemoveAt(si + 1);
            }
        }

        private void upToTop_Click(object sender, EventArgs e)
        {
            int si = getSelectedIndexOf(rightBox);
            if (si > 0)
            {
                rightBox.Items.Insert(0, rightBox.SelectedItem);
                rightBox.SelectedIndex = 0;
                rightBox.Items.RemoveAt(si + 1);
            }
        }

        private void oneToRight_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndexCollection si;
            
            if (getSelectedIndexOf(leftBox) >= 0)
            {
                rightBox.Items.AddRange(leftBox.SelectedItems.Cast<object>().ToArray());

                si = leftBox.SelectedIndices;

                while(si.Count > 0)
                {
                    leftBox.Items.RemoveAt(leftBox.SelectedIndices[0]);
                }
            }
        }

        private void allToRight_Click(object sender, EventArgs e)
        {
            rightBox.Items.AddRange(leftBox.Items);
            leftBox.Items.Clear();
        }

        private void allToLeft_Click(object sender, EventArgs e)
        {
            leftBox.Items.AddRange(rightBox.Items);
            rightBox.Items.Clear();
        }

        private void oneToLeft_Click(object sender, EventArgs e)
        {
            leftBox.Items.Add(rightBox.SelectedItem);
            rightBox.Items.RemoveAt(rightBox.SelectedIndex);
        }

        private void downOne_Click(object sender, EventArgs e)
        {
            int si = getSelectedIndexOf(rightBox);
            if (si < rightBox.Items.Count-1)
            {
                rightBox.Items.Insert(si + 2, rightBox.SelectedItem);
                rightBox.SelectedIndex = si + 2;
                rightBox.Items.RemoveAt(si);
            }
        }

        private void downToBottom_Click(object sender, EventArgs e)
        {
            int si = getSelectedIndexOf(rightBox);
            rightBox.Items.Add(rightBox.SelectedItem);
            rightBox.Items.RemoveAt(si);
            rightBox.SelectedIndex = rightBox.Items.Count - 1;
        }
    }
}
