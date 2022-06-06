namespace GMagazzinoApsov.Model
{
    public class Prodotto
    {
        public string Varieta { get; set; }
        public string Categoria { get; set; }
        public string Concia { get; set; }
        public string Partita { get; set; }

        public string Lotto { get; set; }

        public override string ToString()
        {
            return Varieta;
        }

    }
}
