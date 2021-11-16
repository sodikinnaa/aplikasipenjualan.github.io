namespace Aplikasi_Penjualan.GUI
{
    partial class Teransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teransaksi));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.datatransaksi = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnew = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btdelt = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btsend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbjenis = new System.Windows.Forms.ComboBox();
            this.textnama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datatransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 46;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 45;
            // 
            // datatransaksi
            // 
            this.datatransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatransaksi.Location = new System.Drawing.Point(34, 213);
            this.datatransaksi.Name = "datatransaksi";
            this.datatransaksi.Size = new System.Drawing.Size(579, 170);
            this.datatransaksi.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(372, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 57);
            this.button1.TabIndex = 43;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnew
            // 
            this.btnew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnew.ForeColor = System.Drawing.Color.Black;
            this.btnew.Location = new System.Drawing.Point(28, 185);
            this.btnew.Name = "btnew";
            this.btnew.Size = new System.Drawing.Size(77, 22);
            this.btnew.TabIndex = 42;
            this.btnew.Text = "Data Baru";
            this.btnew.UseVisualStyleBackColor = false;
            // 
            // btedit
            // 
            this.btedit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btedit.ForeColor = System.Drawing.Color.Black;
            this.btedit.Location = new System.Drawing.Point(194, 185);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(77, 22);
            this.btedit.TabIndex = 41;
            this.btedit.Text = "Edit Data";
            this.btedit.UseVisualStyleBackColor = false;
            // 
            // btdelt
            // 
            this.btdelt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btdelt.ForeColor = System.Drawing.Color.Black;
            this.btdelt.Location = new System.Drawing.Point(365, 185);
            this.btdelt.Name = "btdelt";
            this.btdelt.Size = new System.Drawing.Size(77, 22);
            this.btdelt.TabIndex = 40;
            this.btdelt.Text = "Hapus Data";
            this.btdelt.UseVisualStyleBackColor = false;
            // 
            // btupdate
            // 
            this.btupdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btupdate.ForeColor = System.Drawing.Color.Black;
            this.btupdate.Location = new System.Drawing.Point(277, 185);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(82, 22);
            this.btupdate.TabIndex = 39;
            this.btupdate.Text = "Perbarui Data";
            this.btupdate.UseVisualStyleBackColor = false;
            // 
            // btsend
            // 
            this.btsend.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btsend.ForeColor = System.Drawing.Color.Black;
            this.btsend.Location = new System.Drawing.Point(111, 185);
            this.btsend.Name = "btsend";
            this.btsend.Size = new System.Drawing.Size(77, 22);
            this.btsend.TabIndex = 38;
            this.btsend.Text = "Save";
            this.btsend.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Harga :";
            // 
            // cbjenis
            // 
            this.cbjenis.FormattingEnabled = true;
            this.cbjenis.Location = new System.Drawing.Point(156, 54);
            this.cbjenis.Name = "cbjenis";
            this.cbjenis.Size = new System.Drawing.Size(200, 21);
            this.cbjenis.TabIndex = 36;
            // 
            // textnama
            // 
            this.textnama.Location = new System.Drawing.Point(156, 90);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(200, 20);
            this.textnama.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Kode Barang :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID Transaksi :";
            // 
            // Teransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 420);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.datatransaksi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnew);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btdelt);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btsend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbjenis);
            this.Controls.Add(this.textnama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Teransaksi";
            this.Text = "Teransaksi";
            ((System.ComponentModel.ISupportInitialize)(this.datatransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView datatransaksi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnew;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btdelt;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btsend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbjenis;
        private System.Windows.Forms.TextBox textnama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}