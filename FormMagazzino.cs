
using GMagazzinoApsov.Helper;
using GMagazzinoApsov.Model;
using Newtonsoft.Json;
using System.Linq;

namespace GMagazzinoApsov
{
    public partial class FormMagazzino : Form
    {
        private int _numeroColonne;
        private int _numeroRighe;
        private int _numeroRighePerSchermata = 15;
        public Magazzino Magazzino { get; set; }
        //private DataGridView grigliaMagazzino;
        public FormMagazzino(Magazzino magazzino)
        {
            InitializeComponent();
            Start(magazzino);
            //IMPORT/EXPORT EXCEL
            //PAGINA INZIALE SELEZIONE MAGAZZINI
            //TODO SCARICO = ELIMINO I PRODOTTI DALLE CELLE SELEZIONATA CON POPUP DI CONFERMA
            //PULSANTE CTRL-Z
            //SPOSTAMENTO VALORI CELLE
        }

        private void Start(Magazzino magazzino)
        {
            _numeroColonne = magazzino.NumeroColonne;
            _numeroRighe = magazzino.NumeroRighe;
            Magazzino = magazzino;
            InizializzaForm();
            InizializzaPanelMagazzino();
            InizializzaToolbar();
        }

        private void InizializzaForm()
        {
            this.Resize += Form_Resize;
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
        private void InizializzaPanelMagazzino()
        {
            grigliaMagazzino.CellDoubleClick += grigliaMagazzino_CellDoubleClick;
            grigliaMagazzino.CellPainting += grigliaMagazzino_CellPainting;

            for (int i = 0; i < _numeroColonne; i++)
            {
                int header = i + 1;
                AggiungiColonna(grigliaMagazzino, header.ToString());
            }
            for (int i = 0; i < _numeroRighe; i++)
            {
                int header = i + 1;
                AggiungiRiga(grigliaMagazzino, header.ToString());
            }
            panelGrigliaMagazzino.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left;
            grigliaMagazzino.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left;
            PopolaGrigliaMagazzino();
        }

        private void PopolaGrigliaMagazzino()
        {
            foreach (DataGridViewRow riga in grigliaMagazzino.Rows)
            {
                foreach (DataGridViewCell cella in riga.Cells)
                {
                    var prodotto = Magazzino.ListaProdotti.Where(p => p.Riga == cella.RowIndex && p.Colonna == cella.ColumnIndex).FirstOrDefault();
                    if (prodotto != null)
                    {
                        cella.Value = prodotto;
                    }
                }
            }
        }

        private void InizializzaToolbar()
        {
            panelToolbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelToolbar.Dock = DockStyle.Bottom;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in grigliaMagazzino.Rows)
            {
                riga.Height = grigliaMagazzino.Parent.Height / _numeroRighePerSchermata;
            }
        }

        private void AggiungiColonna(DataGridView grigliaMagazzino, string header)
        {
            var colonna = new DataGridViewTextBoxColumn();
            colonna.HeaderText = header;
            colonna.SortMode = DataGridViewColumnSortMode.NotSortable;
            grigliaMagazzino.Columns.Add(colonna);
        }

        private void AggiungiRiga(DataGridView grigliaMagazzino, string header)
        {
            var riga = new DataGridViewRow();
            riga.HeaderCell.Value = header;
            riga.Height = this.Height / _numeroRighePerSchermata;
            grigliaMagazzino.Rows.Add(riga);
        }

        private void buttonInserisciProdotti_Click(object sender, EventArgs e)
        {
            if (grigliaMagazzino.SelectedCells == null)
            {
                MessageBox.Show("È necessario selezionare almeno una cella");
            }
            else
            {
                bool flagInserisci = true;
                foreach (DataGridViewCell cella in grigliaMagazzino.SelectedCells)
                {
                    if (cella.Value != null)
                    {
                        MessageBox.Show("È necessario che tutte le celle selezionate siano vuote");
                        flagInserisci = false;
                        break;
                    }
                }
                if (flagInserisci)
                {
                    var formInserisciProdotto = new FormProdotto(grigliaMagazzino, Magazzino);
                    formInserisciProdotto.ShowDialog();
                }
            }
        }

        private void grigliaMagazzino_CellDoubleClick(Object sender, DataGridViewCellEventArgs e)
        {
            if (grigliaMagazzino.ColumnCount > e.ColumnIndex && grigliaMagazzino.Rows.Count > e.RowIndex
                && e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                var cella = grigliaMagazzino[e.ColumnIndex, e.RowIndex];
                if (cella.Value != null)
                {
                    Prodotto prodotto = (Prodotto) cella.Value;
                    var formInserisciProdotto = new FormProdotto(prodotto);
                    formInserisciProdotto.ShowDialog();
                }
            }
        }

        private void buttonRimuoviProdotto_Click(object sender, EventArgs e)
        {
            if (grigliaMagazzino.SelectedCells == null)
            {
                MessageBox.Show("È necessario selezionare almeno una cella");
            }
            else
            {
                foreach (DataGridViewCell cella in grigliaMagazzino.SelectedCells)
                {
                    cella.Value = null;
                }
            }
        }

        private void grigliaMagazzino_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.CellStyle.BackColor = e.Value == null ? Color.Red : Color.Green;
        }

        private void buttonEsportaMagazzino_Click(object sender, EventArgs e)
        {
            var lista = new List<Prodotto>();
            foreach (DataGridViewRow riga in grigliaMagazzino.Rows)
            {
                foreach (DataGridViewCell cella in riga.Cells)
                {
                    if (cella.Value != null)
                    {
                        var prodottoCella = (Prodotto) cella.Value;
                        var prodotto = HelperSalvataggio.Clona(prodottoCella);
                        prodotto.Riga = cella.RowIndex;
                        prodotto.Colonna = cella.ColumnIndex;
                        Magazzino.ListaProdotti.Add(prodotto);
                    }
                }
            }
            Magazzino.NumeroRighe = grigliaMagazzino.RowCount;
            Magazzino.NumeroColonne = grigliaMagazzino.ColumnCount;
            HelperSalvataggio.Esporta(Magazzino);
        }
    }
}
