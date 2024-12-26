namespace P7_1_714230044
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxNama = new TextBox();
            textBoxKelas = new TextBox();
            comboBoxAngkatan = new ComboBox();
            buttonCheck = new Button();
            buttonTutup = new Button();
            label4 = new Label();
            radioButtonWeekday = new RadioButton();
            radioButtonWeekend = new RadioButton();
            checkBoxKuliah = new CheckBox();
            checkBoxTidur = new CheckBox();
            checkBoxLiburan = new CheckBox();
            buttonCetak = new Button();
            buttonReset = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 45);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 164);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Kelas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 102);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Angkatan";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(187, 42);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(278, 27);
            textBoxNama.TabIndex = 3;
            // 
            // textBoxKelas
            // 
            textBoxKelas.Location = new Point(187, 161);
            textBoxKelas.Multiline = true;
            textBoxKelas.Name = "textBoxKelas";
            textBoxKelas.Size = new Size(278, 88);
            textBoxKelas.TabIndex = 4;
            // 
            // comboBoxAngkatan
            // 
            comboBoxAngkatan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAngkatan.FormattingEnabled = true;
            comboBoxAngkatan.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "3024" });
            comboBoxAngkatan.Location = new Point(187, 102);
            comboBoxAngkatan.Name = "comboBoxAngkatan";
            comboBoxAngkatan.Size = new Size(278, 28);
            comboBoxAngkatan.TabIndex = 5;
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(187, 289);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(94, 29);
            buttonCheck.TabIndex = 6;
            buttonCheck.Text = "Check";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // buttonTutup
            // 
            buttonTutup.Location = new Point(371, 289);
            buttonTutup.Name = "buttonTutup";
            buttonTutup.Size = new Size(94, 29);
            buttonTutup.TabIndex = 7;
            buttonTutup.Text = "Tutup";
            buttonTutup.UseVisualStyleBackColor = true;
            buttonTutup.Click += buttonTutup_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(197, 355);
            label4.Name = "label4";
            label4.Size = new Size(123, 31);
            label4.TabIndex = 8;
            label4.Text = "KEGIATAN";
            // 
            // radioButtonWeekday
            // 
            radioButtonWeekday.AutoSize = true;
            radioButtonWeekday.Location = new Point(43, 410);
            radioButtonWeekday.Name = "radioButtonWeekday";
            radioButtonWeekday.Size = new Size(119, 24);
            radioButtonWeekday.TabIndex = 9;
            radioButtonWeekday.TabStop = true;
            radioButtonWeekday.Text = "Senin - Jumat";
            radioButtonWeekday.UseVisualStyleBackColor = true;
            radioButtonWeekday.CheckedChanged += radioButtonWeekday_CheckedChanged;
            // 
            // radioButtonWeekend
            // 
            radioButtonWeekend.AutoSize = true;
            radioButtonWeekend.Location = new Point(43, 440);
            radioButtonWeekend.Name = "radioButtonWeekend";
            radioButtonWeekend.Size = new Size(133, 24);
            radioButtonWeekend.TabIndex = 10;
            radioButtonWeekend.TabStop = true;
            radioButtonWeekend.Text = "Sabtu - Minggu";
            radioButtonWeekend.UseVisualStyleBackColor = true;
            radioButtonWeekend.CheckedChanged += radioButtonWeekend_CheckedChanged;
            // 
            // checkBoxKuliah
            // 
            checkBoxKuliah.AutoSize = true;
            checkBoxKuliah.Location = new Point(43, 490);
            checkBoxKuliah.Name = "checkBoxKuliah";
            checkBoxKuliah.Size = new Size(72, 24);
            checkBoxKuliah.TabIndex = 11;
            checkBoxKuliah.Text = "Kuliah";
            checkBoxKuliah.UseVisualStyleBackColor = true;
            // 
            // checkBoxTidur
            // 
            checkBoxTidur.AutoSize = true;
            checkBoxTidur.Location = new Point(43, 520);
            checkBoxTidur.Name = "checkBoxTidur";
            checkBoxTidur.Size = new Size(65, 24);
            checkBoxTidur.TabIndex = 12;
            checkBoxTidur.Text = "Tidur";
            checkBoxTidur.UseVisualStyleBackColor = true;
            // 
            // checkBoxLiburan
            // 
            checkBoxLiburan.AutoSize = true;
            checkBoxLiburan.Location = new Point(43, 550);
            checkBoxLiburan.Name = "checkBoxLiburan";
            checkBoxLiburan.Size = new Size(80, 24);
            checkBoxLiburan.TabIndex = 13;
            checkBoxLiburan.Text = "Liburan";
            checkBoxLiburan.UseVisualStyleBackColor = true;
            // 
            // buttonCetak
            // 
            buttonCetak.Location = new Point(187, 611);
            buttonCetak.Name = "buttonCetak";
            buttonCetak.Size = new Size(94, 29);
            buttonCetak.TabIndex = 14;
            buttonCetak.Text = "Cetak";
            buttonCetak.UseVisualStyleBackColor = true;
            buttonCetak.Click += buttonCetak_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(371, 611);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 15;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(411, 402);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 670);
            Controls.Add(pictureBox1);
            Controls.Add(buttonReset);
            Controls.Add(buttonCetak);
            Controls.Add(checkBoxLiburan);
            Controls.Add(checkBoxTidur);
            Controls.Add(checkBoxKuliah);
            Controls.Add(radioButtonWeekend);
            Controls.Add(radioButtonWeekday);
            Controls.Add(label4);
            Controls.Add(buttonTutup);
            Controls.Add(buttonCheck);
            Controls.Add(comboBoxAngkatan);
            Controls.Add(textBoxKelas);
            Controls.Add(textBoxNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxNama;
        private TextBox textBoxKelas;
        private ComboBox comboBoxAngkatan;
        private Button buttonCheck;
        private Button buttonTutup;
        private Label label4;
        private RadioButton radioButtonWeekday;
        private RadioButton radioButtonWeekend;
        private CheckBox checkBoxKuliah;
        private CheckBox checkBoxTidur;
        private CheckBox checkBoxLiburan;
        private Button buttonCetak;
        private Button buttonReset;
        private PictureBox pictureBox1;
    }
}
