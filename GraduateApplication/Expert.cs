using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Security.Cryptography;


namespace GraduateApplication
{
    public class Expert
    {
        DatabaseUser dbUser = new DatabaseUser();
        public Expert(string u, string p = "", string n = "", string e = "", string t = "", string a = "", string q = "", string ans = "")
        {
            username = u;
            password = p;
            expert_name = n;
            expert_email = e;
            tel = t;
            addr = a;
            question = q;
            answer = ans;
        }


        //Methods:
        public void check_admin()
        {
            List<Expert> experts = new List<Expert>();
            experts = dbUser.loadUsers();

            if (experts.Count == 0)
            {
                string encryptPass = encrypt_password("123456");
                Expert admin = new Expert("Admin", encryptPass);
                dbUser.addUser(admin);
            }
        }
        public bool sign_in(string u, string p)
        {
            string encryptPass = encrypt_password(p);

            List<Expert> users = new List<Expert>();
            users = dbUser.loadUsers();

            bool found = false;
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].get_username() == u)
                {
                    if (users[i].get_password() == encryptPass)
                    {
                        this.username = u;
                        this.password = encryptPass;
                        this.expert_name = users[i].get_expert_name();
                        this.expert_email = users[i].get_expert_email();
                        this.tel = users[i].get_tel();
                        this.addr = users[i].get_addr();
                        this.question = users[i].get_question();
                        this.answer = users[i].get_answer();

                        found = true;
                    }
                }
            }

            return found;
        }
        public string forgot_password(string username)
        {
            Expert e = new Expert(username);
            e = dbUser.findUser(username);

            if (e.get_expert_email() == "#notSet#" || e.get_question() == "#notSet#")
            {
                return "#notSet#";
            }
            else
            {
                return e.get_question();
            }
        }
        public bool send_password(string username, string ans)
        {
            Expert e = new Expert(username);
            e = dbUser.findUser(username);

            if (e.get_answer() == ans) 
            {
                string decryptPass = decrypt_password(e.get_password());
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("ut.graduate.application@gmail.com");
                mail.Subject = "Your Password";
                mail.Body = "Hello " + e.get_username() + " !\nThis is your Password: " + decryptPass + "\nPlease try to keep it safe!\n\nUniversity of Tehran";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ut.graduate.application", "UniversityOfTehran");
                SmtpServer.EnableSsl = true;
                mail.To.Add(e.get_expert_email());

                SmtpServer.Send(mail);

                return true;
            }

            return false;
        }
        public void edit_profile(Expert updated_expert)
        {
            dbUser.editUser(this, updated_expert);
        }
        public string encrypt_password(string password)
        {
            string strmsg = string.Empty;
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            strmsg = Convert.ToBase64String(encode);
            return strmsg;
        }
        public string decrypt_password(string encryptpwd)
        {
            string decryptpwd = string.Empty;
            UTF8Encoding encodepwd = new UTF8Encoding();
            Decoder Decode = encodepwd.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encryptpwd);
            int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            decryptpwd = new String(decoded_char);
            return decryptpwd;
        }


        //setters:
        public void set_password(string p) { password = p; }
        public void set_expert_name(string n) { expert_name = n; }
        public void set_expert_email(string e) { expert_email = e; }
        public void set_tel(string t) { tel = t; }
        public void set_addr(string a) { addr = a; }
        public void set_question(string q) { question = q; }
        public void set_answer(string ans) { answer = ans; }
        public void set_updated(string n, string p, string e, string t, string a, string q, string ans)
        {
            expert_name = n;
            password = p;
            expert_email = e;
            tel = t;
            addr = a;
            question = q;
            answer = ans;
        }


        //getters:
        public string get_username() { return username; }
        public string get_password() { return password; }
        public string get_expert_name() { return expert_name; }
        public string get_expert_email() { return expert_email; }
        public string get_tel() { return tel; }
        public string get_addr() { return addr; }
        public string get_question() { return question; }
        public string get_answer() { return answer; }


        //fields:
        string username;
        string password;
        string expert_name;
        string expert_email;
        string tel;
        string addr;
        string question;
        string answer;
    }
}
