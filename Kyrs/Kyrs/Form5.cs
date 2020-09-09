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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            loginbox.Text = Person.Met();
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

        private void showtiketbutton_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `номер билета`, `Имя`, `Фамилия`, `номер рейса`, `Пункт отправки`, `Время отправки` FROM `купленные билеты` WHERE `логин пользователя` = @uL ", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Person.Login;
            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table;
        }
        private void loginbox_Click(object sender, EventArgs e)
        {
            
        }

        private void rebuybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 rebuyform = new Form4();
            rebuyform.Show();
        }
    }
}

