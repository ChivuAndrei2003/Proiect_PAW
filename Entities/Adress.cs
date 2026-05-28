namespace Proiect_PAW_Chivu_Evelyn_Andrei.Entities
{
    public class Adress
    {
        public Adress(int id, string oras, string strada, string numar, Client client)
        {
            this.id = id;
            this.oras = oras;
            this.strada = strada;
            this.numar = numar;
            Client = client;
        }

        public int id { get; set; }
        public string oras { get; set; }
        public string strada { get; set; }
        public string numar { get; set; }

        public Client Client { get; set; }

    }
}

