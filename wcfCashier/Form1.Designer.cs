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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_pesanan = new System.Windows.Forms.ComboBox();
            this.label_ttlhrg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_jmlPEsan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pesanan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Harga";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 270);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "label_nobill";
            // 
            // comboBox_pesanan
            // 
            this.comboBox_pesanan.FormattingEnabled = true;
            this.comboBox_pesanan.Location = new System.Drawing.Point(399, 152);
            this.comboBox_pesanan.Name = "comboBox_pesanan";
            this.comboBox_pesanan.Size = new System.Drawing.Size(121, 24);
            this.comboBox_pesanan.TabIndex = 5;
            // 
            // label_ttlhrg
            // 
            this.label_ttlhrg.AutoSize = true;
            this.label_ttlhrg.Location = new System.Drawing.Point(396, 230);
            this.label_ttlhrg.Name = "label_ttlhrg";
            this.label_ttlhrg.Size = new System.Drawing.Size(46, 17);
            this.label_ttlhrg.TabIndex = 6;
            this.label_ttlhrg.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Jumlah Pesanan";
            // 
            // textBox_jmlPEsan
            // 
            this.textBox_jmlPEsan.Location = new System.Drawing.Point(399, 194);
            this.textBox_jmlPEsan.Name = "textBox_jmlPEsan";
            this.textBox_jmlPEsan.Size = new System.Drawing.Size(100, 22);
            this.textBox_jmlPEsan.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_jmlPEsan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_ttlhrg);
            this.Controls.Add(this.comboBox_pesanan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_pesanan;
        private System.Windows.Forms.Label label_ttlhrg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_jmlPEsan;
    }
}

