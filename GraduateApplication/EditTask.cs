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
    public partial class EditTask : Form
    {
        Task task1;
        Task task2;
        UserGroup group;
        Person person;
        Template template;

        public EditTask(Task t)
        {
            InitializeComponent();
            group = new UserGroup("#notSet#");
            person = new Person("#notSet#", "#notSet#");
            template = new Template("#notSet#");

            task1 = new Task("#notSet#", "#notSet#");
            task2 = new Task("#notSet#", "#notSet#");
            task1 = t;

            List<string> groups = new List<string>();
            groups = group.loadGroups();

            List<Person> persons = new List<Person>();
            persons = person.loadPersons();

            List<Template> templates = new List<Template>();
            templates = template.loadTemplates();

            for (int i = 0; i < groups.Count; i++)
            {
                groupsComboBox.Items.Add(groups.ElementAt(i));
            }

            for (int i = 0; i < persons.Count; i++)
            {
                personsComboBox.Items.Add(persons.ElementAt(i).get_person_name() + " <" +
                    persons.ElementAt(i).get_person_email() + ">");
            }

            for (int i = 0; i < templates.Count; i++)
            {
                templatesComboBox.Items.Add(templates[i].get_name());
            }

            toTextBox.Text = t.get_receivers();
            subjectTextBox.Text = t.get_subject();
            contentTextBox.Text = t.get_content();
            verificationCheckBox.Checked = t.get_need_verification();
            verifyCheckBox.Checked = t.get_verified();
            string dt = t.get_time();
            DateTime dateTime = DateTime.Parse(dt);
            dateTimePicker.Value = dateTime;

            RepeatComboBox.Items.Add("Yearly");
            RepeatComboBox.Items.Add("Monthly");
            RepeatComboBox.Items.Add("Daily");
        }

        public Task get_task()
        {
            return task2;
        }

        private void addRecButton_Click(object sender, EventArgs e)
        {
            if (personsComboBox.SelectedIndex > -1)
            {
                if (!toTextBox.Text.Contains(personsComboBox.SelectedItem.ToString()))
                {
                    toTextBox.Text += personsComboBox.SelectedItem.ToString();
                    toTextBox.Text += "; ";

                    int i1 = personsComboBox.SelectedItem.ToString().IndexOf("<");
                    int i2 = personsComboBox.SelectedItem.ToString().IndexOf(">");

                    string name = personsComboBox.SelectedItem.ToString().Substring(0, i1 - 1);
                    string email = personsComboBox.SelectedItem.ToString().Substring(i1 + 1, i2 - i1 - 1);

                    Person p = new Person(name, email);
                    task2.add_task_persons(p);
                }
            }

            if (groupsComboBox.SelectedIndex > -1)
            {
                if (!toTextBox.Text.Contains(groupsComboBox.SelectedItem.ToString()))
                {
                    toTextBox.Text += groupsComboBox.SelectedItem.ToString();
                    toTextBox.Text += "; ";

                    task2.add_task_groups(groupsComboBox.SelectedItem.ToString());
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string subject = subjectTextBox.Text;
            string content = contentTextBox.Text;
            bool need_verification = verificationCheckBox.Checked;
            DateTime dt = dateTimePicker.Value;
            string dateTime = dt.ToString();

            if (string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Error: Subject and Content cannot be empty!");
            }
            else if (need_verification == false && toTextBox.Text == "")
            {
                MessageBox.Show("Error: no need verification ! Receivers list cannot be empty!");
            }
            else
            {
                task2.set_updated(subject, content, verificationCheckBox.Checked, verifyCheckBox.Checked, dateTime, toTextBox.Text);

                if (!task2.check_duplicate(task2))
                {
                    task2.editTask(task1, task2);

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                    MessageBox.Show("Changes Saved!");
                }
                else
                {
                    MessageBox.Show("Duplicate Subject and Content");
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void templateButton_Click(object sender, EventArgs e)
        {
            if (templatesComboBox.SelectedIndex > -1)
            {
                string name = templatesComboBox.SelectedItem.ToString();
                template = template.findTemplate(name);

                subjectTextBox.Text = template.get_subject();
                contentTextBox.Text = template.get_content();
            }
        }

        private void repeatButton_Click(object sender, EventArgs e)
        {
            task2.set_repeat(RepeatComboBox.Text);
            MessageBox.Show("Set!");
        }

        private void attachButton_Click(object sender, EventArgs e)
        {
            EditAttachment editAttachment = new EditAttachment(task1.get_attachments());
            DialogResult dr = editAttachment.ShowDialog();

            Attachment attachment = new Attachment();
            attachment = editAttachment.get_attachment();
            task2.set_attachments(attachment);
        }


    }
}
