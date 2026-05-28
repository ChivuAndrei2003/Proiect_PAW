namespace Proiect_PAW_Chivu_Evelyn_Andrei
{
    public partial class PizzaForm : Form
    {
        public PizzaForm()
        {
            InitializeComponent();
        }
        private string getPizzaImagePath(string pizzaName)
        {
            string pizza = pizzaName.Trim().ToLower();

            if (pizza == "country")
            {
                return "Resources/country.jpg";
            }

            if (pizzaName == "all cheese")
            {
                return "Resources/all_cheese.jpg";
            }

            if (pizza == "romaneasca")
            {
                return "Resources/romaneasca.jpg";
            }

            if (pizza == "cu ton")
            {
                return "Resources/cu_ton.jpg";
            }

            if (pizza == "mediteraneana")
            {
                return "Resources/mediteraneana.jpg";
            }

            if (pizza == "rustica")
            {
                return "Resources/rustica.jpg";
            }

            if (pizza == "pepperoni" || pizza == "peperoni")
            {
                return "Resources/pepperoni.jpg";
            }

            if (pizza == "texas")
            {
                return "Resources/texas.jpg";
            }

            else
            {
                return "Resources/pizza_default.jpg";
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
