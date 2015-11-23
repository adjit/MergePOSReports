namespace MergePOSReports
{
    partial class MergeRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MergeRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergeRibbon));
            this.MergeTab = this.Factory.CreateRibbonTab();
            this.mergeGroup = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.MergeTab.SuspendLayout();
            this.mergeGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MergeTab
            // 
            this.MergeTab.Groups.Add(this.mergeGroup);
            this.MergeTab.Label = "Merge POS Reports";
            this.MergeTab.Name = "MergeTab";
            // 
            // mergeGroup
            // 
            this.mergeGroup.Items.Add(this.button1);
            this.mergeGroup.Label = "Merge";
            this.mergeGroup.Name = "mergeGroup";
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageName = "Merge Image";
            this.button1.Label = "Merge Reports";
            this.button1.Name = "button1";
            this.button1.ScreenTip = "Merge POS Reports";
            this.button1.ShowImage = true;
            // 
            // MergeRibbon
            // 
            this.Name = "MergeRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.MergeTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MergeRibbon_Load);
            this.MergeTab.ResumeLayout(false);
            this.MergeTab.PerformLayout();
            this.mergeGroup.ResumeLayout(false);
            this.mergeGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab MergeTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup mergeGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
    }

    partial class ThisRibbonCollection
    {
        internal MergeRibbon MergeRibbon
        {
            get { return this.GetRibbon<MergeRibbon>(); }
        }
    }
}
