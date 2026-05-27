namespace Proiect_PAW_Chivu_Evelyn_Andrei.Entities
{
    public class Pizza
    {
        public Pizza(int id, string nume, string descriere, decimal pret, string imagine)
        {
            this.id = id;
            this.nume = nume;
            this.descriere = descriere;
            this.pret = pret;
            this.imagePath = imagine;
        }
        public Pizza()
        {
            this.id = 22;
            this.nume = "Margherita";
            this.descriere = "Pizza cu salam si masline";
            this.pret = 50;
            this.imagePath = "imagine";
        }
        public int id { get; set; }
        public string nume { get; set; }
        public string descriere { get; set; }
        public decimal pret { get; set; }
        public string imagePath { get; set; }
    }
}
