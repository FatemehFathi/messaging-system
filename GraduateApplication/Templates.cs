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
    public partial class Templates : Form
    {
        Template template;

        public Templates()
        {
            InitializeComponent();
            template = new Template("#notSet#");

            List<Template> templates = new List<Template>();
            templates = template.loadTemplates();

            for (int i = 0; i < templates.Count; i++)
            {
                listBox1.Items.Add(templates[i].get_name());
            }
        }

        private void composeButton_Click(object sender, EventArgs e)
        {
            AddTemplate addTemplate = new AddTemplate();
            DialogResult dr = addTemplate.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                listBox1.Items.Add(addTemplate.get_template().get_name());
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string name = listBox1.SelectedItem.ToString();

                Template t = new Template(name);
                t = template.findTemplate(name);

                EditTemplate editTemplate = new EditTemplate(t);
                DialogResult dr = editTemplate.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.Add(editTemplate.get_template().get_name());
                }
            }
            else
            {
                MessageBox.Show("Please select a temlate");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string name = listBox1.SelectedItem.ToString();

                template.deleteTemplate(name);

                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
