using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P13_714230044.view
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 FormMhs = new Form1();
            FormMhs.MdiParent = this;
            FormMhs.Show();
        }

        private void dataNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNilai FormNilai = new FormNilai();
            FormNilai.MdiParent = this;
            FormNilai.Show();
        }

        private void dataMasterBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBarang FormBarang = new FormBarang();
            FormBarang.MdiParent = this;
            FormBarang.Show();
        }

        private void dataTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransaksi FormTransaksi = new FormTransaksi();
            FormTransaksi.MdiParent = this;
            FormTransaksi.Show();
        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
