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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wCF_CashierDataSet1.Billpesan' table. You can move, or remove it, as needed.
            this.billpesanTableAdapter.Fill(this.wCF_CashierDataSet1.Billpesan);

        }

        private void button_cari_Click(object sender, EventArgs e)
        {
            try
            {
                this.billpesanTableAdapter.FillBy(this.wCF_CashierDataSet1.Billpesan, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Text, typeof(System.DateTime))))));
                this.dataGridView1.Refresh();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            //try
            //    {
            //        this.hasaL1TableAdapter.FillBy6(this.hasilLautDataSet.HasaL1, dateTimePicker_cari.Text);
            //        this.reportViewer1.RefreshReport();
            //    }
            //    catch (System.Exception ex)
            //    {
            //        System.Windows.Forms.MessageBox.Show(ex.Message);
            //    }
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.billpesanTableAdapter.FillBy(this.wCF_CashierDataSet1.Billpesan, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(tgl_PemesananToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
