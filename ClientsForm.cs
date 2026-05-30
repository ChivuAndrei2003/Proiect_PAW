using Proiect_PAW_Chivu_Evelyn_Andrei.Entities;
using System.ComponentModel;

namespace Proiect_PAW_Chivu_Evelyn_Andrei
{
    public partial class ClientsForm : Form
    {
        #region Attributes
        private BindingList<Client> _clients;
        #endregion

        public ClientsForm()
        {
            InitializeComponent();

            _clients = new BindingList<Client>();


            dataGridView1.DataSource = _clients;

        }

        private Client? GetSelectedClient()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return null;
            }

            return dataGridView1.SelectedRows[0].DataBoundItem as Client;
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ClientsForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_Main_Page_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Json_Serialize_Click(object sender, EventArgs e)
        {

        }

        private void btn_Json_Deserealize_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Completeaza numele clientului");
                return;
            }

            int id;
            if (!int.TryParse(textBox3.Text, out id))
            {
                id = _clients.Count + 1;
            }

            Client client = new Client(id, textBox2.Text, textBox4.Text, new List<Comanda>());
            _clients.Add(client);
        }

        private void btn_Update_Click(object? sender, EventArgs e)
        {
            Client? client = GetSelectedClient();

            if (client == null)
            {
                MessageBox.Show("Alege un client");
                return;
            }

            int id;
            if (int.TryParse(textBox3.Text, out id))
            {
                client.Id = id;
            }

            client.numeClient = textBox2.Text;
            client.adresaLivrare = textBox4.Text;

            dataGridView1.Refresh();
        }

        private void btn_Delete_Click(object? sender, EventArgs e)
        {
            Client? client = GetSelectedClient();

            if (client == null)
            {
                MessageBox.Show("Alege un client");
                return;
            }

            if (MessageBox.Show("Stergi clientul selectat?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes)
            {
                _clients.Remove(client);
            }
        }

        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            Client? client = GetSelectedClient();

            if (client == null)
            {
                return;
            }

            textBox2.Text = client.numeClient;
            textBox3.Text = client.Id.ToString();
            textBox4.Text = client.adresaLivrare;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
