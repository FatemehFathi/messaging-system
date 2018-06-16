using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace GraduateApplication
{
    public class DatabaseTask
    {
        private SQLiteConnection sqliteConnecetion;
        private SqliteDataBase db;
        
        public DatabaseTask() {
            db = SqliteDataBase.getDataBase();
            sqliteConnecetion = db.getSqliteConnecetion();
        }


        public void addTask(Task t)
        {
            int taskId1, groupId1, personId1;

            int nv, v, s;
            if (t.get_need_verification() == false) nv = 0; else nv = 1;
            if (t.get_verified() == false) v = 0; else v = 1;
            if (t.get_sent() == false) s = 0; else s = 1;

            SQLiteCommand insert_taskTable = new SQLiteCommand("INSERT INTO TaskTable(Receivers, Subject, Content, NeedVerification, Verify, Date, Sent, Repeat) VALUES ('" + t.get_receivers() + "','" + t.get_subject() + "','" + t.get_content() + "','" + nv + "','" + v + "','" + t.get_time() + "','" + s + "','" + t.get_repeat() + "');", sqliteConnecetion);
            insert_taskTable.ExecuteNonQuery();

            SQLiteCommand find_taskId = new SQLiteCommand("SELECT TaskId FROM TaskTable WHERE Subject = '" + t.get_subject() + "' AND Content = '" + t.get_content() + "'", sqliteConnecetion);
            SQLiteDataReader reader = find_taskId.ExecuteReader();

            System.Int64 tId1 = (System.Int64)reader["TaskId"];
            taskId1 = (int)tId1;


            for (int i = 0; i < t.get_task_persons().Count; i++)
            {
                SQLiteCommand find_personId = new SQLiteCommand("SELECT PersonId FROM PersonTable WHERE Name = '" + t.get_task_persons()[i].get_person_name() + "'", sqliteConnecetion);
                reader = find_personId.ExecuteReader();

                System.Int64 pId1 = (System.Int64)reader["PersonId"];
                personId1 = (int)pId1;

                SQLiteCommand insert_taskPersonTable = new SQLiteCommand("INSERT INTO TaskPersonTable(TaskId1, PersonId1) VALUES ('" + taskId1 + "','" + personId1 + "');", sqliteConnecetion);
                insert_taskPersonTable.ExecuteNonQuery();
            }


            for (int i = 0; i < t.get_task_groups().Count; i++)
            {
                SQLiteCommand find_groupId = new SQLiteCommand("SELECT GroupId FROM GroupTable WHERE Name = '" + t.get_task_groups()[i] + "'", sqliteConnecetion);
                reader = find_groupId.ExecuteReader();

                System.Int64 gId1 = (System.Int64)reader["GroupId"];
                groupId1 = (int)gId1;

                SQLiteCommand insert_taskGroupTable = new SQLiteCommand("INSERT INTO TaskGroupTable(TaskId1, GroupId1) VALUES ('" + taskId1 + "','" + groupId1 + "');", sqliteConnecetion);
                insert_taskGroupTable.ExecuteNonQuery();
            }


            Attachment att = new Attachment();
            att = t.get_attachments();
            if (att.get_attach1() != "No file selected")
            {
                SQLiteCommand insert_taskAttachmentTable = new SQLiteCommand("INSERT INTO TaskAttachmentTable(TaskId1, Attachment) VALUES ('" + taskId1 + "','" + att.get_attach1() + "');", sqliteConnecetion);
                insert_taskAttachmentTable.ExecuteNonQuery();
            }
            if (att.get_attach2() != "No file selected")
            {
                SQLiteCommand insert_taskAttachmentTable = new SQLiteCommand("INSERT INTO TaskAttachmentTable(TaskId1, Attachment) VALUES ('" + taskId1 + "','" + att.get_attach2() + "');", sqliteConnecetion);
                insert_taskAttachmentTable.ExecuteNonQuery();
            }
            if (att.get_attach3() != "No file selected")
            {
                SQLiteCommand insert_taskAttachmentTable = new SQLiteCommand("INSERT INTO TaskAttachmentTable(TaskId1, Attachment) VALUES ('" + taskId1 + "','" + att.get_attach3() + "');", sqliteConnecetion);
                insert_taskAttachmentTable.ExecuteNonQuery();
            }
            if (att.get_attach4() != "No file selected")
            {
                SQLiteCommand insert_taskAttachmentTable = new SQLiteCommand("INSERT INTO TaskAttachmentTable(TaskId1, Attachment) VALUES ('" + taskId1 + "','" + att.get_attach4() + "');", sqliteConnecetion);
                insert_taskAttachmentTable.ExecuteNonQuery();
            }
            if (att.get_attach5() != "No file selected")
            {
                SQLiteCommand insert_taskAttachmentTable = new SQLiteCommand("INSERT INTO TaskAttachmentTable(TaskId1, Attachment) VALUES ('" + taskId1 + "','" + att.get_attach5() + "');", sqliteConnecetion);
                insert_taskAttachmentTable.ExecuteNonQuery();
            }

        }


        public List<Task> loadTasks()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM TaskTable", sqliteConnecetion);
            SQLiteDataReader reader = cmd.ExecuteReader();

            string subject;
            string content;
            List<Task> tasks = new List<Task>();

            while (reader.Read())
            {
                System.Int64 tId1 = (System.Int64)reader["TaskId"];
                int taskId1 = (int)tId1;

                subject = (string)reader["Subject"];
                content = (string)reader["Content"];

                Task t = new Task(subject, content);

                t.set_receivers((string)reader["Receivers"]);
                t.set_time((string)reader["Date"]);
                t.set_repeat((string)reader["Repeat"]);

                System.Int64 nv = (System.Int64)reader["NeedVerification"];
                int needV = (int)nv;

                System.Int64 v = (System.Int64)reader["Verify"];
                int V = (int)v;

                System.Int64 s = (System.Int64)reader["Sent"];
                int S = (int)s;

                if (needV == 0) t.set_need_verification(false); else t.set_need_verification(true);
                if (V == 0) t.set_verified(false); else t.set_verified(true);
                if (S == 0) t.set_sent(false); else t.set_sent(true);


                SQLiteCommand find_attachments = new SQLiteCommand("SELECT Attachment FROM TaskAttachmentTable WHERE TaskId1 = " + taskId1, sqliteConnecetion);
                reader = find_attachments.ExecuteReader();

                List<string> atts = new List<string>();
                while (reader.Read())
                {
                    string att = (string)reader["Attachment"];
                    atts.Add(att);
                }

                Attachment attachment = new Attachment();
                if (atts.Count == 1) attachment.set_attachs(atts[0]);
                else if (atts.Count == 2) attachment.set_attachs(atts[0], atts[1]);
                else if (atts.Count == 3) attachment.set_attachs(atts[0], atts[1], atts[2]);
                else if (atts.Count == 4) attachment.set_attachs(atts[0], atts[1], atts[2], atts[3]);
                else if (atts.Count == 5) attachment.set_attachs(atts[0], atts[1], atts[2], atts[3], atts[4]);

                t.set_attachments(attachment);

                tasks.Add(t);
            }

            return tasks;
        }


        public Task findTask(string subj, string cont)
        {
            Task t = new Task(subj, cont);
            int taskId1 = 0;

            SQLiteCommand find_taskId = new SQLiteCommand("SELECT TaskId, Receivers, NeedVerification, Verify, Date, Sent, Repeat FROM TaskTable WHERE Subject = '" + subj + "' AND Content = '" + cont + "'", sqliteConnecetion);
            SQLiteDataReader reader = find_taskId.ExecuteReader();

            while (reader.Read())
            {
                System.Int64 tId1 = (System.Int64)reader["TaskId"];
                taskId1 = (int)tId1;

                t.set_receivers((string)reader["Receivers"]);

                System.Int64 nv = (System.Int64)reader["NeedVerification"];
                int needV = (int)nv;

                System.Int64 v = (System.Int64)reader["Verify"];
                int V = (int)v;

                System.Int64 s = (System.Int64)reader["Sent"];
                int S = (int)s;

                t.set_time((string)reader["Date"]);

                t.set_repeat((string)reader["Repeat"]);

                if (needV == 0) t.set_need_verification(false); else t.set_need_verification(true);
                if (V == 0) t.set_verified(false); else t.set_verified(true);
                if (S == 0) t.set_sent(false); else t.set_sent(true);
            }

            ////////////////////////////////////////////////////////////////////////////////////////////

            SQLiteCommand find_personsId = new SQLiteCommand("SELECT PersonId1 FROM TaskPersonTable WHERE TaskId1 = " + taskId1, sqliteConnecetion);
            reader = find_personsId.ExecuteReader();

            List<int> personsId1 = new List<int>();
            while (reader.Read())
            {
                System.Int64 pId1 = (System.Int64)reader["PersonId1"];
                personsId1.Add((int)pId1);
            }


            for (int i = 0; i < personsId1.Count; i++)
            {
                SQLiteCommand find_persons = new SQLiteCommand("SELECT Name, Email FROM PersonTable WHERE PersonId = " + personsId1[i], sqliteConnecetion);
                reader = find_persons.ExecuteReader();

                string name = (string)reader["Name"];
                string email = (string)reader["Email"];
                Person p = new Person(name, email);

                t.add_task_persons(p);
            }

            ////////////////////////////////////////////////////////////////////////////////////////////

            SQLiteCommand find_groupsId = new SQLiteCommand("SELECT GroupId1 FROM TaskGroupTable WHERE GroupId1 = " + taskId1, sqliteConnecetion);
            reader = find_groupsId.ExecuteReader();

            List<int> groupsId1 = new List<int>();
            while (reader.Read())
            {
                System.Int64 gId1 = (System.Int64)reader["GroupId1"];
                groupsId1.Add((int)gId1);
            }


            for (int i = 0; i < groupsId1.Count; i++)
            {
                SQLiteCommand find_groups = new SQLiteCommand("SELECT Name FROM GroupTable WHERE GroupId = " + groupsId1[i], sqliteConnecetion);
                reader = find_groups.ExecuteReader();

                string name = (string)reader["Name"];

                t.add_task_groups(name);
            }

            ////////////////////////////////////////////////////////////////////////////////////////////

            SQLiteCommand find_attachments = new SQLiteCommand("SELECT * FROM TaskAttachmentTable WHERE TaskId1 = " + taskId1, sqliteConnecetion);
            reader = find_attachments.ExecuteReader();

            List<string> atts = new List<string>();
            while (reader.Read())
            {
                string att = (string)reader["Attachment"];
                atts.Add(att);
            }

            Attachment attachment = new Attachment();
            if (atts.Count == 1) attachment.set_attachs(atts[0]);
            else if (atts.Count == 2) attachment.set_attachs(atts[0], atts[1]);
            else if (atts.Count == 3) attachment.set_attachs(atts[0], atts[1], atts[2]);
            else if (atts.Count == 4) attachment.set_attachs(atts[0], atts[1], atts[2], atts[3]);
            else if (atts.Count == 5) attachment.set_attachs(atts[0], atts[1], atts[2], atts[3], atts[4]);

            t.set_attachments(attachment);

            ////////////////////////////////////////////////////////////////////////////////////////////

            t.set_pk(taskId1);

            return t;
        }


        public void editTask(Task t1, Task t2)
        {
            int tId = t1.get_pk();

            //SQLiteCommand updateSQL1 = new SQLiteCommand("UPDATE TaskTable SET Subject = '" + t2.get_subject() + "' AND Content = '" + t2.get_content() + "' AND Receivers = '" + t2.get_receivers() + "' AND NeedVerification = '" + t2.get_need_verification() + "' AND Verify = '" + t2.get_verified() + "' WHERE TaskId = " + tId, sqliteConnecetion);
            //updateSQL1.ExecuteNonQuery();

            SQLiteCommand deleteSQL0 = new SQLiteCommand("DELETE FROM TaskTable WHERE TaskId = " + tId, sqliteConnecetion);
            deleteSQL0.ExecuteNonQuery();

            SQLiteCommand deleteSQL1 = new SQLiteCommand("DELETE FROM TaskPersonTable WHERE TaskId1 = " + tId, sqliteConnecetion);
            deleteSQL1.ExecuteNonQuery();

            SQLiteCommand deleteSQL2 = new SQLiteCommand("DELETE FROM TaskGroupTable WHERE TaskId1 = " + tId, sqliteConnecetion);
            deleteSQL2.ExecuteNonQuery();

            SQLiteCommand deleteSQL3 = new SQLiteCommand("DELETE FROM TaskAttachmentTable WHERE TaskId1 = " + tId, sqliteConnecetion);
            deleteSQL2.ExecuteNonQuery();

            addTask(t2);

            /*
            for (int i = 0; i < t2.get_task_persons().Count; i++)
            {
                SQLiteCommand find_personId = new SQLiteCommand("SELECT PersonId FROM PersonTable WHERE Name = '" + t2.get_task_persons()[i].get_person_name() + "'", sqliteConnecetion);
                SQLiteDataReader reader = find_personId.ExecuteReader();

                System.Int64 pId1 = (System.Int64)reader["PersonId"];
                int personId1 = (int)pId1;

                SQLiteCommand insert_taskPersonTable = new SQLiteCommand("INSERT INTO TaskPersonTable(TaskId1, PersonId1) VALUES ('" + tId + "','" + personId1 + "');", sqliteConnecetion);
                insert_taskPersonTable.ExecuteNonQuery();
            }


            for (int i = 0; i < t2.get_task_groups().Count; i++)
            {
                SQLiteCommand find_groupId = new SQLiteCommand("SELECT GroupId FROM GroupTable WHERE Name = '" + t2.get_task_groups()[i] + "'", sqliteConnecetion);
                SQLiteDataReader reader = find_groupId.ExecuteReader();

                System.Int64 gId1 = (System.Int64)reader["GroupId"];
                int groupId1 = (int)gId1;

                SQLiteCommand insert_taskGroupTable = new SQLiteCommand("INSERT INTO TaskGroupTable(TaskId1, GroupId1) VALUES ('" + tId + "','" + groupId1 + "');", sqliteConnecetion);
                insert_taskGroupTable.ExecuteNonQuery();
            }
            */
        }


        public void deleteTask(string subj, string cont)
        {
            SQLiteCommand deleteSQL = new SQLiteCommand("DELETE FROM TaskTable WHERE Subject = '" + subj + "' AND Content = '" + cont + "'", sqliteConnecetion);
            deleteSQL.ExecuteNonQuery();
        }


        public void sentTask(string subj, string cont)
        {
            SQLiteCommand find_taskId = new SQLiteCommand("SELECT TaskId FROM TaskTable WHERE Subject = '" + subj + "' AND Content = '" + cont + "'", sqliteConnecetion);
            SQLiteDataReader reader = find_taskId.ExecuteReader();

            System.Int64 tId = (System.Int64)reader["TaskId"];
            int taskId = (int)tId;

            SQLiteCommand updateSQL = new SQLiteCommand("UPDATE TaskTable SET Sent = '" + 1 + "' WHERE TaskId = " + taskId, sqliteConnecetion);
            updateSQL.ExecuteNonQuery();
        }

    }
}
