﻿namespace wcfCashier
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_cari = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.iDBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglPemesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jmlPesanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalhargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billpesanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wCF_CashierDataSet4 = new wcfCashier.WCF_CashierDataSet4();
            this.billpesanTableAdapter = new wcfCashier.WCF_CashierDataSet4TableAdapters.BillpesanTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billpesanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCF_CashierDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_cari);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(72, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 321);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CARI BILL";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_cari
            // 
            this.button_cari.Location = new System.Drawing.Point(563, 33);
            this.button_cari.Name = "button_cari";
            this.button_cari.Size = new System.Drawing.Size(75, 23);
            this.button_cari.TabIndex = 3;
            this.button_cari.Text = "Cari";
            this.button_cari.UseVisualStyleBackColor = true;
            this.button_cari.Click += new System.EventHandler(this.button_cari_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(516, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBillDataGridViewTextBoxColumn,
            this.tglPemesananDataGridViewTextBoxColumn,
            this.iDMenuDataGridViewTextBoxColumn,
            this.jmlPesanaDataGridViewTextBoxColumn,
            this.totalhargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.billpesanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 230);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(365, 396);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // iDBillDataGridViewTextBoxColumn
            // 
            this.iDBillDataGridViewTextBoxColumn.DataPropertyName = "ID_Bill";
            this.iDBillDataGridViewTextBoxColumn.HeaderText = "ID_Bill";
            this.iDBillDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDBillDataGridViewTextBoxColumn.Name = "iDBillDataGridViewTextBoxColumn";
            this.iDBillDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDBillDataGridViewTextBoxColumn.Width = 125;
            // 
            // tglPemesananDataGridViewTextBoxColumn
            // 
            this.tglPemesananDataGridViewTextBoxColumn.DataPropertyName = "Tgl_Pemesanan";
            this.tglPemesananDataGridViewTextBoxColumn.HeaderText = "Tgl_Pemesanan";
            this.tglPemesananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tglPemesananDataGridViewTextBoxColumn.Name = "tglPemesananDataGridViewTextBoxColumn";
            this.tglPemesananDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDMenuDataGridViewTextBoxColumn
            // 
            this.iDMenuDataGridViewTextBoxColumn.DataPropertyName = "ID_Menu";
            this.iDMenuDataGridViewTextBoxColumn.HeaderText = "ID_Menu";
            this.iDMenuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDMenuDataGridViewTextBoxColumn.Name = "iDMenuDataGridViewTextBoxColumn";
            this.iDMenuDataGridViewTextBoxColumn.Width = 125;
            // 
            // jmlPesanaDataGridViewTextBoxColumn
            // 
            this.jmlPesanaDataGridViewTextBoxColumn.DataPropertyName = "jml_Pesana";
            this.jmlPesanaDataGridViewTextBoxColumn.HeaderText = "jml_Pesana";
            this.jmlPesanaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jmlPesanaDataGridViewTextBoxColumn.Name = "jmlPesanaDataGridViewTextBoxColumn";
            this.jmlPesanaDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalhargaDataGridViewTextBoxColumn
            // 
            this.totalhargaDataGridViewTextBoxColumn.DataPropertyName = "Totalharga";
            this.totalhargaDataGridViewTextBoxColumn.HeaderText = "Totalharga";
            this.totalhargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalhargaDataGridViewTextBoxColumn.Name = "totalhargaDataGridViewTextBoxColumn";
            this.totalhargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // billpesanBindingSource
            // 
            this.billpesanBindingSource.DataMember = "Billpesan";
            this.billpesanBindingSource.DataSource = this.wCF_CashierDataSet4;
            // 
            // wCF_CashierDataSet4
            // 
            this.wCF_CashierDataSet4.DataSetName = "WCF_CashierDataSet4";
            this.wCF_CashierDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billpesanTableAdapter
            // 
            this.billpesanTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billpesanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCF_CashierDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_cari;
        private System.Windows.Forms.Button btn_back;
        private WCF_CashierDataSet4 wCF_CashierDataSet4;
        private System.Windows.Forms.BindingSource billpesanBindingSource;
        private WCF_CashierDataSet4TableAdapters.BillpesanTableAdapter billpesanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglPemesananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jmlPesanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalhargaDataGridViewTextBoxColumn;
    }
}