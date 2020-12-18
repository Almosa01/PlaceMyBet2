using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class EventosExamen
    {
        public int mercado;
        public double cuotaOver;
        public double cuotaUnder;
        public string nombreVisitante;

        public EventosExamen(int mercado, double cuotaOver, double cuotaUnder,string nombreVisitante)
        {
            this.mercado = mercado;
            this.cuotaOver = cuotaOver;
            this.cuotaUnder = cuotaUnder;
            this.nombreVisitante = nombreVisitante;
        }
    }
}