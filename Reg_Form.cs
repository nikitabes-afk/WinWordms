using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WinFormsApp1;
using WinForms;

namespace WinFormsApp1
{
    public partial class Reg_Form : Form
    {
        DB database = new DB();
        public Reg_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Reg_Button_Click(object sender, EventArgs e)
        {

            var password = Box_Pass.Text;
            var login = Box_Login.Text;

            string querystring = $"insert into register(login_user, password_user) values('{login}', {password})";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            database.openConnetcion();

            bool k 

            if()
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан", "Успех!");
                LoginForm LoginFrm = new LoginForm();
                this.Hide();
                LoginFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }
            database.closeConnetcion();

        }

        private Boolean checkuser()
        {

            var password = Box_Pass.Text;
            var login = Box_Login.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystrin = $"select id_user, login_user, password_user from register where login_user = '{login}',and password_user = '{password}'";
            SqlCommand command = new SqlCommand(querystrin, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует");
                return true;
            }
            else
                return false;
        }
    }
}
