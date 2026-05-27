namespace Proiect_PAW_Chivu_Evelyn_Andrei.Entities
{
    public class Adress
    {
        public Adress(int id, string judet, string localitate, string strada, string numar, string codPostal)
        {
            this.id = id;
            this.judet = judet;
            this.localitate = localitate;
            this.strada = strada;
            this.numar = numar;
            this.codPostal = codPostal;
        }

        public int id { get; set; }
        public string judet { get; set; }
        public string localitate { get; set; }
        public string strada { get; set; }
        public string numar { get; set; }
        public string codPostal { get; set; }
    }
}

