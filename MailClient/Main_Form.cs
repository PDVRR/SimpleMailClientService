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
    public partial class Main_Form : Form
    {
        Service1Client clnt = new Service1Client();
        DataTable dataTable = new DataTable();

        string email;
        public Main_Form(string email)
        {
            //записываем адрес почты с формы логина
            this.email = email;

            InitializeComponent();
            //заполняем таблицу входящими сообшениями 
            dataTable = clnt.GetInboxMessages(email);
            dataGridView1.DataSource = dataTable;
        }
        //обработка нажатия на кнопку создания нового письма
        private void NewMailButton_Click(object sender, EventArgs e)
        {
            //загружаем форму с передачей адреса почты
            new Mail_Form(email).Show();
        }
        //обработчик нажатия кнопки "inbox" в меню
        private void inboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //заполняем таблицу входящими сообшениями 
            dataTable = clnt.GetInboxMessages(email);
            dataGridView1.DataSource = dataTable;
        }
        //обработчик нажатия кнопки "sent" в меню
        private void sentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //заполняем таблицу отправленными сообшениями 
            dataTable = clnt.GetSentMessages(email);
            dataGridView1.DataSource = dataTable;
        }
        //обработчик нажатия кнопки просмотра сообщения
        private void ViewMailButton_Click(object sender, EventArgs e)
        {
            try
            {
                //записываем номер выбранной в табличке строки
                int StringNumber = dataGridView1.SelectedCells[0].RowIndex;
                //создаем новый DataGridViewRow с данными из выбранной строки 
                DataGridViewRow Mail = dataGridView1.Rows[StringNumber];
                //загружаем форму с передачей выбранной строки
                new Mail_Form(null, Mail).Show();
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //поиск по определенным полям
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            //если выбрано одно из полей
            if (EmailFromRadioBtn.Checked)
            {
                //фильтруем значения
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("From like '{0}%'", SearchTextBox.Text);
            }
            else if(SubjectRadioBtn.Checked)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Subject like '{0}%'", SearchTextBox.Text);
            }
            else if (ContentRadioBtn.Checked)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Content like '{0}%'", SearchTextBox.Text);
            }
            else if (TagsRadioBtn.Checked)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Tags like '{0}%'", SearchTextBox.Text);
            }
            
        }

        private void DateRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            //если выбрано поле "Date"
            if (DateRadioBtn.Checked)
            {
                //делаем видимым datetimepicker
                dateTimePicker1.Visible = true;
                //(dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Date = #" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "#");
                //скрываем поля поиска
                SearchTextBox.Enabled = false;
            }
            else
            {
                dateTimePicker1.Visible = false;
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
                SearchTextBox.Enabled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("Date = #" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "#");
        }
    }
}
