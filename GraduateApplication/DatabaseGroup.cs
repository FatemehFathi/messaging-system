using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace GraduateApplication
{
    public class DatabaseGroup
    {
        private SQLiteConnection sqliteConnecetion;
        private SqliteDataBase db;
        
        public DatabaseGroup() {
            db = SqliteDataBase.getDataBase();
            sqliteConnecetion = db.getSqliteConnecetion();
        }


        public void addGroup(UserGroup g)
        {
            int groupId1, groupId2, personId1;

            SQLiteCommand insert_groupTable = new SQLiteCommand("INSERT INTO GroupTable(Name) VALUES ('" + g.get_group_name() + "');", sqliteConnecetion);
            insert_groupTable.ExecuteNonQuery();


            SQLiteCommand find_groupId = new SQLiteCommand("SELECT GroupId FROM GroupTable WHERE Name = '" + g.get_group_name() + "'", sqliteConnecetion);
            SQLiteDataReader reader = find_groupId.ExecuteReader();

            System.Int64 gId1 = (System.Int64)reader["GroupId"];
            groupId1 = (int)gId1;


            for (int i = 0; i < g.get_group_users().Count; i++)
            {
                SQLiteCommand find_personId = new SQLiteCommand("SELECT PersonId FROM PersonTable WHERE Name = '" + g.get_group_users()[i].get_person_name() + "'", sqliteConnecetion);
                reader = find_personId.ExecuteReader();

                System.Int64 pId1 = (System.Int64)reader["PersonId"];
                personId1 = (int)pId1;

                SQLiteCommand insert_userGroupTable = new SQLiteCommand("INSERT INTO UserGroupTable(GroupId1, PersonId1) VALUES ('" + groupId1 + "','" + personId1 + "');", sqliteConnecetion);
                insert_userGroupTable.ExecuteNonQuery();
            }


            for (int i = 0; i < g.get_group_groups().Count; i++)
            {
                SQLiteCommand find_groupId2 = new SQLiteCommand("SELECT GroupId FROM GroupTable WHERE Name = '" + g.get_group_groups()[i] + "'", sqliteConnecetion);
                reader = find_groupId2.ExecuteReader();

                System.Int64 gId2 = (System.Int64)reader["GroupId"];
                groupId2 = (int)gId2;

                SQLiteCommand insert_groupGroupTable = new SQLiteCommand("INSERT INTO GroupGroupTable(GroupId1, GroupId2) VALUES ('" + groupId1 + "','" + groupId2 + "');", sqliteConnecetion);
                insert_groupGroupTable.ExecuteNonQuery();
            }

        }


        public List<string> loadGroups()
        {
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM GroupTable", sqliteConnecetion);
            SQLiteDataReader reader = cmd.ExecuteReader();

            List<string> names = new List<string>();
            while (reader.Read())
            {
                names.Add((string)reader["Name"]);
            }

            return names;
        }


        public UserGroup findGroup(string gname)
        {
            //////////////////////// gid1 ro biab
            //////////////////////// az jadvale usergroup pid1 ha ro biab. az jadvale person name, email ro biab !!! push back kon
            //////////////////////// az jadvale groupgroup gid2 ha ro biab. az jadvale group name ro biab !!! push back kon

            UserGroup ug = new UserGroup(gname);

            SQLiteCommand find_groupId = new SQLiteCommand("SELECT GroupId FROM GroupTable WHERE Name = '" + gname + "'", sqliteConnecetion);
            SQLiteDataReader reader = find_groupId.ExecuteReader();

            System.Int64 gId1 = (System.Int64)reader["GroupId"];
            int groupId1 = (int)gId1;


            ////////////////////////////////////////////////////////////////////////////////////////////

            SQLiteCommand find_personsId = new SQLiteCommand("SELECT PersonId1 FROM UserGroupTable WHERE GroupId1 = " + groupId1, sqliteConnecetion);
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

                ug.add_group_user(p);
            }

            ////////////////////////////////////////////////////////////////////////////////////////////


            SQLiteCommand find_groupsId = new SQLiteCommand("SELECT GroupId2 FROM GroupGroupTable WHERE GroupId1 = " + groupId1, sqliteConnecetion);
            reader = find_groupsId.ExecuteReader();

            List<int> groupsId2 = new List<int>();
            while (reader.Read())
            {
                System.Int64 gId2 = (System.Int64)reader["GroupId2"];
                groupsId2.Add((int)gId2);
            }


            for (int i = 0; i < groupsId2.Count; i++)
            {
                SQLiteCommand find_groups = new SQLiteCommand("SELECT Name FROM GroupTable WHERE GroupId = " + groupsId2[i], sqliteConnecetion);
                reader = find_groups.ExecuteReader();

                string name = (string)reader["Name"];

                ug.add_group_group(name);
            }

            ug.set_pk(groupId1);
            return ug;
        }


        public void editGroup(UserGroup g1, UserGroup g2)
        {
            int gId = g1.get_gId();

            SQLiteCommand updateSQL1 = new SQLiteCommand("UPDATE GroupTable SET Name = '" + g2.get_group_name() + "' WHERE GroupId = " + gId, sqliteConnecetion);
            updateSQL1.ExecuteNonQuery();

            SQLiteCommand deleteSQL1 = new SQLiteCommand("DELETE FROM UserGroupTable WHERE GroupId1 = " + gId, sqliteConnecetion);
            deleteSQL1.ExecuteNonQuery();

            SQLiteCommand deleteSQL2 = new SQLiteCommand("DELETE FROM GroupGroupTable WHERE GroupId1 = " + gId, sqliteConnecetion);
            deleteSQL2.ExecuteNonQuery();



            for (int i = 0; i < g2.get_group_users().Count; i++)
            {
                SQLiteCommand find_personId = new SQLiteCommand("SELECT PersonId FROM PersonTable WHERE Name = '" + g2.get_group_users()[i].get_person_name() + "'", sqliteConnecetion);
                SQLiteDataReader reader = find_personId.ExecuteReader();

                System.Int64 pId1 = (System.Int64)reader["PersonId"];
                int personId1 = (int)pId1;

                SQLiteCommand insert_userGroupTable = new SQLiteCommand("INSERT INTO UserGroupTable(GroupId1, PersonId1) VALUES ('" + gId + "','" + personId1 + "');", sqliteConnecetion);
                insert_userGroupTable.ExecuteNonQuery();
            }


            for (int i = 0; i < g2.get_group_groups().Count; i++)
            {
                SQLiteCommand find_groupId2 = new SQLiteCommand("SELECT GroupId FROM GroupTable WHERE Name = '" + g2.get_group_groups()[i] + "'", sqliteConnecetion);
                SQLiteDataReader reader = find_groupId2.ExecuteReader();

                System.Int64 gId2 = (System.Int64)reader["GroupId"];
                int groupId2 = (int)gId2;

                SQLiteCommand insert_groupGroupTable = new SQLiteCommand("INSERT INTO GroupGroupTable(GroupId1, GroupId2) VALUES ('" + gId + "','" + groupId2 + "');", sqliteConnecetion);
                insert_groupGroupTable.ExecuteNonQuery();
            }

        }


        public void deleteGroup(string name)
        {
            //az har se ta jadvale group pak kon - ON DELETE CASCADE --> faghat az jadval avali kafie !
            SQLiteCommand deleteSQL = new SQLiteCommand("DELETE FROM GroupTable WHERE Name = '" + name + "'", sqliteConnecetion);
            deleteSQL.ExecuteNonQuery();
        }

    }
}
