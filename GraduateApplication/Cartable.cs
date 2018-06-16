using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading;

namespace GraduateApplication
{
    public class Cartable
    {
        DatabaseTask dbTask = new DatabaseTask();


        //methods:
        public void daily_run()
        {
            DateTime today = DateTime.Now.AddDays(0);

            List<Task> tasks = new List<Task>();
            List<Task> noRepeat_tasks = new List<Task>();
            List<Task> daily_tasks = new List<Task>();
            List<Task> monthly_tasks = new List<Task>();
            List<Task> yearly_tasks = new List<Task>();
            
            tasks = dbTask.loadTasks();
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].get_repeat() != "" && tasks[i].get_verified())
                {
                    if (tasks[i].get_repeat() == "Yearly")
                    {
                        yearly_tasks.Add(tasks[i]);
                    }
                    else if (tasks[i].get_repeat() == "Monthly")
                    {
                        monthly_tasks.Add(tasks[i]);
                    } else if (tasks[i].get_repeat() == "Daily")
                    {
                        daily_tasks.Add(tasks[i]);
                    }
                }

                else if (tasks[i].get_repeat() == "" && tasks[i].get_verified()) 
                {
                    noRepeat_tasks.Add(tasks[i]);
                }
            }




            //send yearly:
            for (int i = 0; i < yearly_tasks.Count; i++)
            {
                string dt = yearly_tasks[i].get_time();
                DateTime task_date = DateTime.Parse(dt);

                if (task_date.Date.Month == today.Date.Month && task_date.Date.Day == today.Date.Day)
                {
                    send_mail(tasks[i]);
                }
            }


            //send monthly:
            for (int i = 0; i < monthly_tasks.Count; i++)
            {
                string dt = monthly_tasks[i].get_time();
                DateTime task_date = DateTime.Parse(dt);

                if (task_date.Date.Day == today.Date.Day)
                {
                    send_mail(tasks[i]);
                }
            }


            //send daily:
            for (int i = 0; i < daily_tasks.Count; i++)
            {
                send_mail(tasks[i]);
            }


            //send noRepeat:
            for (int i = 0; i < noRepeat_tasks.Count; i++)
            {
                send_mail(tasks[i]);
            }


            Thread.Sleep(86400000);
        }

        public void send_mail(Task t)
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
            }

            t.sentTask(t.get_subject(), t.get_content());
        }
    }

}
