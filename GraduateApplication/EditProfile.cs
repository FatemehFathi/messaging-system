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
    public partial class EditProfile : Form
    {
        Expert expert;
        public EditProfile(Expert e1)
        {
            InitializeComponent();

            expert = new Expert(e1.get_username());

            nameTextBox.Text = e1.get_expert_name();
            usernameTextBox.Text = e1.get_username();
            passTextBox.UseSystemPasswordChar = true;
            pass2TextBox.UseSystemPasswordChar = true;
            emailTextBox.Text = e1.get_expert_email();
            telTextBox.Text = e1.get_tel();
            addrTextBox.Text = e1.get_addr();
            questionTextBox.Text = e1.get_question();
            answerTextBox.Text = e1.get_answer();
        }

        public Expert get_expert { get; set; } 

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (passTextBox.Text == pass2TextBox.Text && passTextBox.Text != "")
            {
                if ((questionTextBox.Text != "" && answerTextBox.Text != "") || (questionTextBox.Text == "" && answerTextBox.Text == ""))
                {
                    string password = passTextBox.Text;
                    string encryptPass = expert.encrypt_password(password);

                    string name = nameTextBox.Text;
                    string username = usernameTextBox.Text;
                    string email = emailTextBox.Text;
                    string addr = addrTextBox.Text;
                    string tel = telTextBox.Text;
                    string question = questionTextBox.Text;
                    string answer = answerTextBox.Text;

                    Expert updated_expert = new Expert(username);
                    updated_expert.set_updated(name, encryptPass, email, tel, addr, question, answer);
                    expert.edit_profile(updated_expert);

                    this.get_expert = updated_expert;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Set both security question and answer");
                }
            }
            else
            {
                MessageBox.Show("Passwords didn't match");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void picButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "All files|*.*";
            d.Multiselect = true;
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = d.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
