using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_714230044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            String os = "";
            String status = "";

            // Sistem operasi
            if (rb_android.Checked == true)
            {
                os = "Android";
            }
            else if (rb_ios.Checked == true)
            {
                os = "iOS";
            }
            else
            {
                os = "Tidak diketahui";
            }

            // Status perbaikan
            if (cbYa.Checked == true)
            {
                status = "Ya, sudah diperbaiki";
            }
            else
            {
                status = "Belum diperbaiki";
            }

            MessageBox.Show(
                "Merk HP : " + txtMerkHP.Text + "\nSistem Operasi : " + os + "\nStatus Perbaikan :" + status,
                "Informasi Service HP",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
