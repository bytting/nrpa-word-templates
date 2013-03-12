using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Xml;
using System.Xml.XPath;
using System.Configuration;
using System.Reflection;

namespace NRPA
{
    public partial class FormDokumentMal : Form
    {        
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FormDokumentMal));        
        private bool initialized = false;
        private bool loadOk = true;        
        private bool mIsNorwegianGUILanguage;        
        private string[] requiredFiles = 
        { 
            "W_OffForv.xml", "W_Uhell.xml", "W_Kontakter.xml",
            "W_IntRap.dotm", "W_Ledermote.dotm", "W_Notat.dotm", "W_Press.dotm", "W_Referat.dotm", "W_Telefax.dotm", "W_Uhell.dotm", "W_BNotat.dotm"
        };        
        private DocumentInfo mDocInfo;        

        public FormDokumentMal()
        {
            Thread.CurrentThread.CurrentUICulture = Utils.ciNB;
            InitializeComponent();        
        }        

        public DocumentInfo DocInfo
        {
            get { return mDocInfo; }            
        }        

        private void FormBrevmal_Load(object sender, EventArgs e)
        {
            tabs.HideTabs = true;            
            
            foreach (string file in requiredFiles)
            {
                string localFile = Utils.ResourcePath + file;
                if (!File.Exists(localFile))
                {
                    loadOk = false;
                    MessageBox.Show("Filen [ " + localFile + " ] er ikke tilgjengelig. Kan ikke fortsette", "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }            

            if (loadOk)
            {                                                
                this.Text = "Dokument maler";

                loadAccidentTypes();
                loadContacts();
                loadAuthorContact();                                
            }
        }

        private void FormDokumentMal_Paint(object sender, PaintEventArgs e)
        {
            if (!initialized)
            {
                initialized = true;
                if (!loadOk)
                {
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
        }

        private void btnMalCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;            
            Close();
        }

        private void btnMalOk_Click(object sender, EventArgs e)
        {               
            if (rbNote.Checked)
                tabs.SelectedTab = tabPageNote;
            else if (rbReference.Checked) 
                tabs.SelectedTab = tabPageReference;            
            else if (rbInternalReport.Checked) 
                tabs.SelectedTab = tabPageInternalReport;
            else if (rbLeaderMeeting.Checked) 
                tabs.SelectedTab = tabPageLedermote;
            else if (rbTelefax.Checked) 
                tabs.SelectedTab = tabPageTelefax;
            else if (rbPress.Checked) 
                tabs.SelectedTab = tabPagePress;
            else if (rbAccident.Checked) 
                tabs.SelectedTab = tabPageAccident;
            else if (rbDecisionNote.Checked)
                tabs.SelectedTab = tabPageDecisionNote;       
        }

        private bool getCurrentUoffForvCombos(ref ComboBox uoff, ref ComboBox forv)
        {
            if (tabs.SelectedTab == tabPageNote) { uoff = cboxNoteUoff; forv = cboxNoteForv; return true; }
            if (tabs.SelectedTab == tabPageReference) { uoff = cboxCommentUoff; forv = cboxCommentForv; return true; }
            if (tabs.SelectedTab == tabPageInternalReport) { uoff = cboxInternalReportUoff; forv = cboxInternalReportForv; return true; }
            if (tabs.SelectedTab == tabPageLedermote) { uoff = cboxLedermoteUoff; forv = cboxLedermoteForv; return true; }
            if (tabs.SelectedTab == tabPageAccident) { uoff = cboxAccidentUoff; forv = cboxAccidentForv; return true; }
            if (tabs.SelectedTab == tabPageDecisionNote) { uoff = cboxBNoteUOff; forv = cboxBNoteForv; return true; }
            return false;
        }

        private void toolNorwegian_Click(object sender, EventArgs e)
        {
            ComboBox uoff = null, forv = null;
            bool uoff_enabled = false, forv_enabled = false;            

            bool hasCombos = getCurrentUoffForvCombos(ref uoff, ref forv);                        
            if (hasCombos)
            {
                uoff_enabled = uoff.Enabled;
                forv_enabled = forv.Enabled;
            }

            changeLanguage(this, Utils.ciNB);
            this.Text = "Dokument maler";
            Utils.formContact.setNorwegianLang();
            Utils.formOffForv.CancelCaption = "Lukk";
            btnEditCaseHandler.Text = "Rediger saksbeh.";
            btnShowLawInfo.Text = "Vis lovtekster";
            btnOffentlighetsloven.Text = "Offentlighetsloven";
            btnForvaltningsloven.Text = "Forvaltningsloven";

            toolSelectLang.Image = toolNorwegian.Image;

            mIsNorwegianGUILanguage = true;
            //loadNorwegianToolTips();       

            if (hasCombos)
            {
                uoff.Enabled = uoff_enabled;
                forv.Enabled = forv_enabled;
            }
        }

        private void toolEnglish_Click(object sender, EventArgs e)
        {
            ComboBox uoff = null, forv = null;
            bool uoff_enabled = false, forv_enabled = false;

            bool hasCombos = getCurrentUoffForvCombos(ref uoff, ref forv);
            if (hasCombos)
            {
                uoff_enabled = uoff.Enabled;
                forv_enabled = forv.Enabled;
            }

            changeLanguage(this, Utils.ciEN);
            this.Text = "Document templates";
            Utils.formContact.setEnglishLang();
            Utils.formOffForv.CancelCaption = "Close";
            btnEditCaseHandler.Text = "Edit case handler";
            btnShowLawInfo.Text = "Show law summary";
            btnOffentlighetsloven.Text = "Law of publications";
            btnForvaltningsloven.Text = "Law of trust";
            
            toolSelectLang.Image = toolEnglish.Image;

            mIsNorwegianGUILanguage = false;
            //loadNorwegianToolTips();       

            if (hasCombos)
            {
                uoff.Enabled = uoff_enabled;
                forv.Enabled = forv_enabled;
            }
        }

        private void changeLanguage(Control cc, CultureInfo ci)
        {            
            resources.ApplyResources(cc, cc.Name, ci);
            foreach (Control c in cc.Controls)
                changeLanguage(c, ci);                        
        }

        void loadAuthorContact()
        {
            Utils.formContact.loadContactFile();
            Contact c = Utils.formContact.contact;                                    
            if (c.default_language == "English")            
                toolEnglish_Click(null, null);                                            
            else            
                toolNorwegian_Click(null, null);                                            
        }

        private void btnMalBack_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = tabPageTemplates;
        }        

        private void btnNoteOk_Click(object sender, EventArgs e)
        {            
            mDocInfo.DocType = DocumentType.Note;
            mDocInfo.From = tbNoteFrom.Text;
            mDocInfo.To = tbNoteTo.Text;
            mDocInfo.Copy1 = tbNoteCopy1.Text;
            mDocInfo.Copy2 = tbNoteCopy2.Text;
            mDocInfo.Copy3 = tbNoteCopy3.Text;
            mDocInfo.Date = dtNoteDate.Value;
            mDocInfo.Ref = tbNoteRef.Text;
            mDocInfo.Heading = tbNoteHeading.Text;
            mDocInfo.OffLov = cboxNoteUoff.Text;
            mDocInfo.ForvLov = cboxNoteForv.Text;

            DialogResult = DialogResult.OK;
            Close();                        
        }

        private void btnReferenceOk_Click(object sender, EventArgs e)
        {            
            mDocInfo.DocType = DocumentType.Comment;
            mDocInfo.From = tbCommentFrom.Text;
            mDocInfo.To = tbCommentTo.Text;
            mDocInfo.Copy1 = tbCommentCopy1.Text;
            mDocInfo.Copy2 = tbCommentCopy2.Text;
            mDocInfo.Copy3 = tbCommentCopy3.Text;
            mDocInfo.Date = dtCommentDate.Value;
            mDocInfo.Ref = tbCommentRef.Text;
            mDocInfo.Heading = tbCommentHeading.Text;
            mDocInfo.OffLov = cboxCommentUoff.Text;
            mDocInfo.ForvLov = cboxCommentForv.Text;

            DialogResult = DialogResult.OK;
            Close();                        
        }

        private void loadOff(ref ComboBox cb, ref TextBox tbHelp)
        {
            XPathDocument doc = null;
            try
            {
                doc = new XPathDocument(Utils.ResourcePath + "W_OffForv.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Åpning av filen [" + Utils.ResourcePath + "W_OffForv.xml] mislyktes. Kan ikke fortsette", "Feil");
                return;
            }
            
            XPathNavigator nav = doc.CreateNavigator();
            XPathNodeIterator iter = nav.Select("//off/value");
            if (iter.Count > 0)
                cb.Items.Add("");
            while (iter.MoveNext())
                cb.Items.Add(iter.Current.Value);
            if (cb.Items.Count > 0)
                cb.SelectedIndex = 0;
            tbHelp.Text = "Velg paragraf...";
        }

        private void loadForv(ref ComboBox cb, string offtext, ref TextBox tbHelp)
        {
            XPathDocument doc = null;
            try
            {
                doc = new XPathDocument(Utils.ResourcePath + "W_OffForv.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Åpning av filen [" + Utils.ResourcePath + "W_OffForv.xml] mislyktes. Kan ikke fortsette", "Feil");
                return;
            }

            cb.Items.Clear();
            cb.Text = "";            
            XPathNavigator nav = doc.CreateNavigator();
            XPathNodeIterator iter = nav.Select("/root/off/forv/value[../../value='" + offtext + "']");
            cb.Enabled = false;
            if (iter.Count > 0)
                cb.Items.Add("");
            while (iter.MoveNext())
                cb.Items.Add(iter.Current.Value);
            if (cb.Items.Count > 0)
            {
                cb.Enabled = true;
                cb.SelectedIndex = 0;                
            }

            iter = nav.Select("/root/off/desc[../value='" + offtext + "']");
            if (iter.Count > 0)
            {
                iter.MoveNext();
                tbHelp.Text = offtext + " - " + iter.Current.Value + Environment.NewLine;
            }
            else tbHelp.Text = "";
        }

        private void clearComboBox(ref ComboBox cb, bool enable)
        {
            cb.Items.Clear();
            cb.Text = "";
            cb.Enabled = enable;
        }

        private void cbNoteUOff_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNoteUOff.Checked)
            {
                clearComboBox(ref cboxNoteUoff, true);                
                loadOff(ref cboxNoteUoff, ref tbNoteHelp);                
            }
            else
            {
                clearComboBox(ref cboxNoteUoff, false);
                clearComboBox(ref cboxNoteForv, false);
                tbNoteHelp.Text = "";
            }
        }

        private void cboxNoteUoff_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadForv(ref cboxNoteForv, cboxNoteUoff.Text, ref tbNoteHelp);
        }

        private void cbCommentUOff_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCommentUOff.Checked)
            {
                clearComboBox(ref cboxCommentUoff, true);
                loadOff(ref cboxCommentUoff, ref tbCommentHelp);
            }
            else
            {
                clearComboBox(ref cboxCommentUoff, false);
                clearComboBox(ref cboxCommentForv, false);
                tbCommentHelp.Text = "";
            }
        }

        private void cboxCommentUoff_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadForv(ref cboxCommentForv, cboxCommentUoff.Text, ref tbCommentHelp);
        }

        private void btnInternalReportOk_Click(object sender, EventArgs e)
        {                        
            mDocInfo.DocType = DocumentType.InternalReport;
            mDocInfo.From = tbInternalReportFrom.Text;                        
            mDocInfo.Date = dtInternalReportDate.Value;
            mDocInfo.Ref = tbInternalReportRef.Text;
            mDocInfo.Heading = tbInternalReportHeading.Text;
            mDocInfo.OffLov = cboxInternalReportUoff.Text;
            mDocInfo.ForvLov = cboxInternalReportForv.Text;

            DialogResult = DialogResult.OK;
            Close();                        
        }

        private void cbInternalReportUOff_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInternalReportUOff.Checked)
            {
                clearComboBox(ref cboxInternalReportUoff, true);
                loadOff(ref cboxInternalReportUoff, ref tbInternalReportHelp);
            }
            else
            {
                clearComboBox(ref cboxInternalReportUoff, false);
                clearComboBox(ref cboxInternalReportForv, false);
                tbInternalReportHelp.Text = "";
            }
        }

        private void cboxInternalReportUoff_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadForv(ref cboxInternalReportForv, cboxInternalReportUoff.Text, ref tbInternalReportHelp);
        }

        private void btnLedermoteOk_Click(object sender, EventArgs e)
        {            
            mDocInfo.DocType = DocumentType.Ledermote;
            mDocInfo.From = tbLedermoteFrom.Text;
            mDocInfo.To = tbLedermoteTo.Text;
            mDocInfo.Copy1 = tbLedermoteCopy1.Text;
            mDocInfo.Copy2 = tbLedermoteCopy2.Text;
            mDocInfo.Copy3 = tbLedermoteCopy3.Text;
            mDocInfo.Date = dtLedermoteDate.Value;
            mDocInfo.Ref = tbLedermoteRef.Text;
            mDocInfo.Heading = tbLedermoteHeading.Text;
            mDocInfo.OffLov = cboxLedermoteUoff.Text;
            mDocInfo.ForvLov = cboxLedermoteForv.Text;

            DialogResult = DialogResult.OK;
            Close();                        
        }

        private void cbLedermoteUOff_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLedermoteUOff.Checked)
            {
                clearComboBox(ref cboxLedermoteUoff, true);
                loadOff(ref cboxLedermoteUoff, ref tbLedermoteHelp);
            }
            else
            {
                clearComboBox(ref cboxLedermoteUoff, false);
                clearComboBox(ref cboxLedermoteForv, false);
                tbLedermoteHelp.Text = "";
            }
        }

        private void cboxLedermoteUoff_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadForv(ref cboxLedermoteForv, cboxLedermoteUoff.Text, ref tbLedermoteHelp);
        }

        private void btnTelefaxOk_Click(object sender, EventArgs e)
        {            
            mDocInfo.DocType = DocumentType.Telefax;
            mDocInfo.From = tbTelefaxFrom.Text;            
            mDocInfo.Copy1 = tbTelefaxCopy1.Text;
            mDocInfo.Copy2 = tbTelefaxCopy2.Text;
            mDocInfo.Copy3 = tbTelefaxCopy3.Text;
            mDocInfo.Date = dtTelefaxDate.Value;            
            mDocInfo.Heading = tbTelefaxHeading.Text;
            mDocInfo.FromFax = tbTelefaxFaxFrom.Text;
            mDocInfo.ToFax = tbTelefaxFaxTo.Text;
            mDocInfo.NumberOfPages = (int)nupTelefaxPages.Value;

            DialogResult = DialogResult.OK;
            Close();                        
        }

        private void loadContacts()
        {
            XPathDocument doc = null;
            try
            {
                doc = new XPathDocument(Utils.ResourcePath + "W_Kontakter.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Åpning av filen [" + Utils.ResourcePath + "W_Kontakter.xml] mislyktes. Kan ikke fortsette", "Feil");
                return;
            }

            cboxPressContact1.Items.Clear();
            cboxPressContact2.Items.Clear();
            cboxPressContact1.Items.Add("");
            cboxPressContact2.Items.Add("");
            
            XPathNavigator nav = doc.CreateNavigator();
            XPathNodeIterator iter = nav.Select("//contact/name | //contact/phone_work");
            while (iter.MoveNext())
            {
                if (!String.IsNullOrEmpty(iter.Current.Value.Trim()))
                {
                    string contact = iter.Current.Value;
                    if (iter.MoveNext())
                    {
                        if (!String.IsNullOrEmpty(iter.Current.Value.Trim()))
                            contact += " Tlf " + iter.Current.Value;
                    }

                    cboxPressContact1.Items.Add(contact);
                    cboxPressContact2.Items.Add(contact);
                }
            }
        }

        private void btnPressOk_Click(object sender, EventArgs e)
        {            
            mDocInfo.DocType = DocumentType.Press;
            mDocInfo.ReferenceNumber = tbPressReferenceNumber.Text;
            mDocInfo.Copy1 = cboxPressContact1.Text;
            mDocInfo.Copy2 = cboxPressContact2.Text;             
            mDocInfo.Date = dtPressDate.Value;
            mDocInfo.Heading = tbPressHeading.Text;            

            DialogResult = DialogResult.OK;
            Close();                        
        }

        private void loadAccidentTypes()
        {
            XPathDocument doc = null;
            try
            {
                doc = new XPathDocument(Utils.ResourcePath + "W_Uhell.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Åpning av filen [" + Utils.ResourcePath + "W_Uhell.xml] mislyktes. Kan ikke fortsette", "Feil");
                return;
            }

            cboxAccidentType.Items.Clear();
            cboxAccidentType.Items.Add("");            
            XPathNavigator nav = doc.CreateNavigator();
            XPathNodeIterator iter = nav.Select("//uhell/value");
            while (iter.MoveNext())
                cboxAccidentType.Items.Add(iter.Current.Value);
            tbAccidentHelp.Text = "Velg type i henhold til interne retningslinjer...";
        }

        private void btnAccidentOk_Click(object sender, EventArgs e)
        {
            mDocInfo.DocType = DocumentType.Accident;
            mDocInfo.From = tbAccidentFrom.Text;
            mDocInfo.To = tbAccidentTo.Text;
            mDocInfo.Copy1 = tbAccidentCopy1.Text;
            mDocInfo.Date = dtAccidentDate.Value;
            mDocInfo.Heading = tbAccidentHeading.Text;
            mDocInfo.AccidentType = cboxAccidentType.Text;
            mDocInfo.OffLov = cboxAccidentUoff.Text;
            mDocInfo.ForvLov = cboxAccidentForv.Text;

            DialogResult = DialogResult.OK;
            Close();                        
        }

        private void btnBNoteOk_Click(object sender, EventArgs e)
        {
            mDocInfo.DocType = DocumentType.DecisionNote;
            mDocInfo.From = tbBNoteFrom.Text;
            mDocInfo.To = tbBNoteTo.Text;
            mDocInfo.Copy1 = tbBNoteCopy1.Text;
            mDocInfo.Copy2 = tbBNoteCopy2.Text;
            mDocInfo.Copy3 = tbBNoteCopy3.Text;
            mDocInfo.Date = dtBNoteDate.Value;
            mDocInfo.Ref = tbBNoteRef.Text;
            mDocInfo.Heading = tbBNoteHeading.Text;
            mDocInfo.OffLov = cboxBNoteUOff.Text;
            mDocInfo.ForvLov = cboxBNoteForv.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cbAccidentUOff_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAccidentUOff.Checked)
            {
                clearComboBox(ref cboxAccidentUoff, true);
                loadOff(ref cboxAccidentUoff, ref tbAccidentHelp);
            }
            else
            {
                clearComboBox(ref cboxAccidentUoff, false);
                clearComboBox(ref cboxAccidentForv, false);
                tbAccidentHelp.Text = "";
            }
        }

        private void cboxAccidentUoff_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadForv(ref cboxAccidentForv, cboxAccidentUoff.Text, ref tbAccidentHelp);
        }

        private void cboxAccidentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxAccidentType.Text == "")
            {
                tbAccidentHelp.Text = "Velg type i henhold til interne retningslinjer...";
                return;
            }

            XPathDocument doc = null;
            try
            {
                doc = new XPathDocument(Utils.ResourcePath + "W_Uhell.xml");                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Åpning av filen [" + Utils.ResourcePath + "W_Uhell.xml] mislyktes. Kan ikke fortsette", "Feil");
                return;
            }

            XPathNavigator nav = doc.CreateNavigator();
            XPathNodeIterator iter = nav.Select("/root/uhell/desc[../value='" + cboxAccidentType.Text + "']");
            if (iter.Count > 0)
            {
                iter.MoveNext();
                tbAccidentHelp.Text = iter.Current.Value;
            }
        }

        private void btnOffentlighetsloven_Click(object sender, EventArgs e)
        {                        
            Utils.formOffForv.showOffentlighetsloven(btnOffentlighetsloven.Text);        
        }

        private void btnForvaltningsloven_Click(object sender, EventArgs e)
        {            
            Utils.formOffForv.showForvaltningsloven(btnForvaltningsloven.Text);            
        }        

        private void cboxNoteForv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.formOffForv.displayOffForvInfo(ref cboxNoteUoff, ref cboxNoteForv, ref tbNoteHelp);            
        }

        private void cboxCommentForv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.formOffForv.displayOffForvInfo(ref cboxCommentUoff, ref cboxCommentForv, ref tbCommentHelp);            
        }

        private void cboxInternalReportForv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.formOffForv.displayOffForvInfo(ref cboxInternalReportUoff, ref cboxInternalReportForv, ref tbInternalReportHelp);            
        }

        private void cboxLedermoteForv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.formOffForv.displayOffForvInfo(ref cboxLedermoteUoff, ref cboxLedermoteForv, ref tbLedermoteHelp);            
        }

        private void cboxAccidentForv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.formOffForv.displayOffForvInfo(ref cboxAccidentUoff, ref cboxAccidentForv, ref tbAccidentHelp);            
        }

        private void btnEditCaseHandler_Click(object sender, EventArgs e)
        {
            string lang = Utils.formContact.contact.default_language;
            Utils.formContact.editContactFile();
            Contact c = Utils.formContact.contact;
            if (c.default_language != lang)
            {
                if (c.default_language == "English")
                    toolEnglish_Click(null, null);
                else
                    toolNorwegian_Click(null, null);
            }
        }

        private void cbBNoteUOff_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBNoteUOff.Checked)
            {
                clearComboBox(ref cboxBNoteUOff, true);
                loadOff(ref cboxBNoteUOff, ref tbBNoteHelp);
            }
            else
            {
                clearComboBox(ref cboxBNoteUOff, false);
                clearComboBox(ref cboxBNoteForv, false);
                tbBNoteHelp.Text = "";
            }
        }

        private void cboxBNoteUOff_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadForv(ref cboxBNoteForv, cboxBNoteUOff.Text, ref tbBNoteHelp);
        }

        private void cboxBNoteForv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.formOffForv.displayOffForvInfo(ref cboxBNoteUOff, ref cboxBNoteForv, ref tbBNoteHelp);            
        }                                        
    }
}
