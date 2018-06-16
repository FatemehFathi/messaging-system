using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraduateApplication
{
    public partial class EditTemplate : Form
    {
        Template template1;
        Template template2;

        public EditTemplate(Template t)
        {
            InitializeComponent();
            template1 = new Template("#notSet#");
            template2 = new Template("#notSet#");
            template1 = t;

            nameTextBox.Text = t.get_name();
            subjectTextBox.Text = t.get_subject();
            contentTextBox.Text = t.get_content();
        }

        public Template get_template()
        {
            return template2;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string subject = subjectTextBox.Text;
            string content = contentTextBox.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Error: Name and Subject and Content cannot be empty!");
            }
            else
            {
                template2.set_updated(name, subject, content);
                template2.editTemplate(template1, template2);

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
                MessageBox.Show("Changes Saved!");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
