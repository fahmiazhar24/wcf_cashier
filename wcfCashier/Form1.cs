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
    public partial class Form1 : Form
    {
        string menu, harga, id;
        public Form1()
        {
            InitializeComponent();
            label_ttlhrg.Text = "0";
            label6.Text = "menu";
            dateTimePicker1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void textBox_jmlPEsan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                int x = Convert.ToInt32(harga);
                int jumlah = Convert.ToInt32(textBox_jmlPEsan.Text);
                int total = x * jumlah;
                label_ttlhrg.Text = "Rp "+ Convert.ToString(total);
            }
            catch
            {

            }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wCF_CashierDataSet.menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.wCF_CashierDataSet.menu);
            // TODO: This line of code loads data into the 'wCF_CashierDataSet2.menu' table. You can move, or remove it, as needed.
            //this.menuTableAdapter.Fill(this.wCF_CashierDataSet2.menu);


        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=DESKTOP-DK319Q3;Initial Catalog=WCF_Cashier;integrated security=True";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into BillPesan(Tgl_Pemesanan,ID_Menu,jml_Pesana,Totalharga) values(@Tgl_Pemesanan,@ID_Menu,@jml_Pesana,@Totalharga)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Tgl_Pemesanan", dateTimePicker1.Value.Date);
            sqlCommand.Parameters.AddWithValue("@ID_Menu", id);
            sqlCommand.Parameters.AddWithValue("@jml_Pesana", textBox_jmlPEsan.Text);
            sqlCommand.Parameters.AddWithValue("@Totalharga", label_ttlhrg.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            menu = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            harga = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            id = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            label6.Text = menu;

        }
    }
}
