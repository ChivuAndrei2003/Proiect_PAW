namespace Proiect_PAW_Chivu_Evelyn_Andrei.Entities
{
    public class Client
    {
        public Client(int id, string numeClient, string adresaLivrare, List<Comanda> comenzi)
        {
            Id = id;
            this.numeClient = numeClient;
            this.adresaLivrare = adresaLivrare;
            Comenzi = comenzi;
        }

        public int Id { get; set; }
        public string numeClient { get; set; }
        public string adresaLivrare { get; set; }
        public List<Comanda> Comenzi { get; set; } = new List<Comanda>();


    }
}
