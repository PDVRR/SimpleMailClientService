using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MailService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        //строка подключения к базе данных
        string conString = "Data Source=(local);Initial Catalog=Mail_DB;Integrated Security=True";

        //функция отправки сообщения
        public string SendMail(string subject, DateTime date, string emailTo, string emailFrom, string tags, string content)
        {
            try
            {
                //используя sql соединение
                using (SqlConnection con = new SqlConnection(conString))
                {
                    //открываем соединение с бд
                    con.Open();
                    //создаем команду для запроса к бд
                    SqlCommand sqlCmd = new SqlCommand("INSERT INTO Mails VALUES(@subject, @date, @to, @from, @tags, @content)", con);
                    //добавляем параметры
                    sqlCmd.Parameters.AddWithValue("subject", subject);
                    sqlCmd.Parameters.AddWithValue("date", date);
                    sqlCmd.Parameters.AddWithValue("to", emailTo);
                    sqlCmd.Parameters.AddWithValue("from", emailFrom);
                    sqlCmd.Parameters.AddWithValue("tags", tags);
                    sqlCmd.Parameters.AddWithValue("content", content);

                    //если выполнено без ошибок возвращяем строку о успешной отправке
                    if (sqlCmd.ExecuteNonQuery() == 1)
                    {
                        return "Email sent successfully";
                    }
                    else //иначе ошибку
                    {
                        return "Email doesn't sent";
                    }
                    
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        //функция получения входящих сообщений
        public DataTable GetInboxMessages(string emailTo)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    //создаем SqlDataAdapter для заполнения datatable
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Mails where [To] = '" + emailTo + "'", con);

                    DataTable dataTable = new DataTable();
                    //заполняем datatable
                    dataAdapter.Fill(dataTable);
                    dataTable.TableName = "TodoItems";
                    return dataTable;

                }
            }
            catch 
            {
                return null;
            }
        }
        //функция получения отправленных сообщений
        public DataTable GetSentMessages(string emailFrom)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Mails where [From] = '" + emailFrom + "'", con);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataTable.TableName = "TodoItems";
                    return dataTable;

                }
            }
            catch
            {
                return null;
            }
        }
    }
}
