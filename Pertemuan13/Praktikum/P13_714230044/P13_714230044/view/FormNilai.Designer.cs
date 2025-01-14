namespace P13_714230044.view
{
    partial class FormNilai
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
            dataNilai = new DataGridView();
            gbForm = new GroupBox();
            textBoxNama = new TextBox();
            textBoxNilai = new TextBox();
            cbNPM = new ComboBox();
            cbKategori = new ComboBox();
            cbMatkul = new ComboBox();
            labelNilai = new Label();
            labelNPM = new Label();
            labelKategori = new Label();
            labelMatkul = new Label();
            gbAction = new GroupBox();
            buttonRubah = new Button();
            buttonHapus = new Button();
            buttonSimpan = new Button();
            buttonRefresh = new Button();
            gbPencarian = new GroupBox();
            cariData = new Label();
            textBoxPencarian = new TextBox();
            btnExport = new Button();
            gbTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataNilai).BeginInit();
            gbForm.SuspendLayout();
            gbAction.SuspendLayout();
            gbPencarian.SuspendLayout();
            SuspendLayout();
            // 
            // gbTabel
            // 
            gbTabel.Controls.Add(dataNilai);
            gbTabel.Location = new Point(23, 14);
            gbTabel.Margin = new Padding(4, 3, 4, 3);
            gbTabel.Name = "gbTabel";
            gbTabel.Padding = new Padding(4, 3, 4, 3);
            gbTabel.Size = new Size(732, 256);
            gbTabel.TabIndex = 0;
            gbTabel.TabStop = false;
            gbTabel.Text = "Tabel Data Mahasiswa";
            // 
            // dataNilai
            // 
            dataNilai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataNilai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataNilai.Location = new Point(16, 22);
            dataNilai.Margin = new Padding(4, 3, 4, 3);
            dataNilai.Name = "dataNilai";
            dataNilai.Size = new Size(696, 213);
            dataNilai.TabIndex = 0;
            dataNilai.CellClick += dataNilai_CellClick;
            // 
            // gbForm
            // 
            gbForm.Controls.Add(textBoxNama);
            gbForm.Controls.Add(textBoxNilai);
            gbForm.Controls.Add(cbNPM);
            gbForm.Controls.Add(cbKategori);
            gbForm.Controls.Add(cbMatkul);
            gbForm.Controls.Add(labelNilai);
            gbForm.Controls.Add(labelNPM);
            gbForm.Controls.Add(labelKategori);
            gbForm.Controls.Add(labelMatkul);
            gbForm.Location = new Point(23, 277);
            gbForm.Margin = new Padding(4, 3, 4, 3);
            gbForm.Name = "gbForm";
            gbForm.Padding = new Padding(4, 3, 4, 3);
            gbForm.Size = new Size(377, 245);
            gbForm.TabIndex = 1;
            gbForm.TabStop = false;
            gbForm.Text = "Form Data Mahasiswa";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(102, 149);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.ReadOnly = true;
            textBoxNama.Size = new Size(243, 23);
            textBoxNama.TabIndex = 8;
            // 
            // textBoxNilai
            // 
            textBoxNilai.Location = new Point(102, 188);
            textBoxNilai.Name = "textBoxNilai";
            textBoxNilai.Size = new Size(243, 23);
            textBoxNilai.TabIndex = 7;
            // 
            // cbNPM
            // 
            cbNPM.FormattingEnabled = true;
            cbNPM.Location = new Point(102, 120);
            cbNPM.Name = "cbNPM";
            cbNPM.Size = new Size(243, 23);
            cbNPM.TabIndex = 6;
            cbNPM.SelectedIndexChanged += cbNPM_SelectedIndexChanged;
            // 
            // cbKategori
            // 
            cbKategori.FormattingEnabled = true;
            cbKategori.Items.AddRange(new object[] { "ATS", "AAS" });
            cbKategori.Location = new Point(102, 75);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(243, 23);
            cbKategori.TabIndex = 5;
            // 
            // cbMatkul
            // 
            cbMatkul.FormattingEnabled = true;
            cbMatkul.Items.AddRange(new object[] { "Pemrograman I", "Pemrograman II", "Pemrograman III", "Pemrograman IV", "Literasi Data", "Sistem ERP", "RPL", "Metodologi Penelitian", "PKN", "General English I" });
            cbMatkul.Location = new Point(102, 33);
            cbMatkul.Name = "cbMatkul";
            cbMatkul.Size = new Size(243, 23);
            cbMatkul.TabIndex = 4;
            // 
            // labelNilai
            // 
            labelNilai.AutoSize = true;
            labelNilai.Location = new Point(25, 191);
            labelNilai.Margin = new Padding(4, 0, 4, 0);
            labelNilai.Name = "labelNilai";
            labelNilai.Size = new Size(31, 15);
            labelNilai.TabIndex = 3;
            labelNilai.Text = "Nilai";
            // 
            // labelNPM
            // 
            labelNPM.AutoSize = true;
            labelNPM.Location = new Point(25, 128);
            labelNPM.Margin = new Padding(4, 0, 4, 0);
            labelNPM.Name = "labelNPM";
            labelNPM.Size = new Size(34, 15);
            labelNPM.TabIndex = 2;
            labelNPM.Text = "NPM";
            // 
            // labelKategori
            // 
            labelKategori.AutoSize = true;
            labelKategori.Location = new Point(25, 84);
            labelKategori.Margin = new Padding(4, 0, 4, 0);
            labelKategori.Name = "labelKategori";
            labelKategori.Size = new Size(51, 15);
            labelKategori.TabIndex = 1;
            labelKategori.Text = "Kategori";
            // 
            // labelMatkul
            // 
            labelMatkul.AutoSize = true;
            labelMatkul.Location = new Point(25, 36);
            labelMatkul.Margin = new Padding(4, 0, 4, 0);
            labelMatkul.Name = "labelMatkul";
            labelMatkul.Size = new Size(44, 15);
            labelMatkul.TabIndex = 0;
            labelMatkul.Text = "Matkul";
            // 
            // gbAction
            // 
            gbAction.Controls.Add(buttonRubah);
            gbAction.Controls.Add(buttonHapus);
            gbAction.Controls.Add(buttonSimpan);
            gbAction.Controls.Add(buttonRefresh);
            gbAction.Location = new Point(421, 379);
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
            gbPencarian.Controls.Add(btnExport);
            gbPencarian.Controls.Add(cariData);
            gbPencarian.Controls.Add(textBoxPencarian);
            gbPencarian.Location = new Point(421, 276);
            gbPencarian.Name = "gbPencarian";
            gbPencarian.Size = new Size(334, 97);
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
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(0, 192, 0);
            btnExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.ForeColor = Color.Black;
            btnExport.Location = new Point(77, 61);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(237, 25);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export Excel";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // FormNilai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 593);
            Controls.Add(gbPencarian);
            Controls.Add(gbAction);
            Controls.Add(gbForm);
            Controls.Add(gbTabel);
            ForeColor = Color.Black;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormNilai";
            Text = "FormNilai";
            Load += FormNilai_Load;
            gbTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataNilai).EndInit();
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
        private System.Windows.Forms.Label labelNilai;
        private System.Windows.Forms.Label labelNPM;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.Label labelMatkul;
        private System.Windows.Forms.DataGridView dataNilai;
        private System.Windows.Forms.Button buttonRubah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonRefresh;
        private GroupBox gbPencarian;
        private Label cariData;
        private TextBox textBoxPencarian;
        private ComboBox cbMatkul;
        private TextBox textBoxNilai;
        private ComboBox cbNPM;
        private ComboBox cbKategori;
        private TextBox textBoxNama;
        private Button btnExport;
    }
}