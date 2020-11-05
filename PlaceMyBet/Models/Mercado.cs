using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Mercado
    {
        public Mercado(int idMercado, double mercado, double cuotaOver, double cuotaUnder, double dineroOver, double dineroUnder)
        {
            this.idMercado = idMercado;
            this.mercado = mercado;
            this.cuotaOver = cuotaOver;
            this.cuotaUnder = cuotaUnder;
            this.dineroOver = dineroOver;
            this.dineroUnder = dineroUnder;
        }

        public int idMercado { get; set; }

        public double mercado { get; set; }

        public double cuotaOver { get; set; }

        public double cuotaUnder { get; set; }

        public double dineroOver { get; set; }

        public double dineroUnder { get; set; }
    }
    public class MercadoDto
    {
        public MercadoDto(double mercado, double cuotaOver, double cuotaUnder)
        {
            this.mercado = mercado;
            this.cuotaOver = cuotaOver;
            this.cuotaUnder = cuotaUnder;
        }

        public double mercado { get; set; }

        public double cuotaOver { get; set; }

        public double cuotaUnder { get; set; }
    }

}