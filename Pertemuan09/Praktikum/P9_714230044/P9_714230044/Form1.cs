using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714230044
{
    public partial class Form1 : Form
    {
        koneksi koneksi = new koneksi();

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
    }
}
