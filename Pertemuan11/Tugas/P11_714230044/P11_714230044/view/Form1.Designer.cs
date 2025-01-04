namespace P11_714230044
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
            gbTabel = new GroupBox();
            dataMahasiswa = new DataGridView();
            gbForm = new GroupBox();
            comboBoxAngkatan = new ComboBox();
            textBoxHP = new TextBox();
            textBoxEmail = new TextBox();
            textBoxAlamat = new TextBox();
            textBoxNama = new TextBox();
            textBoxNPM = new TextBox();
            labelHP = new Label();
            labelEmail = new Label();
            labelAlamat = new Label();
            labelAngkatan = new Label();
            labelNama = new Label();
            labelNPM = new Label();
            gbAction = new GroupBox();
            buttonRubah = new Button();
            buttonHapus = new Button();
            buttonSimpan = new Button();
            buttonRefresh = new Button();
            gbPencarian = new GroupBox();
            cariData = new Label();
            textBoxPencarian = new TextBox();
            gbTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataMahasiswa).BeginInit();
            gbForm.SuspendLayout();
            gbAction.SuspendLayout();
            gbPencarian.SuspendLayout();
            SuspendLayout();
            // 
            // gbTabel
            // 
            gbTabel.Controls.Add(dataMahasiswa);
            gbTabel.Location = new Point(23, 14);
            gbTabel.Margin = new Padding(4, 3, 4, 3);
            gbTabel.Name = "gbTabel";
            gbTabel.Padding = new Padding(4, 3, 4, 3);
            gbTabel.Size = new Size(732, 256);
            gbTabel.TabIndex = 0;
            gbTabel.TabStop = false;
            gbTabel.Text = "Tabel Data Mahasiswa";
            // 
            // dataMahasiswa
            // 
            dataMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMahasiswa.Location = new Point(16, 22);
            dataMahasiswa.Margin = new Padding(4, 3, 4, 3);
            dataMahasiswa.Name = "dataMahasiswa";
            dataMahasiswa.Size = new Size(696, 213);
            dataMahasiswa.TabIndex = 0;
            dataMahasiswa.CellClick += dataMahasiswa_CellClick;
            // 
            // gbForm
            // 
            gbForm.Controls.Add(comboBoxAngkatan);
            gbForm.Controls.Add(textBoxHP);
            gbForm.Controls.Add(textBoxEmail);
            gbForm.Controls.Add(textBoxAlamat);
            gbForm.Controls.Add(textBoxNama);
            gbForm.Controls.Add(textBoxNPM);
            gbForm.Controls.Add(labelHP);
            gbForm.Controls.Add(labelEmail);
            gbForm.Controls.Add(labelAlamat);
            gbForm.Controls.Add(labelAngkatan);
            gbForm.Controls.Add(labelNama);
            gbForm.Controls.Add(labelNPM);
            gbForm.Location = new Point(23, 277);
            gbForm.Margin = new Padding(4, 3, 4, 3);
            gbForm.Name = "gbForm";
            gbForm.Padding = new Padding(4, 3, 4, 3);
            gbForm.Size = new Size(377, 286);
            gbForm.TabIndex = 1;
            gbForm.TabStop = false;
            gbForm.Text = "Form Data Mahasiswa";
            // 
            // comboBoxAngkatan
            // 
            comboBoxAngkatan.FormattingEnabled = true;
            comboBoxAngkatan.Items.AddRange(new object[] { "2018", "2019", "2020", "2021", "2022", "2023", "2024" });
            comboBoxAngkatan.Location = new Point(110, 99);
            comboBoxAngkatan.Margin = new Padding(4, 3, 4, 3);
            comboBoxAngkatan.Name = "comboBoxAngkatan";
            comboBoxAngkatan.Size = new Size(229, 23);
            comboBoxAngkatan.TabIndex = 11;
            // 
            // textBoxHP
            // 
            textBoxHP.Location = new Point(110, 232);
            textBoxHP.Margin = new Padding(4, 3, 4, 3);
            textBoxHP.Name = "textBoxHP";
            textBoxHP.Size = new Size(229, 23);
            textBoxHP.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(110, 198);
            textBoxEmail.Margin = new Padding(4, 3, 4, 3);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(229, 23);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.Location = new Point(110, 136);
            textBoxAlamat.Margin = new Padding(4, 3, 4, 3);
            textBoxAlamat.Multiline = true;
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.Size = new Size(229, 51);
            textBoxAlamat.TabIndex = 8;
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(110, 66);
            textBoxNama.Margin = new Padding(4, 3, 4, 3);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(229, 23);
            textBoxNama.TabIndex = 7;
            // 
            // textBoxNPM
            // 
            textBoxNPM.Location = new Point(110, 32);
            textBoxNPM.Margin = new Padding(4, 3, 4, 3);
            textBoxNPM.Name = "textBoxNPM";
            textBoxNPM.Size = new Size(229, 23);
            textBoxNPM.TabIndex = 6;
            // 
            // labelHP
            // 
            labelHP.AutoSize = true;
            labelHP.Location = new Point(19, 235);
            labelHP.Margin = new Padding(4, 0, 4, 0);
            labelHP.Name = "labelHP";
            labelHP.Size = new Size(42, 15);
            labelHP.TabIndex = 5;
            labelHP.Text = "No HP";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(18, 202);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email";
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.Location = new Point(19, 143);
            labelAlamat.Margin = new Padding(4, 0, 4, 0);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(45, 15);
            labelAlamat.TabIndex = 3;
            labelAlamat.Text = "Alamat";
            // 
            // labelAngkatan
            // 
            labelAngkatan.AutoSize = true;
            labelAngkatan.Location = new Point(19, 103);
            labelAngkatan.Margin = new Padding(4, 0, 4, 0);
            labelAngkatan.Name = "labelAngkatan";
            labelAngkatan.Size = new Size(58, 15);
            labelAngkatan.TabIndex = 2;
            labelAngkatan.Text = "Angkatan";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(19, 69);
            labelNama.Margin = new Padding(4, 0, 4, 0);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(39, 15);
            labelNama.TabIndex = 1;
            labelNama.Text = "Nama";
            // 
            // labelNPM
            // 
            labelNPM.AutoSize = true;
            labelNPM.Location = new Point(19, 36);
            labelNPM.Margin = new Padding(4, 0, 4, 0);
            labelNPM.Name = "labelNPM";
            labelNPM.Size = new Size(34, 15);
            labelNPM.TabIndex = 0;
            labelNPM.Text = "NPM";
            // 
            // gbAction
            // 
            gbAction.Controls.Add(buttonRubah);
            gbAction.Controls.Add(buttonHapus);
            gbAction.Controls.Add(buttonSimpan);
            gbAction.Controls.Add(buttonRefresh);
            gbAction.Location = new Point(421, 347);
            gbAction.Margin = new Padding(4, 3, 4, 3);
            gbAction.Name = "gbAction";
            gbAction.Padding = new Padding(4, 3, 4, 3);
            gbAction.Size = new Size(334, 212);
            gbAction.TabIndex = 2;
            gbAction.TabStop = false;
            gbAction.Text = "Tabel Action";
            // 
            // buttonRubah
            // 
            buttonRubah.Location = new Point(33, 118);
            buttonRubah.Margin = new Padding(4, 3, 4, 3);
            buttonRubah.Name = "buttonRubah";
            buttonRubah.Size = new Size(282, 27);
            buttonRubah.TabIndex = 3;
            buttonRubah.Text = "Rubah";
            buttonRubah.UseVisualStyleBackColor = true;
            buttonRubah.Click += buttonRubah_Click;
            // 
            // buttonHapus
            // 
            buttonHapus.Location = new Point(33, 159);
            buttonHapus.Margin = new Padding(4, 3, 4, 3);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(282, 27);
            buttonHapus.TabIndex = 2;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = true;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // buttonSimpan
            // 
            buttonSimpan.Location = new Point(33, 73);
            buttonSimpan.Margin = new Padding(4, 3, 4, 3);
            buttonSimpan.Name = "buttonSimpan";
            buttonSimpan.Size = new Size(282, 27);
            buttonSimpan.TabIndex = 1;
            buttonSimpan.Text = "Simpan";
            buttonSimpan.UseVisualStyleBackColor = true;
            buttonSimpan.Click += buttonSimpan_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(33, 29);
            buttonRefresh.Margin = new Padding(4, 3, 4, 3);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(282, 27);
            buttonRefresh.TabIndex = 0;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // gbPencarian
            // 
            gbPencarian.Controls.Add(cariData);
            gbPencarian.Controls.Add(textBoxPencarian);
            gbPencarian.Location = new Point(421, 276);
            gbPencarian.Name = "gbPencarian";
            gbPencarian.Size = new Size(334, 65);
            gbPencarian.TabIndex = 3;
            gbPencarian.TabStop = false;
            gbPencarian.Text = "Form Pencarian";
            // 
            // cariData
            // 
            cariData.AutoSize = true;
            cariData.Location = new Point(16, 32);
            cariData.Name = "cariData";
            cariData.Size = new Size(55, 15);
            cariData.TabIndex = 1;
            cariData.Text = "Cari Data";
            // 
            // textBoxPencarian
            // 
            textBoxPencarian.Location = new Point(77, 29);
            textBoxPencarian.Name = "textBoxPencarian";
            textBoxPencarian.Size = new Size(237, 23);
            textBoxPencarian.TabIndex = 0;
            textBoxPencarian.TextChanged += textBoxPencarian_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 573);
            Controls.Add(gbPencarian);
            Controls.Add(gbAction);
            Controls.Add(gbForm);
            Controls.Add(gbTabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataMahasiswa).EndInit();
            gbForm.ResumeLayout(false);
            gbForm.PerformLayout();
            gbAction.ResumeLayout(false);
            gbPencarian.ResumeLayout(false);
            gbPencarian.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbTabel;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelAngkatan;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelNPM;
        private System.Windows.Forms.TextBox textBoxHP;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNPM;
        private System.Windows.Forms.ComboBox comboBoxAngkatan;
        private System.Windows.Forms.DataGridView dataMahasiswa;
        private System.Windows.Forms.Button buttonRubah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonRefresh;
        private GroupBox gbPencarian;
        private Label cariData;
        private TextBox textBoxPencarian;
    }
}

