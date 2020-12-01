using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class CasaApuestas
    {
        public CasaApuestas(int id, double saldoActual, string nombreBanco, int numtarjeta, string correo)
        {
            this.id = id;
            SaldoActual = saldoActual;
            NombreBanco = nombreBanco;
            Numtarjeta = numtarjeta;
            Correo = correo;
        }

        public int id { get; set; }
        public double SaldoActual { get; set; }
        public string NombreBanco { get; set; }
        public int Numtarjeta { get; set; }
        public string Correo { get; set; }

    }
}