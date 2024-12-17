namespace P9_714230044
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
            this.gbTabel = new System.Windows.Forms.GroupBox();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.textBoxHP = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNPM = new System.Windows.Forms.TextBox();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelAngkatan = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelNPM = new System.Windows.Forms.Label();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.comboBoxAngkatan = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonRubah = new System.Windows.Forms.Button();
            this.dataMahasiswa = new System.Windows.Forms.DataGridView();
            this.gbTabel.SuspendLayout();
            this.gbForm.SuspendLayout();
            this.gbAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTabel
            // 
            this.gbTabel.Controls.Add(this.dataMahasiswa);
            this.gbTabel.Location = new System.Drawing.Point(20, 12);
            this.gbTabel.Name = "gbTabel";
            this.gbTabel.Size = new System.Drawing.Size(627, 222);
            this.gbTabel.TabIndex = 0;
            this.gbTabel.TabStop = false;
            this.gbTabel.Text = "Tabel Data Mahasiswa";
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.comboBoxAngkatan);
            this.gbForm.Controls.Add(this.textBoxHP);
            this.gbForm.Controls.Add(this.textBoxEmail);
            this.gbForm.Controls.Add(this.textBoxAlamat);
            this.gbForm.Controls.Add(this.textBoxNama);
            this.gbForm.Controls.Add(this.textBoxNPM);
            this.gbForm.Controls.Add(this.labelHP);
            this.gbForm.Controls.Add(this.labelEmail);
            this.gbForm.Controls.Add(this.labelAlamat);
            this.gbForm.Controls.Add(this.labelAngkatan);
            this.gbForm.Controls.Add(this.labelNama);
            this.gbForm.Controls.Add(this.labelNPM);
            this.gbForm.Location = new System.Drawing.Point(20, 240);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(323, 248);
            this.gbForm.TabIndex = 1;
            this.gbForm.TabStop = false;
            this.gbForm.Text = "Form Data Mahasiswa";
            // 
            // textBoxHP
            // 
            this.textBoxHP.Location = new System.Drawing.Point(94, 201);
            this.textBoxHP.Name = "textBoxHP";
            this.textBoxHP.Size = new System.Drawing.Size(197, 20);
            this.textBoxHP.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(94, 172);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(197, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(94, 118);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(197, 45);
            this.textBoxAlamat.TabIndex = 8;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(94, 57);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(197, 20);
            this.textBoxNama.TabIndex = 7;
            // 
            // textBoxNPM
            // 
            this.textBoxNPM.Location = new System.Drawing.Point(94, 28);
            this.textBoxNPM.Name = "textBoxNPM";
            this.textBoxNPM.Size = new System.Drawing.Size(197, 20);
            this.textBoxNPM.TabIndex = 6;
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Location = new System.Drawing.Point(16, 204);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(39, 13);
            this.labelHP.TabIndex = 5;
            this.labelHP.Text = "No HP";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(15, 175);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(16, 124);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(39, 13);
            this.labelAlamat.TabIndex = 3;
            this.labelAlamat.Text = "Alamat";
            // 
            // labelAngkatan
            // 
            this.labelAngkatan.AutoSize = true;
            this.labelAngkatan.Location = new System.Drawing.Point(16, 89);
            this.labelAngkatan.Name = "labelAngkatan";
            this.labelAngkatan.Size = new System.Drawing.Size(53, 13);
            this.labelAngkatan.TabIndex = 2;
            this.labelAngkatan.Text = "Angkatan";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(16, 60);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(35, 13);
            this.labelNama.TabIndex = 1;
            this.labelNama.Text = "Nama";
            // 
            // labelNPM
            // 
            this.labelNPM.AutoSize = true;
            this.labelNPM.Location = new System.Drawing.Point(16, 31);
            this.labelNPM.Name = "labelNPM";
            this.labelNPM.Size = new System.Drawing.Size(31, 13);
            this.labelNPM.TabIndex = 0;
            this.labelNPM.Text = "NPM";
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.buttonRubah);
            this.gbAction.Controls.Add(this.buttonHapus);
            this.gbAction.Controls.Add(this.buttonSimpan);
            this.gbAction.Controls.Add(this.buttonRefresh);
            this.gbAction.Location = new System.Drawing.Point(361, 301);
            this.gbAction.Name = "gbAction";
            this.gbAction.Size = new System.Drawing.Size(286, 184);
            this.gbAction.TabIndex = 2;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "Tabel Action";
            // 
            // comboBoxAngkatan
            // 
            this.comboBoxAngkatan.FormattingEnabled = true;
            this.comboBoxAngkatan.Location = new System.Drawing.Point(94, 86);
            this.comboBoxAngkatan.Name = "comboBoxAngkatan";
            this.comboBoxAngkatan.Size = new System.Drawing.Size(197, 21);
            this.comboBoxAngkatan.TabIndex = 11;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(28, 25);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(242, 23);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(28, 63);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(242, 23);
            this.buttonSimpan.TabIndex = 1;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(28, 138);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(242, 23);
            this.buttonHapus.TabIndex = 2;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            // 
            // buttonRubah
            // 
            this.buttonRubah.Location = new System.Drawing.Point(28, 102);
            this.buttonRubah.Name = "buttonRubah";
            this.buttonRubah.Size = new System.Drawing.Size(242, 23);
            this.buttonRubah.TabIndex = 3;
            this.buttonRubah.Text = "Rubah";
            this.buttonRubah.UseVisualStyleBackColor = true;
            // 
            // dataMahasiswa
            // 
            this.dataMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMahasiswa.Location = new System.Drawing.Point(14, 19);
            this.dataMahasiswa.Name = "dataMahasiswa";
            this.dataMahasiswa.Size = new System.Drawing.Size(597, 185);
            this.dataMahasiswa.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 497);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.gbForm);
            this.Controls.Add(this.gbTabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTabel.ResumeLayout(false);
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            this.gbAction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMahasiswa)).EndInit();
            this.ResumeLayout(false);

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
    }
}

