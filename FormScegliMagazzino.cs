using GMagazzinoApsov.Helper;


namespace GMagazzinoApsov
{
    public partial class FormScegliMagazzino : Form
    {
        public FormScegliMagazzino()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            textBoxPercorsoImport.TextChanged += textBoxPercorsoImport_TextChanged;
            buttonProsegui.Enabled = false;
        }

        private void buttonProsegui_Click(object sender, EventArgs e)
        {
            var magazzino = HelperSalvataggio.Importa(textBoxPercorsoImport.Text);
            var formMagazzino = new FormMagazzino(magazzino);
            formMagazzino.ShowDialog();
        }

        private void buttonScegliMagazzino_Click(object sender, EventArgs e)
        {
            textBoxPercorsoImport.Text = HelperSalvataggio.ApriSelezioneFile();
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
    }
}
