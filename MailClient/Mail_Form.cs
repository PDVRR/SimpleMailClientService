using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailClient.MailService;

namespace MailClient
{
    public partial class Mail_Form : Form
    {
        Service1Client MailSrvc;
        public Mail_Form(string email = null, DataGridViewRow Mail = null)
        {
            InitializeComponent();
            MailSrvc = new Service1Client();
            //если передан адрес почты
            if (email != null)
            {
                //заполняем соответствующее текстовое поле
                EmailFrom.Text = email;
            }
            //если передана выбранная строка
            if(Mail != null)
            {
                //заполняем значения текстбоксов из выбранной строки
                SubjectMail.Text = Mail.Cells[0].Value.ToString();
                DateLabel.Visible = true;
                DateLabel.Text = Mail.Cells[1].Value.ToString();
                EmailTo.Text = Mail.Cells[2].Value.ToString();
                EmailFrom.Text = Mail.Cells[3].Value.ToString();
                TagsMail.Text = Mail.Cells[4].Value.ToString();
                ContentMail.Text = Mail.Cells[5].Value.ToString();
                //скрываем кнопку отправки почты 
                SendMailButton.Visible = false;
                //делаем видимой дату создания письма
                label1.Visible = true;
                //делаем видимым поле EmailFrom
                EmailFrom.Visible = true;

                //делаем все объекты на форме только для чтения
                foreach (Control x in this.Controls)
                {
                    if (x is TextBox)
                    {
                        ((TextBox)x).ReadOnly = true;
                    }
                }
                //меняем текст окна
                this.Text = "View mail";
            }

        }
        //обработчик кнопки отправки почты
        private void SendMailButton_Click(object sender, EventArgs e)
        {
            //если все поля заполнены
            if (CheckRequiredFields(this.Controls)){

                EmailTo.Text = EmailTo.Text.ToLower();
                
                //если адрес почты введен корректно
                if (IsValidEmail(EmailTo.Text))
                {
                    try
                    {
                        //пытаемся отправить сообщение
                        string result = MailSrvc.SendMail(SubjectMail.Text, DateTime.Today, EmailTo.Text, EmailFrom.Text, TagsMail.Text, ContentMail.Text);
                        //выводим результат
                        MessageBox.Show(result);
                        this.Close();
                    }
                    catch
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Invalid email!");
                }
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //проверка заполнения полей
        private bool CheckRequiredFields(Control.ControlCollection controls)
        {
            foreach (Control x in controls)
            {
                //если элемент текстбокс
                if (x is TextBox)
                {
                    //если в него не введен текст
                    if (((TextBox)x).Text == "")
                    {
                        //выводим ошибку
                        MessageBox.Show("The " + ((TextBox)x).Name + " is empty!");
                        return false;

                    }
                }
            }
            return true;
        }

        //проверка корректности почты
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
    }
}
