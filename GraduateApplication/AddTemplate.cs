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
    public partial class AddTemplate : Form
    {
        Template template;

        public AddTemplate()
        {
            InitializeComponent();
            template = new Template("#notSet#");
        }

        public Template get_template()
        {
            return template;
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
                template.set_updated(name, subject, content);
                template.addTemplate(template);

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
