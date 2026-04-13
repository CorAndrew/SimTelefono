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

        // Proprietà per accedere ai dati
        public string Destinatario
        {
            get
            {
                return destinatario;
            }
        }

        public int Durata
        {
            get
            {
                return durata;
            }
        }
    }
}
