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
    public partial class Groups : Form
    {
        UserGroup group;
        Person person;

        public Groups()
        {
            InitializeComponent();
            group = new UserGroup("#notSet#");
            person = new Person("#notSet#", "#notSet#");

            List<string> groups = new List<string>();
            groups = group.loadGroups();

            List<Person> persons = new List<Person>();
            persons = person.loadPersons();

            
            for (int i = 0; i < groups.Count; i++)
            {
                listBox1.Items.Add(groups.ElementAt(i));
            }
            
            for (int i = 0; i < persons.Count; i++)
            {
                listBox2.Items.Add(persons.ElementAt(i).get_person_name() + " <" +
                    persons.ElementAt(i).get_person_email() + ">");
            }
        }

        private void createGroupButton_Click(object sender, EventArgs e)
        {
            AddGroup addGroup = new AddGroup();
            DialogResult dr = addGroup.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                listBox1.Items.Add(addGroup.get_group().get_group_name());
            }
        }

        private void editGroupButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string gname = listBox1.SelectedItem.ToString();

                UserGroup ug = new UserGroup(gname);
                ug = group.findGroup(gname);

                EditGroup editGroup = new EditGroup(ug);
                DialogResult dr = editGroup.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.Add(editGroup.get_group().get_group_name());
                }
            }
        }

        private void deleteGroupButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string gname = listBox1.SelectedItem.ToString();
                group.deleteGroup(gname);

                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            DialogResult dr = addPerson.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                if (addPerson.get_person().get_person_name() != "#notSet#")
                {
                    listBox2.Items.Add(addPerson.get_person().get_person_name() + " <" + addPerson.get_person().get_person_email() + ">");
                }
            }
        }

        private void editPersonButton_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                string item = listBox2.SelectedItem.ToString();

                int i1 = item.IndexOf("<");
                int i2 = item.IndexOf(">");

                string name = item.Substring(0, i1 - 1);
                string email = item.Substring(i1 + 1, i2 - i1 - 1);

                Person p = new Person(name, email);
                EditPerson editPerson = new EditPerson(p);
                DialogResult dr = editPerson.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                    listBox2.Items.Add(editPerson.get_person().get_person_name() + " <" + editPerson.get_person().get_person_email() + ">");
                }
            }
        }

        private void deletePersonButton_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                string item = listBox2.SelectedItem.ToString();

                int i1 = item.IndexOf("<");
                int i2 = item.IndexOf(">");

                string name = item.Substring(0, i1 - 1);
                string email = item.Substring(i1 + 1, i2 - i1 - 1);

                person.deletePerson(name, email);

                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

    }
}
