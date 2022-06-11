using GMagazzinoApsov.Helper;
using GMagazzinoApsov.Model;
using System.Text.RegularExpressions;

namespace GMagazzinoApsov
{
    public partial class FormScegliMagazzino : Form
    {
        private Regex _regexInteri = new Regex("(\\d)");
        private const int NUMERO_RIGHE_MASSIMO = 100;
        private const int NUMERO_COLONNA_MASSIMO = 100;

        public FormScegliMagazzino()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            textBoxPercorsoImport.TextChanged += textBoxPercorsoImport_TextChanged;
            textBoxNome.TextChanged += panelMagazzino_TextChanged;
            textBoxColonne.TextChanged += panelMagazzino_TextChanged;
            textBoxRighe.TextChanged += panelMagazzino_TextChanged;
            InizializzaForm();
            buttonProsegui.Enabled = false;
            checkBoxScegliMagazzino.Checked = true;
        }

        private void InizializzaForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void buttonProsegui_Click(object sender, EventArgs e)
        {
            var magazzino = new Magazzino();
            if (checkBoxScegliMagazzino.Checked)
            {
                //VERIFICARE COSA SUCCEDE IN CASO DI IMPORT CHE VA MALE
                magazzino = HelperSalvataggio.Importa(textBoxPercorsoImport.Text);
            }
            else if (!_regexInteri.IsMatch(textBoxRighe.Text) || !_regexInteri.IsMatch(textBoxColonne.Text))
            {
                MessageBox.Show("È necessario inserire valori validi.", "Errore");
                return;
            }
            else
            {
                magazzino.Nome = textBoxNome.Text;
                magazzino.NumeroRighe = Int32.Parse(textBoxRighe.Text);
                magazzino.NumeroColonne = Int32.Parse(textBoxColonne.Text);
            }
            if (magazzino.NumeroRighe > NUMERO_RIGHE_MASSIMO || magazzino.NumeroColonne > NUMERO_COLONNA_MASSIMO)
            {
                MessageBox.Show($"La dimensione massima non può superare {NUMERO_COLONNA_MASSIMO}X{NUMERO_RIGHE_MASSIMO}.", "Errore");
                return;
            }
            var formMagazzino = new FormMagazzino(magazzino);
            formMagazzino.ShowDialog();
            Close();
        }

        private void buttonScegliMagazzino_Click(object sender, EventArgs e)
        {
            textBoxPercorsoImport.Text = HelperSalvataggio.ApriSelezioneFile();
        }

        private void panelMagazzino_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNome.Text == String.Empty || textBoxColonne.Text == String.Empty || textBoxRighe.Text == String.Empty)
            {
                buttonProsegui.Enabled = false;
            }
            else
            {
                buttonProsegui.Enabled = true;
            }
        }


        private void textBoxPercorsoImport_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPercorsoImport.Text == String.Empty)
            {
                textBoxPercorsoImport.ReadOnly = false;
                buttonProsegui.Enabled = false;
            }
            else
            {
                textBoxPercorsoImport.ReadOnly = true;
                buttonProsegui.Enabled = true;
            }
        }

        private void checkBoxScegliMagazzino_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxScegliMagazzino.Checked)
            {
                checkBoxCreaMagazzino.Checked = false;
                panelCreaMagazzino.Enabled = false;
                panelScegliMagazzino.Enabled = true;
                textBoxNome.ResetText();
                textBoxRighe.ResetText();
                textBoxColonne.ResetText();
            }
        }

        private void checkBoxCreaMagazzino_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCreaMagazzino.Checked)
            {
                checkBoxScegliMagazzino.Checked = false;
                panelScegliMagazzino.Enabled = false;
                panelScegliMagazzino.Refresh();
                panelCreaMagazzino.Enabled = true;
            }
        }
    }
}
