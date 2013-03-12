using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace NRPA
{
    public partial class FormContact : Form
    {
        private Contact mContact = new Contact();

        public FormContact()
        {
            InitializeComponent();
        }

        private void FormContact_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(mContact.name))
                tbName.Text = mContact.name;
            if (!String.IsNullOrEmpty(mContact.initials))
                tbInitials.Text = mContact.initials;
            if (!String.IsNullOrEmpty(mContact.phone))
                tbPhone.Text = mContact.phone;
            if (!String.IsNullOrEmpty(mContact.title))
                tbTitle.Text = mContact.title;
            if (!String.IsNullOrEmpty(mContact.title_english))
                tbEnglishTitle.Text = mContact.title_english;
            if (!String.IsNullOrEmpty(mContact.default_language))
            {
                int idx = cboxDefaultLanguage.FindStringExact(mContact.default_language);
                cboxDefaultLanguage.SelectedIndex = (idx >= 0) ? idx : 0;                
            }
            else cboxDefaultLanguage.SelectedIndex = 0;
        }

        public Contact contact
        {
            get { return mContact; }
        }

        public bool personalFolderExists()
        {
            return Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));            
        }

        public bool contactFileExists()
        {            
            return File.Exists(contactFile);
        }

        public string contactFile
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Utils.WordInfoFile; }
        }

        private bool readContactFile()
        {
            if (!contactFileExists())
                return false;
            
            TextReader reader = null;
            try
            {
                reader = File.OpenText(contactFile);
                mContact.name = reader.ReadLine();
                mContact.initials = reader.ReadLine();
                mContact.phone = reader.ReadLine();
                mContact.title = reader.ReadLine();
                mContact.title_english = reader.ReadLine();
                mContact.default_language = reader.ReadLine();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return true;
        }

        private bool writeContactFile()
        {
            if (!personalFolderExists())
                return false;            

            FileStream stream = null;
            TextWriter writer = null;
            try
            {
                stream = new FileStream(contactFile, FileMode.Create);
                writer = new StreamWriter(stream);
                writer.WriteLine(mContact.name);
                writer.WriteLine(mContact.initials);
                writer.WriteLine(mContact.phone);
                writer.WriteLine(mContact.title);
                writer.WriteLine(mContact.title_english);
                writer.WriteLine(mContact.default_language);
            }
            catch (Exception ex)
            {                
                return false;
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }

            setWordAuthorAndInitials(mContact.name, mContact.initials, mContact.phone, mContact.title, mContact.title_english);

            return true;
        }

        public bool isContactInfoComplete()
        {
            if (String.IsNullOrEmpty(mContact.name)
                || String.IsNullOrEmpty(mContact.initials)
                || String.IsNullOrEmpty(mContact.phone)
                || String.IsNullOrEmpty(mContact.title)
                || String.IsNullOrEmpty(mContact.title_english)
                || String.IsNullOrEmpty(mContact.default_language))
            {
                return false;
            }
            return true;
        }

        private bool isFormComplete()
        {
            if (String.IsNullOrEmpty(tbName.Text.Trim())
                || String.IsNullOrEmpty(tbInitials.Text.Trim())
                || String.IsNullOrEmpty(tbPhone.Text.Trim())
                || String.IsNullOrEmpty(tbTitle.Text.Trim())
                || String.IsNullOrEmpty(tbEnglishTitle.Text.Trim())
                || String.IsNullOrEmpty(cboxDefaultLanguage.Text.Trim()))
            {
                return false;
            }
            return true;
        }

        public void getWordAuthorAndInitials()
        {               
            Word.Application app = Globals.ThisAddIn.Application;            

            if (!String.IsNullOrEmpty(app.UserName))            
                mContact.name = tbName.Text = app.UserName;
            else mContact.name = tbName.Text = String.Empty;

            if (!String.IsNullOrEmpty(app.UserInitials))
                mContact.initials = tbInitials.Text = app.UserInitials;
            else mContact.initials = tbInitials.Text = String.Empty;
        }

        public void setWordAuthorAndInitials(string author, string initials, string phone, string title, string title_english)
        {
            Word.Application app = Globals.ThisAddIn.Application;
            if(app.UserName != author)
                app.UserName = author;
            if(app.UserInitials != initials)
                app.UserInitials = initials;
            string address = phone + Environment.NewLine + title + Environment.NewLine + title_english + Environment.NewLine + Environment.NewLine + Environment.NewLine;
            app.UserAddress = address;
        }

        public void loadContactFile()
        {
            if (!personalFolderExists())
                return;

            if (!contactFileExists())
            {
                getWordAuthorAndInitials();

                DialogResult dr = ShowDialog();
                if (dr == DialogResult.OK)
                {
                    if (!writeContactFile())
                    {
                        MessageBox.Show("Oppretting av filen [" + contactFile + "] mislyktes. Kan ikke lagre personlig informasjon", "Feil");
                        return;
                    }
                }
            }
            else
            {
                readContactFile();

                getWordAuthorAndInitials();

                if(!isContactInfoComplete())
                {
                    DialogResult dr = ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        if (!writeContactFile())
                        {
                            MessageBox.Show("Oppretting av filen [" + contactFile + "] mislyktes. Kan ikke lagre personlig informasjon", "Feil");
                            return;
                        }
                    }
                }
            }
        }

        public bool editContactFile()
        {
            if (!personalFolderExists())
            {
                MessageBox.Show("Din personlige katalog ble ikke funnet. Kan ikke redigere kontaktinformasjon", "Feil");
                return false;
            }

            if (!contactFileExists())
            {
                getWordAuthorAndInitials();

                DialogResult dr = ShowDialog();
                if (dr == DialogResult.OK)
                {
                    if (!writeContactFile())
                    {
                        MessageBox.Show("Oppretting av filen [" + contactFile + "] mislyktes. Kan ikke lagre personlig informasjon", "Feil");
                        return false;
                    }
                }
            }
            else
            {
                readContactFile();

                getWordAuthorAndInitials();

                DialogResult dr = ShowDialog();
                if (dr == DialogResult.OK)
                {
                    if (!writeContactFile())
                    {
                        MessageBox.Show("Oppretting av filen [" + contactFile + "] mislyktes. Kan ikke lagre personlig informasjon", "Feil");
                        return false;
                    }
                }
            }
            return true;
        }

        public void setNorwegianLang()
        {
            this.Text = "Saksbehandler informasjon";
            this.lblName.Text = "Skriv inn ditt eget navn";
            this.lblInitials.Text = "Skriv inn dine initialer (Maks 4 tegn)";
            this.lblPhone.Text = "Skriv inn ditt jobb telefonnummer";
            this.lblTitle.Text = "Skriv inn din tittel";
            this.lblTitleEnglish.Text = "Skriv inn din tittel på engelsk";
            this.lblDefaultLanguage.Text = "Velg hvilket språk du vanligvis bruker";
            this.btnCancel.Text = "Avbryt";
        }

        public void setNorwegian2Lang()
        {
            this.Text = "Saksbehandler informasjon";
            this.lblName.Text = "Skriv inn ditt eget navn";
            this.lblInitials.Text = "Skriv inn dine initialer (Maks 4 tegn)";
            this.lblPhone.Text = "Skriv inn ditt jobb telefonnummer";
            this.lblTitle.Text = "Skriv inn din tittel";
            this.lblTitleEnglish.Text = "Skriv inn din tittel på engelsk";
            this.lblDefaultLanguage.Text = "Velg hvilket språk du vanligvis bruker";
            this.btnCancel.Text = "Avbryt";
        }

        public void setEnglishLang()
        {
            this.Text = "Case handler information";
            this.lblName.Text = "Enter your own name";
            this.lblInitials.Text = "Enter your initials (Max 4 characters)";
            this.lblPhone.Text = "Enter your work phone number";
            this.lblTitle.Text = "Enter your title";
            this.lblTitleEnglish.Text = "Enter your title in english";
            this.lblDefaultLanguage.Text = "Choose your preferred language";
            this.btnCancel.Text = "Cancel";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            mContact.name = tbName.Text.Trim();
            mContact.initials = tbInitials.Text.Trim();
            mContact.phone = tbPhone.Text.Trim();
            mContact.title = tbTitle.Text.Trim();
            mContact.title_english = tbEnglishTitle.Text.Trim();
            mContact.default_language = cboxDefaultLanguage.Text;

            if (!isContactInfoComplete())                
            {
                MessageBox.Show("Alle felter må fylles ut", "Feil");
                return;
            }
            
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {            
            if (!isFormComplete())
            {
                MessageBox.Show("Alle felter må fylles ut", "Feil");
                return;
            }        

            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isFormComplete())
            {
                MessageBox.Show("Alle felter må fylles ut", "Feil");
                e.Cancel = true;                
            }            
        }        
    }
}
