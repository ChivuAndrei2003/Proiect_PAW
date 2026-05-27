namespace Proiect_PAW_Chivu_Evelyn_Andrei.Entities
{
    public class Client
    {
        public string numeClient { get; set; }
        public string adresaLivrare { get; set; }
        public string comanda { get; set; }

        public Client(string numeClient, string adresaLivrare, string comanda)
        {
            this.numeClient = numeClient;
            this.adresaLivrare = adresaLivrare;
            this.comanda = comanda;
        }
    }
}
