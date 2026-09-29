namespace esListBox
{
    public partial class Form1 : Form
    {
        List<string> origineDati = new List<string>();

        public Form1()
        {
            InitializeComponent();
            Aggiorna();
            caricaDati("Animali.txt");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Aggiungi_Click(object sender, EventArgs e)
        {
            
            if (verifica(textBoxAggiungi.Text) == false)
            {
                MessageBox.Show("errore");
            }
            else
            {
                string parola = textBoxAggiungi.Text;
                parola = parola.Trim();
                parola = parola.ToLower();
                origineDati.Add(parola);
                textBoxAggiungi.Clear();
                Aggiorna();
            }
        }

        private void Aggiorna()
        {
            listBox1.Items.Clear();

            foreach (string s in origineDati)
            {
                listBox1.Items.Add(s);
            }
        }

        private bool verifica(string parola)
        {
            if (string.IsNullOrEmpty(parola))
            {
                return false;
            }

            for (int i = 0; i < parola.Length; i++)
            {
                if (parola[i] != ' ')
                {
                    return true;
                }
            }

            return false;
        }
        
        private void caricaDati(string nomeFile)
        {
            if (!File.Exists(nomeFile))
            {
                MessageBox.Show("Il file non esiste");
            }
            else
            {
                using(StreamReader sr = new StreamReader(nomeFile))
                {
                    while (!sr.EndOfStream)
                    {
                        string riga = sr.ReadLine();

                        if(verifica(riga) == true)
                        {
                            riga = riga.Trim();
                            riga = riga.ToLower();
                            origineDati.Add(riga);
                        }
                    }
                }
            }
        }
    }
}
