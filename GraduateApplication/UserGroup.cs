using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraduateApplication
{
    public class UserGroup
    {
        DatabaseGroup dbGroup = new DatabaseGroup();
        public UserGroup(string n) { group_name = n; users = new List<Person>(); groups = new List<string>(); }


        //methods:
        public List<string> prevent_duplication(List<string> checked_items, List<string> groupListBoxItems)
        {
            List<string> res = new List<string>();

            for (int i = 0; i < checked_items.Count; i++)
            {
                bool is_exist = false;
                for (int j = 0; j < groupListBoxItems.Count; j++)
                {
                    if (checked_items[i] == groupListBoxItems[j].ToString())
                    {
                        is_exist = true;
                    }
                }

                if (!is_exist)
                {
                    res.Add(checked_items[i]);
                }
            }

            return res;
        }
        public bool check_duplicate(string n)
        {
            List<string> groups = new List<string>();
            groups = dbGroup.loadGroups();

            for (int i = 0; i < groups.Count; i++)
            {
                if (groups[i] == n)
                {
                    return true;
                }
            }

            return false;
        }


        //DAO:
        public List<string> loadGroups()
        { 
            return dbGroup.loadGroups();
        }
        public void addGroup(UserGroup g)
        {
            dbGroup.addGroup(g);
        }
        public void editGroup(UserGroup group, UserGroup updated_group)
        {
            dbGroup.editGroup(group, updated_group); ;
        }
        public UserGroup findGroup(string gname)
        {
            return dbGroup.findGroup(gname);
        }
        public void deleteGroup(string gname)
        {
            dbGroup.deleteGroup(gname);
        }


        //getters:
        public void set_group_name(string n) { group_name = n; }
        public void add_group_user(Person p) { users.Add(p); }
        public void add_group_group(string g) { groups.Add(g); }
        public void set_pk(int g) { gId = g; }


        //setters:
        public string get_group_name() { return group_name; }
        public List<Person> get_group_users() { return users; }
        public List<string> get_group_groups() { return groups; }
        public int get_gId() { return gId; }

        string group_name;
        List<Person> users;
        List<string> groups;

        int gId;
    }
}
