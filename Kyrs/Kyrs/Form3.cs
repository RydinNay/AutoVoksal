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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 mainform = new Form2();
            mainform.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 persform = new Form5();
            persform.Show();
            Form5 fm5 = new Form5();
            fm5.loginbox.Text = Person.Login;
            
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `bus` WHERE `Пункт отправки` = @uL AND `Пункт прибытия` = @uP AND `Кол-во купленных билетов` < `Кол-во пассажиров` ORDER BY `Дата`, `Время отправки`", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = PunktA.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PunktB.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            Rasp.DataSource = table;
        }

        private void buy_Click(object sender, EventArgs e)
        {
            if (numer.Text == "")
            {
                MessageBox.Show("Вы не ввели номер билета");
                return;
            }

            if (name.Text == "")
            {
                MessageBox.Show("Вы не ввели номер Имя");
                return;
            }

            if (surename.Text == "")
            {
                MessageBox.Show("Вы не ввели номер Фамилию");
                return;
            }


            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `bus` WHERE `номер рейса` = @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = numer.Text;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (Convert.ToInt64(table.Rows[0]["Кол-во пассажиров"]) <= Convert.ToInt64(table.Rows[0]["Кол-во купленных билетов"]))
            {
                MessageBox.Show("Извините но все билеты на этот рейс уже распроданы");
                //return ;
            }
            else 
            {
                int num=10000000;
                num = num + Convert.ToInt32(numer.Text) * 10000 ;

                DataTable table2 = new DataTable();
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();

                MySqlCommand command3 = new MySqlCommand("SELECT * FROM `купленные билеты` WHERE `номер рейса` = @rec ORDER BY `номер билета`", db.getConnection());
                command3.Parameters.Add("@rec", MySqlDbType.Int32).Value = Convert.ToInt32(numer.Text);

                adapter1.SelectCommand = command3;
                adapter1.Fill(table2);
                int a = 0, b = 0;
                Boolean t = true;
                if(table2.Rows.Count != 0)
                for(int i = 0; i < table2.Rows.Count; ++i) 
                {
                    a = Convert.ToInt32(table2.Rows[i]["номер билета"])%1000;
                    if (a - b > 1) 
                    {
                        num = num + b + 1;
                        t = false;
                        i = table2.Rows.Count;
                    }
                    b = a;
                    MessageBox.Show(Convert.ToString(num));
                }

                if (t == true) 
                {
                    num = num + Convert.ToInt32(table.Rows[0]["кол-во купленных билетов"]) + 1;
                }

                MySqlCommand command1 = new MySqlCommand ("INSERT INTO `купленные билеты` (`номер билета`, `логин пользователя`, `Имя`, `Фамилия`, `номер рейса`, `Пункт отправки`, `Время отправки`) VALUES (@numer, @log, @name, @surename, @rec, @punkt, @time)", db.getConnection());
                command1.Parameters.Add("@numer", MySqlDbType.Int32).Value = num;
                command1.Parameters.Add("@log", MySqlDbType.VarChar).Value = Person.Login;
                command1.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
                command1.Parameters.Add("@surename", MySqlDbType.VarChar).Value = surename.Text;
                command1.Parameters.Add("@rec", MySqlDbType.Int32).Value = table.Rows[0]["номер рейса"];
                command1.Parameters.Add("@punkt", MySqlDbType.VarChar).Value = table.Rows[0]["Пункт отправки"];
                command1.Parameters.Add("@time", MySqlDbType.VarChar).Value = table.Rows[0]["Время отправки"];


                int rec = Convert.ToInt32(table.Rows[0]["номер рейса"]);
                int kup = Convert.ToInt32(table.Rows[0]["Кол-во купленных билетов"])+1;

                MySqlCommand command2 = new MySqlCommand ("UPDATE `bus` SET `Кол-во купленных билетов` = @kup WHERE `номер рейса` LIKE @rec", db.getConnection());
                command2.Parameters.Add("@kup", MySqlDbType.Int32).Value = kup;
                command2.Parameters.Add("@rec", MySqlDbType.Int32).Value = rec;

                db.openconnection();

                if (command1.ExecuteNonQuery() == 1)

                    

                
                if (command2.ExecuteNonQuery() == 1)

                    MessageBox.Show("Поздравляем с покупкой, вы можете посмотреть ваш былет в вашем личном кабинете");

                else
                    MessageBox.Show("Аккаунт не создан, проверьте данные");

                db.closeconnection();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
