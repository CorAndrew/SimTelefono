using System;
using System.Collections.Generic;
using System.Text;

namespace SimTelefono
{
    public class Telefonata
    {
        private string destinatario;
        private int durata;

        public Telefonata(string destinatario, int durata)
        {
            this.destinatario = destinatario;
            this.durata = durata;
        }

        // Proprietà in sola lettura per accedere ai dati
        public string Destinatario => destinatario;
        public int Durata => durata;
    }
}
