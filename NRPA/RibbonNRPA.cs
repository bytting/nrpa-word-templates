using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;
using System.Threading;

namespace NRPA
{
    public partial class RibbonNRPA
    {        
        private static string resourcePath = Utils.ResourcePath;
        
        private string[] requiredFiles = 
        { 
            "W_OffForv.xml", "W_Uhell.xml", "W_Kontakter.xml", "W_Brev.dotm",
            "W_IntRap.dotm", "W_Ledermote.dotm", "W_Notat.dotm", "W_Press.dotm", "W_Referat.dotm", "W_Telefax.dotm", "W_Uhell.dotm", "W_BNotat.dotm"
        };        

        private void RibbonNRPA_Load(object sender, RibbonUIEventArgs e)
        {            
            Utils.formContact.loadContactFile();

            if (!Directory.Exists(Utils.ResourcePath))
                Directory.CreateDirectory(Utils.ResourcePath);

            if (Directory.Exists(Utils.SharedResourcePath))
            {
                foreach (string file in requiredFiles)
                {
                    string sharedFile = Utils.SharedResourcePath + file;
                    string localFile = Utils.ResourcePath + file;

                    if (File.Exists(sharedFile) && File.Exists(localFile))
                    {
                        if (File.GetLastAccessTime(localFile) != File.GetLastAccessTime(sharedFile))
                        {
                            File.Copy(sharedFile, localFile, true);
                        }
                    }
                    else if (File.Exists(sharedFile))
                    {
                        File.Copy(sharedFile, localFile, true);
                    }
                }
            }            
        }        

