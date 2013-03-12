namespace NRPA
{
    partial class FormContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContact));
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbEnglishTitle = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleEnglish = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboxDefaultLanguage = new System.Windows.Forms.ComboBox();
            this.lblDefaultLanguage = new System.Windows.Forms.Label();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblInitials = new System.Windows.Forms.Label();
            this.tbInitials = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 59);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(291, 20);
            this.tbName.TabIndex = 0;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(12, 160);
            this.tbPhone.MaxLength = 11;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(291, 20);
            this.tbPhone.TabIndex = 2;
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(12, 210);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(291, 20);
            this.tbTitle.TabIndex = 3;
            // 
            // tbEnglishTitle
            // 
            this.tbEnglishTitle.Location = new System.Drawing.Point(12, 259);
            this.tbEnglishTitle.Name = "tbEnglishTitle";
            this.tbEnglishTitle.Size = new System.Drawing.Size(291, 20);
            this.tbEnglishTitle.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Skriv inn ditt eget navn";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(15, 143);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(160, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Skriv inn ditt jobb telefonnummer";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(15, 193);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 13);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Skriv inn din tittel";
            // 
            // lblTitleEnglish
            // 
            this.lblTitleEnglish.AutoSize = true;
            this.lblTitleEnglish.Location = new System.Drawing.Point(15, 242);
            this.lblTitleEnglish.Name = "lblTitleEnglish";
            this.lblTitleEnglish.Size = new System.Drawing.Size(142, 13);
            this.lblTitleEnglish.TabIndex = 7;
            this.lblTitleEnglish.Text = "Skriv inn din tittel på engelsk";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 23);
            this.panel1.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOk.Location = new System.Drawing.Point(166, 0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(241, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboxDefaultLanguage
            // 
            this.cboxDefaultLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDefaultLanguage.FormattingEnabled = true;
            this.cboxDefaultLanguage.Items.AddRange(new object[] {
            "Norsk - Bokmål",
            "Norsk - Nynorsk",
            "English"});
            this.cboxDefaultLanguage.Location = new System.Drawing.Point(12, 308);
            this.cboxDefaultLanguage.Name = "cboxDefaultLanguage";
            this.cboxDefaultLanguage.Size = new System.Drawing.Size(291, 21);
            this.cboxDefaultLanguage.TabIndex = 5;
            // 
            // lblDefaultLanguage
            // 
            this.lblDefaultLanguage.AutoSize = true;
            this.lblDefaultLanguage.Location = new System.Drawing.Point(15, 291);
            this.lblDefaultLanguage.Name = "lblDefaultLanguage";
            this.lblDefaultLanguage.Size = new System.Drawing.Size(183, 13);
            this.lblDefaultLanguage.TabIndex = 11;
            this.lblDefaultLanguage.Text = "Velg hvilket språk du vanligvis bruker";
            // 
            // tools
            // 
            this.tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tools.Location = new System.Drawing.Point(0, 0);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(316, 25);
            this.tools.TabIndex = 12;
            this.tools.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 371);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(316, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.Location = new System.Drawing.Point(15, 92);
            this.lblInitials.Name = "lblInitials";
            this.lblInitials.Size = new System.Drawing.Size(174, 13);
            this.lblInitials.TabIndex = 14;
            this.lblInitials.Text = "Skriv inn dine initialer (Maks 4 tegn)";
            // 
            // tbInitials
            // 
            this.tbInitials.Location = new System.Drawing.Point(12, 109);
            this.tbInitials.MaxLength = 4;
            this.tbInitials.Name = "tbInitials";
            this.tbInitials.Size = new System.Drawing.Size(291, 20);
            this.tbInitials.TabIndex = 1;
            // 
            // FormContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 393);
            this.Controls.Add(this.tbInitials);
            this.Controls.Add(this.lblInitials);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.lblDefaultLanguage);
            this.Controls.Add(this.cboxDefaultLanguage);
            this.Controls.Add(this.lblTitleEnglish);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbEnglishTitle);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContact";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saksbehandler informasjon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormContact_FormClosing);
            this.Load += new System.EventHandler(this.FormContact_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbEnglishTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleEnglish;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cboxDefaultLanguage;
        private System.Windows.Forms.Label lblDefaultLanguage;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lblInitials;
        private System.Windows.Forms.TextBox tbInitials;
    }
}