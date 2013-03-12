using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Configuration;
using System.IO;

namespace NRPA
{
    public enum DocumentType 
    { 
        Note, 
        Comment,
        InternalReport,
        Ledermote,
        Telefax,
        Press,
        Accident,
        DecisionNote
    }

    public struct DocumentInfo
    {
        public DocumentType DocType;
        public string From, To, Copy1, Copy2, Copy3, Ref, Heading, OffLov, ForvLov;
        public int NumberOfPages;
        public string FromFax, ToFax, Phone, ReferenceNumber, AccidentType;
        public DateTime Date;        
    }

    public class Contact
    {
        public string name, initials, phone, title, title_english, default_language;
    }

    public class LetterInfo
    {
        public string[] Address = new string[5];
        public string OurReference, TheirReference, CaseHandler, CaseHandlerInitials, CaseHandlerPhone;
        public string DocumentLanguage, Heading, CounterSignature, CounterSignatureTitle;
        public string Attachments, Copies, UOff, Forv;
        public Contact signature = new Contact();
        public bool attachment, copy, uoff;
    }

    static public class Utils
    {
        public static CultureInfo ciEN = new CultureInfo("en-GB");
        public static CultureInfo ciNB = new CultureInfo("nb-NO");
        public static CultureInfo ciNN = new CultureInfo("nn-NO");
        public static string ResourcePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NRPA-Maler2010\\";
        public static string SharedResourcePath = ConfigurationManager.AppSettings["ResourcePath"];
        public static string WordInfoFile = ".nrpa-word-info.txt";

        public static FormContact formContact = new FormContact();
        public static FormOffForv formOffForv = new FormOffForv();        
    }
}
