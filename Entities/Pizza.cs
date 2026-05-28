namespace Proiect_PAW_Chivu_Evelyn_Andrei.Entities
{
    public class Pizza : IEquatable<Pizza?>
    {
        public Pizza(int id, string nume, decimal pret, string imagine, int cantitate)
        {
            this.id = id;
            this.nume = nume;
            this.pret = pret;
            this.imagePath = imagine;
            this.cantitate = cantitate;
        }
        public Pizza()
        {
            this.id = 22;
            this.nume = "Margherita";
            this.pret = 50;
            this.imagePath = "Resources/pizza_default";
            this.cantitate = 1;
        }
        public int id { get; set; }
        public string nume { get; set; }
        public int cantitate { get; set; }

        public decimal pret { get; set; }
        public string imagePath { get; set; }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Pizza);
        }
        // TO DO :
        // MAINE SA FAC CUMVA CA ID-UL SA FIE UN HASH CODE GENERAT ALEATOR 
        public bool Equals(Pizza? other)
        {
            return other is not null &&
                   id == other.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public static bool operator ==(Pizza? left, Pizza? right)
        {
            return EqualityComparer<Pizza>.Default.Equals(left, right);
        }

        public static bool operator !=(Pizza? left, Pizza? right)
        {
            return !(left == right);
        }
    }
}