        private void btnDocTemplates_Click(object sender, RibbonControlEventArgs e)
        {
            // DOKUMENTMALER

            Word.Application app = null;
            Word._Document doc = null;
            object missing = System.Reflection.Missing.Value;

            try
            {
                FormDokumentMal form = new FormDokumentMal();
                DialogResult result = form.ShowDialog();
                if (result != DialogResult.OK)
                    return;
                
                app = Globals.ThisAddIn.Application;                
                object templateName = null;
                DocumentInfo info = form.DocInfo;

                switch (info.DocType)
                {
                    case DocumentType.Note:
                        templateName = resourcePath + "W_Notat.dotm";
                        doc = app.Documents.Add(ref templateName, ref missing, ref missing, ref missing);

                        doc.Bookmarks["Bdato"].Range.Text = "Dato:";
                        doc.Bookmarks["Bdato2"].Range.Text = info.Date.ToShortDateString();
                        doc.Bookmarks["Bfra"].Range.Text = "Fra:";
                        doc.Bookmarks["Bfra2"].Range.Text = info.From;
                        doc.Bookmarks["Breft"].Range.Text = "Ref.:";
                        doc.Bookmarks["Bref"].Range.Text = info.Ref;
                        doc.Bookmarks["Bsign"].Range.Text = info.From;
                        doc.Bookmarks["Btil"].Range.Text = "Til:";
                        doc.Bookmarks["Btil2"].Range.Text = info.To;
                        if (!String.IsNullOrEmpty(info.Copy1) || !String.IsNullOrEmpty(info.Copy2) || !String.IsNullOrEmpty(info.Copy3))
                            doc.Bookmarks["Bkop"].Range.Text = "Kopi:";
                        if (!String.IsNullOrEmpty(info.Copy1))
                            doc.Bookmarks["Bkopi1"].Range.Text = info.Copy1;
                        if (!String.IsNullOrEmpty(info.Copy2))
                            doc.Bookmarks["Bkopi2"].Range.Text = info.Copy2;
                        if (!String.IsNullOrEmpty(info.Copy3))
                            doc.Bookmarks["Bkopi3"].Range.Text = info.Copy3;
                        if (!String.IsNullOrEmpty(info.OffLov))
                        {
                            doc.Bookmarks["Buofft"].Range.Text = "U. off.:";
                            doc.Bookmarks["Buoff"].Range.Text = info.OffLov;
                        }
                        if (!String.IsNullOrEmpty(info.ForvLov))
                            doc.Bookmarks["Bforvl"].Range.Text = info.ForvLov;
                        doc.Bookmarks["Bover"].Range.Text = info.Heading;
                        doc.Bookmarks["Brød"].Range.Select();
                        break;

                    case DocumentType.Comment:
                        templateName = resourcePath + "W_Referat.dotm";
                        doc = app.Documents.Add(ref templateName, ref missing, ref missing, ref missing);

                        doc.Bookmarks["Bdato"].Range.Text = "Dato:";
                        doc.Bookmarks["Bdato2"].Range.Text = info.Date.ToShortDateString();
                        doc.Bookmarks["Bfra"].Range.Text = "Fra:";
                        doc.Bookmarks["Bfra2"].Range.Text = info.From;
                        doc.Bookmarks["Breft"].Range.Text = "Ref.:";
                        doc.Bookmarks["Bref"].Range.Text = info.Ref;
                        doc.Bookmarks["Bsign"].Range.Text = info.From;
                        doc.Bookmarks["Btil"].Range.Text = "Til:";
                        doc.Bookmarks["Btil2"].Range.Text = info.To;
                        if (!String.IsNullOrEmpty(info.Copy1) || !String.IsNullOrEmpty(info.Copy2) || !String.IsNullOrEmpty(info.Copy3))
                            doc.Bookmarks["Bkop"].Range.Text = "Kopi:";
                        if (!String.IsNullOrEmpty(info.Copy1))
                            doc.Bookmarks["Bkopi1"].Range.Text = info.Copy1;
                        if (!String.IsNullOrEmpty(info.Copy2))
                            doc.Bookmarks["Bkopi2"].Range.Text = info.Copy2;
                        if (!String.IsNullOrEmpty(info.Copy3))
                            doc.Bookmarks["Bkopi3"].Range.Text = info.Copy3;
                        if (!String.IsNullOrEmpty(info.OffLov))
                        {
                            doc.Bookmarks["Buofft"].Range.Text = "U. off.:";
                            doc.Bookmarks["Buoff"].Range.Text = (String.IsNullOrEmpty(info.ForvLov) ? info.OffLov : info.OffLov + " " + info.ForvLov);
                        }
                        doc.Bookmarks["Bover"].Range.Text = info.Heading;
                        doc.Bookmarks["Brød"].Range.Select();
                        break;

                    case DocumentType.InternalReport:
                        templateName = resourcePath + "W_IntRap.dotm";
                        doc = app.Documents.Add(ref templateName, ref missing, ref missing, ref missing);

                        doc.Bookmarks["Bdato"].Range.Text = "Dato:";
                        doc.Bookmarks["Bdato2"].Range.Text = info.Date.ToShortDateString();
                        doc.Bookmarks["Bfra"].Range.Text = "Fra:";
                        doc.Bookmarks["Bfra2"].Range.Text = info.From;
                        doc.Bookmarks["Breft"].Range.Text = "Ref.:";
                        doc.Bookmarks["Bref"].Range.Text = info.Ref;
                        if (!String.IsNullOrEmpty(info.OffLov))
                        {
                            doc.Bookmarks["Buofft"].Range.Text = "U. off.:";
                            doc.Bookmarks["Buoff"].Range.Text = (String.IsNullOrEmpty(info.ForvLov) ? info.OffLov : info.OffLov + " " + info.ForvLov);
                        }
                        doc.Bookmarks["Bover"].Range.Text = info.Heading;
                        doc.Bookmarks["Brød"].Range.Select();
                        break;

                    case DocumentType.Ledermote:
                        templateName = resourcePath + "W_Ledermote.dotm";
                        doc = app.Documents.Add(ref templateName, ref missing, ref missing, ref missing);

                        doc.Bookmarks["Bdato"].Range.Text = "Dato:";
                        doc.Bookmarks["Bdato2"].Range.Text = info.Date.ToShortDateString();
                        doc.Bookmarks["Bfra"].Range.Text = "Fra:";
                        doc.Bookmarks["Bfra2"].Range.Text = info.From;
                        doc.Bookmarks["Breft"].Range.Text = "Ref.:";
                        doc.Bookmarks["Bref"].Range.Text = info.Ref;
                        doc.Bookmarks["Bsign"].Range.Text = info.From;
                        doc.Bookmarks["Btil"].Range.Text = "Til:";
                        doc.Bookmarks["Btil2"].Range.Text = info.To;
                        if (!String.IsNullOrEmpty(info.Copy1) || !String.IsNullOrEmpty(info.Copy2) || !String.IsNullOrEmpty(info.Copy3))
                            doc.Bookmarks["Bkop"].Range.Text = "Kopi:";
                        if (!String.IsNullOrEmpty(info.Copy1))
                            doc.Bookmarks["Bkopi1"].Range.Text = info.Copy1;
                        if (!String.IsNullOrEmpty(info.Copy2))
                            doc.Bookmarks["Bkopi2"].Range.Text = info.Copy2;
                        if (!String.IsNullOrEmpty(info.Copy3))
                            doc.Bookmarks["Bkopi3"].Range.Text = info.Copy3;
                        if (!String.IsNullOrEmpty(info.OffLov))
                        {
                            doc.Bookmarks["Buofft"].Range.Text = "U. off.:";
                            doc.Bookmarks["Buoff"].Range.Text = (String.IsNullOrEmpty(info.ForvLov) ? info.OffLov : info.OffLov + " " + info.ForvLov);
                        }
                        doc.Bookmarks["Bover"].Range.Text = info.Heading;
                        doc.Bookmarks["Brød"].Range.Select();
                        break;

                    case DocumentType.Telefax:
                        templateName = resourcePath + "W_Telefax.dotm";
                        doc = app.Documents.Add(ref templateName, ref missing, ref missing, ref missing);

                        doc.Bookmarks["Bdato2"].Range.Text = info.Date.ToShortDateString();
                        doc.Bookmarks["Bfra"].Range.Text = info.From;
                        doc.Bookmarks["Btel"].Range.Text = info.Phone;
                        doc.Bookmarks["Bffax"].Range.Text = info.FromFax;
                        doc.Bookmarks["Bsign"].Range.Text = info.From;
                        doc.Bookmarks["Btil"].Range.Text = info.Copy1;
                        doc.Bookmarks["Btil1"].Range.Text = info.Copy2;
                        doc.Bookmarks["Btil2"].Range.Text = info.Copy3;
                        doc.Bookmarks["Btfax"].Range.Text = info.ToFax;
                        doc.Bookmarks["Bpagno"].Range.Text = info.NumberOfPages.ToString();
                        doc.Bookmarks["Bover"].Range.Text = info.Heading;
                        doc.Bookmarks["Brød"].Range.Select();
                        break;

                    case DocumentType.Press:
                        templateName = resourcePath + "W_Press.dotm";
                        doc = app.Documents.Add(ref templateName, ref missing, ref missing, ref missing);

                        doc.Bookmarks["Bdato"].Range.Text = "Dato:";
                        doc.Bookmarks["Bdato2"].Range.Text = info.Date.ToShortDateString();
                        doc.Bookmarks["B_Saksnr"].Range.Text = info.ReferenceNumber;
                        doc.Bookmarks["B_KontaktTekst"].Range.Text = "Kontaktpersoner:";
                        doc.Bookmarks["B_Kontakt1"].Range.Text = info.Copy1;
                        doc.Bookmarks["B_Kontakt2"].Range.Text = info.Copy2;
                        doc.Bookmarks["Bover"].Range.Text = info.Heading;
                        doc.Bookmarks["Brød"].Range.Select();
                        break;

                    case DocumentType.Accident:
                        templateName = resourcePath + "W_Uhell.dotm";
                        doc = app.Documents.Add(ref templateName, ref missing, ref missing, ref missing);

                        doc.Bookmarks["Bdato"].Range.Text = "Dato:";
                        doc.Bookmarks["Bdato2"].Range.Text = info.Date.ToShortDateString();
                        doc.Bookmarks["Bfra"].Range.Text = "Fra:";
                        doc.Bookmarks["Bfra2"].Range.Text = info.From;
                        doc.Bookmarks["Bsign"].Range.Text = info.From;
                        doc.Bookmarks["Btil"].Range.Text = "Til:";
                        doc.Bookmarks["Btil2"].Range.Text = info.To;
                        if (!String.IsNullOrEmpty(info.Copy1))
                        {
                            doc.Bookmarks["Bkop"].Range.Text = "Kopi:";
                            doc.Bookmarks["Bkopi1"].Range.Text = info.Copy1;
                        }
                        if (!String.IsNullOrEmpty(info.AccidentType))
                        {
                            doc.Bookmarks["Breft"].Range.Text = "Type:";
                            doc.Bookmarks["Bref"].Range.Text = info.AccidentType;
                        }
                        if (!String.IsNullOrEmpty(info.OffLov))
                        {
                            doc.Bookmarks["Buofft"].Range.Text = "U. off.:";
                            doc.Bookmarks["Buoff"].Range.Text = (String.IsNullOrEmpty(info.ForvLov) ? info.OffLov : info.OffLov + " " + info.ForvLov);
                        }
                        doc.Bookmarks["Bover"].Range.Text = info.Heading;
                        doc.Bookmarks["Brød"].Range.Select();
                        break;

                    case DocumentType.DecisionNote:
                        templateName = resourcePath + "W_BNotat.dotm";
                        doc = app.Documents.Add(ref templateName, ref missing, ref missing, ref missing);

                        doc.Bookmarks["Bdato"].Range.Text = "Dato:";
                        doc.Bookmarks["Bdato2"].Range.Text = info.Date.ToShortDateString();
                        doc.Bookmarks["Bfra"].Range.Text = "Fra:";
                        doc.Bookmarks["Bfra2"].Range.Text = info.From;
                        doc.Bookmarks["Breft"].Range.Text = "Ref.:";
                        doc.Bookmarks["Bref"].Range.Text = info.Ref;
                        doc.Bookmarks["Bsign"].Range.Text = info.From;
                        doc.Bookmarks["Btil"].Range.Text = "Til:";
                        doc.Bookmarks["Btil2"].Range.Text = info.To;
                        if (!String.IsNullOrEmpty(info.Copy1) || !String.IsNullOrEmpty(info.Copy2) || !String.IsNullOrEmpty(info.Copy3))
                            doc.Bookmarks["Bkop"].Range.Text = "Kopi:";
                        if (!String.IsNullOrEmpty(info.Copy1))
                            doc.Bookmarks["Bkopi1"].Range.Text = info.Copy1;
                        if (!String.IsNullOrEmpty(info.Copy2))
                            doc.Bookmarks["Bkopi2"].Range.Text = info.Copy2;
                        if (!String.IsNullOrEmpty(info.Copy3))
                            doc.Bookmarks["Bkopi3"].Range.Text = info.Copy3;
                        if (!String.IsNullOrEmpty(info.OffLov))
                        {
                            doc.Bookmarks["Buofft"].Range.Text = "U. off.:";
                            doc.Bookmarks["Buoff"].Range.Text = info.OffLov;
                        }
                        if (!String.IsNullOrEmpty(info.ForvLov))
                            doc.Bookmarks["Bforvl"].Range.Text = info.ForvLov;
                        doc.Bookmarks["Bover"].Range.Text = info.Heading;
                        doc.Bookmarks["Brød"].Range.Select();
                        break;

                    default:
                        MessageBox.Show("Ukjent dokument type", "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                if (doc != null)
                    doc.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
                string msg = "Noe har gått galt ved oppretting av dokument. Feil: " + ex.Message;
                MessageBox.Show(msg, "Feil");
            }
        }

        private void btnLetterTemplate_Click(object sender, RibbonControlEventArgs e)
        {
            // BREVMAL

            Word.Application app = null;
            Word._Document doc = null;
            object missing = System.Reflection.Missing.Value;

            try
            {                
                FormBrevMal form = new FormBrevMal();
                DialogResult result = form.ShowDialog();
                if (result != DialogResult.OK)
                    return;
                
                app = Globals.ThisAddIn.Application;                
                object templateName = resourcePath + "W_Brev.dotm";
                LetterInfo info = form.LetterInfo;

                doc = app.Documents.Add(ref templateName, ref missing, ref missing, ref missing);                

                string txt_their_ref = "Deres ref.",
                    txt_our_ref = "Vår ref.",
                    txt_case_handler = "Saksbeh.",
                    txt_our_date = "Vår dato",
                    txt_regards = "Vennlig hilsen",
                    txt_attachment = "Vedlegg: ",
                    txt_copy = "Kopi: ",
                    //our_date = DateTime.Now.ToString("d", Utils.ciNB),
                    our_date = DateTime.Now.ToString("yyyy-MM-dd"),
                    signature_title = info.signature.title;

                switch(info.DocumentLanguage.ToLower().Trim())
                {
                    case "english":
                        txt_their_ref = "Your ref.";
                        txt_our_ref = "Our ref.";
                        txt_case_handler = "Inquiries";
                        txt_our_date = "Our date";
                        txt_regards = "Yours sincerely";
                        txt_attachment = "Encl.: ";
                        txt_copy = "Copy: ";
                        //our_date = DateTime.Now.ToString("d", Utils.ciEN);
                        our_date = DateTime.Now.ToString("yyyy-MM-dd");
                        signature_title = info.signature.title_english;
                        break;
                    case "norsk - nynorsk":
                        txt_their_ref = "Dykkar ref.";                                                                        
                        txt_regards = "Med helsing";                        
                        break;                    
                }                               

                doc.Bookmarks["Adresselinje_1"].Range.Text = info.Address[0];
                doc.Bookmarks["Adresselinje_2"].Range.Text = info.Address[1];
                doc.Bookmarks["Adresselinje_3"].Range.Text = info.Address[2];
                doc.Bookmarks["Adresselinje_4"].Range.Text = info.Address[3];
                doc.Bookmarks["Adresselinje_5"].Range.Text = info.Address[4];
                doc.Bookmarks["Overskriften"].Range.Text = info.Heading;
                doc.Bookmarks["TEXT_Deres_referanse"].Range.Text = txt_their_ref;
                doc.Bookmarks["Deres_referanse"].Range.Text = info.TheirReference;
                doc.Bookmarks["TEXT_Vår_referanse"].Range.Text = txt_our_ref;
                doc.Bookmarks["Vår_referanse"].Range.Text = info.OurReference + "/" + info.CaseHandlerInitials;
                if (info.uoff)
                {
                    doc.Bookmarks["Gradering"].Range.Text = "U.off.:";
                    doc.Bookmarks["Hjemmel1"].Range.Text = info.UOff;
                    doc.Bookmarks["Hjemmel2"].Range.Text = info.Forv;
                }
                doc.Bookmarks["TEXT_Vår_saksbehandler"].Range.Text = txt_case_handler;
                doc.Bookmarks["Vår_saksbehandler"].Range.Text = info.CaseHandler + " tlf. " + info.CaseHandlerPhone;
                doc.Bookmarks["TEXT_Vår_dato"].Range.Text = txt_our_date;
                doc.Bookmarks["Vår_dato"].Range.Text = our_date;
                doc.Bookmarks["Parafist_navn"].Range.Text = info.CounterSignature;
                doc.Bookmarks["Parafist_tittel"].Range.Text = info.CounterSignatureTitle;                
                doc.Bookmarks["Underskrivers_navn"].Range.Text = info.signature.name;
                doc.Bookmarks["Underskrivers_tittel"].Range.Text = signature_title;
                doc.Bookmarks["Hilsen"].Range.Text = txt_regards;
                if (info.copy)
                    doc.Bookmarks["Kopi_til"].Range.Text = txt_copy + info.Copies;
                if (info.attachment)
                    doc.Bookmarks["Vedlegg"].Range.Text = txt_attachment + info.Attachments;

                doc.Bookmarks["Brødteksten"].Range.Select();
            }
            catch (Exception ex)
            {
                if(doc != null)                
                    doc.Close(Word.WdSaveOptions.wdDoNotSaveChanges);                
                string msg = "Noe har gått galt ved oppretting av dokument. Feil: " + ex.Message;
                MessageBox.Show(msg, "Feil");
            }
        }
    }
}
