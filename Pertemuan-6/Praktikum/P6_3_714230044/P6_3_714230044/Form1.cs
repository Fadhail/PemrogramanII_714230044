using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714230044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Set Error Messages
        private void SetErrorMessages(TextBox textBox, string warningMessage, string wrongMessage, string correctMessage)
        {
            epWarning.SetError(textBox, warningMessage);
            epWrong.SetError(textBox, wrongMessage);
            epCorrect.SetError(textBox, correctMessage);
        }

        // Text Box Nama
        private void tbHuruf_Leave(object sender, EventArgs e)
        {
            if (tbHuruf.Text == "")
            {
                SetErrorMessages(tbHuruf, "Textbox Huruf tidak boleh kosong!", "", "");
            }
            else if (tbHuruf.Text.All(Char.IsLetter))
            {
                SetErrorMessages(tbHuruf, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(tbHuruf, "", "Inputan hanya boleh huruf!", "");
            }
        }

        // Text Box Angka
        private void tbAngka_TextChanged(object sender, EventArgs e)
        {
            if (tbAngka.Text == "")
            {
                SetErrorMessages(tbAngka, "Textbox Angka tidak boleh kosong!", "", "");
            }
            else if (tbAngka.Text.All(Char.IsNumber))
            {
                SetErrorMessages(tbAngka, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(tbAngka, "", "Inputan hanya boleh angka!", "");
            }
        }

        // Text Box Email
        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                SetErrorMessages(tbEmail, "Textbox Email tidak boleh kosong!", "", "");
            }
            else if (Regex.IsMatch(tbEmail.Text, @"^^[^@\s]+@[^@\s]+(.[^@\s]+)+$"))
            {
                SetErrorMessages(tbEmail, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(tbEmail, "", "Format email salah!\nContoh: a@b.c", "");
            }
        }

        // Leave Angka 1
        private void tbAngka1_Leave(object sender, EventArgs e)
        {
            if (tbAngka1.Text == "")
            {
                SetErrorMessages(tbAngka1, "Textbox Angka 1 tidak boleh kosong!", "", "");
            }
            else if (tbAngka2.Text == "")
            {
                SetErrorMessages(tbAngka2, "Textbox Angka 2 tidak boleh kosong!", "", "");
            }
        }

        // Leave Angka 2
        private void tbAngka2_Leave(object sender, EventArgs e)
        {
            if (tbAngka2.Text == "")
            {
                SetErrorMessages(tbAngka2, "Textbox Angka 2 tidak boleh kosong!", "", "");
            }
            else if (tbAngka1.Text == "")
            {
                SetErrorMessages(tbAngka1, "Textbox Angka 1 tidak boleh kosong!", "", "");
            }
            else if (int.TryParse(tbAngka1.Text, out int angka1) && int.TryParse(tbAngka2.Text, out int angka2))
            {
                if (angka1 < angka2)
                {
                    SetErrorMessages(tbAngka2, "", "Angka 1 harus lebih besar dari Angka 2!", "");
                    SetErrorMessages(tbAngka1, "", "Angka 1 harus lebih besar dari Angka 2!", "");
                }
                else
                {
                    SetErrorMessages(tbAngka1, "", "", "Betul!");
                    SetErrorMessages(tbAngka2, "", "", "Betul!");
                }
            }
        }

        // Text Box Angka1
        private void tbAngka1_TextChanged(object sender, EventArgs e)
        {
            if (tbAngka1.Text == "")
            {
                SetErrorMessages(tbAngka, "Textbox Angka 1 tidak boleh kosong!", "", "");
            }
            else if (tbAngka1.Text.All(Char.IsNumber))
            {
                SetErrorMessages(tbAngka1, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(tbAngka1, "", "Inputan hanya boleh angka!", "");
            }
        }

        // Text Box Angka2
        private void tbAngka2_TextChanged(object sender, EventArgs e)
        {
            if (tbAngka2.Text == "")
            {
                SetErrorMessages(tbAngka, "Textbox Angka 1 tidak boleh kosong!", "", "");
            }
            else if (tbAngka2.Text.All(Char.IsNumber))
            {
                SetErrorMessages(tbAngka2, "", "", "Betul!");
            }
            else
            {
                SetErrorMessages(tbAngka2, "", "Inputan hanya boleh angka!", "");
            }
        }
    }
}
