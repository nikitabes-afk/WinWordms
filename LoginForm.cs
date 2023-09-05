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

namespace WinForms
{
    public partial class LoginForm : Form
    {
        DB database = new DB();
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.passField.AutoSize = false;
            int sizeHeidhtloginField = this.loginField.Size.Height;
            this.passField.Size = new Size(this.passField.Size.Width, sizeHeidhtloginField);
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            this.closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            this.closeButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passUser = passField.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string qweryString = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(qweryString, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm frm1 = new LoginForm();
                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Не удалось войти!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Label_Reg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reg_Form frem_reg = new Reg_Form();
            frem_reg.Show();
            this.Hide();
        }
    }
}
