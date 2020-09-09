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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `bus`", db.getConnection());


            adapter.SelectCommand = command;
            adapter.Fill(table);

            Rasp.DataSource = table;
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `bus` WHERE `Пункт отправки` = @uL AND `Пункт прибытия` = @uP ORDER BY `Дата`, `Время отправки`", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = PunktA.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PunktB.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            Rasp.DataSource = table;
        }

        private void buybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 buyform = new Form3();
            buyform.Show();
        }

        

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rebuybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 rebuyform = new Form4();
            rebuyform.Show();
        }

        private void Pers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 persform = new Form5();
            persform.Show();

            Form5 fm5 = new Form5();
            fm5.loginbox.Text = Person.Login;
        }

        private void PunktA_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
