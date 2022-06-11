using GMagazzinoApsov.Model;

namespace GMagazzinoApsov
{
    public partial class FormProdotto : Form
    {
        private DataGridView _grigliaMagazzino { get; set; }
        private Prodotto _prodotto { get; set; }
        
        public FormProdotto(DataGridView grigliaMagazzino, Magazzino magazzino)
        {
            InitializeComponent();
            _grigliaMagazzino = grigliaMagazzino;
            var listaVarieta = new string[] { String.Empty, "Annica", "Axum", "Rebelde" };
            var listaCategoria = new string[] { String.Empty, "Base", "Prebase1", "Prebase2" };
            var listaConcia = new string[] { String.Empty, "Rosso", "Blu", "Silver" };
            
            comboVarieta.DataSource = listaVarieta;
            comboCategoria.DataSource = listaCategoria;
            comboConcia.DataSource = listaConcia;
        }

        public FormProdotto(Prodotto prodotto)
        {
            InitializeComponent();
            _prodotto = prodotto;
            GestisciVisibilitaSolaVisualizzazione();
        }

        private void GestisciVisibilitaSolaVisualizzazione()
        {
            comboCategoria.Hide();
            comboConcia.Hide();
            comboVarieta.Hide();
            buttonSalvaProdotto.Hide();

            GeneraTextboxDaCombo(comboCategoria, _prodotto.Categoria);
            GeneraTextboxDaCombo(comboConcia, _prodotto.Concia);
            GeneraTextboxDaCombo(comboVarieta, _prodotto.Varieta);
            textBoxLotto.ReadOnly = true;
            textBoxPartita.ReadOnly = true;
        }

        private void GeneraTextboxDaCombo(ComboBox combo, string testo)
        {
            string nome = $"textbox_{combo.Name}";
            AggiungiTextBox(nome, testo, combo.Location, combo.Size);
        }

        private void AggiungiTextBox(string controlName, string testo, Point posizione, Size size)
        {
            var textBox = new TextBox();
            textBox.Name = controlName;
            textBox.Text = testo;
            textBox.Size = size;
            textBox.Location = posizione;
            textBox.ReadOnly = true;
            this.Controls.Add(textBox);
        }

        private void buttonSalvaProdotto_Click(object sender, EventArgs e)
        {
            var prodotto = new Prodotto();
            prodotto.Varieta = comboVarieta.SelectedItem?.ToString();
            prodotto.Categoria = comboCategoria.SelectedItem?.ToString();
            prodotto.Concia = comboConcia.SelectedItem?.ToString();

            if (prodotto.Varieta == String.Empty || prodotto.Concia == String.Empty || prodotto.Categoria == String.Empty)
            {
                MessageBox.Show("È necessario compilare i campi obbligatori.");
            }
            else
            {
                prodotto.Partita = textBoxPartita.Text;
                prodotto.Lotto = textBoxLotto.Text;

                var celleSelezionata = _grigliaMagazzino.SelectedCells;
                foreach (DataGridViewCell cella in celleSelezionata)
                {
                    cella.Value = prodotto;
                }
                this.Close();
            }
        }
    }
}
