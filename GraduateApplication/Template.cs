using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraduateApplication
{
    public class Template
    {
        DatabaseTemplate dbTemplate = new DatabaseTemplate();
        public Template(string n, string s = "", string c = "")
        {
            name = n;
            subject = s;
            content = c;
        }


        //DAO:
        public void addTemplate(Template t)
        {
            dbTemplate.addTemplate(t);
        }
        public void editTemplate(Template t1, Template t2)
        {
            dbTemplate.editTemplate(t1, t2);
        }
        public List<Template> loadTemplates()
        {
            return dbTemplate.loadTemplates();
        }
        public Template findTemplate(string n)
        {
            return dbTemplate.findTemplate(n);
        }
        public void deleteTemplate(string n)
        {
            dbTemplate.deleteTemplate(n);
        }


        //setters:
        public void set_name(string n) { name = n; }
        public void set_subject(string s) { subject = s; }
        public void set_content(string c) { content = c; }
        public void set_id(int id) { template_id = id; }
        public void set_updated(string n, string s, string c) 
        {
            name = n;
            subject = s;
            content = c;
        }


        //getters:
        public string get_name() { return name; }
        public string get_content() { return content; }
        public string get_subject() { return subject; }
        public int get_id() { return template_id; }


        //fields:
        string name;
        string content;
        string subject;
        int template_id;
    }
}
