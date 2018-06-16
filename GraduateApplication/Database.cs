using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace GraduateApplication
{
    class SqliteDataBase
    {
        private static SqliteDataBase sqliteDataBase = null;
        private static SQLiteConnection sqliteConnecetion;

        private SqliteDataBase()
        {
            //SQLiteConnection.CreateFile("SoftwareEngDB.sqlite");
            sqliteConnecetion = new SQLiteConnection("Data Source = SoftwareEngDB.sqlite; Version = 3");
            sqliteConnecetion.Open();

            SQLiteCommand user_table = new SQLiteCommand("create table if not exists UserTable(Username Text, Password Text, Name Text, Email Text, Tel Text, Addr Text, Question Text, Answer Text, UserId Integer PRIMARY KEY AUTOINCREMENT);", sqliteConnecetion);
            user_table.ExecuteNonQuery();

            SQLiteCommand person_table = new SQLiteCommand("create table if not exists PersonTable(Name Text, Email Text, PersonId Integer PRIMARY KEY AUTOINCREMENT);", sqliteConnecetion);
            person_table.ExecuteNonQuery();

            SQLiteCommand group_table = new SQLiteCommand("create table if not exists GroupTable(Name Text, GroupId Integer PRIMARY KEY AUTOINCREMENT);", sqliteConnecetion);
            group_table.ExecuteNonQuery();

            SQLiteCommand userGroup_table = new SQLiteCommand("create table if not exists UserGroupTable(GroupId1 Integer, PersonId1 Integer, FOREIGN KEY(PersonId1) REFERENCES PersonTable(PersonId )ON DELETE CASCADE, FOREIGN KEY(GroupId1) REFERENCES GroupTable(GroupId) ON DELETE CASCADE);", sqliteConnecetion);
            userGroup_table.ExecuteNonQuery();

            SQLiteCommand groupGroup_table = new SQLiteCommand("create table if not exists GroupGroupTable(GroupId1 Integer, GroupId2 Integer, FOREIGN KEY(GroupId1) REFERENCES GroupTable(GroupId) ON DELETE CASCADE, FOREIGN KEY(GroupId2) REFERENCES GroupTable(GroupId) ON DELETE CASCADE);", sqliteConnecetion);
            groupGroup_table.ExecuteNonQuery();

            SQLiteCommand template_table = new SQLiteCommand("create table if not exists TemplateTable(Name Text, Subject Text, Content Text, TemplateId Integer PRIMARY KEY AUTOINCREMENT);", sqliteConnecetion);
            template_table.ExecuteNonQuery();

            SQLiteCommand task_table = new SQLiteCommand("create table if not exists TaskTable(Receivers Text, Subject Text, Content Text, NeedVerification Integer, Verify Integer, Date Text, Sent Integer, Repeat Text, TaskId Integer PRIMARY KEY AUTOINCREMENT);", sqliteConnecetion);
            task_table.ExecuteNonQuery();

            SQLiteCommand taskPerson_table = new SQLiteCommand("create table if not exists TaskPersonTable(TaskId1 Integer, PersonId1 Integer, FOREIGN KEY(PersonId1) REFERENCES PersonTable(PersonId) ON DELETE CASCADE, FOREIGN KEY(TaskId1) REFERENCES TaskTable(TaskId) ON DELETE CASCADE);", sqliteConnecetion);
            taskPerson_table.ExecuteNonQuery();

            SQLiteCommand taskGroup_table = new SQLiteCommand("create table if not exists TaskGroupTable(TaskId1 Integer, GroupId1 Integer, FOREIGN KEY(GroupId1) REFERENCES GroupTable(GroupId) ON DELETE CASCADE, FOREIGN KEY(TaskId1) REFERENCES TaskTable(TaskId) ON DELETE CASCADE);", sqliteConnecetion);
            taskGroup_table.ExecuteNonQuery();

            SQLiteCommand taskAttachment_table = new SQLiteCommand("create table if not exists TaskAttachmentTable(TaskId1 Integer, Attachment Text, FOREIGN KEY(TaskId1) REFERENCES TaskTable(TaskId) ON DELETE CASCADE);", sqliteConnecetion);
            taskAttachment_table.ExecuteNonQuery();
        }

        public static SqliteDataBase getDataBase()
        {
            if (sqliteDataBase == null)
                sqliteDataBase = new SqliteDataBase();
            return sqliteDataBase;
        }

        public SQLiteConnection getSqliteConnecetion()
        {
            return sqliteConnecetion;
        }

    }
}