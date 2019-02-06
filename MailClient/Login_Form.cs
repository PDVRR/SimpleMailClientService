using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailClient
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        //проверка корректности заполнения почты
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            EmailTextBox.Text = EmailTextBox.Text.ToLower();
            //проверка правильности ввода почты и пароля
            if (IsValidEmail(EmailTextBox.Text))
            {
                if (PasswordTextBox.Text == "123")
                {
                    new Main_Form(EmailTextBox.Text).Show();
                }
                else
                {
                    MessageBox.Show("Invalid password");
                }
            }
            else
            {
                MessageBox.Show("Invalid email");
            }
        }
    }
}
