using System.Resources;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace P5_4_714230044
{
    partial class Form1
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
            this.title = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.Label();
            this.JenisKelamin = new System.Windows.Forms.Label();
            this.TanggalLahir = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cb_JenisKelamin = new System.Windows.Forms.ComboBox();
            this.dtp_TanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.gb_PilihanKelas = new System.Windows.Forms.GroupBox();
            this.cb_Panahan = new System.Windows.Forms.CheckBox();
            this.cb_BuluTangkis = new System.Windows.Forms.CheckBox();
            this.cb_Voli = new System.Windows.Forms.CheckBox();
            this.cb_Basket = new System.Windows.Forms.CheckBox();
            this.cb_Yoga = new System.Windows.Forms.CheckBox();
            this.cb_Tenis = new System.Windows.Forms.CheckBox();
            this.cb_Renang = new System.Windows.Forms.CheckBox();
            this.cb_SepakBola = new System.Windows.Forms.CheckBox();
            this.gb_PilihanJadwal = new System.Windows.Forms.GroupBox();
            this.rb_Minggu = new System.Windows.Forms.RadioButton();
            this.rb_SelasaKamis = new System.Windows.Forms.RadioButton();
            this.rb_SabtuMinggu = new System.Windows.Forms.RadioButton();
            this.rb_SeninRabu = new System.Windows.Forms.RadioButton();
            this.btn_Tampilkan = new System.Windows.Forms.Button();
            this.btn_Selesai = new System.Windows.Forms.Button();
            this.gb_PilihanKelas.SuspendLayout();
            this.gb_PilihanJadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Franklin Gothic Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(360, 50);
            this.title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(382, 43);
            this.title.TabIndex = 0;
            this.title.Text = "FORM PENDAFTARAN";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Nama
            // 
            this.Nama.AutoSize = true;
            this.Nama.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama.Location = new System.Drawing.Point(239, 132);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(59, 24);
            this.Nama.TabIndex = 1;
            this.Nama.Text = "Nama";
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.AutoSize = true;
            this.JenisKelamin.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JenisKelamin.Location = new System.Drawing.Point(239, 193);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(134, 24);
            this.JenisKelamin.TabIndex = 2;
            this.JenisKelamin.Text = "Jenis Kelamin";
            // 
            // TanggalLahir
            // 
            this.TanggalLahir.AutoSize = true;
            this.TanggalLahir.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TanggalLahir.Location = new System.Drawing.Point(239, 260);
            this.TanggalLahir.Name = "TanggalLahir";
            this.TanggalLahir.Size = new System.Drawing.Size(129, 24);
            this.TanggalLahir.TabIndex = 3;
            this.TanggalLahir.Text = "Tanggal Lahir";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(460, 130);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(340, 26);
            this.txtNama.TabIndex = 4;
            // 
            // cb_JenisKelamin
            // 
            this.cb_JenisKelamin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_JenisKelamin.FormattingEnabled = true;
            this.cb_JenisKelamin.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.cb_JenisKelamin.Location = new System.Drawing.Point(460, 187);
            this.cb_JenisKelamin.Name = "cb_JenisKelamin";
            this.cb_JenisKelamin.Size = new System.Drawing.Size(340, 30);
            this.cb_JenisKelamin.TabIndex = 5;
            this.cb_JenisKelamin.Text = "--Pilih Jenis Kelamin--";
            // 
            // dtp_TanggalLahir
            // 
            this.dtp_TanggalLahir.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_TanggalLahir.Location = new System.Drawing.Point(460, 258);
            this.dtp_TanggalLahir.Name = "dtp_TanggalLahir";
            this.dtp_TanggalLahir.Size = new System.Drawing.Size(340, 26);
            this.dtp_TanggalLahir.TabIndex = 6;
            // 
            // gb_PilihanKelas
            // 
            this.gb_PilihanKelas.BackColor = System.Drawing.Color.Transparent;
            this.gb_PilihanKelas.Controls.Add(this.cb_Panahan);
            this.gb_PilihanKelas.Controls.Add(this.cb_BuluTangkis);
            this.gb_PilihanKelas.Controls.Add(this.cb_Voli);
            this.gb_PilihanKelas.Controls.Add(this.cb_Basket);
            this.gb_PilihanKelas.Controls.Add(this.cb_Yoga);
            this.gb_PilihanKelas.Controls.Add(this.cb_Tenis);
            this.gb_PilihanKelas.Controls.Add(this.cb_Renang);
            this.gb_PilihanKelas.Controls.Add(this.cb_SepakBola);
            this.gb_PilihanKelas.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_PilihanKelas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb_PilihanKelas.Location = new System.Drawing.Point(173, 326);
            this.gb_PilihanKelas.Name = "gb_PilihanKelas";
            this.gb_PilihanKelas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gb_PilihanKelas.Size = new System.Drawing.Size(320, 220);
            this.gb_PilihanKelas.TabIndex = 7;
            this.gb_PilihanKelas.TabStop = false;
            this.gb_PilihanKelas.Text = "Pilihan Kelas";
            // 
            // cb_Panahan
            // 
            this.cb_Panahan.AutoSize = true;
            this.cb_Panahan.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Panahan.Location = new System.Drawing.Point(179, 161);
            this.cb_Panahan.Name = "cb_Panahan";
            this.cb_Panahan.Size = new System.Drawing.Size(86, 26);
            this.cb_Panahan.TabIndex = 7;
            this.cb_Panahan.Text = "Panahan";
            this.cb_Panahan.UseVisualStyleBackColor = true;
            // 
            // cb_BuluTangkis
            // 
            this.cb_BuluTangkis.AutoSize = true;
            this.cb_BuluTangkis.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_BuluTangkis.Location = new System.Drawing.Point(179, 79);
            this.cb_BuluTangkis.Name = "cb_BuluTangkis";
            this.cb_BuluTangkis.Size = new System.Drawing.Size(117, 26);
            this.cb_BuluTangkis.TabIndex = 6;
            this.cb_BuluTangkis.Text = "Buku Tangkis";
            this.cb_BuluTangkis.UseVisualStyleBackColor = true;
            // 
            // cb_Voli
            // 
            this.cb_Voli.AutoSize = true;
            this.cb_Voli.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Voli.Location = new System.Drawing.Point(179, 120);
            this.cb_Voli.Name = "cb_Voli";
            this.cb_Voli.Size = new System.Drawing.Size(55, 26);
            this.cb_Voli.TabIndex = 5;
            this.cb_Voli.Text = "Voli";
            this.cb_Voli.UseVisualStyleBackColor = true;
            // 
            // cb_Basket
            // 
            this.cb_Basket.AutoSize = true;
            this.cb_Basket.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Basket.Location = new System.Drawing.Point(179, 40);
            this.cb_Basket.Name = "cb_Basket";
            this.cb_Basket.Size = new System.Drawing.Size(75, 26);
            this.cb_Basket.TabIndex = 4;
            this.cb_Basket.Text = "Basket";
            this.cb_Basket.UseVisualStyleBackColor = true;
            // 
            // cb_Yoga
            // 
            this.cb_Yoga.AutoSize = true;
            this.cb_Yoga.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Yoga.Location = new System.Drawing.Point(27, 161);
            this.cb_Yoga.Name = "cb_Yoga";
            this.cb_Yoga.Size = new System.Drawing.Size(61, 26);
            this.cb_Yoga.TabIndex = 3;
            this.cb_Yoga.Text = "Yoga";
            this.cb_Yoga.UseVisualStyleBackColor = true;
            // 
            // cb_Tenis
            // 
            this.cb_Tenis.AutoSize = true;
            this.cb_Tenis.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Tenis.Location = new System.Drawing.Point(27, 120);
            this.cb_Tenis.Name = "cb_Tenis";
            this.cb_Tenis.Size = new System.Drawing.Size(64, 26);
            this.cb_Tenis.TabIndex = 2;
            this.cb_Tenis.Text = "Tenis";
            this.cb_Tenis.UseVisualStyleBackColor = true;
            // 
            // cb_Renang
            // 
            this.cb_Renang.AutoSize = true;
            this.cb_Renang.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Renang.Location = new System.Drawing.Point(27, 79);
            this.cb_Renang.Name = "cb_Renang";
            this.cb_Renang.Size = new System.Drawing.Size(78, 26);
            this.cb_Renang.TabIndex = 1;
            this.cb_Renang.Text = "Renang";
            this.cb_Renang.UseVisualStyleBackColor = true;
            // 
            // cb_SepakBola
            // 
            this.cb_SepakBola.AutoSize = true;
            this.cb_SepakBola.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_SepakBola.Location = new System.Drawing.Point(27, 40);
            this.cb_SepakBola.Name = "cb_SepakBola";
            this.cb_SepakBola.Size = new System.Drawing.Size(106, 26);
            this.cb_SepakBola.TabIndex = 0;
            this.cb_SepakBola.Text = "Sepak Bola";
            this.cb_SepakBola.UseVisualStyleBackColor = true;
            // 
            // gb_PilihanJadwal
            // 
            this.gb_PilihanJadwal.Controls.Add(this.rb_Minggu);
            this.gb_PilihanJadwal.Controls.Add(this.rb_SelasaKamis);
            this.gb_PilihanJadwal.Controls.Add(this.rb_SabtuMinggu);
            this.gb_PilihanJadwal.Controls.Add(this.rb_SeninRabu);
            this.gb_PilihanJadwal.Location = new System.Drawing.Point(586, 326);
            this.gb_PilihanJadwal.Name = "gb_PilihanJadwal";
            this.gb_PilihanJadwal.Size = new System.Drawing.Size(320, 220);
            this.gb_PilihanJadwal.TabIndex = 8;
            this.gb_PilihanJadwal.TabStop = false;
            this.gb_PilihanJadwal.Text = "Pilihan Jadwal";
            // 
            // rb_Minggu
            // 
            this.rb_Minggu.AutoSize = true;
            this.rb_Minggu.BackColor = System.Drawing.Color.Transparent;
            this.rb_Minggu.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Minggu.Location = new System.Drawing.Point(26, 164);
            this.rb_Minggu.Name = "rb_Minggu";
            this.rb_Minggu.Size = new System.Drawing.Size(179, 26);
            this.rb_Minggu.TabIndex = 3;
            this.rb_Minggu.TabStop = true;
            this.rb_Minggu.Text = "Minggu, 13.00 - 20.00";
            this.rb_Minggu.UseVisualStyleBackColor = false;
            // 
            // rb_SelasaKamis
            // 
            this.rb_SelasaKamis.AutoSize = true;
            this.rb_SelasaKamis.BackColor = System.Drawing.Color.Transparent;
            this.rb_SelasaKamis.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_SelasaKamis.Location = new System.Drawing.Point(26, 80);
            this.rb_SelasaKamis.Name = "rb_SelasaKamis";
            this.rb_SelasaKamis.Size = new System.Drawing.Size(253, 26);
            this.rb_SelasaKamis.TabIndex = 2;
            this.rb_SelasaKamis.TabStop = true;
            this.rb_SelasaKamis.Text = "Selasa s/d Kamis, 14.00 - 16.00 ";
            this.rb_SelasaKamis.UseVisualStyleBackColor = false;
            // 
            // rb_SabtuMinggu
            // 
            this.rb_SabtuMinggu.AutoSize = true;
            this.rb_SabtuMinggu.BackColor = System.Drawing.Color.Transparent;
            this.rb_SabtuMinggu.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_SabtuMinggu.Location = new System.Drawing.Point(26, 121);
            this.rb_SabtuMinggu.Name = "rb_SabtuMinggu";
            this.rb_SabtuMinggu.Size = new System.Drawing.Size(251, 26);
            this.rb_SabtuMinggu.TabIndex = 1;
            this.rb_SabtuMinggu.TabStop = true;
            this.rb_SabtuMinggu.Text = "Sabtu s/d Minggu, 09.00 - 11.00";
            this.rb_SabtuMinggu.UseVisualStyleBackColor = false;
            // 
            // rb_SeninRabu
            // 
            this.rb_SeninRabu.AutoSize = true;
            this.rb_SeninRabu.BackColor = System.Drawing.Color.Transparent;
            this.rb_SeninRabu.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_SeninRabu.Location = new System.Drawing.Point(26, 39);
            this.rb_SeninRabu.Name = "rb_SeninRabu";
            this.rb_SeninRabu.Size = new System.Drawing.Size(236, 26);
            this.rb_SeninRabu.TabIndex = 0;
            this.rb_SeninRabu.TabStop = true;
            this.rb_SeninRabu.Text = "Senin s/d Rabu, 14.00 - 16.00";
            this.rb_SeninRabu.UseVisualStyleBackColor = false;
            // 
            // btn_Tampilkan
            // 
            this.btn_Tampilkan.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tampilkan.Location = new System.Drawing.Point(408, 585);
            this.btn_Tampilkan.Name = "btn_Tampilkan";
            this.btn_Tampilkan.Size = new System.Drawing.Size(113, 30);
            this.btn_Tampilkan.TabIndex = 9;
            this.btn_Tampilkan.Text = "Tampilkan";
            this.btn_Tampilkan.UseVisualStyleBackColor = true;
            this.btn_Tampilkan.Click += new System.EventHandler(this.btn_Tampilkan_Click);
            // 
            // btn_Selesai
            // 
            this.btn_Selesai.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Selesai.Location = new System.Drawing.Point(558, 585);
            this.btn_Selesai.Name = "btn_Selesai";
            this.btn_Selesai.Size = new System.Drawing.Size(113, 30);
            this.btn_Selesai.TabIndex = 10;
            this.btn_Selesai.Text = "Selesai";
            this.btn_Selesai.UseVisualStyleBackColor = true;
            this.btn_Selesai.Click += new System.EventHandler(this.btn_Selesai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.btn_Selesai);
            this.Controls.Add(this.btn_Tampilkan);
            this.Controls.Add(this.gb_PilihanJadwal);
            this.Controls.Add(this.gb_PilihanKelas);
            this.Controls.Add(this.dtp_TanggalLahir);
            this.Controls.Add(this.cb_JenisKelamin);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.TanggalLahir);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_PilihanKelas.ResumeLayout(false);
            this.gb_PilihanKelas.PerformLayout();
            this.gb_PilihanJadwal.ResumeLayout(false);
            this.gb_PilihanJadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label Nama;
        private System.Windows.Forms.Label JenisKelamin;
        private System.Windows.Forms.Label TanggalLahir;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cb_JenisKelamin;
        private System.Windows.Forms.DateTimePicker dtp_TanggalLahir;
        private System.Windows.Forms.GroupBox gb_PilihanKelas;
        private System.Windows.Forms.CheckBox cb_BuluTangkis;
        private System.Windows.Forms.CheckBox cb_Voli;
        private System.Windows.Forms.CheckBox cb_Basket;
        private System.Windows.Forms.CheckBox cb_Yoga;
        private System.Windows.Forms.CheckBox cb_Tenis;
        private System.Windows.Forms.CheckBox cb_Renang;
        private System.Windows.Forms.CheckBox cb_SepakBola;
        private System.Windows.Forms.GroupBox gb_PilihanJadwal;
        private System.Windows.Forms.CheckBox cb_Panahan;
        private System.Windows.Forms.RadioButton rb_SeninRabu;
        private System.Windows.Forms.RadioButton rb_Minggu;
        private System.Windows.Forms.RadioButton rb_SelasaKamis;
        private System.Windows.Forms.RadioButton rb_SabtuMinggu;
        private System.Windows.Forms.Button btn_Tampilkan;
        private System.Windows.Forms.Button btn_Selesai;
    }
}

