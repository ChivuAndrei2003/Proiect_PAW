namespace Proiect_PAW_Chivu_Evelyn_Andrei
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //

        }



        private void OpenForm(Form form)
        {
            Hide();
            form.FormClosed += ChildForm_FormClosed;
            form.Show();
        }

        private void ChildForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Pizza_Click(object? sender, EventArgs e)
        {
            OpenForm(new PizzaForm());
        }

        private void btn_Clients_Click(object? sender, EventArgs e)
        {
            OpenForm(new ClientsForm());
        }

        private void btn_Adresses_Click(object? sender, EventArgs e)
        {
            OpenForm(new AdressForm());
        }
    }
}
