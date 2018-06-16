using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraduateApplication
{
    public partial class EditGroup : Form
    {
        UserGroup group;
        Person person;

        public EditGroup(UserGroup ug)
        {
            InitializeComponent();
            person = new Person("#notSet#", "#notSet#");
            group = new UserGroup(ug.get_group_name());
            group = ug;
            nameTextBox.Text = ug.get_group_name();

            List<string> groups = new List<string>();
            groups = group.loadGroups();

            List<Person> persons = new List<Person>();
            persons = person.loadPersons();

            for (int i = 0; i < groups.Count; i++)
            {
                if (groups[i] != group.get_group_name())
                    allGroupsCheckedListBox.Items.Add(groups.ElementAt(i));
            }

            for (int i = 0; i < persons.Count; i++)
            {
                allPersonsCheckedListBox.Items.Add(persons.ElementAt(i).get_person_name() + " <" +
                    persons.ElementAt(i).get_person_email() + ">");
            }



            for (int i = 0; i < ug.get_group_users().Count; i++)
            {
                groupListBox.Items.Add(ug.get_group_users()[i].get_person_name() + " <" +
                    ug.get_group_users()[i].get_person_email() + ">");
            }

            for (int i = 0; i < ug.get_group_groups().Count; i++)
            {
                groupListBox.Items.Add(ug.get_group_groups()[i]);
            }
        }

        public UserGroup get_group()
        {
            return group;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (allPersonsCheckedListBox.CheckedItems.Count != -1)
            {
                List<string> checked_items = allPersonsCheckedListBox.CheckedItems.Cast<string>().ToList();
                List<string> groupListBoxItems = groupListBox.Items.Cast<string>().ToList();

                List<string> res = group.prevent_duplication(checked_items, groupListBoxItems);

                for (int i = 0; i < res.Count; i++)
                {
                    groupListBox.Items.Add(res[i]);
                }

                //unchecked !
                for (int i = 0; i < allPersonsCheckedListBox.Items.Count; i++)
                    allPersonsCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }


            if (allGroupsCheckedListBox.CheckedItems.Count != -1)
            {
                List<string> checked_items = allGroupsCheckedListBox.CheckedItems.Cast<string>().ToList();
                List<string> groupListBoxItems = groupListBox.Items.Cast<string>().ToList();

                List<string> res = group.prevent_duplication(checked_items, groupListBoxItems);

                for (int i = 0; i < res.Count; i++)
                {
                    groupListBox.Items.Add(res[i]);
                }

                //unchecked !
                for (int i = 0; i < allGroupsCheckedListBox.Items.Count; i++)
                    allGroupsCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (groupListBox.SelectedIndex != -1)
                groupListBox.Items.RemoveAt(groupListBox.SelectedIndex);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Error: Group Name cannot be empty!");
            }
            else
            {
                if (!group.check_duplicate(name))
                {

                    UserGroup ug = new UserGroup(name);

                    for (int i = 0; i < groupListBox.Items.Count; i++)
                    {
                        string item = groupListBox.Items[i].ToString();
                        int i1, i2;
                        if ((i1 = item.IndexOf("<")) != -1)
                        {
                            i2 = item.IndexOf(">");
                            string pname = item.Substring(0, i1 - 1);
                            string email = item.Substring(i1 + 1, i2 - i1 - 1);

                            Person p = new Person(pname, email);
                            ug.add_group_user(p);
                        }
                        else
                        {
                            ug.add_group_group(item);
                        }
                    }

                    group.editGroup(group, ug);
                    group = ug;

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                    MessageBox.Show("Changes Saved!");
                }
                else
                {
                    MessageBox.Show("Duplicate name!");
                }

            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

    }
}
