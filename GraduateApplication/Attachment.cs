using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraduateApplication
{
    public class Attachment
    {
        public Attachment()
        {
            attach1 = "No file selected";
            attach2 = "No file selected";
            attach3 = "No file selected";
            attach4 = "No file selected";
            attach5 = "No file selected";
        }


        //setters:
        public void set_attachs(string a1, string a2 = "No file selected", string a3 = "No file selected", string a4 = "No file selected", string a5 = "No file selected")
        {
            attach1 = (a1 != "") ? a1 : "No file selected";
            attach2 = (a2 != "") ? a2 : "No file selected";
            attach3 = (a3 != "") ? a3 : "No file selected";
            attach4 = (a4 != "") ? a4 : "No file selected";
            attach5 = (a5 != "") ? a5 : "No file selected";
        }


        //getters:
        public string get_attach1() { return attach1; }
        public string get_attach2() { return attach2; }
        public string get_attach3() { return attach3; }
        public string get_attach4() { return attach4; }
        public string get_attach5() { return attach5; }


        //fields:
        string attach1;
        string attach2;
        string attach3;
        string attach4;
        string attach5;
    }
}