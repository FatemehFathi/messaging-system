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
    public partial class Login : Form
    {
        Expert expert;
        public Login()
        {
            InitializeComponent();

            expert = new Expert("#notSet#");
            textBox2.UseSystemPasswordChar = true;

            expert.check_admin();
        }

        private void forgotPassLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your username");
            }
            
            else
            {
                string username = textBox1.Text;
                string question = expert.forgot_password(username);

                if (question != "")
                {
                    ForgotPassword fp = new ForgotPassword(username, question);
                    DialogResult dr = fp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sorry ! You did not set any security question or e-mail address");
                }
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username != "" && password != "")
            {

                bool signed_in = false;
                signed_in = expert.sign_in(username, password);

                if (signed_in)
                {
                    this.Hide();
                    MainMenu mainMenu = new MainMenu(expert);
                    DialogResult dr = mainMenu.ShowDialog();
                    textBox1.Text = "";
                    textBox2.Text = "";

                    this.Show();
                }
                else
                {
                    MessageBox.Show("ERROR: The username or password you entered is incorrect!");
                }
            }
            else
            {
                MessageBox.Show("Enter your username and password");
            }

        }
    }
}
