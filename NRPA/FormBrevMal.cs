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
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace NRPA
{    
    public partial class FormBrevMal : Form
    {
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FormBrevMal));        
        private bool initialized = false;
        private bool loadOk = true;        
        private ToolTip tooltip = new ToolTip();
        private string[] requiredFiles = 
        {             
            "W_OffForv.xml", "W_Kontakter.xml", "W_Brev.dotm"
        };        
        Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();
        Contact currentSignature = null;        

        private LetterInfo mLetterInfo = new LetterInfo();
        private string mRefFormat = "/xxxxx/nnn";
        private string mNorwegianPhoneDir = "+47";
        private bool mIsNorwegianGUILanguage;        

        public FormBrevMal()
        {
            Thread.CurrentThread.CurrentUICulture = Utils.ciNB;
            InitializeComponent();
        }

        public LetterInfo LetterInfo
        {
            get { return mLetterInfo; }
        }

        private void FormBrevMal_Load(object sender, EventArgs e)
        {            
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
                this.Text = "Brevmal";
                this.Icon = new Icon(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("NRPA.nrpa-sol.ico"));

                loadContacts();
                loadOff(ref cboxUoff);                
                loadAuthorContact();                

                btnReferanseformat_Click(sender, null);                
            }
        }

        bool isNorwegianLanguage()
        {
            return (cboxDocumentLang.Text == "Norsk - Bokmål" || cboxDocumentLang.Text == "Norsk - Nynorsk");
        }

        bool isNorwegianGUILanguage()
        {
            return mIsNorwegianGUILanguage;
        }

        private void loadNorwegianToolTips()
        {
            tooltip.SetToolTip(tbAddress1, "Skriv inn mottakers adresse");
            tooltip.SetToolTip(tbOurReference, "Sett inn arkiv referanse." + Environment.NewLine 
                + "\txxxxx\t: Saksnummer bestående av 5 siffer" + Environment.NewLine
                + "\tnnn\t: Arkivkode som desimaltall");
            tooltip.SetToolTip(tbTheirReference, "Skriv inn mottakers referanse");
            tooltip.SetToolTip(tbCaseHandler, "Skriv inn saksbehandlers navn");
            tooltip.SetToolTip(tbCaseHandlerPhone, "Skriv inn saksbehandlers telefonnummer");
            tooltip.SetToolTip(cboxDocumentLang, "Velg brevets språk");
            tooltip.SetToolTip(tbHeading, "Skriv inn brevets overskrift");
            tooltip.SetToolTip(cboxSignature, "Velg underskriver");
            tooltip.SetToolTip(tbSignatureTitle, "Skriv inn underskrivers tittel");
            tooltip.SetToolTip(tbCounterSignature, "Skriv inn paraferers navn");
            tooltip.SetToolTip(tbCounterSignatureTitle, "Skriv inn paraferers tittel");
            tooltip.SetToolTip(tbAttachments, "Skriv inn informasjon om vedlegg");
            tooltip.SetToolTip(tbCopies, "Skriv inn informasjon om kopier");
            tooltip.SetToolTip(cboxUoff, "Velg paragraf for untagelse av publisering");
            tooltip.SetToolTip(cboxForv, "Velg paragraf fra forvaltningsloven");            
        }

        private void loadNorwegian2ToolTips()
        {
            tooltip.SetToolTip(tbAddress1, "Skriv inn mottakers adresse");
            tooltip.SetToolTip(tbOurReference, "Sett inn arkiv referanse." + Environment.NewLine
                + "\txxxxx\t: Saksnummer bestående av 5 siffer" + Environment.NewLine
                + "\tnnn\t: Arkivkode som desimaltall");
            tooltip.SetToolTip(tbTheirReference, "Skriv inn mottakers referanse");
            tooltip.SetToolTip(tbCaseHandler, "Skriv inn saksbehandlers navn");
            tooltip.SetToolTip(tbCaseHandlerPhone, "Skriv inn saksbehandlers telefonnummer");
            tooltip.SetToolTip(cboxDocumentLang, "Velg brevets språk");
            tooltip.SetToolTip(tbHeading, "Skriv inn brevets overskrift");
            tooltip.SetToolTip(cboxSignature, "Velg underskriver");
            tooltip.SetToolTip(tbSignatureTitle, "Skriv inn underskrivers tittel");
            tooltip.SetToolTip(tbCounterSignature, "Skriv inn paraferers navn");
            tooltip.SetToolTip(tbCounterSignatureTitle, "Skriv inn paraferers tittel");
            tooltip.SetToolTip(tbAttachments, "Skriv inn informasjon om vedlegg");
            tooltip.SetToolTip(tbCopies, "Skriv inn informasjon om kopier");
            tooltip.SetToolTip(cboxUoff, "Velg paragraf for untagelse av publisering");
            tooltip.SetToolTip(cboxForv, "Velg paragraf fra forvaltningsloven");
        }

        private void loadEnglishToolTips()
        {
            tooltip.SetToolTip(tbAddress1, "Enter receivers address");
            tooltip.SetToolTip(tbOurReference, "Insert archive reference." + Environment.NewLine
                + "\txxxxx\t: Case number consisting of 5 numbers" + Environment.NewLine
                + "\tnnn\t: Archive code as a decimal number");
            tooltip.SetToolTip(tbTheirReference, "Enter receivers reference");
            tooltip.SetToolTip(tbCaseHandler, "Enter case handlers name");
            tooltip.SetToolTip(tbCaseHandlerPhone, "Enter case handlers phone number");
            tooltip.SetToolTip(cboxDocumentLang, "Choose the language for the letter");
            tooltip.SetToolTip(tbHeading, "Enter the letters header text");
            tooltip.SetToolTip(cboxSignature, "Choose signature");
            tooltip.SetToolTip(tbSignatureTitle, "Enter signature title");
            tooltip.SetToolTip(tbCounterSignature, "Enter counter signature name");
            tooltip.SetToolTip(tbCounterSignatureTitle, "Enter counter signature title");
            tooltip.SetToolTip(tbAttachments, "Enter information about attachments");
            tooltip.SetToolTip(tbCopies, "Enter information about copies");
            tooltip.SetToolTip(cboxUoff, "Choose paragraph for publishing exception");
            tooltip.SetToolTip(cboxForv, "Choose paragraph from the laws of trust");            
        }

        void loadAuthorContact()
        {
            Utils.formContact.loadContactFile();
            Contact c = Utils.formContact.contact;

            tbCounterSignature.Text = c.name;
            tbCounterSignatureTitle.Text = c.title;
            tbCaseHandler.Text = c.name;
            tbCaseHandlerPhone.Text = c.phone;

            if (c.default_language == "English")
            {
                toolEnglish_Click(null, null);
                int idx = cboxDocumentLang.FindStringExact("English");
                cboxDocumentLang.SelectedIndex = (idx >= 0) ? idx : 0;                                                
            }
            else if (c.default_language == "Norsk - Bokmål")
            {
                toolNorwegian_Click(null, null);
                int idx = cboxDocumentLang.FindStringExact("Norsk - Bokmål");
                cboxDocumentLang.SelectedIndex = (idx >= 0) ? idx : 0;                                                
            }
            else
            {
                toolNorwegian2_Click(null, null);
                int idx = cboxDocumentLang.FindStringExact("Norsk - Nynorsk");
                cboxDocumentLang.SelectedIndex = (idx >= 0) ? idx : 0;
            }
        }

        private void FormBrevMal_Paint(object sender, PaintEventArgs e)
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

        private void toolNorwegian_Click(object sender, EventArgs e)
        {
            bool uoff_enabled = cboxUoff.Enabled;
            bool forv_enabled = cboxForv.Enabled;

            changeLanguage(this, Utils.ciNB);            
            this.Text = "Brevmal";
            Utils.formContact.setNorwegianLang();
            Utils.formOffForv.CancelCaption = "Lukk";
            btnEditCaseHandler.Text = "Rediger saksbeh.";
            btnFillAuto.Text = "Fyll inn";
            btnShowLawInfo.Text = "Vis lovtekster";
            btnFillSaksbehandler.Text = "Saksbehandler";
            btnFillParaferer.Text = "Paraferer";
            btnReferanseformat.Text = "Referanseformat";
            btnOffentlighetsloven.Text = "Offentlighetsloven";
            btnForvaltningsloven.Text = "Forvaltningsloven";

            toolSelectLang.Image = toolNorwegian.Image;
            toolSelectedLang.Text = toolNorwegian.Text;

            mIsNorwegianGUILanguage = true;
            loadNorwegianToolTips();            

            cboxUoff.Enabled = uoff_enabled;
            cboxForv.Enabled = forv_enabled;
        }

        private void toolNorwegian2_Click(object sender, EventArgs e)
        {
            bool uoff_enabled = cboxUoff.Enabled;
            bool forv_enabled = cboxForv.Enabled;

            changeLanguage(this, Utils.ciNN);
            this.Text = "Brevmal";
            Utils.formContact.setNorwegian2Lang();
            Utils.formOffForv.CancelCaption = "Lukk";
            btnEditCaseHandler.Text = "Rediger saksbeh.";
            btnFillAuto.Text = "Fyll inn";
            btnShowLawInfo.Text = "Vis lovtekster";
            btnFillSaksbehandler.Text = "Saksbehandler";
            btnFillParaferer.Text = "Paraferer";
            btnReferanseformat.Text = "Referanseformat";
            btnOffentlighetsloven.Text = "Offentlighetsloven";
            btnForvaltningsloven.Text = "Forvaltningsloven";

            toolSelectLang.Image = toolNorwegian2.Image;
            toolSelectedLang.Text = toolNorwegian2.Text;

            mIsNorwegianGUILanguage = true;
            loadNorwegian2ToolTips();

            cboxUoff.Enabled = uoff_enabled;
            cboxForv.Enabled = forv_enabled;
        }

        private void toolEnglish_Click(object sender, EventArgs e)
        {
            bool uoff_enabled = cboxUoff.Enabled;
            bool forv_enabled = cboxForv.Enabled;

            changeLanguage(this, Utils.ciEN);            
            this.Text = "Letter template";
            Utils.formContact.setEnglishLang();
            Utils.formOffForv.CancelCaption = "Close";
            btnEditCaseHandler.Text = "Edit case handler";
            btnFillAuto.Text = "Auto fill";
            btnShowLawInfo.Text = "Show law summary";
            btnFillSaksbehandler.Text = "Case handler";
            btnFillParaferer.Text = "Counter signature";
            btnReferanseformat.Text = "Reference format";
            btnOffentlighetsloven.Text = "Law of publications";
            btnForvaltningsloven.Text = "Law of trust";
            
            toolSelectLang.Image = toolEnglish.Image;
            toolSelectedLang.Text = toolEnglish.Text;

            mIsNorwegianGUILanguage = false;
            loadEnglishToolTips();

            cboxUoff.Enabled = uoff_enabled;
            cboxForv.Enabled = forv_enabled;
        }

        private void changeLanguage(Control cc, CultureInfo ci)
        {
            resources.ApplyResources(cc, cc.Name, ci);
            foreach (Control c in cc.Controls)
                changeLanguage(c, ci);
        }        

        private void loadContacts()
        {
            cboxSignature.Items.Clear();            
            cboxSignature.Items.Add("");

            XmlDocument xml = null;
            try
            {
                xml = new XmlDocument();
                xml.Load(Utils.ResourcePath + "W_Kontakter.xml");                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Åpning av filen [" + Utils.ResourcePath + "W_Kontakter.xml] mislyktes. Kan ikke laste inn kontakter", "Feil");
                return;
            }

            XmlNodeList xnList = xml.SelectNodes("/root/contact");
            foreach (XmlNode xn in xnList)
            {
                Contact c = new Contact();
                c.name = xn["name"].InnerText;
                c.phone = xn["phone_work"].InnerText;
                c.title = xn["title"].InnerText;
                c.title_english = xn["title_english"].InnerText;

                cboxSignature.Items.Add(c.name);
                contacts.Add(c.name, c);
            }
        }

        private void loadOff(ref ComboBox cb)
        {
            XPathDocument doc = null;
            try
            {
                doc = new XPathDocument(Utils.ResourcePath + "W_OffForv.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Åpning av filen [" + Utils.ResourcePath + "W_OffForv.xml] mislyktes. Kan ikke laste inn lovparagrafer", "Feil");
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
        }

        private void loadForv(ref ComboBox cb, string offtext)
        {
            cb.Items.Clear();
            cb.Text = "";            

            XPathDocument doc = null;
            try
            {
                doc = new XPathDocument(Utils.ResourcePath + "W_OffForv.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Åpning av filen [" + Utils.ResourcePath + "W_OffForv.xml] mislyktes. Kan ikke laste inn lovparagrafer", "Feil");
                return;
            }   
         
            XPathNavigator nav = doc.CreateNavigator();
            XPathNodeIterator iter = nav.Select("/root/off/forv/value[../../value='" + offtext + "']");            
            if (iter.Count > 0)
                cb.Items.Add("");
            while (iter.MoveNext())
                cb.Items.Add(iter.Current.Value);
            if (cb.Items.Count > 0)
            {
                cb.SelectedIndex = 0;
                cb.Enabled = true;
            }
            else cb.Enabled = false;

            iter = nav.Select("/root/off/desc[../value='" + offtext + "']");
            if (iter.Count > 0)
            {
                iter.MoveNext();
                tooltip.SetToolTip(cboxUoff, offtext + " - " + iter.Current.Value);

            }
            else
            {
                if(isNorwegianGUILanguage())
                    tooltip.SetToolTip(cboxUoff, "Velg paragraf for untagelse av publisering");
                else tooltip.SetToolTip(cboxUoff, "Choose paragraph for publishing exception");
            }
        }        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            int i = 0;
            if(!String.IsNullOrEmpty(tbAddress1.Text))
                mLetterInfo.Address[i++] = tbAddress1.Text;
            if (!String.IsNullOrEmpty(tbAddress2.Text))
                mLetterInfo.Address[i++] = tbAddress2.Text;
            if (!String.IsNullOrEmpty(tbAddress3.Text))
                mLetterInfo.Address[i++] = tbAddress3.Text;
            if (!String.IsNullOrEmpty(tbAddress4.Text))
                mLetterInfo.Address[i++] = tbAddress4.Text;
            if (!String.IsNullOrEmpty(tbAddress5.Text))
                mLetterInfo.Address[i++] = tbAddress5.Text;            

            mLetterInfo.DocumentLanguage = cboxDocumentLang.Text;
            mLetterInfo.Heading = tbHeading.Text;
            mLetterInfo.UOff = cboxUoff.Text;
            mLetterInfo.Forv = cboxForv.Text;
            mLetterInfo.OurReference = tbOurReference.Text;
            mLetterInfo.TheirReference = tbTheirReference.Text;
            mLetterInfo.CaseHandler = tbCaseHandler.Text;
            mLetterInfo.CaseHandlerInitials = Utils.formContact.contact.initials;
            if (String.IsNullOrEmpty(tbCaseHandlerPhoneDir.Text.Trim()))
                mLetterInfo.CaseHandlerPhone = tbCaseHandlerPhone.Text.Trim();
            else
                mLetterInfo.CaseHandlerPhone = tbCaseHandlerPhoneDir.Text.Trim() + " " + tbCaseHandlerPhone.Text.Trim();
            mLetterInfo.CounterSignature = tbCounterSignature.Text;
            mLetterInfo.CounterSignatureTitle = tbCounterSignatureTitle.Text;
            mLetterInfo.Attachments = tbAttachments.Text;
            mLetterInfo.Copies = tbCopies.Text;
            if (currentSignature != null)
            {
                mLetterInfo.signature.name = currentSignature.name;
                if(isNorwegianLanguage())
                    mLetterInfo.signature.phone = currentSignature.phone;
                else
                    mLetterInfo.signature.phone = mNorwegianPhoneDir + " " + currentSignature.phone;
                mLetterInfo.signature.title = currentSignature.title;
                mLetterInfo.signature.title_english = currentSignature.title_english;
            }
            else if(!String.IsNullOrEmpty(cboxSignature.Text.Trim()))
            {
                mLetterInfo.signature.name = cboxSignature.Text;                
                if(!String.IsNullOrEmpty(tbSignatureTitle.Text.Trim()))
                {
                    mLetterInfo.signature.title = tbSignatureTitle.Text;
                    mLetterInfo.signature.title_english = tbSignatureTitle.Text;
                }                
            }
            mLetterInfo.attachment = !String.IsNullOrEmpty(tbAttachments.Text.Trim());
            mLetterInfo.copy = !String.IsNullOrEmpty(tbCopies.Text.Trim());
            mLetterInfo.uoff = !String.IsNullOrEmpty(cboxUoff.Text.Trim());
        }                                                

        private void cboxUoff_SelectedIndexChanged(object sender, EventArgs e)
        {            
            loadForv(ref cboxForv, cboxUoff.Text);
        }

        private void cboxSignature_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadContactData();
        }

        void LoadContactData()
        {
            if (String.IsNullOrEmpty(cboxSignature.Text.Trim()))
            {
                tbSignatureTitle.Text = "";
                currentSignature = null;
            }
            else
            {
                if(contacts.ContainsKey(cboxSignature.Text.Trim()))
                {
                    currentSignature = contacts[cboxSignature.Text.Trim()];
                    if (isNorwegianLanguage())
                        tbSignatureTitle.Text = currentSignature.title;
                    else
                        tbSignatureTitle.Text = currentSignature.title_english;                        
                }
            }
        }

        private void cboxDocumentLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadContactData();
            if (isNorwegianLanguage())
            {
                tbCaseHandlerPhoneDir.Text = "";
                tbCounterSignatureTitle.Text = Utils.formContact.contact.title;
            }
            else
            {
                tbCaseHandlerPhoneDir.Text = mNorwegianPhoneDir;
                tbCounterSignatureTitle.Text = Utils.formContact.contact.title_english;
            }
        }                                                                

        private void cboxForv_SelectedIndexChanged(object sender, EventArgs e)
        {
            XPathDocument doc = null;
            try
            {
                doc = new XPathDocument(Utils.ResourcePath + "W_OffForv.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Åpning av filen [" + Utils.ResourcePath + "W_OffForv.xml] mislyktes. Kan ikke laste inn lovparagrafer", "Feil");
                return;
            }
            
            string forvlov = cboxForv.Text;                        
            XPathNavigator nav = doc.CreateNavigator();
            if (!String.IsNullOrEmpty(forvlov))
            {
                XPathNodeIterator iter = nav.Select("/root/off/forv/desc[../value='" + forvlov + "']");
                if (iter.Count > 0)
                {
                    iter.MoveNext();
                    tooltip.SetToolTip(cboxForv, forvlov + " - " + iter.Current.Value);
                }
            }
            else
            {
                if(isNorwegianGUILanguage())
                    tooltip.SetToolTip(cboxForv, "Velg paragraf fra forvaltningsloven");
                else tooltip.SetToolTip(cboxForv, "Choose paragraph from the laws of trust");            
            }
        }        

        private void btnEditCaseHandler_Click(object sender, EventArgs e)
        {
            string lang = Utils.formContact.contact.default_language;
            if (Utils.formContact.editContactFile())
            {
                Contact c = Utils.formContact.contact;
                tbCounterSignature.Text = c.name;
                if (isNorwegianLanguage())
                    tbCounterSignatureTitle.Text = c.title;
                else
                    tbCounterSignatureTitle.Text = c.title_english;
                tbCaseHandler.Text = c.name;
                tbCaseHandlerPhone.Text = c.phone;

                if (c.default_language != lang)
                {
                    if (c.default_language == "English")
                    {
                        toolEnglish_Click(null, null);
                        int idx = cboxDocumentLang.FindStringExact("English");
                        cboxDocumentLang.SelectedIndex = (idx >= 0) ? idx : 0;
                    }
                    else if (c.default_language == "Norsk - Bokmål")
                    {
                        toolNorwegian_Click(null, null);
                        int idx = cboxDocumentLang.FindStringExact("Norsk - Bokmål");
                        cboxDocumentLang.SelectedIndex = (idx >= 0) ? idx : 0;
                    }
                    else
                    {
                        toolNorwegian2_Click(null, null);
                        int idx = cboxDocumentLang.FindStringExact("Norsk - Nynorsk");
                        cboxDocumentLang.SelectedIndex = (idx >= 0) ? idx : 0;
                    }
                }
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

        private void btnFillSaksbehandler_Click(object sender, EventArgs e)
        {
            if(Utils.formContact.isContactInfoComplete())
            {
                Contact c = Utils.formContact.contact;
                tbCaseHandler.Text = c.name;
                tbCaseHandlerPhone.Text = c.phone;
                if (isNorwegianLanguage())
                    tbCaseHandlerPhoneDir.Text = "";
                else tbCaseHandlerPhoneDir.Text = mNorwegianPhoneDir;
            }
        }

        private void btnFillParaferer_Click(object sender, EventArgs e)
        {
            if (Utils.formContact.isContactInfoComplete())                        
            {
                Contact c = Utils.formContact.contact;
                tbCounterSignature.Text = c.name;
                if (isNorwegianLanguage())
                    tbCounterSignatureTitle.Text = c.title;
                else
                    tbCounterSignatureTitle.Text = c.title_english;
            }
        }

        private void btnReferanseformat_Click(object sender, EventArgs e)
        {
            tbOurReference.Text = DateTime.Now.Year.ToString() + mRefFormat;
        }                
    }
}
