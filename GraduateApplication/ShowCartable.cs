using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace GraduateApplication
{
    public partial class ShowCartable : Form
    {
        Task task;
        public ShowCartable()
        {
            InitializeComponent();
            task = new Task();
            List<Task> tasks = new List<Task>();
            tasks = task.loadTasks();

            DateTime today = DateTime.Now.AddDays(0);
            for (int i = 0; i < tasks.Count; i++ )
            {
                string dt = tasks[i].get_time();
                DateTime task_date = DateTime.Parse(dt);

                if (today.Date == task_date.Date)
                {
                    if (!tasks[i].get_verified())
                    {
                        if (!tasks[i].get_sent())
                            listBox1.Items.Add(tasks[i].get_subject() + " <" + tasks[i].get_content() + ">");
                        else if (tasks[i].get_sent() && tasks[i].get_repeat() != "")
                            listBox1.Items.Add(tasks[i].get_subject() + " <" + tasks[i].get_content() + ">");
                    }
                }
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                if (!tasks[i].get_sent())
                    listBox2.Items.Add(tasks[i].get_subject() + " <" + tasks[i].get_content() + ">");
                else if (tasks[i].get_sent() && tasks[i].get_repeat() != "")
                    listBox2.Items.Add(tasks[i].get_subject() + " <" + tasks[i].get_content() + ">");
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
            else if (listBox2.SelectedIndex != -1)
            {
                string item = listBox2.SelectedItem.ToString();

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
                    listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                    listBox2.Items.Add(editTask.get_task().get_subject() + " <" + editTask.get_task().get_content() + ">");
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
            else if (listBox2.SelectedIndex != -1)
            {
                string item = listBox2.SelectedItem.ToString();

                int i1 = item.IndexOf("<");
                int i2 = item.IndexOf(">");

                string subj = item.Substring(0, i1 - 1);
                string cont = item.Substring(i1 + 1, i2 - i1 - 1);

                task.deleteTask(subj, cont);

                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            Task t = new Task("#notSet#", "#notSet#");

            int ind1 = -1;
            int ind2 = -1;

            if (listBox1.SelectedIndex != -1)
            {
                string item = listBox1.SelectedItem.ToString();

                int i1 = item.IndexOf("<");
                int i2 = item.IndexOf(">");

                string subj = item.Substring(0, i1 - 1);
                string cont = item.Substring(i1 + 1, i2 - i1 - 1);

                t = task.findTask(subj, cont);
                ind1 = listBox1.SelectedIndex;
            }
            else if (listBox2.SelectedIndex != -1)
            {
                string item = listBox2.SelectedItem.ToString();

                int i1 = item.IndexOf("<");
                int i2 = item.IndexOf(">");

                string subj = item.Substring(0, i1 - 1);
                string cont = item.Substring(i1 + 1, i2 - i1 - 1);

                t = task.findTask(subj, cont);
                ind2 = listBox2.SelectedIndex;
            }

            if (t.get_subject() != "#notSet#")
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("ut.graduate.application@gmail.com");
                    mail.Subject = t.get_subject();
                    mail.Body = t.get_content();

                    if (t.get_attachments().get_attach1() != "No file selected")
                    {
                        System.Net.Mail.Attachment att = new System.Net.Mail.Attachment(t.get_attachments().get_attach1());
                        mail.Attachments.Add(att);
                    }
                    if (t.get_attachments().get_attach2() != "No file selected")
                    {
                        System.Net.Mail.Attachment att = new System.Net.Mail.Attachment(t.get_attachments().get_attach2());
                        mail.Attachments.Add(att);
                    }
                    if (t.get_attachments().get_attach3() != "No file selected")
                    {
                        System.Net.Mail.Attachment att = new System.Net.Mail.Attachment(t.get_attachments().get_attach3());
                        mail.Attachments.Add(att);
                    }
                    if (t.get_attachments().get_attach4() != "No file selected")
                    {
                        System.Net.Mail.Attachment att = new System.Net.Mail.Attachment(t.get_attachments().get_attach4());
                        mail.Attachments.Add(att);
                    }
                    if (t.get_attachments().get_attach5() != "No file selected")
                    {
                        System.Net.Mail.Attachment att = new System.Net.Mail.Attachment(t.get_attachments().get_attach5());
                        mail.Attachments.Add(att);
                    }
                    

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("ut.graduate.application", "UniversityOfTehran");
                    SmtpServer.EnableSsl = true;

                    List<string> rec = new List<string>();
                    rec = t.find_rec();

                    for (int i = 0; i < rec.Count; i++)
                    {
                        mail.To.Add(rec[i]);
                        SmtpServer.Send(mail);
                        MessageBox.Show("Sent to: " + rec[i]);
                    }

                    MessageBox.Show("Mails Sent !");

                    if (ind1 != -1) listBox1.Items.RemoveAt(ind1);
                    else if (ind2 != -1) listBox2.Items.RemoveAt(ind2);

                    task.sentTask(t.get_subject(), t.get_content());
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

    }
}
