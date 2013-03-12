namespace NRPA
{
    partial class FormBrevMal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrevMal));
            this.tools = new System.Windows.Forms.ToolStrip();
            this.toolSelectLang = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolNorwegian = new System.Windows.Forms.ToolStripMenuItem();
            this.toolNorwegian2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditCaseHandler = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFillAuto = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnFillSaksbehandler = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFillParaferer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReferanseformat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowLawInfo = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnOffentlighetsloven = new System.Windows.Forms.ToolStripMenuItem();
            this.btnForvaltningsloven = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbAddress1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOurReference = new System.Windows.Forms.TextBox();
            this.tbTheirReference = new System.Windows.Forms.TextBox();
            this.tbCaseHandler = new System.Windows.Forms.TextBox();
            this.tbHeading = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxDocumentLang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxSignature = new System.Windows.Forms.ComboBox();
            this.tbSignatureTitle = new System.Windows.Forms.TextBox();
            this.tbCounterSignature = new System.Windows.Forms.TextBox();
            this.tbCounterSignatureTitle = new System.Windows.Forms.TextBox();
            this.tbAttachments = new System.Windows.Forms.TextBox();
            this.tbCopies = new System.Windows.Forms.TextBox();
            this.cboxUoff = new System.Windows.Forms.ComboBox();
            this.cboxForv = new System.Windows.Forms.ComboBox();
            this.tbCaseHandlerPhone = new System.Windows.Forms.TextBox();
            this.tbCaseHandlerPhoneDir = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.lblCopy = new System.Windows.Forms.Label();
            this.lblUoff = new System.Windows.Forms.Label();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.tbAddress3 = new System.Windows.Forms.TextBox();
            this.tbAddress4 = new System.Windows.Forms.TextBox();
            this.tbAddress5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolSelectedLang = new System.Windows.Forms.ToolStripLabel();
            this.tools.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tools
            // 
            this.tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSelectLang,
            this.btnEditCaseHandler,
            this.toolStripSeparator2,
            this.btnFillAuto,
            this.toolStripSeparator1,
            this.btnShowLawInfo,
            this.toolSelectedLang});
            this.tools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            resources.ApplyResources(this.tools, "tools");
            this.tools.Name = "tools";
            // 
            // toolSelectLang
            // 
            this.toolSelectLang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolSelectLang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSelectLang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNorwegian,
            this.toolNorwegian2,
            this.toolEnglish});
            resources.ApplyResources(this.toolSelectLang, "toolSelectLang");
            this.toolSelectLang.Name = "toolSelectLang";
            // 
            // toolNorwegian
            // 
            resources.ApplyResources(this.toolNorwegian, "toolNorwegian");
            this.toolNorwegian.Name = "toolNorwegian";
            this.toolNorwegian.Click += new System.EventHandler(this.toolNorwegian_Click);
            // 
            // toolNorwegian2
            // 
            this.toolNorwegian2.Image = global::NRPA.Properties.Resources.no;
            this.toolNorwegian2.Name = "toolNorwegian2";
            resources.ApplyResources(this.toolNorwegian2, "toolNorwegian2");
            this.toolNorwegian2.Click += new System.EventHandler(this.toolNorwegian2_Click);
            // 
            // toolEnglish
            // 
            resources.ApplyResources(this.toolEnglish, "toolEnglish");
            this.toolEnglish.Name = "toolEnglish";
            this.toolEnglish.Click += new System.EventHandler(this.toolEnglish_Click);
            // 
            // btnEditCaseHandler
            // 
            resources.ApplyResources(this.btnEditCaseHandler, "btnEditCaseHandler");
            this.btnEditCaseHandler.Name = "btnEditCaseHandler";
            this.btnEditCaseHandler.Click += new System.EventHandler(this.btnEditCaseHandler_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // btnFillAuto
            // 
            this.btnFillAuto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFillSaksbehandler,
            this.btnFillParaferer,
            this.btnReferanseformat});
            resources.ApplyResources(this.btnFillAuto, "btnFillAuto");
            this.btnFillAuto.Name = "btnFillAuto";
            // 
            // btnFillSaksbehandler
            // 
            this.btnFillSaksbehandler.Name = "btnFillSaksbehandler";
            resources.ApplyResources(this.btnFillSaksbehandler, "btnFillSaksbehandler");
            this.btnFillSaksbehandler.Click += new System.EventHandler(this.btnFillSaksbehandler_Click);
            // 
            // btnFillParaferer
            // 
            this.btnFillParaferer.Name = "btnFillParaferer";
            resources.ApplyResources(this.btnFillParaferer, "btnFillParaferer");
            this.btnFillParaferer.Click += new System.EventHandler(this.btnFillParaferer_Click);
            // 
            // btnReferanseformat
            // 
            this.btnReferanseformat.Name = "btnReferanseformat";
            resources.ApplyResources(this.btnReferanseformat, "btnReferanseformat");
            this.btnReferanseformat.Click += new System.EventHandler(this.btnReferanseformat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // btnShowLawInfo
            // 
            this.btnShowLawInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOffentlighetsloven,
            this.btnForvaltningsloven});
            resources.ApplyResources(this.btnShowLawInfo, "btnShowLawInfo");
            this.btnShowLawInfo.Name = "btnShowLawInfo";
            // 
            // btnOffentlighetsloven
            // 
            this.btnOffentlighetsloven.Name = "btnOffentlighetsloven";
            resources.ApplyResources(this.btnOffentlighetsloven, "btnOffentlighetsloven");
            this.btnOffentlighetsloven.Click += new System.EventHandler(this.btnOffentlighetsloven_Click);
            // 
            // btnForvaltningsloven
            // 
            this.btnForvaltningsloven.Name = "btnForvaltningsloven";
            resources.ApplyResources(this.btnForvaltningsloven, "btnForvaltningsloven");
            this.btnForvaltningsloven.Click += new System.EventHandler(this.btnForvaltningsloven_Click);
            // 
            // status
            // 
            resources.ApplyResources(this.status, "status");
            this.status.Name = "status";
            this.status.SizingGrip = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnCancel);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnOk
            // 
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.Name = "btnOk";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbAddress1
            // 
            resources.ApplyResources(this.tbAddress1, "tbAddress1");
            this.tbAddress1.Name = "tbAddress1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbOurReference
            // 
            resources.ApplyResources(this.tbOurReference, "tbOurReference");
            this.tbOurReference.Name = "tbOurReference";
            // 
            // tbTheirReference
            // 
            resources.ApplyResources(this.tbTheirReference, "tbTheirReference");
            this.tbTheirReference.Name = "tbTheirReference";
            // 
            // tbCaseHandler
            // 
            resources.ApplyResources(this.tbCaseHandler, "tbCaseHandler");
            this.tbCaseHandler.Name = "tbCaseHandler";
            // 
            // tbHeading
            // 
            resources.ApplyResources(this.tbHeading, "tbHeading");
            this.tbHeading.Name = "tbHeading";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // cboxDocumentLang
            // 
            this.cboxDocumentLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDocumentLang.FormattingEnabled = true;
            this.cboxDocumentLang.Items.AddRange(new object[] {
            resources.GetString("cboxDocumentLang.Items"),
            resources.GetString("cboxDocumentLang.Items1"),
            resources.GetString("cboxDocumentLang.Items2")});
            resources.ApplyResources(this.cboxDocumentLang, "cboxDocumentLang");
            this.cboxDocumentLang.Name = "cboxDocumentLang";
            this.cboxDocumentLang.SelectedIndexChanged += new System.EventHandler(this.cboxDocumentLang_SelectedIndexChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // cboxSignature
            // 
            this.cboxSignature.FormattingEnabled = true;
            resources.ApplyResources(this.cboxSignature, "cboxSignature");
            this.cboxSignature.Name = "cboxSignature";
            this.cboxSignature.SelectedIndexChanged += new System.EventHandler(this.cboxSignature_SelectedIndexChanged);
            // 
            // tbSignatureTitle
            // 
            resources.ApplyResources(this.tbSignatureTitle, "tbSignatureTitle");
            this.tbSignatureTitle.Name = "tbSignatureTitle";
            // 
            // tbCounterSignature
            // 
            resources.ApplyResources(this.tbCounterSignature, "tbCounterSignature");
            this.tbCounterSignature.Name = "tbCounterSignature";
            // 
            // tbCounterSignatureTitle
            // 
            resources.ApplyResources(this.tbCounterSignatureTitle, "tbCounterSignatureTitle");
            this.tbCounterSignatureTitle.Name = "tbCounterSignatureTitle";
            // 
            // tbAttachments
            // 
            resources.ApplyResources(this.tbAttachments, "tbAttachments");
            this.tbAttachments.Name = "tbAttachments";
            // 
            // tbCopies
            // 
            resources.ApplyResources(this.tbCopies, "tbCopies");
            this.tbCopies.Name = "tbCopies";
            // 
            // cboxUoff
            // 
            this.cboxUoff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUoff.FormattingEnabled = true;
            resources.ApplyResources(this.cboxUoff, "cboxUoff");
            this.cboxUoff.Name = "cboxUoff";
            this.cboxUoff.SelectedIndexChanged += new System.EventHandler(this.cboxUoff_SelectedIndexChanged);
            // 
            // cboxForv
            // 
            this.cboxForv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboxForv, "cboxForv");
            this.cboxForv.FormattingEnabled = true;
            this.cboxForv.Name = "cboxForv";
            this.cboxForv.SelectedIndexChanged += new System.EventHandler(this.cboxForv_SelectedIndexChanged);
            // 
            // tbCaseHandlerPhone
            // 
            resources.ApplyResources(this.tbCaseHandlerPhone, "tbCaseHandlerPhone");
            this.tbCaseHandlerPhone.Name = "tbCaseHandlerPhone";
            // 
            // tbCaseHandlerPhoneDir
            // 
            resources.ApplyResources(this.tbCaseHandlerPhoneDir, "tbCaseHandlerPhoneDir");
            this.tbCaseHandlerPhoneDir.Name = "tbCaseHandlerPhoneDir";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // lblAttachment
            // 
            resources.ApplyResources(this.lblAttachment, "lblAttachment");
            this.lblAttachment.Name = "lblAttachment";
            // 
            // lblCopy
            // 
            resources.ApplyResources(this.lblCopy, "lblCopy");
            this.lblCopy.Name = "lblCopy";
            // 
            // lblUoff
            // 
            resources.ApplyResources(this.lblUoff, "lblUoff");
            this.lblUoff.Name = "lblUoff";
            // 
            // tbAddress2
            // 
            resources.ApplyResources(this.tbAddress2, "tbAddress2");
            this.tbAddress2.Name = "tbAddress2";
            // 
            // tbAddress3
            // 
            resources.ApplyResources(this.tbAddress3, "tbAddress3");
            this.tbAddress3.Name = "tbAddress3";
            // 
            // tbAddress4
            // 
            resources.ApplyResources(this.tbAddress4, "tbAddress4");
            this.tbAddress4.Name = "tbAddress4";
            // 
            // tbAddress5
            // 
            resources.ApplyResources(this.tbAddress5, "tbAddress5");
            this.tbAddress5.Name = "tbAddress5";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // toolSelectedLang
            // 
            this.toolSelectedLang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolSelectedLang.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolSelectedLang.Name = "toolSelectedLang";
            resources.ApplyResources(this.toolSelectedLang, "toolSelectedLang");
            // 
            // FormBrevMal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbAddress5);
            this.Controls.Add(this.tbAddress4);
            this.Controls.Add(this.tbAddress3);
            this.Controls.Add(this.tbAddress2);
            this.Controls.Add(this.lblUoff);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCaseHandlerPhoneDir);
            this.Controls.Add(this.tbCaseHandlerPhone);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboxForv);
            this.Controls.Add(this.cboxUoff);
            this.Controls.Add(this.tbCopies);
            this.Controls.Add(this.tbAttachments);
            this.Controls.Add(this.tbCounterSignatureTitle);
            this.Controls.Add(this.tbCounterSignature);
            this.Controls.Add(this.tbSignatureTitle);
            this.Controls.Add(this.cboxSignature);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboxDocumentLang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbHeading);
            this.Controls.Add(this.tbCaseHandler);
            this.Controls.Add(this.tbTheirReference);
            this.Controls.Add(this.tbOurReference);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddress1);
            this.Controls.Add(this.status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBrevMal";
            this.Load += new System.EventHandler(this.FormBrevMal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormBrevMal_Paint);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripDropDownButton toolSelectLang;
        private System.Windows.Forms.ToolStripMenuItem toolNorwegian;
        private System.Windows.Forms.ToolStripMenuItem toolEnglish;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbAddress1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOurReference;
        private System.Windows.Forms.TextBox tbTheirReference;
        private System.Windows.Forms.TextBox tbCaseHandler;
        private System.Windows.Forms.TextBox tbHeading;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxDocumentLang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboxSignature;
        private System.Windows.Forms.TextBox tbSignatureTitle;
        private System.Windows.Forms.TextBox tbCounterSignature;
        private System.Windows.Forms.TextBox tbCounterSignatureTitle;
        private System.Windows.Forms.TextBox tbAttachments;
        private System.Windows.Forms.TextBox tbCopies;
        private System.Windows.Forms.ComboBox cboxUoff;
        private System.Windows.Forms.ComboBox cboxForv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbCaseHandlerPhone;
        private System.Windows.Forms.TextBox tbCaseHandlerPhoneDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripButton btnEditCaseHandler;
        private System.Windows.Forms.ToolStripDropDownButton btnShowLawInfo;
        private System.Windows.Forms.ToolStripMenuItem btnOffentlighetsloven;
        private System.Windows.Forms.ToolStripMenuItem btnForvaltningsloven;
        private System.Windows.Forms.ToolStripDropDownButton btnFillAuto;
        private System.Windows.Forms.ToolStripMenuItem btnFillSaksbehandler;
        private System.Windows.Forms.ToolStripMenuItem btnFillParaferer;
        private System.Windows.Forms.ToolStripMenuItem btnReferanseformat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.Label lblUoff;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.TextBox tbAddress3;
        private System.Windows.Forms.TextBox tbAddress4;
        private System.Windows.Forms.TextBox tbAddress5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem toolNorwegian2;
        private System.Windows.Forms.ToolStripLabel toolSelectedLang;
    }
}