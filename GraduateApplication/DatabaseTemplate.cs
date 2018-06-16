using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace GraduateApplication
{
    public class DatabaseTemplate
    {
        private SQLiteConnection sqliteConnecetion;
        private SqliteDataBase db;
        
        public DatabaseTemplate() {
            db = SqliteDataBase.getDataBase();
            sqliteConnecetion = db.getSqliteConnecetion();
        }


        public void addTemplate(Template t)
        {
            SQLiteCommand insert_templateTable = new SQLiteCommand("INSERT INTO TemplateTable(Name, Subject, Content) VALUES ('" + t.get_name() + "','" + t.get_subject() + "','" + t.get_content() + "');", sqliteConnecetion);
            insert_templateTable.ExecuteNonQuery();
        }


        public List<Template> loadTemplates()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM TemplateTable", sqliteConnecetion);
            SQLiteDataReader reader = cmd.ExecuteReader();

            string name;
            string subject;
            string content;
            List<Template> templates = new List<Template>();

            while (reader.Read())
            {
                name = (string)reader["Name"];
                subject = (string)reader["Subject"];
                content = (string)reader["Content"];
                System.Int64 tId = (System.Int64)reader["TemplateId"];

                Template t = new Template(name);
                t.set_subject(subject);
                t.set_content(content);
                t.set_id((int)tId);

                templates.Add(t);
            }
            return templates;
        }


        public Template findTemplate(string name)
        {
            Template t = new Template(name);

            SQLiteCommand find_template = new SQLiteCommand("SELECT * FROM TemplateTable WHERE Name = '" + name + "'", sqliteConnecetion);
            SQLiteDataReader reader = find_template.ExecuteReader();

            while (reader.Read())
            {
                string subject = (string)reader["Subject"]; Console.WriteLine("mmmmmmmmmmm..." + subject);
                string content = (string)reader["Content"]; Console.WriteLine("ssssssssss..." + content);
                t.set_subject(subject);
                t.set_content(content);
                System.Int64 tId = (System.Int64)reader["TemplateId"];
                t.set_id((int)tId);
            }

            return t;
        }


        public void editTemplate(Template t1, Template t2)
        {
            SQLiteCommand find_templateId = new SQLiteCommand("SELECT TemplateId FROM TemplateTable WHERE Name = '" + t1.get_name() + "'", sqliteConnecetion);
            SQLiteDataReader reader = find_templateId.ExecuteReader();

            System.Int64 tId = (System.Int64)reader["TemplateId"];
            int templateId = (int)tId;


            SQLiteCommand updateNameSQL = new SQLiteCommand("UPDATE TemplateTable SET Name = '" + t2.get_name() + "' WHERE TemplateId = " + templateId, sqliteConnecetion);
            updateNameSQL.ExecuteNonQuery();

            SQLiteCommand updateSubjSQL = new SQLiteCommand("UPDATE TemplateTable SET Subject = '" + t2.get_subject() + "' WHERE TemplateId = " + templateId, sqliteConnecetion);
            updateSubjSQL.ExecuteNonQuery();

            SQLiteCommand updateContSQL = new SQLiteCommand("UPDATE TemplateTable SET Content = '" + t2.get_content() + "' WHERE TemplateId = " + templateId, sqliteConnecetion);
            updateContSQL.ExecuteNonQuery();
        }


        public void deleteTemplate(string name)
        {
            SQLiteCommand deleteSQL = new SQLiteCommand("DELETE FROM TemplateTable WHERE Name = '" + name + "'", sqliteConnecetion);
            deleteSQL.ExecuteNonQuery();
        }

    }
}
