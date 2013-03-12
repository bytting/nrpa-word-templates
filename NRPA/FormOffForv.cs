using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Windows.Forms;

namespace NRPA
{
    public partial class FormOffForv : Form
    {
        public FormOffForv()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string CancelCaption
        {
            get { return btnClose.Text; }
            set { btnClose.Text = value; }
        }        

        public void showOffentlighetsloven(string title)
        {
            this.Text = title;
            this.loadXPath("/root/off/value | /root/off/desc | /root/off/text");            
            this.ShowDialog();
        }

        public void showForvaltningsloven(string title)
        {
            this.Text = title;
            this.loadXPath("/root/off/forv/value | /root/off/forv/desc | /root/off/forv/text");
            this.ShowDialog();
        }

        private void loadXPath(string xpath)
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

            tbInfo.Text = "";
            XPathNavigator nav = doc.CreateNavigator();

            XPathNavigator it = nav.SelectSingleNode("/root");
            string forvurl = it.GetAttribute("LawsOfTrustURL", "");
            string lastRevised = it.GetAttribute("LastRevised", "");
            tbInfo.Text += "Referanse: " + forvurl + Environment.NewLine + "Sist oppdatert: " + lastRevised + Environment.NewLine + Environment.NewLine + Environment.NewLine;

            XPathNodeIterator iter = nav.Select(xpath);
            for (int i = 0; i < iter.Count / 3; i++)
            {
                iter.MoveNext();
                tbInfo.Text += iter.Current.Value;

                iter.MoveNext();
                tbInfo.Text += " - " + iter.Current.Value;
                tbInfo.Text += Environment.NewLine;

                tbInfo.Text += "============================================================================================";

                iter.MoveNext();
                tbInfo.Text += iter.Current.Value;
                tbInfo.Text += Environment.NewLine + Environment.NewLine;
            }

            tbInfo.Select(0, 0);
        }

        public void displayOffForvInfo(ref ComboBox uoff, ref ComboBox forv, ref TextBox tbInfo)
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

            string offlov = uoff.Text;
            string forvlov = forv.Text;

            XPathNavigator nav = doc.CreateNavigator();
            if (!String.IsNullOrEmpty(offlov))
            {
                XPathNodeIterator iter = nav.Select("/root/off/desc[../value='" + offlov + "']");
                if (iter.Count > 0)
                {
                    iter.MoveNext();
                    tbInfo.Text = offlov + " - " + iter.Current.Value + Environment.NewLine;
                }
            }
            else tbInfo.Text = "";

            if (!String.IsNullOrEmpty(forvlov))
            {
                XPathNodeIterator iter = nav.Select("/root/off/forv/desc[../value='" + forvlov + "']");
                if (iter.Count > 0)
                {
                    iter.MoveNext();
                    tbInfo.Text += forvlov + " - " + iter.Current.Value + Environment.NewLine;
                }
            }
        }
    }
}
