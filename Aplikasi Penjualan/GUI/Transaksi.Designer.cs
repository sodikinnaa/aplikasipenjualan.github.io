
namespace Aplikasi_Penjualan.GUI
{
    partial class Transaksi
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
            this.paneltransaksi = new System.Windows.Forms.Panel();
            this.trans = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Barang = new System.Windows.Forms.Panel();
            this.hapus = new System.Windows.Forms.Button();
            this.Tambah = new System.Windows.Forms.Button();
            this.cari = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textJumlah = new System.Windows.Forms.TextBox();
            this.textHargaBarang = new System.Windows.Forms.TextBox();
            this.textNamaBarang = new System.Windows.Forms.TextBox();
            this.textKodeBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dTransaksi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNamaPembeli = new System.Windows.Forms.TextBox();
            this.textidTransaksi = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pembeli = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.paneltransaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trans)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Barang.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltransaksi
            // 
            this.paneltransaksi.Controls.Add(this.trans);
            this.paneltransaksi.Location = new System.Drawing.Point(12, 32);
            this.paneltransaksi.Name = "paneltransaksi";
            this.paneltransaksi.Size = new System.Drawing.Size(702, 116);
            this.paneltransaksi.TabIndex = 0;
            // 
            // trans
            // 
            this.trans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trans.Location = new System.Drawing.Point(0, 3);
            this.trans.Name = "trans";
            this.trans.Size = new System.Drawing.Size(699, 93);
            this.trans.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(291, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 197);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 181);
            this.dataGridView1.TabIndex = 0;
            // 
            // Barang
            // 
            this.Barang.Controls.Add(this.hapus);
            this.Barang.Controls.Add(this.Tambah);
            this.Barang.Controls.Add(this.cari);
            this.Barang.Controls.Add(this.label8);
            this.Barang.Controls.Add(this.label7);
            this.Barang.Controls.Add(this.label6);
            this.Barang.Controls.Add(this.textJumlah);
            this.Barang.Controls.Add(this.textHargaBarang);
            this.Barang.Controls.Add(this.textNamaBarang);
            this.Barang.Controls.Add(this.textKodeBarang);
            this.Barang.Controls.Add(this.label5);
            this.Barang.Location = new System.Drawing.Point(12, 266);
            this.Barang.Name = "Barang";
            this.Barang.Size = new System.Drawing.Size(273, 130);
            this.Barang.TabIndex = 2;
            // 
            // hapus
            // 
            this.hapus.Location = new System.Drawing.Point(184, 104);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(75, 23);
            this.hapus.TabIndex = 19;
            this.hapus.Text = "hapus";
            this.hapus.UseVisualStyleBackColor = true;
            // 
            // Tambah
            // 
            this.Tambah.Location = new System.Drawing.Point(104, 104);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(75, 23);
            this.Tambah.TabIndex = 18;
            this.Tambah.Text = "Tambahkan";
            this.Tambah.UseVisualStyleBackColor = true;
            // 
            // cari
            // 
            this.cari.Location = new System.Drawing.Point(25, 104);
            this.cari.Name = "cari";
            this.cari.Size = new System.Drawing.Size(75, 23);
            this.cari.TabIndex = 14;
            this.cari.Text = "Cari";
            this.cari.UseVisualStyleBackColor = true;
            this.cari.Click += new System.EventHandler(this.cari_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Jumlah";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Harga Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nama Barang";
            // 
            // textJumlah
            // 
            this.textJumlah.Location = new System.Drawing.Point(91, 73);
            this.textJumlah.Name = "textJumlah";
            this.textJumlah.Size = new System.Drawing.Size(168, 20);
            this.textJumlah.TabIndex = 14;
            // 
            // textHargaBarang
            // 
            this.textHargaBarang.Enabled = false;
            this.textHargaBarang.Location = new System.Drawing.Point(91, 51);
            this.textHargaBarang.Name = "textHargaBarang";
            this.textHargaBarang.Size = new System.Drawing.Size(168, 20);
            this.textHargaBarang.TabIndex = 13;
            // 
            // textNamaBarang
            // 
            this.textNamaBarang.Enabled = false;
            this.textNamaBarang.Location = new System.Drawing.Point(91, 29);
            this.textNamaBarang.Name = "textNamaBarang";
            this.textNamaBarang.Size = new System.Drawing.Size(168, 20);
            this.textNamaBarang.TabIndex = 12;
            // 
            // textKodeBarang
            // 
            this.textKodeBarang.Enabled = false;
            this.textKodeBarang.Location = new System.Drawing.Point(91, 7);
            this.textKodeBarang.Name = "textKodeBarang";
            this.textKodeBarang.Size = new System.Drawing.Size(168, 20);
            this.textKodeBarang.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kode Barang";
            // 
            // dTransaksi
            // 
            this.dTransaksi.AutoSize = true;
            this.dTransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTransaksi.Location = new System.Drawing.Point(313, 156);
            this.dTransaksi.Name = "dTransaksi";
            this.dTransaksi.Size = new System.Drawing.Size(138, 20);
            this.dTransaksi.TabIndex = 3;
            this.dTransaksi.Text = "Detail Transaksi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID_Transaksi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama Pembeli :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total :";
            // 
            // textNamaPembeli
            // 
            this.textNamaPembeli.Location = new System.Drawing.Point(94, 32);
            this.textNamaPembeli.Name = "textNamaPembeli";
            this.textNamaPembeli.Size = new System.Drawing.Size(165, 20);
            this.textNamaPembeli.TabIndex = 7;
            // 
            // textidTransaksi
            // 
            this.textidTransaksi.Location = new System.Drawing.Point(94, 10);
            this.textidTransaksi.Name = "textidTransaksi";
            this.textidTransaksi.Size = new System.Drawing.Size(165, 20);
            this.textidTransaksi.TabIndex = 8;
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(94, 55);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(165, 20);
            this.textTotal.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Barang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tanggal :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textNamaPembeli);
            this.panel2.Controls.Add(this.textidTransaksi);
            this.panel2.Controls.Add(this.textTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 88);
            this.panel2.TabIndex = 12;
            // 
            // pembeli
            // 
            this.pembeli.AutoSize = true;
            this.pembeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pembeli.Location = new System.Drawing.Point(23, 161);
            this.pembeli.Name = "pembeli";
            this.pembeli.Size = new System.Drawing.Size(59, 13);
            this.pembeli.TabIndex = 10;
            this.pembeli.Text = "Pembeli :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Simpan Transaksi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Hapus Transaksi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 408);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dTransaksi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pembeli);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Barang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.paneltransaksi);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            this.paneltransaksi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trans)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Barang.ResumeLayout(false);
            this.Barang.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paneltransaksi;
        private System.Windows.Forms.DataGridView trans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Barang;
        private System.Windows.Forms.Label dTransaksi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textJumlah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNamaPembeli;
        private System.Windows.Forms.TextBox textidTransaksi;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label pembeli;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Button Tambah;
        private System.Windows.Forms.Button cari;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textKodeBarang;
        public System.Windows.Forms.TextBox textHargaBarang;
        public System.Windows.Forms.TextBox textNamaBarang;
    }
}