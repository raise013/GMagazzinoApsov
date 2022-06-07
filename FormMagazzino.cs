
using GMagazzinoApsov.Model;

namespace GMagazzinoApsov
{
    public partial class FormMagazzino : Form
    {
        private int _numeroColonne = 29;
        private int _numeroRighe = 12;
        //private DataGridView grigliaMagazzino;
        public FormMagazzino()
        {
            InitializeComponent();
            Start();

            //IMPORT/EXPORT EXCEL
            //PAGINA INZIALE SELEZIONE MAGAZZINI
            //RIDIMENSIONAMENTO grigliaMagazzino
            //TODO SCARICO = ELIMINO I PRODOTTI DALLE CELLE SELEZIONATA CON POPUP DI CONFERMA
            //PULSANTE CTRL-Z
            //SPOSTAMENTO VALORI CELLE
        }

        private void Start()
        {
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
            foreach (DataGridViewRow riga in grigliaMagazzino.Rows)
            {
                foreach (DataGridViewCell cella in riga.Cells)
                {
                    cella.Style.BackColor = cella.Value == null ? Color.Red : Color.Green;
                }
            }
            panelGrigliaMagazzino.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left;
            grigliaMagazzino.Anchor = AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left;
        }

        private void InizializzaToolbar()
        {
            buttonInserisciProdotti.Dock = DockStyle.Bottom;
            panelToolbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelToolbar.Dock = DockStyle.Bottom;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            foreach (DataGridViewRow riga in grigliaMagazzino.Rows)
            {
                riga.Height = grigliaMagazzino.Parent.Height / _numeroRighe;
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
            riga.Height = this.Height / _numeroRighe;
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
                var formInserisciProdotto = new FormProdotto(grigliaMagazzino);
                formInserisciProdotto.ShowDialog(); // Shows Form2
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
    }
}
