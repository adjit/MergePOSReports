using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using ExcelTools = Microsoft.Office.Tools.Excel;

namespace MergePOSReports
{
    public partial class ThisAddIn
    {
         ///////////////////////////////////////
        /*******  GLOBALS DECLARATION  *******/
       ///////////////////////////////////////

        public struct MergeProperties
        {
            public string prefix, rootFolder;
            public DateTime startDate, endDate;
        }

         ///////////////////////////////////////
        /*******   UI EVENT  METHODS   *******/
       ///////////////////////////////////////

        public void openReportInterface()
        {
            MergeReportInterface ui = new MergeReportInterface();
            ui.ShowDialog();
        }

        public MergeProperties setMergeProperties(string pre, DateTime sd, DateTime ed, string rf)
        {
            MergeProperties mp = new MergeProperties();

            mp.prefix = pre;
            mp.startDate = sd;
            mp.endDate = ed;
            mp.rootFolder = rf;

            return mp;
        }

        public void mergeReports(MergeProperties mp)
        {
            SelectColumns sc = new SelectColumns();

            int startMonth,
                startYear,
                endMonth,
                endYear,
                thisMonth,
                thisYear,
                rows,
                columns,
                thisRow,
                thisColumn,
                state = 0;

            Boolean totalRow = true;

            string rootFolder,
                   prefix,
                   filePath;

            List<string> columnList = new List<string>();

            Excel.Workbook xlWorkBook,
                           thisWorkBook = this.Application.ActiveWorkbook;

            Excel.Worksheet xlWorkSheet;

            Excel.Range range, blankRange;

            startMonth = thisMonth = mp.startDate.Month;
            startYear = thisYear = mp.startDate.Year;
            endMonth = mp.endDate.Month;
            endYear = mp.endDate.Year;
            rootFolder = mp.rootFolder;
            prefix = mp.prefix;

            //while(thisMonth <= endMonth && thisYear <= endYear)
            if (thisMonth <= endMonth && thisYear <= endYear)
            {
                filePath = makeFilepath(rootFolder, prefix, thisMonth, thisYear);

                try
                {
                    xlWorkBook = this.Application.Workbooks.Open(filePath, false, true);
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Error opening file at path: " + filePath, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    thisMonth++;
                    thisYear++;
                    //continue;
                    return;
                }

                xlWorkSheet = xlWorkBook.Worksheets[1];
                range = xlWorkSheet.UsedRange;
                rows = range.Rows.Count;
                columns = range.Columns.Count;
                thisRow = thisColumn = 1;

                if(state == 0)
                {
                    while(thisColumn <= columns)
                    {
                        columnList.Add((string)(xlWorkSheet.Cells[thisRow, thisColumn] as Excel.Range).Value);
                        thisColumn++;
                    }
                    sc.setAvailableColumns(columnList);

                    if (sc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        columnList.Clear();
                        columnList = sc.getSelectedColumns();
                        state++;
                    }
                    else { sc.Close(); return; }
                    //else continue;
                }

                range = xlWorkSheet.Range[xlWorkSheet.Cells[rows][1], xlWorkSheet.Cells[rows][columns]];
                try
                {
                    blankRange = range.SpecialCells(Excel.XlCellType.xlCellTypeBlanks);
                }
                catch (Exception)
                {
                    totalRow = false;
                    System.Diagnostics.Debug.WriteLine("There is no total row");
                }
                xlWorkBook.Close(false);
            }
        }

         ///////////////////////////////////////
        /*******    HELPER  METHODS    *******/
       ///////////////////////////////////////

        private List<Excel.Range> getColumns(Excel.Worksheet exSheet, List<String> columnList, int numRows, int numCols)
        {
            List<Excel.Range> columns = new List<Excel.Range>();
            Excel.Range headers = exSheet.Range[exSheet.Cells[1], exSheet.Cells[numCols]];
            Excel.Range columnHeader;

            int thisCol = 0;

            while(thisCol <= numCols)
            {

            }

            return columns;
        }

        private int selectAlternateColumn(Excel.Range headers)
        {
            int column = -1;

            alternateColumn ac = new alternateColumn();

            for(int i = 0; i < headers.Columns.Count; i++)
            {
                ac.addAlternateColumnToList((string)(headers.Cells[1, i] as Excel.Range).Value);
            }

            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK) return ac.getSelectedAlternateColumn();
            else return column;
        }

        private string makeFilepath(string folderPath, string prefix, int month, int year)
        {
            string[] paths = { folderPath, year.ToString() , getShortMonth(month) + year.ToString(), prefix + getIntegerMonth(month) + getIntegerYear(year) + ".xlsx" };
            return System.IO.Path.Combine(paths);
        }

        private string getShortMonth(int month)
        {
            switch (month)
            {
                case 1: return "jan";
                case 2: return "feb";
                case 3: return "mar";
                case 4: return "apr";
                case 5: return "may";
                case 6: return "jun";
                case 7: return "jul";
                case 8: return "aug";
                case 9: return "sep";
                case 10: return "oct";
                case 11: return "nov";
                case 12: return "dec";
                default: return "";
            }
        }

        private string getIntegerMonth(int month)
        {
            if (month < 10) return "0" + month.ToString();
            else return month.ToString();
        }

        private string getIntegerYear(int year)
        {
            int thisYear = year % 100;
            return thisYear.ToString();
        }

         ///////////////////////////////////////
        /*******     VS GENERATED      *******/
       ///////////////////////////////////////

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
