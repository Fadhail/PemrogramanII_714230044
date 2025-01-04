using P11_714230044.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_714230044.controller
{
    internal class Mahasiswa
    {
        koneksi koneksi = new koneksi();
        public bool status;

        public bool insert(M_mahasiswa mahasiswa)
        {
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_mahasiswa (npm, nama, angkatan, alamat, email, nohp) VALUES('" + mahasiswa.Npm + "', '" + mahasiswa.Nama + "','" + mahasiswa.Angkatan + "','" + mahasiswa.Alamat + "','" + mahasiswa.Email + "','" + mahasiswa.Nohp + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool update(M_mahasiswa mahasiswa, string npm_mhs)
        {
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_mahasiswa SET nama='" + mahasiswa.Nama + "'," + "angkatan='" + mahasiswa.Angkatan + "'," + "alamat='" + mahasiswa.Alamat + "'," + "email='" + mahasiswa.Email + "'," + "nohp='" + mahasiswa.Nohp + "' WHERE npm = '" + npm_mhs + "'");

                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Delete(string npm_mhs)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_mahasiswa WHERE npm='" + npm_mhs + "'");
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
                status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return status;
        }
    }
}
