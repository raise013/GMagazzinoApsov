using GMagazzinoApsov.Model;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace GMagazzinoApsov.Helper
{
    public static class HelperSalvataggio
    {
        private static readonly Regex _regexPath = new Regex(@"^(?:[a-zA-Z]\:|\\\\[\w\.]+\\[\w.$]+)\\(?:[\w]+\\)*\w([\w.])+$");
        public static void Esporta(Magazzino magazzino)
        {
            try
            {
                //RENDERE ASYNC: VOGLIO DESERIALIZZARE MENTRE SCELGO IL PERCORSO
                //IMPOSTARE VERO NOME MAGAZZINO
                string jsonMagazzino = JsonConvert.SerializeObject(magazzino, Formatting.Indented);
                string path = ApriSelezionePath();
                if (_regexPath.IsMatch(path))
                {
                    string dataAttuale = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string nomeMagazzino = magazzino.Nome == null ? "Magazzino" : magazzino.Nome;
                    string nomeFile = $"Magazzino_{dataAttuale}";
                    string percorsoCompleto = $"{path}\\{nomeFile}.json";
                    File.WriteAllText(percorsoCompleto, jsonMagazzino);
                    MessageBox.Show("Il file è stato esportato correttamente.", "Info");
                }
                else
                {
                    MessageBox.Show("Percorso selezionato non valido.", "Errore");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Impossibile esportare il file del magazzino.", "Errore");
            }
        }

        private static string ApriSelezionePath()
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            var dialogResult = folderBrowserDialog.ShowDialog();
            string path = String.Empty;
            if (dialogResult == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;
            }
            return path;
        }

        public static string ApriSelezioneFile()
        {
            var openFileDialog = new OpenFileDialog();
            var dialogResult = openFileDialog.ShowDialog();
            string filePath = String.Empty;
            if (dialogResult == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            return filePath;
        }

        public static Magazzino Importa(string path)
        {
            var magazzino = new Magazzino();
            if (_regexPath.IsMatch(path))
            {
                try
                {
                    if (File.Exists(path))
                    {
                        var jsonMagazzino = File.ReadAllText(path);
                        magazzino = JsonConvert.DeserializeObject<Magazzino>(jsonMagazzino);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Impossibile importare il file.", "Errore");
                    throw new Exception();
                }
            }
            else
            {
                MessageBox.Show("Il percorso indicato non è valido.", "Errore");
                throw new Exception();
            }
            return magazzino;
        }

        public static Prodotto Clona(Prodotto prodotto)
        {
            var nuovoProdotto = new Prodotto();
            nuovoProdotto.Varieta = prodotto.Varieta;
            nuovoProdotto.Categoria = prodotto.Categoria;
            nuovoProdotto.Concia = prodotto.Concia;
            nuovoProdotto.Partita = prodotto.Partita;
            nuovoProdotto.Lotto = prodotto.Lotto;
            nuovoProdotto.Riga = prodotto.Riga;
            nuovoProdotto.Colonna = prodotto.Colonna;
            return nuovoProdotto;
        }
    }
}
