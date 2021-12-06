using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplikasi_Penjualan.GUI
{
    public partial class DialogBarang : Form
    {
        public Transaksi transaksi = null;
        Kelas.koneksi koeksi = new Kelas.koneksi();
        public DialogBarang()
        {
            InitializeComponent();
            //Coding 2
            loadDaftar();
            
        }

        private void pilih_barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //coding gride barnag
            txtid.Text = pilih_barang.Rows[e.RowIndex].Cells[0].Value.ToString();
            textnama.Text = pilih_barang.Rows[e.RowIndex].Cells[1].Value.ToString();
            textharga.Text = pilih_barang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        //Coding 1

        public DataSet getData()
        {
            DataSet dts = new DataSet();
            try
            {
                string sql = "SELECT kode_barang, nama_barang, harga_jual, stok FROM tabel_barang";
                MySqlCommand command = new MySqlCommand();
                command.Connection = koeksi.getCon();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                data.Fill(dts, "tabel_barang");
            }
            catch (Exception e)
            {
                MessageBox.Show("get \n" + e.ToString());
            }
            return dts;
        }

        void header()
        {
            pilih_barang.Columns[0].HeaderText = "Kode Barang";
            pilih_barang.Columns[1].HeaderText = "Nama Barang";
            pilih_barang.Columns[2].HeaderText = "Harga Barang";
            pilih_barang.Columns[0].HeaderText = "Stok";
        }

        public void loadDaftar()
        {
            DataSet data = getData();
            pilih_barang.DataSource = data;
            pilih_barang.DataMember = "tabel_barang";
            header();
        }

        private void textcari_TextChanged(object sender, EventArgs e)
        {
            if (textcari.Text == "")
            {
                loadDaftar();
            }
            else
            {
                try
                {
                    string text = textcari.Text;
                    DataSet dts = new DataSet();
                    string sql = "SELECT * FROM tabel_barang WHERE kode_barang LIKE '%" + text + "%' OR nama_barang LIKE '%" + text + "%';";
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = koeksi.getCon();
                    command.CommandType = CommandType.Text;
                    command.CommandText = sql;
                    MySqlDataAdapter data = new MySqlDataAdapter(command);
                    data.Fill(dts, "tabel_barang");
                    pilih_barang.DataSource = dts;
                    pilih_barang.DataMember = "tabel_barang";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("get \n" + ex.ToString());
                }
            }
        }

        private void pilih_Click(object sender, EventArgs e)
        {
            transaksi.textHargaBarang.Text = textharga.Text;

 
            this.Dispose();
        }
    }
}
