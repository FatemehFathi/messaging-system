using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraduateApplication
{
    public class Task
    {
        DatabaseTask dbTask = new DatabaseTask();
        DatabasePerson dbPerson = new DatabasePerson();
        DatabaseGroup dbGroup = new DatabaseGroup();

        public Task() { }
        public Task(string subj, string cont)
        {
            receivers = "";
            subject = subj;
            content = cont;
            attachments = new Attachment();
            time = "";
            need_verification = true;
            verified = false;
            task_persons = new List<Person>();
            task_groups = new List<string>();
            sent = false;
            repeat = "";
        }


        //methods:
        public List<string> find_rec()
        {

            List<string> rec = new List<string>();
            string[] words = receivers.Split(';');
            foreach (string word in words)
            {
                if (word != " " && word != "")
                {
                    if (word.Contains("<") && word.Contains(">")) //Person
                    {
                        int i1 = word.IndexOf("<");
                        int i2 = word.IndexOf(">");

                        string email = word.Substring(i1 + 1, i2 - i1 - 1);
                        rec.Add(email);
                    }
                    else if (word.Contains("@") && word.Contains(".")) //Email
                    {
                        int i1 = -1;
                        i1 = word.IndexOf(" ");
                        string s = word;
                        if (i1 != -1)
                        {
                            s = word.Substring(i1 + 1, word.Length - i1 - 1);
                        }
                        rec.Add(s);
                    }
                    else //Group
                    {
                        int i1 = -1;
                        i1 = word.IndexOf(" ");
                        string s = word;
                        if (i1 != -1)
                        {
                            s = word.Substring(i1 + 1, word.Length - i1 - 1);
                        }

                        UserGroup ug = new UserGroup("#notSet#");
                        ug = dbGroup.findGroup(s);
                        List<string> g_rec = new List<string>();
                        g_rec = group_receivers(ug);

                        for (int j = 0; j < g_rec.Count; j++)
                        {
                            rec.Add(g_rec[j]);
                        }
                    }
                }

            }

            List<string> rec_distinct = new List<string>();
            for (int i = 0; i < rec.Count; i++)
            {
                bool is_exist = false;
                for (int j = 0; j < rec_distinct.Count; j++)
                {
                    if (rec[i] == rec_distinct[j]) is_exist = true;
                }

                if (is_exist == false) rec_distinct.Add(rec[i]);
            }

            return rec_distinct;
        }
        public List<string> group_receivers(UserGroup g)
        {
            List<string> rec = new List<string>();

            for (int i = 0; i < g.get_group_users().Count; i++)
            {
                rec.Add(g.get_group_users()[i].get_person_email());
            }

            for (int i = 0; i < g.get_group_groups().Count; i++)
            {
                UserGroup ug = dbGroup.findGroup(g.get_group_groups()[i]);
                List<string> g_rec = new List<string>();
                g_rec = group_receivers(ug);

                for (int j = 0; j < g_rec.Count; j++)
                {
                    rec.Add(g_rec[j]);
                }
            }

            return rec;
        }
        public bool check_duplicate(Task t)
        {
            List<Task> tasks = new List<Task>();
            tasks = dbTask.loadTasks();

            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].get_subject() == t.get_subject())
                {
                    if (tasks[i].get_content() == t.get_content())
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        

        //DAO:
        public void addTask(Task t)
        {
            dbTask.addTask(t);
        }
        public void editTask(Task task1, Task task2)
        {
            dbTask.editTask(task1, task2);
        }
        public List<Task> loadTasks()
        {
            return dbTask.loadTasks();
        }
        public Task findTask(string subj, string cont)
        {
            return dbTask.findTask(subj, cont);
        }
        public void deleteTask(string subj, string cont)
        {
            dbTask.deleteTask(subj, cont);
        }
        public void sentTask(string subj, string cont)
        {
            dbTask.sentTask(subj, cont);
        }


        //setters:
        public void set_receivers(string r) { receivers = r; }
        public void set_content(string c) { content = c; }
        public void set_subject(string s) { subject = s; }
        public void set_time(string t) { time = t; }
        public void set_need_verification(bool nv) { need_verification = nv; }
        public void set_verified(bool v) { verified = v; }
        public void add_task_persons(Person p) { task_persons.Add(p); }
        public void add_task_groups(string g) { task_groups.Add(g); }
        public void set_pk(int p) { pk = p; }
        public void set_attachments(Attachment a)
        {
            attachments = a;
        }
        public void set_updated(string s, string c, bool nv, bool v, string dt, string r)
        {
            subject = s;
            content = c;
            need_verification = nv;
            verified = v;
            time = dt;
            receivers = r;
        }
        public void set_sent(bool s) { sent = s; }
        public void set_repeat(string r) { repeat = r; }


        //getters:
        public string get_receivers() { return receivers; }
        public string get_content() { return content; }
        public string get_subject() { return subject; }
        public Attachment get_attachments() { return attachments; }
        public string get_time() { return time; }
        public bool get_need_verification() { return need_verification; }
        public bool get_verified() { return verified; }
        public List<Person> get_task_persons() { return task_persons; }
        public List<string> get_task_groups() { return task_groups; }
        public int get_pk() { return pk; }
        public bool get_sent() { return sent; }
        public string get_repeat() { return repeat; }


        //fields:
        string receivers;
        string content;
        string subject;
        Attachment attachments;
        string time;
        bool need_verification;
        bool verified;
        List<Person> task_persons;
        List<string> task_groups;
        int pk;
        bool sent;
        string repeat;
    }
}
