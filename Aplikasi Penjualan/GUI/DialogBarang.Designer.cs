
namespace Aplikasi_Penjualan.GUI
{
    partial class DialogBarang
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
            this.pilih = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pilih_barang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textnama = new System.Windows.Forms.TextBox();
            this.textharga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textcari = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pilih_barang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pilih
            // 
            this.pilih.Location = new System.Drawing.Point(282, 18);
            this.pilih.Name = "pilih";
            this.pilih.Size = new System.Drawing.Size(117, 41);
            this.pilih.TabIndex = 0;
            this.pilih.Text = "Pilih";
            this.pilih.UseVisualStyleBackColor = true;
            this.pilih.Click += new System.EventHandler(this.pilih_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(89, 18);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(168, 20);
            this.txtid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Barang       :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pilih_barang);
            this.panel1.Location = new System.Drawing.Point(12, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 162);
            this.panel1.TabIndex = 3;
            // 
            // pilih_barang
            // 
            this.pilih_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pilih_barang.Location = new System.Drawing.Point(3, 16);
            this.pilih_barang.Name = "pilih_barang";
            this.pilih_barang.Size = new System.Drawing.Size(393, 155);
            this.pilih_barang.TabIndex = 0;
            this.pilih_barang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pilih_barang_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama Barang :";
            // 
            // textnama
            // 
            this.textnama.Enabled = false;
            this.textnama.Location = new System.Drawing.Point(88, 45);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(169, 20);
            this.textnama.TabIndex = 5;
            // 
            // textharga
            // 
            this.textharga.Location = new System.Drawing.Point(89, 72);
            this.textharga.Name = "textharga";
            this.textharga.Size = new System.Drawing.Size(168, 20);
            this.textharga.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Harga      :";
            // 
            // textcari
            // 
            this.textcari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textcari.Location = new System.Drawing.Point(268, 97);
            this.textcari.Name = "textcari";
            this.textcari.Size = new System.Drawing.Size(128, 20);
            this.textcari.TabIndex = 8;
            this.textcari.TextChanged += new System.EventHandler(this.textcari_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textcari);
            this.panel2.Controls.Add(this.pilih);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textnama);
            this.panel2.Controls.Add(this.textharga);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Location = new System.Drawing.Point(9, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 122);
            this.panel2.TabIndex = 4;
            // 
            // DialogBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 318);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DialogBarang";
            this.Text = "DialogBarang";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pilih_barang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pilih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textcari;
        private System.Windows.Forms.DataGridView pilih_barang;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox textnama;
        public System.Windows.Forms.TextBox textharga;
    }
}