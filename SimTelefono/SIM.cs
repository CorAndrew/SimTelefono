using System.Collections.Generic;

namespace SimTelefono
{
    public class Sim
    {
        public string NumeroProprietario;
        public double Credito;
        public List<Telefonata> ListaChiamate;

        public Sim(string numero, double creditoIniziale)
        {
            NumeroProprietario = numero;
            Credito = creditoIniziale;
            ListaChiamate = new List<Telefonata>();
        }

        public void AggiungiChiamata(string numero, int minuti)
        {
            // Calcolo costo: aggiungendo 4 prima di dividere per 5, 
            // otteniamo lo scatto anticipato (es: 1 min -> 1€, 6 min -> 2€)
            int costo = (minuti + 4) / 5;
            Credito = Credito - costo;

            Telefonata nuovaChiamata = new Telefonata(numero, minuti);
            ListaChiamate.Add(nuovaChiamata);
        }

        public int CalcolaMinutiTotali()
        {
            int totale = 0;
            foreach (Telefonata t in ListaChiamate)
            {
                totale = totale + t.Durata;
            }
            return totale;
        }

        public int ChiamateVersoNumero(string numeroCercato)
        {
            int contatore = 0;
            foreach (Telefonata t in ListaChiamate)
            {
                if (t.Destinatario == numeroCercato)
                {
                    contatore = contatore + 1;
                }
            }
            return contatore;
        }

        public string OttieniRiepilogo()
        {
            string testo = "SIM: " + NumeroProprietario + "\nCredito: " + Credito + "€\n\nCHIAMATE:\n";
            foreach (Telefonata t in ListaChiamate)
            {
                testo = testo + "- " + t.Destinatario + " (" + t.Durata + " min)\n";
            }
            return testo;
        }
    }
}