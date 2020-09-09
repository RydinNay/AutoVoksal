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
    public partial class Form4 : Form
    {
        public Form4()
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

        private void rebuybuttonchek_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `номер билета` FROM `купленные билеты` WHERE `логин пользователя` = @uL ", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Person.Login;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void rebuybutton_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            DataTable table1 = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `купленные билеты` WHERE `логин пользователя` = @uL AND `номер билета` = @num", db.getConnection());

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `купленные билеты` WHERE `логин пользователя` = @ul", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Person.Login;
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = numerbox.Text;

            command1.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Person.Login;

            adapter.SelectCommand = command1;
            adapter.Fill(table);

            if (numerbox.Text == "") 
            {
                return;
            }

            if (table.Rows.Count == 0) 
            {
                MessageBox.Show("У вас нет купленных билетов");
                return ;
            } 

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 0) 
            {
                MessageBox.Show("Вы ввели не правильный билет");
                return;
            }

            MySqlCommand command2 = new MySqlCommand("DELETE FROM `купленные билеты` WHERE `логин пользователя` = @uL AND `номер билета` = @num", db.getConnection());
            command2.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Person.Login;
            command2.Parameters.Add("@num", MySqlDbType.Int32).Value = Convert.ToInt32(numerbox.Text);


            MySqlCommand command4 = new MySqlCommand("SELECT * FROM `bus` WHERE `номер рейса` = @rec", db.getConnection());

            int index = Convert.ToInt32(table.Rows[0]["номер билета"])%1000000/10000;

            command4.Parameters.Add("@rec", MySqlDbType.Int32).Value = index;

            MessageBox.Show(Convert.ToString(index));

            //MessageBox.Show(command4.Parameters.);

            //MySqlDataAdapter adapter1 = new MySqlDataAdapter();

            adapter.SelectCommand = command4;
            adapter.Fill(table1);

            MessageBox.Show(Convert.ToString(table1.Columns[1]));

            MessageBox.Show(Convert.ToString(command4));

            int index1 = Convert.ToInt32(table1.Rows[0]["Кол-во купленных билетов"]) - 1;

            MySqlCommand command3 = new MySqlCommand("UPDATE `bus` SET `Кол-во купленных билетов` = @num WHERE `номер рейса` LIKE @rec", db.getConnection());
            
            command3.Parameters.Add("@num", MySqlDbType.Int32).Value = index1;
            command3.Parameters.Add("@rec", MySqlDbType.Int32).Value = index;

            db.openconnection();

            if (command2.ExecuteNonQuery() == 1 && command3.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Билет перепродан");
            }
            else MessageBox.Show("Произошла ошибка, попробуйте еще раз");


            db.closeconnection();

            
        }

        private void numerbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

