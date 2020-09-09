using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kyrs
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string loginl = logtextBox1.Text;
            string passl = passtextBox1.Text;

            Person person = new Person();

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `пользователи` WHERE `login` = @uL AND `password` = @uP", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginl;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passl;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) {
                
                this.Hide();
                Person.Login = loginl;
                //MessageBox.Show(Person.Login);
                Form2 mainform = new Form2();
                mainform.Show();
            }
            else
                MessageBox.Show("Неправильный логин или пароль");


        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            if (logtextBox2.Text == "")
            {
                MessageBox.Show("Вы не ввели логин");
                return ;
            }
            if (passtextBox2.Text == "") 
            {
                MessageBox.Show("Вы не ввели пароль");
                return ;
            }

            if (chekUser() == true)
                return ;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `пользователи` (`login`, `password`) VALUES (@log, @pass)", db.getConnection());
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = logtextBox2.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passtextBox2.Text;

            db.openconnection();

            if (command.ExecuteNonQuery() == 1)
            
                MessageBox.Show("Аккаунт создан");
            
            else
                MessageBox.Show("Аккаунт не создан, проверьте данные");

            db.closeconnection();
        }
        public Boolean chekUser()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `пользователи` WHERE `login` = @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = logtextBox2.Text;
            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пльзователь уже существует");
                return true;
            }
            else
            {
                
                return false;
            }
        }

        
    }
}
