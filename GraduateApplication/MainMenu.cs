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
    public partial class MainMenu : Form
    {
        Expert expert;
        public MainMenu(Expert e)
        {
            InitializeComponent();
            expert = new Expert(e.get_username());
            expert = e;
        }

        private void editProfileLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var form = new EditProfile(expert))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    expert = form.get_expert;
                }
            }
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void cartableButton_Click(object sender, EventArgs e)
        {
            ShowCartable showCartable = new ShowCartable();
            DialogResult dr = showCartable.ShowDialog();
        }

        private void templatesButton_Click(object sender, EventArgs e)
        {
            Templates templates = new Templates();
            DialogResult dr = templates.ShowDialog();
        }

        private void tasksButton_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            DialogResult dr = tasks.ShowDialog();
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            Groups groups = new Groups();
            DialogResult dr = groups.ShowDialog();
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            SentMail sentMail = new SentMail();
            DialogResult dr = sentMail.ShowDialog();
        }


    }
}
