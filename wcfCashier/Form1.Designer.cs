namespace wcfCashier
{
    partial class Form1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_ttlhrg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_jmlPEsan = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wCF_CashierDataSet = new wcfCashier.WCF_CashierDataSet();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuTableAdapter = new wcfCashier.WCF_CashierDataSetTableAdapters.menuTableAdapter();
            this.iDMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wCF_CashierDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label_ttlhrg
            // 
            this.label_ttlhrg.AutoSize = true;
            this.label_ttlhrg.Location = new System.Drawing.Point(272, 124);
            this.label_ttlhrg.Name = "label_ttlhrg";
            this.label_ttlhrg.Size = new System.Drawing.Size(46, 17);
            this.label_ttlhrg.TabIndex = 6;
            this.label_ttlhrg.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Harga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Jumlah Pesanan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pesanan";
            // 
            // textBox_jmlPEsan
            // 
            this.textBox_jmlPEsan.Location = new System.Drawing.Point(275, 88);
            this.textBox_jmlPEsan.Name = "textBox_jmlPEsan";
            this.textBox_jmlPEsan.Size = new System.Drawing.Size(150, 22);
            this.textBox_jmlPEsan.TabIndex = 8;
            this.textBox_jmlPEsan.TextChanged += new System.EventHandler(this.textBox_jmlPEsan_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMenuDataGridViewTextBoxColumn,
            this.namaMenuDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.menuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(454, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(221, 205);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "label_Pesanan";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(20, 227);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(94, 26);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "PRINT";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "VIEW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBox_jmlPEsan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_ttlhrg);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(45, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 287);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CASHIER";
            // 
            // wCF_CashierDataSet
            // 
            this.wCF_CashierDataSet.DataSetName = "WCF_CashierDataSet";
            this.wCF_CashierDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "menu";
            this.menuBindingSource.DataSource = this.wCF_CashierDataSet;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // iDMenuDataGridViewTextBoxColumn
            // 
            this.iDMenuDataGridViewTextBoxColumn.DataPropertyName = "ID_Menu";
            this.iDMenuDataGridViewTextBoxColumn.HeaderText = "ID_Menu";
            this.iDMenuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDMenuDataGridViewTextBoxColumn.Name = "iDMenuDataGridViewTextBoxColumn";
            this.iDMenuDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDMenuDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaMenuDataGridViewTextBoxColumn
            // 
            this.namaMenuDataGridViewTextBoxColumn.DataPropertyName = "Nama_Menu";
            this.namaMenuDataGridViewTextBoxColumn.HeaderText = "Nama_Menu";
            this.namaMenuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaMenuDataGridViewTextBoxColumn.Name = "namaMenuDataGridViewTextBoxColumn";
            this.namaMenuDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wCF_CashierDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_ttlhrg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_jmlPEsan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private WCF_CashierDataSet wCF_CashierDataSet;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private WCF_CashierDataSetTableAdapters.menuTableAdapter menuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
    }
}

