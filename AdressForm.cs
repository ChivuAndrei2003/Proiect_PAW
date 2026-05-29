namespace Proiect_PAW_Chivu_Evelyn_Andrei
{
    public partial class AdressForm : Form
    {
        public AdressForm()
        {
            InitializeComponent();
        }

        private void ValidateCity()
        {
            if (string.IsNullOrWhiteSpace(textbox_Nume_Oras.Text))
            {
                throw new InvalidAddressException("Orasul este obligatoriu.");
            }
        }

        private void textbox_Nume_Oras_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                ValidateCity();
                errorProvider1.SetError(textbox_Nume_Oras, "");
                e.Cancel = false;
            }
            catch (InvalidAddressException ex)
            {
                errorProvider1.SetError(textbox_Nume_Oras, ex.Message);
                e.Cancel = true;
            }
        }


        private void textBox_Strada_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_Strada_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Strada.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox_Strada, "Strada este obligatorie");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox_Strada, "");
            }

        }

        private void textBox_Numar_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Numar.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox_Numar, "Numarul este obligatoriu.");
            }
            else if (!int.TryParse(textBox_Numar.Text, out int numar) || numar <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox_Numar, "Numarul trebuie sa fie un numar pozitiv.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox_Numar, "");
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Corecteaza erorile inainte de salvare");
                return;
            }

            MessageBox.Show("adresa este valida");
        }
    }
}
