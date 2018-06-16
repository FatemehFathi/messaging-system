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
    public partial class SentMailShow : Form
    {
        public SentMailShow(Task t)
        {
            InitializeComponent();

            toTextBox.Text = t.get_receivers();
            subjectTextBox.Text = t.get_subject();
            contentTextBox.Text = t.get_content();
            string dt = t.get_time();
            DateTime dateTime = DateTime.Parse(dt);
            dateTimePicker.Value = dateTime;
        }
    }
}
