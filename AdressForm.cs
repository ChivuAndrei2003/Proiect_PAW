using Proiect_PAW_Chivu_Evelyn_Andrei.Entities;
using System.ComponentModel;

namespace Proiect_PAW_Chivu_Evelyn_Andrei
{
    public partial class AdressForm : Form
    {
        #region Attributes
        private BindingList<Adress> _addresses;
        #endregion

        public AdressForm()
        {
            InitializeComponent();

            _addresses = new BindingList<Adress>();


            dataGridView1.DataSource = _addresses;

        }


        private Adress? GetSelectedAddress()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return null;
            }

            return dataGridView1.SelectedRows[0].DataBoundItem as Adress;
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
            if (string.IsNullOrWhiteSpace(textBox_Strada.Text))
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

            Client client = new Client(0, "", "", new List<Comanda>());
            Adress address = new Adress(_addresses.Count + 1, textbox_Nume_Oras.Text, textBox_Strada.Text,
                textBox_Numar.Text, client);
            address.status = comboBox1.Text;

            _addresses.Add(address);
        }

        private void btn_Main_Page_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Update_Click(object? sender, EventArgs e)
        {
            Adress? address = GetSelectedAddress();

            if (address == null)
            {
                MessageBox.Show("Alege o adresa");
                return;
            }

            if (!ValidateChildren())
            {
                MessageBox.Show("Corecteaza erorile inainte de salvare");
                return;
            }

            address.oras = textbox_Nume_Oras.Text;
            address.strada = textBox_Strada.Text;
            address.numar = textBox_Numar.Text;
            address.status = comboBox1.Text;

            dataGridView1.Refresh();
        }

        private void btn_Delete_Click(object? sender, EventArgs e)
        {
            Adress? address = GetSelectedAddress();

            if (address == null)
            {
                MessageBox.Show("Alege o adresa");
                return;
            }

            if (MessageBox.Show("Stergi adresa selectata?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes)
            {
                _addresses.Remove(address);
            }
        }

        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            Adress? address = GetSelectedAddress();

            if (address == null)
            {
                return;
            }

            textbox_Nume_Oras.Text = address.oras;
            textBox_Strada.Text = address.strada;
            textBox_Numar.Text = address.numar;
            comboBox1.Text = address.status;
        }

        private void btn_preview_print_Click(object sender, EventArgs e)
        {

        }

        private void AdressForm_Load(object sender, EventArgs e)
        {

        }
    }
}
