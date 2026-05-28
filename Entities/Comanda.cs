
namespace Proiect_PAW_Chivu_Evelyn_Andrei.Entities
{
    public class Comanda
    {
        public Comanda(int id, Client client, Adress adresaLivrare, List<Pizza> pizze, DateTime dataComanda, decimal total, string status)
        {
            this.id = id;
            this.client = client;
            this.adresaLivrare = adresaLivrare;
            this.pizza = pizze;
            this.dataComanda = dataComanda;
            this.total = total;
            this.status = status;
        }

        public int id { get; set; }

        public Client client { get; set; }

        public Adress adresaLivrare { get; set; }

        public List<Pizza> pizza { get; set; } = new List<Pizza>();

        public DateTime dataComanda { get; set; }

        public decimal total { get; set; }

        public string status { get; set; }
    }
}
