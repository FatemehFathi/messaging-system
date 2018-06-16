using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace GraduateApplication
{
    public class DatabaseUser
    {
        private SQLiteConnection sqliteConnecetion;
        private SqliteDataBase db;
        
        public DatabaseUser() {
            db = SqliteDataBase.getDataBase();
            sqliteConnecetion = db.getSqliteConnecetion();
        }

        public void addUser(Expert e)
        {
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO UserTable(Username, Password, Name, Email, Tel, Addr, Question, Answer) VALUES ('" + e.get_username() + "','" + e.get_password() + "','" + e.get_expert_name() + "','" + e.get_expert_email() + "','" + e.get_tel() + "','" + e.get_addr() + "','" + e.get_question() + "','" + e.get_answer() + "');", sqliteConnecetion);
            insertSQL.ExecuteNonQuery();
        }

        public List<Expert> loadUsers()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM UserTable", sqliteConnecetion);
            SQLiteDataReader reader = cmd.ExecuteReader();

            string username;
            string password;
            string name;
            string email;
            string tel;
            string addr;
            string question;
            string ans;
            List<Expert> users = new List<Expert>();

            while (reader.Read())
            {
                username = (string)reader["Username"];
                password = (string)reader["Password"];
                name = (string)reader["Name"];
                email = (string)reader["Email"];
                tel = (string)reader["Tel"];
                addr = (string)reader["Addr"];
                question = (string)reader["Question"];
                ans = (string)reader["Answer"];
                Expert e = new Expert(username, password, name, email, tel, addr, question, ans);
                users.Add(e);
            }

            return users;
        }

        public Expert findUser(string username)
        {
            Expert e = new Expert(username);

            SQLiteCommand find_userId = new SQLiteCommand("SELECT * FROM UserTable WHERE Username = '" + username + "'", sqliteConnecetion);
            SQLiteDataReader reader = find_userId.ExecuteReader();

            string password;
            string name;
            string email;
            string tel;
            string addr;
            string question;
            string ans;

            while (reader.Read())
            {
                username = (string)reader["Username"];
                password = (string)reader["Password"];
                name = (string)reader["Name"];
                email = (string)reader["Email"];
                tel = (string)reader["Tel"];
                addr = (string)reader["Addr"];
                question = (string)reader["Question"];
                ans = (string)reader["Answer"];
                Expert user = new Expert(username, password, name, email, tel, addr, question, ans);
                e = user;
            }

            return e;
        }

        public void editUser(Expert e1, Expert e2)
        {
            SQLiteCommand find_userId = new SQLiteCommand("SELECT UserId FROM UserTable WHERE Username = '" + e1.get_username() + "'", sqliteConnecetion);
            SQLiteDataReader reader = find_userId.ExecuteReader();

            System.Int64 uId1 = (System.Int64)reader["UserId"];
            int userID = (int)uId1;

            SQLiteCommand updateSQL1 = new SQLiteCommand("UPDATE UserTable SET Username = '" + e2.get_username() + "' WHERE UserId = '" + userID + "'", sqliteConnecetion);
            updateSQL1.ExecuteNonQuery();

            SQLiteCommand updateSQL2 = new SQLiteCommand("UPDATE UserTable SET Password = '" + e2.get_password() + "' WHERE UserId = '" + userID + "'", sqliteConnecetion);
            updateSQL2.ExecuteNonQuery();

            SQLiteCommand updateSQL3 = new SQLiteCommand("UPDATE UserTable SET Name = '" + e2.get_expert_name() + "' WHERE UserId = '" + userID + "'", sqliteConnecetion);
            updateSQL3.ExecuteNonQuery();

            SQLiteCommand updateSQL4 = new SQLiteCommand("UPDATE UserTable SET Email = '" + e2.get_expert_email() + "' WHERE UserId = '" + userID + "'", sqliteConnecetion);
            updateSQL4.ExecuteNonQuery();

            SQLiteCommand updateSQL5 = new SQLiteCommand("UPDATE UserTable SET Tel = '" + e2.get_tel() + "' WHERE UserId = '" + userID + "'", sqliteConnecetion);
            updateSQL5.ExecuteNonQuery();

            SQLiteCommand updateSQL6 = new SQLiteCommand("UPDATE UserTable SET Addr = '" + e2.get_addr() + "' WHERE UserId = '" + userID + "'", sqliteConnecetion);
            updateSQL6.ExecuteNonQuery();

            SQLiteCommand updateSQL7 = new SQLiteCommand("UPDATE UserTable SET Question = '" + e2.get_question() + "' WHERE UserId = '" + userID + "'", sqliteConnecetion);
            updateSQL7.ExecuteNonQuery();

            SQLiteCommand updateSQL8 = new SQLiteCommand("UPDATE UserTable SET Answer = '" + e2.get_answer() + "' WHERE UserId = '" + userID + "'", sqliteConnecetion);
            updateSQL8.ExecuteNonQuery();
        }

    }
}
