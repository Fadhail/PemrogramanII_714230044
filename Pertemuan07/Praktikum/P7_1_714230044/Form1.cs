using System.Text;

namespace P7_1_714230044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Size = new Size(534, 395);
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(textBoxNama.Text))
            {
                errorMessage.AppendLine("Nama harus diisi");
            }

            if (comboBoxAngkatan.SelectedIndex == -1)
            {
                errorMessage.AppendLine("Angkatan harus diisi");
            }

            if (string.IsNullOrWhiteSpace(textBoxKelas.Text))
            {
                errorMessage.AppendLine("Kelas harus diisi");
            }

            string errorMsg = errorMessage.ToString();

            if (string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show(
                    "Lengkap",
                    "Succes!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Size = new Size(534, 717);
            }
            else
            {
                MessageBox.Show(
                    errorMsg.Trim(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }


        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonWeekday_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekday.Checked)
            {
                checkBoxKuliah.Enabled = true;
                checkBoxTidur.Enabled = true;
                checkBoxLiburan.Enabled = false;

                checkBoxKuliah.Checked = false;
                checkBoxTidur.Checked = false;
                checkBoxLiburan.Checked = false;
            }
        }

        private void radioButtonWeekend_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonWeekend.Checked)
            {
                checkBoxKuliah.Enabled = false;
                checkBoxTidur.Enabled = true;
                checkBoxLiburan.Enabled = true;

                checkBoxKuliah.Checked = false;
                checkBoxTidur.Checked = false;
                checkBoxLiburan.Checked = false;
            }
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            string? hari = Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked)?.Text;

            string? kegiatan = string.Join(
                ", ",
                Controls.OfType<CheckBox>()
                    .Where(cb => cb.Checked)
                    .Select(cb => cb.Text)
            );


            MessageBox.Show(
                $"""
                Nama: {textBoxNama.Text}
                Angkatan: {comboBoxAngkatan.Text}
                Kelas: {textBoxKelas.Text}
                ===============
                Hari: {hari}
                Kegiatan: {kegiatan}
                """,
                "Informasi Data Submit",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textbox) textbox.Text = "";
                else if (control is ComboBox comboBox) comboBox.SelectedIndex = -1;
                else if (control is RadioButton radioBtn) radioBtn.Checked = false;
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                    checkBox.Enabled = true;
                }
            }

            Size = new Size(534, 395);

            MessageBox.Show(
                "Form berhasil direset",
                "Data Tereset",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
