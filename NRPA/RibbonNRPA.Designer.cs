namespace NRPA
{
    partial class RibbonNRPA : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonNRPA()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonNRPA));
            this.tabNRPA = this.Factory.CreateRibbonTab();
            this.groupNRPA = this.Factory.CreateRibbonGroup();
            this.btnLetterTemplate = this.Factory.CreateRibbonButton();
            this.btnDocTemplates = this.Factory.CreateRibbonButton();
            this.tabNRPA.SuspendLayout();
            this.groupNRPA.SuspendLayout();
            // 
            // tabNRPA
            // 
            this.tabNRPA.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tabNRPA.Groups.Add(this.groupNRPA);
            this.tabNRPA.Label = "NRPA";
            this.tabNRPA.Name = "tabNRPA";
            // 
            // groupNRPA
            // 
            this.groupNRPA.Items.Add(this.btnLetterTemplate);
            this.groupNRPA.Items.Add(this.btnDocTemplates);
            this.groupNRPA.Label = "NRPA";
            this.groupNRPA.Name = "groupNRPA";
            // 
            // btnLetterTemplate
            // 
            this.btnLetterTemplate.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnLetterTemplate.Image = ((System.Drawing.Image)(resources.GetObject("btnLetterTemplate.Image")));
            this.btnLetterTemplate.Label = "Brevmal";
            this.btnLetterTemplate.Name = "btnLetterTemplate";
            this.btnLetterTemplate.ScreenTip = "Brevmal";
            this.btnLetterTemplate.ShowImage = true;
            this.btnLetterTemplate.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnLetterTemplate_Click);
            // 
            // btnDocTemplates
            // 
            this.btnDocTemplates.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnDocTemplates.Image = ((System.Drawing.Image)(resources.GetObject("btnDocTemplates.Image")));
            this.btnDocTemplates.Label = "Dokument maler";
            this.btnDocTemplates.Name = "btnDocTemplates";
            this.btnDocTemplates.ScreenTip = "Dokument maler";
            this.btnDocTemplates.ShowImage = true;
            this.btnDocTemplates.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnDocTemplates_Click);
            // 
            // RibbonNRPA
            // 
            this.Name = "RibbonNRPA";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tabNRPA);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonNRPA_Load);
            this.tabNRPA.ResumeLayout(false);
            this.tabNRPA.PerformLayout();
            this.groupNRPA.ResumeLayout(false);
            this.groupNRPA.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabNRPA;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupNRPA;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDocTemplates;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLetterTemplate;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonNRPA RibbonNRPA
        {
            get { return this.GetRibbon<RibbonNRPA>(); }
        }
    }
}
