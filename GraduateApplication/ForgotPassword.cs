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
    public partial class ForgotPassword : Form
    {
        Expert expert;
        public ForgotPassword(string username, string question)
        {
            InitializeComponent();
            questionLable.Text = "Security Question: " + question;
            expert = new Expert(username);
        }

        private void sendPassButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Your Answer");
            }
            else 
            {
                bool sent = expert.send_password(expert.get_username(), textBox1.Text);

                if (sent)
                {
                    MessageBox.Show("An email will be sent to your email address with your password");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Your answer is wrong");
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
