using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wcfCashier
{
    public partial class Form1 : Form
    {
        string menu, harga;
        public Form1()
        {
            InitializeComponent();
            label_ttlhrg.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            menu = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            harga = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

            label6.Text = menu;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
