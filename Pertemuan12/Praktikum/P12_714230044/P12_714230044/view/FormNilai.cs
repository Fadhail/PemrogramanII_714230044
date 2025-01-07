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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P12_714230044.view
{
    public partial class FormNilai : Form
    {
        koneksi koneksi = new koneksi();
        M_nilai m_Nilai = new M_nilai();
        string id_nilai;

        public FormNilai()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            dataNilai.DataSource = koneksi.ShowData("SELECT id_nilai, matkul, kategori, t_nilai.npm, nama, nilai FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm");
            dataNilai.Columns[0].HeaderText = "ID";
            dataNilai.Columns[1].HeaderText = "MaKul";
            dataNilai.Columns[2].HeaderText = "Kategori";
            dataNilai.Columns[3].HeaderText = "NPM";
            dataNilai.Columns[4].HeaderText = "Nama";
            dataNilai.Columns[5].HeaderText = "Nilai";
        }

        private void FormNilai_Load(object sender, EventArgs e)
        {
            Tampil();
            GetDataMhs();
        }

        public void GetDataMhs()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT * FROM t_mahasiswa");
            while (reader.Read())
            {
                int npm = reader.GetInt32("npm");
                cbNPM.Items.Add(npm);
            }
            reader.Close();
            koneksi.CloseConnection();
        }


        private void dataNilai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_nilai = dataNilai.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbMatkul.Text = dataNilai.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbKategori.Text = dataNilai.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbNPM.Text = dataNilai.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxNilai.Text = dataNilai.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void textBoxPencarian_TextChanged(object sender, EventArgs e)
        {
            dataNilai.DataSource = koneksi.ShowData("SELECT id_nilai, matkul, kategori, t_nilai.npm, nama, nilai " + "FROM t_nilai JOIN t_mahasiswa ON t_mahasiswa.npm = t_nilai.npm " + "WHERE t_nilai.npm LIKE '%' '" + textBoxPencarian.Text + "' '%' " + "OR nama LIKE '%' '" + textBoxPencarian.Text + "' '%'" + "OR matkul LIKE '%' '" + textBoxPencarian.Text + "' '%'");
        }

        public void GetNamaMhs()
        {
            koneksi.OpenConnection();
            MySqlDataReader reader = koneksi.reader("SELECT nama FROM t_mahasiswa WHERE npm = '" + cbNPM.Text + "'");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    textBoxNama.Text = reader.GetString(0);
                }
            }
            reader.Close();
            koneksi.CloseConnection();
        }

        private void cbNPM_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNamaMhs();
        }

        public void ResetForm()
        {
            cbMatkul.SelectedIndex = -1;
            cbKategori.SelectedIndex = -1;
            cbNPM.SelectedIndex = -1;
            textBoxNilai.Text = "";
            textBoxNama.Text = "";
            textBoxPencarian.Text = "";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (cbMatkul.SelectedIndex == -1 || cbKategori.SelectedIndex == -1 || cbNPM.SelectedIndex == -1 || textBoxNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_Nilai.Matkul = cbMatkul.Text;
                m_Nilai.Kategori = cbKategori.Text;
                m_Nilai.Npm = cbNPM.Text;
                m_Nilai.Nilai = textBoxNilai.Text;
                nilai.Insert(m_Nilai);
                ResetForm();
                Tampil();
            }
        }

        private void buttonRubah_Click(object sender, EventArgs e)
        {
            if (cbMatkul.SelectedIndex == -1 || cbKategori.SelectedIndex == -1 || cbNPM.SelectedIndex == -1 || textBoxNilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Nilai nilai = new Nilai();
                m_Nilai.Matkul = cbMatkul.Text;
                m_Nilai.Kategori = cbKategori.Text;
                m_Nilai.Npm = cbNPM.Text;
                m_Nilai.Nilai = textBoxNilai.Text;
                nilai.Update(m_Nilai, id_nilai);
                ResetForm();
                Tampil();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?","Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Nilai nilai = new Nilai();
                nilai.Delete(id_nilai);
                ResetForm();
                Tampil();
            }
        }
    }
}
