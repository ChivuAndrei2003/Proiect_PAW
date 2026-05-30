using Proiect_PAW_Chivu_Evelyn_Andrei.Entities;
using System.Text.Json;

namespace Proiect_PAW_Chivu_Evelyn_Andrei
{
    public partial class PizzaForm : Form
    {
        #region Attributes
        private List<Pizza> _pizzas;
        #endregion

        public PizzaForm()
        {
            InitializeComponent();

            pizzas = new List<Pizza>();
        }

        private List<Pizza> pizzas = new();

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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PizzaForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string numePizza = comboBox1.Text;
            decimal pret = textBox_Pret.Value;
            decimal cantitate = textBox_Cantitate.Value;

            int cantitate_to_int = (int)cantitate;

            //TO DO : ADAUGA LABEL DE CANTITATE IN PIZZA CARD
            if (string.IsNullOrEmpty(numePizza))
            {
                MessageBox.Show("Alege o pizza");
                return;
                // string pizzaPath = getPizzaImagePath(numePizza);
            }

            Pizza pizza = new Pizza(
                pizzas.Count + 1,
                numePizza,
                pret,
                getPizzaImagePath(numePizza),
                cantitate_to_int
                );

            pizzas.Add(pizza);
            MessageBox.Show("Pizza a fost adaugata in lista.");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Json_Serialize_Click(object sender, EventArgs e)
        {

            using (FileStream stream = File.Create("SerializedJSON.json"))
            {
                JsonSerializer.Serialize(stream, pizzas);
            }

        }

        private void btn_Json_Deserealize_Click(object sender, EventArgs e)
        {
            using (FileStream stream = File.OpenRead("SerializedJSON.json"))
            {
                var deserializedParticipants = JsonSerializer.Deserialize<List<Pizza>>(stream);
                if (deserializedParticipants != null)
                    pizzas = deserializedParticipants;

                // DisplayParticipants();
            }
        }

        private void btn_Text_File(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {


                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("LastName,FirstName,BirthDate");

                    foreach (var p in _pizzas)
                    {
                        sw.WriteLine("\"{0}\", \"{1}\", \"{2}\""
                            , p.nume.Replace("\"", "\"\"")
                            , p.cantitate.ToString()
                            , p.pret.ToString();
                    }
                }
            }
        }
    }
}
