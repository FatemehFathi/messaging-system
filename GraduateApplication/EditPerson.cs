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
    public partial class EditPerson : Form
    {
        Person person;

        public EditPerson(Person p)
        {
            InitializeComponent();
            person = new Person("#notSet#", "#notSet#");
            person = p;

            nameTextBox.Text = p.get_person_name();
            emailTextBox.Text = p.get_person_email();
        }

        public Person get_person()
        {
            return person;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Error: Name and Email cannot be empty!");
            }
            else
            {
                if (!person.check_duplicate(name, email))
                {
                    Person updated_person = new Person(name, email);
                    person.editPerson(person, updated_person);
                    person = updated_person;

                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                    MessageBox.Show("Changes Saved!");
                }
                else
                {
                    MessageBox.Show("Duplicate person!");
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
