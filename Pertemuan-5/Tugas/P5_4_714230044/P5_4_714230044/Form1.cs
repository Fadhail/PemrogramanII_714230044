using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714230044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Tampilkan_Click(object sender, EventArgs e)
        {
            String jenisKelamin = "";
            String kelas = "";
            String jadwal = "";

            // Max Length Nama
            if (txtNama.Text.Length > 20)
            {
                MessageBox.Show(
                "Nama Tidak Boleh Lebih Dari 20 Karakter!",
                "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nama Tidak Boleh Kosong
            if (string.IsNullOrEmpty(txtNama.Text))
            {
                MessageBox.Show(
                "Nama Tidak Boleh Kosong!",
                "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Jenis Kelamin
            if (cb_JenisKelamin.Text == "Laki-laki")
            {
                jenisKelamin = "Laki-laki";
            }
            else if (cb_JenisKelamin.Text == "Perempuan")
            {
                jenisKelamin = "Perempuan";
            }
            else
            {
                jenisKelamin = "Tidak Diketahui";
            }

            // Format Tanggal Lahir
            String tanggalLahir = dtp_TanggalLahir.Value.ToString("dd MMMM yyyy");

            // Kelas
            if (cb_SepakBola.Checked)
            {
                kelas += "Sepak Bola, ";
            }
            if (cb_Renang.Checked)
            {
                kelas += "Renang, ";
            }
            if (cb_Tenis.Checked)
            {
                kelas += "Tenis, ";
            }
            if (cb_Yoga.Checked)
            {
                kelas += "Yoga, ";
            }
            if (cb_Basket.Checked)
            {
                kelas += "Basket, ";
            }
            if (cb_BuluTangkis.Checked)
            {
                kelas += "Bulu Tangkis, ";
            }
            if (cb_Voli.Checked)
            {
                kelas += "Voli, ";
            }
            if (cb_Panahan.Checked)
            {
                kelas += "Panahan";
            }

            // Peringatan Jika Tidak Memilih Kelas
            if (string.IsNullOrEmpty(kelas))
            {
                MessageBox.Show(
                "Harus Memilih Salah Satu Dari Pilihan Kelas!",
                "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Jadwal
            if (rb_SeninRabu.Checked)
            {
                jadwal = "Senin s/d Rabu, 14.00 - 16.00";
            }
            if (rb_SelasaKamis.Checked)
            {
                jadwal = "Selasa s/d Kamis, 14.00 - 16.00 ";
            }
            if (rb_SabtuMinggu.Checked)
            {
                jadwal = "Sabtu s/d Minggu, 09.00 - 11.00";
            }
            if (rb_Minggu.Checked)
            {
                jadwal = "Minggu, 13.00 - 20.00";
            }

            // Peringatan Jika Tidak Memilih Jadwal
            if (string.IsNullOrEmpty(jadwal))
            {
                MessageBox.Show(
                "Harus Memilih Salah Satu Dari Pilihan Jadwal!",
                "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Nama : " + txtNama.Text + 
                "\nJenis Kelamin : " + jenisKelamin + 
                "\nTanggal Lahir : " + tanggalLahir +
                "\nPilihan Kelas : " + kelas +
                "\nPilihan Jadwal : " + jadwal,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_Selesai_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
