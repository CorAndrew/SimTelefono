using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace SimTelefono
{
    public partial class Form1 : Form
    {
        private Sim miaSim;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            // Se la sim non esiste, la crea
            if (miaSim == null)
            {
                miaSim = new Sim(txtNumero.Text, double.Parse(txtCredito.Text));
            }

            string dest = txtDestinatario.Text;
            int minuti = int.Parse(txtMinuti.Text);

            if (string.IsNullOrWhiteSpace(dest))
            {
                MessageBox.Show("Inserisci il numero del destinatario!");
                return;
            }

            miaSim.AggiungiChiamata(dest, minuti);

            // Aggiorna la textbox in tempo reale
            txtCredito.Text = miaSim.Credito.ToString();

            MessageBox.Show("Chiamata salvata!\nCredito residuo: " + miaSim.Credito + "€");

            txtDestinatario.Clear();
            txtMinuti.Clear();
        }

        private void btnMinuti_Click(object sender, EventArgs e)
        {
            if (miaSim == null)
            {
                MessageBox.Show("Nessuna SIM attiva!");
                return;
            }
            MessageBox.Show("Minuti totali effettuati: " + miaSim.CalcolaMinutiTotali());
        }

        private void btnTelefonata_Click(object sender, EventArgs e)
        {
            if (miaSim == null)
            {
                MessageBox.Show("Nessuna SIM attiva!");
                return;
            }

            string numeroCercato = Interaction.InputBox("Inserisci il numero da cercare:", "Ricerca");

            if (numeroCercato != "")
            {
                int conteggio = miaSim.ChiamateVersoNumero(numeroCercato);
                MessageBox.Show("Chiamate verso " + numeroCercato + ": " + conteggio);
            }
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            if (miaSim == null)
            {
                MessageBox.Show("Nessuna SIM attiva!");
                return;
            }

            MessageBox.Show(miaSim.OttieniRiepilogo(), "Dati Completi SIM");
        }
    }
}