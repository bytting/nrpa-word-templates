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
            this.toolSelectedLang = new System.Windows.Forms.ToolStripLabel();
            this.status = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
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
            this.tblLayoutLetter = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tools.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tblLayoutLetter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tools
            // 
            this.tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditCaseHandler,
            this.toolStripSeparator2,
            this.btnFillAuto,
            this.toolStripSeparator1,
            this.btnShowLawInfo,
            this.toolSelectedLang});
            this.tools.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Padding = new System.Windows.Forms.Padding(0);
            this.tools.Size = new System.Drawing.Size(803, 25);
            this.tools.TabIndex = 0;
            this.tools.Text = "toolStrip1";
            // 
            // btnEditCaseHandler
            // 
            this.btnEditCaseHandler.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCaseHandler.Image")));
            this.btnEditCaseHandler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCaseHandler.Name = "btnEditCaseHandler";
            this.btnEditCaseHandler.Size = new System.Drawing.Size(115, 22);
            this.btnEditCaseHandler.Text = "Rediger saksbeh.";
            this.btnEditCaseHandler.ToolTipText = "Trykk her for å redigere personlig informasjon";
            this.btnEditCaseHandler.Click += new System.EventHandler(this.btnEditCaseHandler_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFillAuto
            // 
            this.btnFillAuto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFillSaksbehandler,
            this.btnFillParaferer,
            this.btnReferanseformat});
            this.btnFillAuto.Image = ((System.Drawing.Image)(resources.GetObject("btnFillAuto.Image")));
            this.btnFillAuto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFillAuto.Name = "btnFillAuto";
            this.btnFillAuto.Size = new System.Drawing.Size(74, 22);
            this.btnFillAuto.Text = "Fyll inn";
            this.btnFillAuto.ToolTipText = "Fyll inn felter automatisk";
            // 
            // btnFillSaksbehandler
            // 
            this.btnFillSaksbehandler.Name = "btnFillSaksbehandler";
            this.btnFillSaksbehandler.Size = new System.Drawing.Size(161, 22);
            this.btnFillSaksbehandler.Text = "Saksbehandler";
            this.btnFillSaksbehandler.Click += new System.EventHandler(this.btnFillSaksbehandler_Click);
            // 
            // btnFillParaferer
            // 
            this.btnFillParaferer.Name = "btnFillParaferer";
            this.btnFillParaferer.Size = new System.Drawing.Size(161, 22);
            this.btnFillParaferer.Text = "Paraferer";
            this.btnFillParaferer.Click += new System.EventHandler(this.btnFillParaferer_Click);
            // 
            // btnReferanseformat
            // 
            this.btnReferanseformat.Name = "btnReferanseformat";
            this.btnReferanseformat.Size = new System.Drawing.Size(161, 22);
            this.btnReferanseformat.Text = "Referanseformat";
            this.btnReferanseformat.Click += new System.EventHandler(this.btnReferanseformat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnShowLawInfo
            // 
            this.btnShowLawInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOffentlighetsloven,
            this.btnForvaltningsloven});
            this.btnShowLawInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnShowLawInfo.Image")));
            this.btnShowLawInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowLawInfo.Name = "btnShowLawInfo";
            this.btnShowLawInfo.Size = new System.Drawing.Size(105, 22);
            this.btnShowLawInfo.Text = "Vis lovtekster";
            // 
            // btnOffentlighetsloven
            // 
            this.btnOffentlighetsloven.Name = "btnOffentlighetsloven";
            this.btnOffentlighetsloven.Size = new System.Drawing.Size(172, 22);
            this.btnOffentlighetsloven.Text = "Offentlighetsloven";
            this.btnOffentlighetsloven.Click += new System.EventHandler(this.btnOffentlighetsloven_Click);
            // 
            // btnForvaltningsloven
            // 
            this.btnForvaltningsloven.Name = "btnForvaltningsloven";
            this.btnForvaltningsloven.Size = new System.Drawing.Size(172, 22);
            this.btnForvaltningsloven.Text = "Forvaltningsloven";
            this.btnForvaltningsloven.Click += new System.EventHandler(this.btnForvaltningsloven_Click);
            // 
            // toolSelectedLang
            // 
            this.toolSelectedLang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolSelectedLang.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolSelectedLang.Name = "toolSelectedLang";
            this.toolSelectedLang.Size = new System.Drawing.Size(106, 22);
            this.toolSelectedLang.Text = "Selected Language";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(0, 480);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(803, 22);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 23);
            this.panel1.TabIndex = 99;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(653, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOk.Location = new System.Drawing.Point(728, 0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 23;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbAddress1
            // 
            this.tblLayoutLetter.SetColumnSpan(this.tbAddress1, 3);
            this.tbAddress1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddress1.Location = new System.Drawing.Point(3, 24);
            this.tbAddress1.MaxLength = 256;
            this.tbAddress1.Name = "tbAddress1";
            this.tbAddress1.Size = new System.Drawing.Size(594, 20);
            this.tbAddress1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(403, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Deres referanse";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vår referanse";
            // 
            // tbOurReference
            // 
            this.tblLayoutLetter.SetColumnSpan(this.tbOurReference, 2);
            this.tbOurReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOurReference.Location = new System.Drawing.Point(3, 150);
            this.tbOurReference.MaxLength = 64;
            this.tbOurReference.Name = "tbOurReference";
            this.tbOurReference.Size = new System.Drawing.Size(394, 20);
            this.tbOurReference.TabIndex = 6;
            // 
            // tbTheirReference
            // 
            this.tblLayoutLetter.SetColumnSpan(this.tbTheirReference, 2);
            this.tbTheirReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTheirReference.Location = new System.Drawing.Point(403, 150);
            this.tbTheirReference.MaxLength = 128;
            this.tbTheirReference.Name = "tbTheirReference";
            this.tbTheirReference.Size = new System.Drawing.Size(397, 20);
            this.tbTheirReference.TabIndex = 7;
            // 
            // tbCaseHandler
            // 
            this.tbCaseHandler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCaseHandler.Location = new System.Drawing.Point(3, 192);
            this.tbCaseHandler.MaxLength = 128;
            this.tbCaseHandler.Name = "tbCaseHandler";
            this.tbCaseHandler.Size = new System.Drawing.Size(194, 20);
            this.tbCaseHandler.TabIndex = 8;
            // 
            // tbHeading
            // 
            this.tblLayoutLetter.SetColumnSpan(this.tbHeading, 4);
            this.tbHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHeading.Location = new System.Drawing.Point(3, 234);
            this.tbHeading.MaxLength = 512;
            this.tbHeading.Name = "tbHeading";
            this.tbHeading.Size = new System.Drawing.Size(797, 20);
            this.tbHeading.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(3, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Overskrift";
            // 
            // cboxDocumentLang
            // 
            this.cboxDocumentLang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxDocumentLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDocumentLang.Items.AddRange(new object[] {
            "Norsk - Bokmål",
            "Norsk - Nynorsk",
            "English"});
            this.cboxDocumentLang.Location = new System.Drawing.Point(603, 192);
            this.cboxDocumentLang.Name = "cboxDocumentLang";
            this.cboxDocumentLang.Size = new System.Drawing.Size(197, 21);
            this.cboxDocumentLang.TabIndex = 11;
            this.cboxDocumentLang.SelectedIndexChanged += new System.EventHandler(this.cboxDocumentLang_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(603, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dokument språk";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(3, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Underskrift";
            // 
            // cboxSignature
            // 
            this.cboxSignature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxSignature.FormattingEnabled = true;
            this.cboxSignature.Location = new System.Drawing.Point(3, 276);
            this.cboxSignature.Name = "cboxSignature";
            this.cboxSignature.Size = new System.Drawing.Size(194, 21);
            this.cboxSignature.TabIndex = 13;
            this.cboxSignature.SelectedIndexChanged += new System.EventHandler(this.cboxSignature_SelectedIndexChanged);
            // 
            // tbSignatureTitle
            // 
            this.tbSignatureTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSignatureTitle.Location = new System.Drawing.Point(203, 276);
            this.tbSignatureTitle.MaxLength = 128;
            this.tbSignatureTitle.Name = "tbSignatureTitle";
            this.tbSignatureTitle.Size = new System.Drawing.Size(194, 20);
            this.tbSignatureTitle.TabIndex = 14;
            // 
            // tbCounterSignature
            // 
            this.tbCounterSignature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCounterSignature.Location = new System.Drawing.Point(403, 276);
            this.tbCounterSignature.MaxLength = 128;
            this.tbCounterSignature.Name = "tbCounterSignature";
            this.tbCounterSignature.Size = new System.Drawing.Size(194, 20);
            this.tbCounterSignature.TabIndex = 15;
            // 
            // tbCounterSignatureTitle
            // 
            this.tbCounterSignatureTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCounterSignatureTitle.Location = new System.Drawing.Point(603, 276);
            this.tbCounterSignatureTitle.MaxLength = 128;
            this.tbCounterSignatureTitle.Name = "tbCounterSignatureTitle";
            this.tbCounterSignatureTitle.Size = new System.Drawing.Size(197, 20);
            this.tbCounterSignatureTitle.TabIndex = 16;
            // 
            // tbAttachments
            // 
            this.tbAttachments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAttachments.Location = new System.Drawing.Point(3, 318);
            this.tbAttachments.MaxLength = 1024;
            this.tbAttachments.Name = "tbAttachments";
            this.tbAttachments.Size = new System.Drawing.Size(194, 20);
            this.tbAttachments.TabIndex = 17;
            // 
            // tbCopies
            // 
            this.tbCopies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCopies.Location = new System.Drawing.Point(203, 318);
            this.tbCopies.MaxLength = 1024;
            this.tbCopies.Name = "tbCopies";
            this.tbCopies.Size = new System.Drawing.Size(194, 20);
            this.tbCopies.TabIndex = 18;
            // 
            // cboxUoff
            // 
            this.tblLayoutLetter.SetColumnSpan(this.cboxUoff, 2);
            this.cboxUoff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxUoff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUoff.Location = new System.Drawing.Point(3, 360);
            this.cboxUoff.Name = "cboxUoff";
            this.cboxUoff.Size = new System.Drawing.Size(394, 21);
            this.cboxUoff.TabIndex = 19;
            this.cboxUoff.SelectedIndexChanged += new System.EventHandler(this.cboxUoff_SelectedIndexChanged);
            // 
            // cboxForv
            // 
            this.tblLayoutLetter.SetColumnSpan(this.cboxForv, 2);
            this.cboxForv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxForv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxForv.Enabled = false;
            this.cboxForv.Location = new System.Drawing.Point(403, 360);
            this.cboxForv.Name = "cboxForv";
            this.cboxForv.Size = new System.Drawing.Size(397, 21);
            this.cboxForv.TabIndex = 20;
            // 
            // tbCaseHandlerPhone
            // 
            this.tbCaseHandlerPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCaseHandlerPhone.Location = new System.Drawing.Point(403, 192);
            this.tbCaseHandlerPhone.MaxLength = 11;
            this.tbCaseHandlerPhone.Name = "tbCaseHandlerPhone";
            this.tbCaseHandlerPhone.Size = new System.Drawing.Size(194, 20);
            this.tbCaseHandlerPhone.TabIndex = 10;
            // 
            // tbCaseHandlerPhoneDir
            // 
            this.tbCaseHandlerPhoneDir.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbCaseHandlerPhoneDir.Location = new System.Drawing.Point(354, 192);
            this.tbCaseHandlerPhoneDir.MaxLength = 4;
            this.tbCaseHandlerPhoneDir.Name = "tbCaseHandlerPhoneDir";
            this.tbCaseHandlerPhoneDir.Size = new System.Drawing.Size(43, 20);
            this.tbCaseHandlerPhoneDir.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "Saksbehandler";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 176);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 101;
            this.label8.Text = "Tlf.";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 103;
            this.label9.Text = "Paraferer";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 106;
            this.label10.Text = "Tittel";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(603, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 107;
            this.label11.Text = "Tittel";
            // 
            // lblAttachment
            // 
            this.lblAttachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Location = new System.Drawing.Point(3, 302);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(46, 13);
            this.lblAttachment.TabIndex = 108;
            this.lblAttachment.Text = "Vedlegg";
            // 
            // lblCopy
            // 
            this.lblCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopy.AutoSize = true;
            this.lblCopy.Location = new System.Drawing.Point(203, 302);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(28, 13);
            this.lblCopy.TabIndex = 109;
            this.lblCopy.Text = "Kopi";
            // 
            // lblUoff
            // 
            this.lblUoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUoff.AutoSize = true;
            this.tblLayoutLetter.SetColumnSpan(this.lblUoff, 2);
            this.lblUoff.Location = new System.Drawing.Point(3, 344);
            this.lblUoff.Name = "lblUoff";
            this.lblUoff.Size = new System.Drawing.Size(202, 13);
            this.lblUoff.TabIndex = 110;
            this.lblUoff.Text = "Velg paragraf for untagelse av publisering";
            // 
            // tbAddress2
            // 
            this.tblLayoutLetter.SetColumnSpan(this.tbAddress2, 3);
            this.tbAddress2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddress2.Location = new System.Drawing.Point(3, 45);
            this.tbAddress2.MaxLength = 256;
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.Size = new System.Drawing.Size(594, 20);
            this.tbAddress2.TabIndex = 2;
            // 
            // tbAddress3
            // 
            this.tblLayoutLetter.SetColumnSpan(this.tbAddress3, 3);
            this.tbAddress3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddress3.Location = new System.Drawing.Point(3, 66);
            this.tbAddress3.MaxLength = 256;
            this.tbAddress3.Name = "tbAddress3";
            this.tbAddress3.Size = new System.Drawing.Size(594, 20);
            this.tbAddress3.TabIndex = 3;
            // 
            // tbAddress4
            // 
            this.tblLayoutLetter.SetColumnSpan(this.tbAddress4, 3);
            this.tbAddress4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddress4.Location = new System.Drawing.Point(3, 87);
            this.tbAddress4.MaxLength = 256;
            this.tbAddress4.Name = "tbAddress4";
            this.tbAddress4.Size = new System.Drawing.Size(594, 20);
            this.tbAddress4.TabIndex = 4;
            // 
            // tbAddress5
            // 
            this.tblLayoutLetter.SetColumnSpan(this.tbAddress5, 3);
            this.tbAddress5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAddress5.Location = new System.Drawing.Point(3, 108);
            this.tbAddress5.MaxLength = 256;
            this.tbAddress5.Name = "tbAddress5";
            this.tbAddress5.Size = new System.Drawing.Size(594, 20);
            this.tbAddress5.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.tblLayoutLetter.SetColumnSpan(this.label12, 2);
            this.label12.Location = new System.Drawing.Point(403, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 13);
            this.label12.TabIndex = 115;
            this.label12.Text = "Velg paragraf fra forvaltningsloven";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(803, 1);
            this.panel3.TabIndex = 117;
            // 
            // tblLayoutLetter
            // 
            this.tblLayoutLetter.ColumnCount = 4;
            this.tblLayoutLetter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutLetter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutLetter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutLetter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblLayoutLetter.Controls.Add(this.tbAddress5, 0, 5);
            this.tblLayoutLetter.Controls.Add(this.tbAddress4, 0, 4);
            this.tblLayoutLetter.Controls.Add(this.tbAddress3, 0, 3);
            this.tblLayoutLetter.Controls.Add(this.tbAddress2, 0, 2);
            this.tblLayoutLetter.Controls.Add(this.label12, 2, 16);
            this.tblLayoutLetter.Controls.Add(this.cboxForv, 2, 17);
            this.tblLayoutLetter.Controls.Add(this.tbAddress1, 0, 1);
            this.tblLayoutLetter.Controls.Add(this.lblUoff, 0, 16);
            this.tblLayoutLetter.Controls.Add(this.label1, 0, 0);
            this.tblLayoutLetter.Controls.Add(this.cboxUoff, 0, 17);
            this.tblLayoutLetter.Controls.Add(this.label3, 0, 6);
            this.tblLayoutLetter.Controls.Add(this.lblAttachment, 0, 14);
            this.tblLayoutLetter.Controls.Add(this.label2, 2, 6);
            this.tblLayoutLetter.Controls.Add(this.label11, 3, 12);
            this.tblLayoutLetter.Controls.Add(this.tbOurReference, 0, 7);
            this.tblLayoutLetter.Controls.Add(this.tbAttachments, 0, 15);
            this.tblLayoutLetter.Controls.Add(this.label9, 2, 12);
            this.tblLayoutLetter.Controls.Add(this.label10, 1, 12);
            this.tblLayoutLetter.Controls.Add(this.tbTheirReference, 2, 7);
            this.tblLayoutLetter.Controls.Add(this.tbCounterSignatureTitle, 3, 13);
            this.tblLayoutLetter.Controls.Add(this.label4, 0, 8);
            this.tblLayoutLetter.Controls.Add(this.tbCounterSignature, 2, 13);
            this.tblLayoutLetter.Controls.Add(this.tbCaseHandlerPhoneDir, 1, 9);
            this.tblLayoutLetter.Controls.Add(this.tbSignatureTitle, 1, 13);
            this.tblLayoutLetter.Controls.Add(this.label8, 1, 8);
            this.tblLayoutLetter.Controls.Add(this.cboxSignature, 0, 13);
            this.tblLayoutLetter.Controls.Add(this.tbCaseHandlerPhone, 2, 9);
            this.tblLayoutLetter.Controls.Add(this.label6, 3, 8);
            this.tblLayoutLetter.Controls.Add(this.cboxDocumentLang, 3, 9);
            this.tblLayoutLetter.Controls.Add(this.tbCaseHandler, 0, 9);
            this.tblLayoutLetter.Controls.Add(this.label5, 0, 10);
            this.tblLayoutLetter.Controls.Add(this.tbHeading, 0, 11);
            this.tblLayoutLetter.Controls.Add(this.label7, 0, 12);
            this.tblLayoutLetter.Controls.Add(this.lblCopy, 1, 14);
            this.tblLayoutLetter.Controls.Add(this.tbCopies, 1, 15);
            this.tblLayoutLetter.Controls.Add(this.pictureBox1, 3, 0);
            this.tblLayoutLetter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutLetter.Location = new System.Drawing.Point(0, 26);
            this.tblLayoutLetter.Margin = new System.Windows.Forms.Padding(2);
            this.tblLayoutLetter.Name = "tblLayoutLetter";
            this.tblLayoutLetter.RowCount = 19;
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tblLayoutLetter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tblLayoutLetter.Size = new System.Drawing.Size(803, 431);
            this.tblLayoutLetter.TabIndex = 118;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(602, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.tblLayoutLetter.SetRowSpan(this.pictureBox1, 6);
            this.pictureBox1.Size = new System.Drawing.Size(199, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 116;
            this.pictureBox1.TabStop = false;
            // 
            // FormBrevMal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 502);
            this.Controls.Add(this.tblLayoutLetter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.status);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(604, 495);
            this.Name = "FormBrevMal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "   Brevmal";
            this.Load += new System.EventHandler(this.FormBrevMal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormBrevMal_Paint);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tblLayoutLetter.ResumeLayout(false);
            this.tblLayoutLetter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.StatusStrip status;
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
        private System.Windows.Forms.ToolStripLabel toolSelectedLang;
        private System.Windows.Forms.TableLayoutPanel tblLayoutLetter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}