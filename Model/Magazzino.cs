
namespace GMagazzinoApsov.Model
{
    public class Magazzino
    {
        public string Nome { get; set; }
        public int NumeroRighe { get; set; }
        public int NumeroColonne { get; set; }
        public List<Prodotto> ListaProdotti { get; set; }

        public Magazzino()
        {
            ListaProdotti = new List<Prodotto>();
        }
    }
}
