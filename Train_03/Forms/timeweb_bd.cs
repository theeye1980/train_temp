using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Train_03.Forms
{
    public partial class timeweb_bd : Form
    {
        public timeweb_bd()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //"Data Source=MyServerAddress;Initial Catalog=MyDatabase;User ID=UserLogin;Pwd=UserPass;"
                //string myConnectionString = "Database=theeye_calendar;Data Source=92.53.96.116;User Id=theeye_calendar;Password=zG44XMwC";
                //string constr_m = "Data Source=92.53.96.116;Initial Catalog=theeye_calendar;User ID=theeye_calendar;Pwd=zG44XMwC;";

                //string constr = "Server=92.53.96.116;Database=theeye_calendar;Uid=theeye_calendar;pwd=zG44XMwC;charset=utf-8;";
                //MySqlConnection myconn = new MySqlConnection(myConnectionString);

                //myconn.Open();
                //MessageBox.Show("Гы");
                //myconn.Close();

                //MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder();
                //mysqlCSB.Server = "92.53.96.116";  // IP адоес БД
                //mysqlCSB.Database = "theeye_calendar";    // Имя БД
                //mysqlCSB.UserID = "theeye_calendar";        // Имя пользователя БД
                //mysqlCSB.Password = "zG44XMwC";   // Пароль пользователя БД
                //mysqlCSB.CharacterSet = "utf-8"; // Кодировка Базы Данных

                //MySqlConnection myconn = new MySqlConnection(mysqlCSB.ConnectionString);
                //myconn.Open();
                //MessageBox.Show("Гы");
                //myconn.Close();
                /*
                string constr = "Server=92.53.96.116;User ID=theeye_calendar;Password=zG44XMwC;Database=theeye_calendar";
                using (var connection = new MySqlConnection(constr))
                {
                    connection.Open();

                    using (var command = new MySqlCommand("SELECT * FROM events", connection))
                    using (var reader = await command.ExecuteReaderAsync())
                        while (await reader.ReadAsync()) { 
                            Console.WriteLine(reader.GetString(0));
                            Console.WriteLine(reader.GetString(1));
                            Console.WriteLine(reader.GetString(2));

                        }



                    // Retrieve all rows

                }*/
            }
            catch { MessageBox.Show("Чет не то (("); }
                
        }

    }
}
