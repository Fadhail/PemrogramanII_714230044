namespace P13_714230044.view
{
    partial class FormBarang
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
            dataBarang = new DataGridView();
            gbForm = new GroupBox();
            textBoxID = new TextBox();
            labelHarga = new Label();
            textBoxHarga = new TextBox();
            textBoxBarang = new TextBox();
            labelBarang = new Label();
            gbAction = new GroupBox();
            buttonRubah = new Button();
            buttonHapus = new Button();
            buttonSimpan = new Button();
            buttonRefresh = new Button();
            gbPencarian = new GroupBox();
            cariData = new Label();
            textBoxPencarian = new TextBox();
            gbTabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataBarang).BeginInit();
            gbForm.SuspendLayout();
            gbAction.SuspendLayout();
            gbPencarian.SuspendLayout();
            SuspendLayout();
            // 
            // gbTabel
            // 
            gbTabel.Controls.Add(dataBarang);
            gbTabel.Location = new Point(23, 14);
            gbTabel.Margin = new Padding(4, 3, 4, 3);
            gbTabel.Name = "gbTabel";
            gbTabel.Padding = new Padding(4, 3, 4, 3);
            gbTabel.Size = new Size(732, 256);
            gbTabel.TabIndex = 0;
            gbTabel.TabStop = false;
            gbTabel.Text = "Tabel Data Barang";
            // 
            // dataBarang
            // 
            dataBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBarang.Location = new Point(16, 22);
            dataBarang.Margin = new Padding(4, 3, 4, 3);
            dataBarang.Name = "dataBarang";
            dataBarang.Size = new Size(696, 213);
            dataBarang.TabIndex = 0;
            dataBarang.CellClick += dataBarang_CellClick;
            // 
            // gbForm
            // 
            gbForm.Controls.Add(textBoxID);
            gbForm.Controls.Add(labelHarga);
            gbForm.Controls.Add(textBoxHarga);
            gbForm.Controls.Add(textBoxBarang);
            gbForm.Controls.Add(labelBarang);
            gbForm.Location = new Point(23, 277);
            gbForm.Margin = new Padding(4, 3, 4, 3);
            gbForm.Name = "gbForm";
            gbForm.Padding = new Padding(4, 3, 4, 3);
            gbForm.Size = new Size(377, 126);
            gbForm.TabIndex = 1;
            gbForm.TabStop = false;
            gbForm.Text = "Form Input Barang";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(347, 33);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(23, 23);
            textBoxID.TabIndex = 5;
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.Location = new Point(25, 81);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(39, 15);
            labelHarga.TabIndex = 4;
            labelHarga.Text = "Harga";
            // 
            // textBoxHarga
            // 
            textBoxHarga.Location = new Point(125, 81);
            textBoxHarga.Name = "textBoxHarga";
            textBoxHarga.Size = new Size(227, 23);
            textBoxHarga.TabIndex = 3;
            // 
            // textBoxBarang
            // 
            textBoxBarang.Location = new Point(125, 33);
            textBoxBarang.Name = "textBoxBarang";
            textBoxBarang.Size = new Size(227, 23);
            textBoxBarang.TabIndex = 2;
            // 
            // labelBarang
            // 
            labelBarang.AutoSize = true;
            labelBarang.Location = new Point(25, 36);
            labelBarang.Margin = new Padding(4, 0, 4, 0);
            labelBarang.Name = "labelBarang";
            labelBarang.Size = new Size(79, 15);
            labelBarang.TabIndex = 0;
            labelBarang.Text = "Nama Barang";
            // 
            // gbAction
            // 
            gbAction.Controls.Add(buttonRubah);
            gbAction.Controls.Add(buttonHapus);
            gbAction.Controls.Add(buttonSimpan);
            gbAction.Controls.Add(buttonRefresh);
            gbAction.Location = new Point(421, 277);
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
            gbPencarian.Location = new Point(23, 424);
            gbPencarian.Name = "gbPencarian";
            gbPencarian.Size = new Size(377, 65);
            gbPencarian.TabIndex = 3;
            gbPencarian.TabStop = false;
            gbPencarian.Text = "Form Pencarian";
            // 
            // cariData
            // 
            cariData.AutoSize = true;
            cariData.Location = new Point(25, 32);
            cariData.Name = "cariData";
            cariData.Size = new Size(55, 15);
            cariData.TabIndex = 1;
            cariData.Text = "Cari Data";
            // 
            // textBoxPencarian
            // 
            textBoxPencarian.Location = new Point(125, 29);
            textBoxPencarian.Name = "textBoxPencarian";
            textBoxPencarian.Size = new Size(237, 23);
            textBoxPencarian.TabIndex = 0;
            textBoxPencarian.TextChanged += textBoxPencarian_TextChanged;
            // 
            // FormBarang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 508);
            Controls.Add(gbPencarian);
            Controls.Add(gbAction);
            Controls.Add(gbForm);
            Controls.Add(gbTabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormBarang";
            Text = "FormBarang";
            Load += FormBarang_Load;
            gbTabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataBarang).EndInit();
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
        private System.Windows.Forms.Label labelBarang;
        private System.Windows.Forms.DataGridView dataBarang;
        private System.Windows.Forms.Button buttonRubah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonRefresh;
        private GroupBox gbPencarian;
        private Label cariData;
        private TextBox textBoxPencarian;
        private TextBox textBoxHarga;
        private TextBox textBoxBarang;
        private ComboBox cbMatkul;
        private TextBox textBoxNilai;
        private ComboBox cbNPM;
        private ComboBox cbKategori;
        private TextBox textBoxNama;
        private Label labelHarga;
        private TextBox textBoxID;
    }
}