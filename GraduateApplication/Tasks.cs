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
    public partial class Tasks : Form
    {
        Task task;
        public Tasks()
        {
            InitializeComponent();
            task = new Task();

            List<Task> tasks = new List<Task>();
            tasks = task.loadTasks();

            for (int i = 0; i < tasks.Count; i++)
            {
                if (!tasks[i].get_sent())
                    listBox1.Items.Add(tasks[i].get_subject() + " <" + tasks[i].get_content() + ">");
                else if (tasks[i].get_sent() && tasks[i].get_repeat() != "")
                    listBox1.Items.Add(tasks[i].get_subject() + " <" + tasks[i].get_content() + ">");
            }

        }

        private void composeButton_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask();
            DialogResult dr = addTask.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                listBox1.Items.Add(addTask.get_task().get_subject() + " <" + addTask.get_task().get_content() + ">");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
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

                EditTask editTask = new EditTask(t);
                DialogResult dr = editTask.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    listBox1.Items.Add(editTask.get_task().get_subject() + " <" + editTask.get_task().get_content() + ">");
                }
            }
            else
            {
                MessageBox.Show("Please select a task!");
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
