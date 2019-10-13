using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wcfCashier
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label_username_Click(object sender, EventArgs e)
        {

        }

        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void label_password_Click(object sender, EventArgs e)
        {

        }

        private void button_signin_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=DESKTOP-DK319Q3;Initial Catalog=WCF_Cashier;integrated security=True";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select username, password from WCF_Cashier.dbo.accountCashier where username='" + textBox_username.Text + "'and password='" + textBox_password.Text + "'", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (textBox_username.Text == "")
            {
                MessageBox.Show("Isi Username Anda");
            }
            else if (textBox_password.Text == "")
            {
                MessageBox.Show("Isi Password Anda");
            }
            else if (dataTable.Rows.Count > 0)
            {
                Form1 welcome = new Form1();
                this.Hide();
                welcome.Show();
            }
            else
            {
                MessageBox.Show("Username atau Password anda salah!!!");
            }
            sqlConnection.Close();
        }
    }
}
