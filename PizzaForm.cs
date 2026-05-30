using Proiect_PAW_Chivu_Evelyn_Andrei.Entities;
using System.ComponentModel;
using System.Text.Json;

namespace Proiect_PAW_Chivu_Evelyn_Andrei
{
    public partial class PizzaForm : Form
    {
        #region Attributes
        private BindingList<Pizza> _pizzas;
        private Pizza? _selectedPizza;
        private PizzaCardControl? _selectedPizzaCard;
        private string _customImagePath;
        #endregion

        public PizzaForm()
        {
            InitializeComponent();

            _pizzas = new BindingList<Pizza>();
            _customImagePath = "";

            ConfigureCardsPanel();
        }

        private void ConfigureCardsPanel()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.Padding = new Padding(10);
        }

        private void AddPizzaCard(Pizza pizza)
        {
            PizzaCardControl card = new PizzaCardControl();
            card.Margin = new Padding(10);
            card.Tag = pizza;
            card.BorderStyle = BorderStyle.FixedSingle;

            card.SetPizza(pizza.nume, pizza.pret, pizza.imagePath);
            AttachSelectHandler(card, (sender, e) => SelectPizza(pizza, card));

            flowLayoutPanel1.Controls.Add(card);
            SelectPizza(pizza, card);
        }

        private void AttachSelectHandler(Control control, EventHandler handler)
        {
            control.Click += handler;

            foreach (Control child in control.Controls)
            {
                AttachSelectHandler(child, handler);
            }
        }

        private void SelectPizza(Pizza pizza, PizzaCardControl card)
        {
            if (_selectedPizzaCard != null)
            {
                _selectedPizzaCard.BackColor = SystemColors.Control;
            }

            _selectedPizza = pizza;
            _selectedPizzaCard = card;
            _selectedPizzaCard.BackColor = Color.LightYellow;

            comboBox1.Text = pizza.nume;
            textBox_Pret.Value = pizza.pret;
            textBox_Cantitate.Value = pizza.cantitate;
        }

        private string getPizzaImagePath(string pizzaName)
        {
            string pizza = pizzaName.Trim().Trim('"').ToLower();

            if (pizza == "country")
            {
                return "Resources/country.jpg";
            }

            if (pizza == "all cheese")
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

            if (pizza == "custom" && !string.IsNullOrWhiteSpace(_customImagePath))
            {
                return _customImagePath;
            }

            return "Resources/pizza_default.jpg";
        }

        private Pizza? GetSelectedPizza()
        {
            return _selectedPizza;
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
            Pizza? pizza = GetSelectedPizza();

            if (pizza == null)
            {
                MessageBox.Show("Alege o pizza");
                return;
            }

            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Alege o pizza");
                return;
            }

            pizza.nume = comboBox1.Text;
            pizza.pret = textBox_Pret.Value;
            pizza.cantitate = (int)textBox_Cantitate.Value;
            pizza.imagePath = getPizzaImagePath(comboBox1.Text);

            _selectedPizzaCard?.SetPizza(pizza.nume, pizza.pret, pizza.imagePath);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string numePizza = comboBox1.Text;
            decimal pret = textBox_Pret.Value;
            int cantitate = (int)textBox_Cantitate.Value;

            if (string.IsNullOrWhiteSpace(numePizza))
            {
                MessageBox.Show("Alege o pizza");
                return;
            }

            Pizza pizza = new Pizza(
                _pizzas.Count + 1,
                numePizza,
                pret,
                getPizzaImagePath(numePizza),
                cantitate
                );

            _pizzas.Add(pizza);
            AddPizzaCard(pizza);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Pizza? pizza = GetSelectedPizza();

            if (pizza == null)
            {
                MessageBox.Show("Alege o pizza");
                return;
            }

            if (MessageBox.Show("Stergi pizza selectata?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes)
            {
                _pizzas.Remove(pizza);
                if (_selectedPizzaCard != null)
                {
                    flowLayoutPanel1.Controls.Remove(_selectedPizzaCard);
                    _selectedPizzaCard.Dispose();
                }

                _selectedPizza = null;
                _selectedPizzaCard = null;
            }
        }

        private void btn_Json_Serialize_Click(object sender, EventArgs e)
        {
            using (FileStream stream = File.Create("SerializedJSON.json"))
            {
                JsonSerializer.Serialize(stream, new List<Pizza>(_pizzas));
            }
        }

        private void btn_Json_Deserealize_Click(object sender, EventArgs e)
        {
            using (FileStream stream = File.OpenRead("SerializedJSON.json"))
            {
                var deserializedPizzas = JsonSerializer.Deserialize<List<Pizza>>(stream);
                if (deserializedPizzas != null)
                {
                    _pizzas.Clear();
                    flowLayoutPanel1.Controls.Clear();
                    _selectedPizza = null;
                    _selectedPizzaCard = null;

                    foreach (Pizza pizza in deserializedPizzas)
                    {
                        _pizzas.Add(pizza);
                        AddPizzaCard(pizza);
                    }
                }
            }
        }

        private void btn_Text_File(object? sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("Nume,Cantitate,Pret");

                    foreach (var p in _pizzas)
                    {
                        sw.WriteLine("\"{0}\", \"{1}\", \"{2}\"",
                            p.nume.Replace("\"", "\"\""),
                            p.cantitate,
                            p.pret);
                    }
                }
            }
        }

        private void btn_Main_Page_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void btn_Adauga_Imagine_Custom_Click(object? sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _customImagePath = openFileDialog.FileName;
                pb_Imagine_Custom.Image = Image.FromFile(_customImagePath);
            }
        }
    }
}
