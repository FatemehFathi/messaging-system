using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace GraduateApplication
{
    public class DatabasePerson
    {
        private SQLiteConnection sqliteConnecetion;
        private SqliteDataBase db;
        
        public DatabasePerson() {
            db = SqliteDataBase.getDataBase();
            sqliteConnecetion = db.getSqliteConnecetion();
        }


        public void addPerson(Person p)
        {
            SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO PersonTable(Name, Email) VALUES ('" + p.get_person_name() + "','" + p.get_person_email() + "');", sqliteConnecetion);
            insertSQL.ExecuteNonQuery();
        }


        public List<Person> loadPersons()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM PersonTable", sqliteConnecetion);
            SQLiteDataReader reader = cmd.ExecuteReader();

            string name;
            string email;
            List<Person> persons = new List<Person>();

            while (reader.Read())
            {
                name = (string)reader["Name"];
                email = (string)reader["Email"];
                Person p = new Person(name, email);
                persons.Add(p);
            }

            return persons;
        }


        public void editPerson(Person p1, Person p2)
        {
            /*
            SQLiteCommand find_personId = new SQLiteCommand("SELECT PersonId FROM PersonTable WHERE Name = '" + p1.get_person_name() + "' AND Email = '" + p1.get_person_email() + "'", sqliteConnecetion);
            SQLiteDataReader reader = find_personId.ExecuteReader();

            System.Int64 pId1 = (System.Int64)reader["PersonId"];
            int personID = (int)pId1;

            SQLiteCommand updateSQL = new SQLiteCommand("UPDATE PersonTable SET Name = '" + p2.get_person_name() + "' AND Email = '" + p2.get_person_email() + "' WHERE PersonId = " + personID, sqliteConnecetion);
            updateSQL.ExecuteNonQuery();
            */

            SQLiteCommand updateSQL1 = new SQLiteCommand("UPDATE PersonTable SET Name = '" + p2.get_person_name() + "' WHERE Name = '" + p1.get_person_name() + "'", sqliteConnecetion);
            updateSQL1.ExecuteNonQuery();

            SQLiteCommand updateSQL2 = new SQLiteCommand("UPDATE PersonTable SET Email = '" + p2.get_person_email() + "' WHERE Email = '" + p1.get_person_email() + "'", sqliteConnecetion);
            updateSQL2.ExecuteNonQuery();
        }


        public void deletePerson(string name, string email)
        {
            SQLiteCommand deleteSQL = new SQLiteCommand("DELETE FROM PersonTable WHERE Name = '" + name + "' AND Email = '" + email + "'", sqliteConnecetion);
            deleteSQL.ExecuteNonQuery();
        }

    }
}
