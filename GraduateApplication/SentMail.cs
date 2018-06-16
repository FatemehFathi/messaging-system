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
    public partial class SentMail : Form
    {
        Task task;
        public SentMail()
        {
            InitializeComponent();
            task = new Task();

            List<Task> tasks = new List<Task>();
            tasks = task.loadTasks();

            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].get_sent())
                    listBox1.Items.Add(tasks[i].get_subject() + " <" + tasks[i].get_content() + ">");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string item = listBox1.SelectedItem.ToString();

                int i1 = item.IndexOf("<");
                int i2 = item.IndexOf(">");

                string subj = item.Substring(0, i1 - 1);
                string cont = item.Substring(i1 + 1, i2 - i1 - 1);

                Task t = new Task(subj, cont);
                t = task.findTask(subj, cont);

                SentMailShow sentTask = new SentMailShow(t);
                DialogResult dr = sentTask.ShowDialog();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string item = listBox1.SelectedItem.ToString();

                int i1 = item.IndexOf("<");
                int i2 = item.IndexOf(">");

                string subj = item.Substring(0, i1 - 1);
                string cont = item.Substring(i1 + 1, i2 - i1 - 1);

                task.deleteTask(subj, cont);

                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
