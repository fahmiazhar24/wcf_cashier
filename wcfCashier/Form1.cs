using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wcfCashier.ServiceReference1;

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

            //ADDRESS
            //Uri ba = new Uri("http://localhost:8000/");
            //ServiceHost host = new ServiceHost(typeof(Hello_Service.Hello), ba);

            //BINDING
            //BasicHttpBinding bind = new BasicHttpBinding();

            //CONTRACT
            //host.AddServiceEndpoint(typeof(Hello_Service.IHello), bind, "hello");

            //ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            //smb.HttpGetEnabled = true;
            //host.Description.Behaviors.Add(smb);
            //host.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        private void textBox_jmlPEsan_TextChanged(object sender, EventArgs e)
        {
            //Service ok = new Service();
            //ok.Kalkulasi(textBox_jmlPEsan.Text, harga);
            //label_ttlhrg.Text = ttlhrgg;
            try
            {
                if (Convert.ToInt32(textBox_jmlPEsan.Text) > 50)
                {
                    MessageBox.Show("Salah boy");
                }
                int x = Convert.ToInt32(harga);
                int jumlah = Convert.ToInt32(textBox_jmlPEsan.Text);
                int total = x * jumlah;
                label_ttlhrg.Text = "Rp " + Convert.ToString(total);
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

        private void button_exit_Click(object sender, EventArgs e)
        {
            Login a = new Login();
            this.Hide();
            a.Show();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            b.idmenu = Convert.ToInt32(id);
            b.jmlpesan = textBox_jmlPEsan.Text;
            b.ttlhrg = label_ttlhrg.Text;
            b.tglpesan = dateTimePicker1.Value.Date;

            Service1Client service = new Service1Client();

            if (service.InsertBill(b) == 1)
            {
                MessageBox.Show("Sukses");
            }

            MessageBox.Show("Bill Insert Successfuly");
            TextWriter txt = new StreamWriter("C:\\Users\\THORIQ\\Documents\\Bill\\" +
                "nota_" + Convert.ToString(b.idmenu) + ".txt");
            txt.WriteLine("ID Bill   : " + b.idmenu);
            txt.WriteLine("Nama Pesanan  : " + label6.Text);
            txt.WriteLine("Jumlah Pesanan : " + b.jmlpesan);
            txt.WriteLine("Total Harga  : " + b.ttlhrg);
            txt.WriteLine("Tanggal  : " + b.tglpesan);
            txt.Close();
            Process.Start("C:\\Users\\THORIQ\\Documents\\Bill\\" +
                "nota_" + Convert.ToString(b.idmenu) + ".txt");



            //SqlConnection sqlConnection = new SqlConnection();
            //sqlConnection.ConnectionString = @"Data Source=DESKTOP-DK319Q3;Initial Catalog=WCF_Cashier;integrated security=True";
            //sqlConnection.Open();
            //SqlCommand sqlCommand = new SqlCommand("insert into BillPesan(Tgl_Pemesanan,ID_Menu,jml_Pesana,Totalharga) values(@Tgl_Pemesanan,@ID_Menu,@jml_Pesana,@Totalharga)", sqlConnection);
            //sqlCommand.Parameters.AddWithValue("@Tgl_Pemesanan", dateTimePicker1.Value.Date);
            //sqlCommand.Parameters.AddWithValue("@ID_Menu", id);
            //sqlCommand.Parameters.AddWithValue("@jml_Pesana", textBox_jmlPEsan.Text);
            //sqlCommand.Parameters.AddWithValue("@Totalharga", label_ttlhrg.Text);
            //sqlCommand.ExecuteNonQuery();
            //sqlConnection.Close();
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
