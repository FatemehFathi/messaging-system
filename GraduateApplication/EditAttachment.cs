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
    public partial class EditAttachment : Form
    {
        Attachment attachment;
        public EditAttachment(Attachment a)
        {
            InitializeComponent();
            attachment = new Attachment();
            attachment = a;

            att1.Text = a.get_attach1();
            att2.Text = a.get_attach2();
            att3.Text = a.get_attach3();
            att4.Text = a.get_attach4();
            att5.Text = a.get_attach5();
        }

        public Attachment get_attachment()
        {
            return attachment;
        }

        private void browse1_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "All files|*.*";
            d.Multiselect = true;
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                att1.Text = d.FileName;
            }

        }

        private void browse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "All files|*.*";
            d.Multiselect = true;
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                att2.Text = d.FileName;
            }
        }

        private void browse3_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "All files|*.*";
            d.Multiselect = true;
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                att3.Text = d.FileName;
            }
        }

        private void browse4_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "All files|*.*";
            d.Multiselect = true;
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                att4.Text = d.FileName;
            }
        }

        private void browse5_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "All files|*.*";
            d.Multiselect = true;
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                att5.Text = d.FileName;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            attachment.set_attachs(att1.Text, att2.Text, att3.Text, att4.Text, att5.Text);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }


    }
}
