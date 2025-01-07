using MySql.Data.MySqlClient;
using P12_714230044.controller;
using P12_714230044.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P12_714230044.view
{
    public partial class FormTransaksi : Form
    {
        koneksi koneksi = new koneksi();
        M_transaksi m_Transaksi = new M_transaksi();
        string id_transaksi;

        public FormTransaksi()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            dataTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, t_barang.id_barang, nama_barang, harga, qty, total FROM t_transaksi JOIN t_barang ON t_barang.id_barang = t_transaksi.id_barang");
            dataTransaksi.Columns[0].HeaderText = "ID";
            dataTransaksi.Columns[1].HeaderText = "ID Barang";
            dataTransaksi.Columns[2].HeaderText = "Nama Barang";
            dataTransaksi.Columns[3].HeaderText = "Harga";
            dataTransaksi.Columns[4].HeaderText = "Quantity";
            dataTransaksi.Columns[5].HeaderText = "Total Harga";

            dataTransaksi.Columns[3].DefaultCellStyle.Format = "Rp ###,###";
            dataTransaksi.Columns[5].DefaultCellStyle.Format = "Rp ###,###";
        }
        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataBarang();
        }

        public void GetDataBarang()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_barang");
            while (reader.Read())
            {
                int id_barang = reader.GetInt32("id_barang");
                comboBoxID.Items.Add(id_barang.ToString());
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void dataTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_transaksi = dataTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBoxID.Text = dataTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxQuantity.Text = dataTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        public void getNamaBarang()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_barang WHERE id_barang = '" + comboBoxID.Text + "'");
            while (reader.Read())
            {
                string nama_barang = reader.GetString("nama_barang");
                textBoxNama.Text = nama_barang;
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void getHargaBarang()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_barang WHERE id_barang = '" + comboBoxID.Text + "'");
            while (reader.Read())
            {
                int harga = reader.GetInt32("harga");
                textBoxHarga.Text = harga.ToString();
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        public void getTotal()
        {
            if (int.TryParse(textBoxQuantity.Text, out int qty) && int.TryParse(textBoxHarga.Text, out int harga))
            {
                int total = qty * harga;
                textBoxTotal.Text = total.ToString();
            }
        }

        private void comboBoxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            getNamaBarang();
            getHargaBarang();
            getTotal();
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            getTotal();
        }

        private void textBoxPencarian_TextChanged(object sender, EventArgs e)
        {
            dataTransaksi.DataSource = koneksi.ShowData("SELECT id_transaksi, t_barang.id_barang, nama_barang, harga, qty, total FROM t_transaksi JOIN t_barang ON t_barang.id_barang = t_transaksi.id_barang WHERE id_transaksi LIKE '%" + textBoxPencarian.Text + "%' OR t_barang.id_barang LIKE '%" + textBoxPencarian.Text + "%' OR nama_barang LIKE '%" + textBoxPencarian.Text + "%' OR harga LIKE '%" + textBoxPencarian.Text + "%' OR qty LIKE '%" + textBoxPencarian.Text + "%' OR total LIKE '%" + textBoxPencarian.Text + "%'");
        }

        public void Reset()
        {
            comboBoxID.SelectedIndex = -1;
            textBoxNama.Text = "";
            textBoxHarga.Text = "";
            textBoxQuantity.Text = "";
            textBoxTotal.Text = "";
            textBoxPencarian.Text = "";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (comboBoxID.SelectedIndex == -1 || textBoxQuantity.Text == "" || textBoxTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiBarang transaksi = new TransaksiBarang();
                m_Transaksi.Id_barang = comboBoxID.Text;
                m_Transaksi.Qty = textBoxQuantity.Text;
                m_Transaksi.Total = textBoxTotal.Text;
                transaksi.Insert(m_Transaksi);
                Reset();
                Tampil();
            }
        }

        private void buttonRubah_Click(object sender, EventArgs e)
        {
            if (comboBoxID.SelectedIndex == -1 || textBoxQuantity.Text == "" || textBoxTotal.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TransaksiBarang transaksi = new TransaksiBarang();
                m_Transaksi.Id_barang = comboBoxID.Text;
                m_Transaksi.Qty = textBoxQuantity.Text;
                m_Transaksi.Total = textBoxTotal.Text;
                transaksi.Update(m_Transaksi, id_transaksi);
                Reset();
                Tampil();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                TransaksiBarang transaksi = new TransaksiBarang();
                transaksi.Delete(id_transaksi);
                Reset();
                Tampil();
            }
        }
    }
}
