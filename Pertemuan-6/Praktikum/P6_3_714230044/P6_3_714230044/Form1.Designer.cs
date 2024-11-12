namespace P6_3_714230044
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtHuruf = new System.Windows.Forms.Label();
            this.txtAngka = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtAngka1 = new System.Windows.Forms.Label();
            this.txtAngka2 = new System.Windows.Forms.Label();
            this.perbandingan = new System.Windows.Forms.Label();
            this.tbHuruf = new System.Windows.Forms.TextBox();
            this.tbAngka = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAngka1 = new System.Windows.Forms.TextBox();
            this.tbAngka2 = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHuruf
            // 
            this.txtHuruf.AutoSize = true;
            this.txtHuruf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHuruf.Location = new System.Drawing.Point(38, 42);
            this.txtHuruf.Name = "txtHuruf";
            this.txtHuruf.Size = new System.Drawing.Size(38, 16);
            this.txtHuruf.TabIndex = 0;
            this.txtHuruf.Text = "Huruf";
            // 
            // txtAngka
            // 
            this.txtAngka.AutoSize = true;
            this.txtAngka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngka.Location = new System.Drawing.Point(38, 79);
            this.txtAngka.Name = "txtAngka";
            this.txtAngka.Size = new System.Drawing.Size(46, 16);
            this.txtAngka.TabIndex = 1;
            this.txtAngka.Text = "Angka";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(38, 114);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(41, 16);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email";
            // 
            // txtAngka1
            // 
            this.txtAngka1.AutoSize = true;
            this.txtAngka1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngka1.Location = new System.Drawing.Point(38, 200);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(56, 16);
            this.txtAngka1.TabIndex = 3;
            this.txtAngka1.Text = "Angka 1";
            // 
            // txtAngka2
            // 
            this.txtAngka2.AutoSize = true;
            this.txtAngka2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngka2.Location = new System.Drawing.Point(38, 241);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAngka2.Size = new System.Drawing.Size(56, 16);
            this.txtAngka2.TabIndex = 4;
            this.txtAngka2.Text = "Angka 2";
            // 
            // perbandingan
            // 
            this.perbandingan.AutoSize = true;
            this.perbandingan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perbandingan.ForeColor = System.Drawing.Color.Red;
            this.perbandingan.Location = new System.Drawing.Point(38, 159);
            this.perbandingan.Name = "perbandingan";
            this.perbandingan.Size = new System.Drawing.Size(123, 16);
            this.perbandingan.TabIndex = 5;
            this.perbandingan.Text = "*Angka 1 > Angka 2";
            // 
            // tbHuruf
            // 
            this.tbHuruf.Location = new System.Drawing.Point(198, 42);
            this.tbHuruf.Name = "tbHuruf";
            this.tbHuruf.Size = new System.Drawing.Size(138, 20);
            this.tbHuruf.TabIndex = 6;
            this.tbHuruf.Leave += new System.EventHandler(this.tbHuruf_Leave);
            // 
            // tbAngka
            // 
            this.tbAngka.Location = new System.Drawing.Point(198, 75);
            this.tbAngka.Name = "tbAngka";
            this.tbAngka.Size = new System.Drawing.Size(138, 20);
            this.tbAngka.TabIndex = 7;
            this.tbAngka.TextChanged += new System.EventHandler(this.tbAngka_TextChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(198, 110);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(138, 20);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbAngka1
            // 
            this.tbAngka1.Location = new System.Drawing.Point(198, 196);
            this.tbAngka1.Name = "tbAngka1";
            this.tbAngka1.Size = new System.Drawing.Size(138, 20);
            this.tbAngka1.TabIndex = 9;
            this.tbAngka1.TextChanged += new System.EventHandler(this.tbAngka1_TextChanged);
            this.tbAngka1.Leave += new System.EventHandler(this.tbAngka1_Leave);
            // 
            // tbAngka2
            // 
            this.tbAngka2.Location = new System.Drawing.Point(198, 237);
            this.tbAngka2.Name = "tbAngka2";
            this.tbAngka2.Size = new System.Drawing.Size(138, 20);
            this.tbAngka2.TabIndex = 10;
            this.tbAngka2.TextChanged += new System.EventHandler(this.tbAngka2_TextChanged);
            this.tbAngka2.Leave += new System.EventHandler(this.tbAngka2_Leave);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 305);
            this.Controls.Add(this.tbAngka2);
            this.Controls.Add(this.tbAngka1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbAngka);
            this.Controls.Add(this.tbHuruf);
            this.Controls.Add(this.perbandingan);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAngka);
            this.Controls.Add(this.txtHuruf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHuruf;
        private System.Windows.Forms.Label txtAngka;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtAngka1;
        private System.Windows.Forms.Label txtAngka2;
        private System.Windows.Forms.Label perbandingan;
        private System.Windows.Forms.TextBox tbHuruf;
        private System.Windows.Forms.TextBox tbAngka;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAngka1;
        private System.Windows.Forms.TextBox tbAngka2;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

