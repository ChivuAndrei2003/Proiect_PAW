namespace Proiect_PAW_Chivu_Evelyn_Andrei
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Pizza_Click(object sender, EventArgs e)
        {
            PizzaForm pizzaForm = new PizzaForm();
            pizzaForm.ShowDialog();
        }

        private void btn_Clients_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.ShowDialog();

        }

        private void btn_Adresses_Click(object sender, EventArgs e)
        {
            AdressForm adressForm = new AdressForm();
            adressForm.ShowDialog();
        }
    }
}
