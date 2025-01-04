using P11_714230044.controller;
using P11_714230044.model;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace P11_714230044
{
    public partial class Form1 : Form
    {
        koneksi koneksi = new koneksi();
        M_mahasiswa m_mhs = new M_mahasiswa();
        Mahasiswa mhs = new Mahasiswa();

        public void Tampil()
        {
            dataMahasiswa.DataSource = koneksi.ShowData("SELECT * FROM t_mahasiswa");
            dataMahasiswa.Columns[0].HeaderText = "NPM";
            dataMahasiswa.Columns[1].HeaderText = "Nama";
            dataMahasiswa.Columns[2].HeaderText = "Angkatan";
            dataMahasiswa.Columns[3].HeaderText = "Alamat";
            dataMahasiswa.Columns[4].HeaderText = "Email";
            dataMahasiswa.Columns[5].HeaderText = "No HP";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxNPM.Text == "" || textBoxNama.Text == "" || comboBoxAngkatan.SelectedIndex == -1 || textBoxAlamat.Text == "" || textBoxEmail.Text == "" || textBoxHP.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                m_mhs.Npm = textBoxNPM.Text;
                m_mhs.Nama = textBoxNama.Text;
                m_mhs.Angkatan = comboBoxAngkatan.SelectedItem.ToString();
                m_mhs.Alamat = textBoxAlamat.Text;
                m_mhs.Email = textBoxEmail.Text;
                m_mhs.Nohp = textBoxHP.Text;

                mhs.insert(m_mhs);

                Reset();
                Tampil();
            }
        }

        public void Reset()
        {
            textBoxNPM.Text = "";
            textBoxNama.Text = "";
            comboBoxAngkatan.SelectedIndex = -1;
            textBoxAlamat.Text = "";
            textBoxEmail.Text = "";
            textBoxHP.Text = "";
            textBoxPencarian.Text = "";
        }

        private void dataMahasiswa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNPM.Text = dataMahasiswa.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNama.Text = dataMahasiswa.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxAngkatan.Text = dataMahasiswa.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxAlamat.Text = dataMahasiswa.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxEmail.Text = dataMahasiswa.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxHP.Text = dataMahasiswa.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void buttonRubah_Click(object sender, EventArgs e)
        {
            if (textBoxNPM.Text == "" || textBoxNama.Text == "" || comboBoxAngkatan.SelectedIndex == -1 || textBoxAlamat.Text == "" || textBoxEmail.Text == "" || textBoxHP.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                m_mhs.Npm = textBoxNPM.Text;
                m_mhs.Nama = textBoxNama.Text;
                m_mhs.Angkatan = comboBoxAngkatan.SelectedItem.ToString();
                m_mhs.Alamat = textBoxAlamat.Text;
                m_mhs.Email = textBoxEmail.Text;
                m_mhs.Nohp = textBoxHP.Text;

                mhs.update(m_mhs, textBoxNPM.Text);

                Reset();
                Tampil();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Reset();
            Tampil();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (textBoxNPM.Text == "" || textBoxNama.Text == "" || comboBoxAngkatan.SelectedIndex == -1 || textBoxAlamat.Text == "" || textBoxEmail.Text == "" || textBoxHP.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?",
                "Perhatian",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                Mahasiswa mhs = new Mahasiswa();
                mhs.Delete(textBoxNPM.Text);
                Reset();
                Tampil();
            }
        }

        private void textBoxPencarian_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM t_mahasiswa WHERE npm LIKE '%" + textBoxPencarian.Text + "%' OR nama LIKE '%" + textBoxPencarian.Text + "%'";
            dataMahasiswa.DataSource = koneksi.ShowData(query);
        }
    }
}