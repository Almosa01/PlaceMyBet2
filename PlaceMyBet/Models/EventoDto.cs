using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PlaceMyBet.Models
{
    public class EventoDtoExa
    {
        public EventoDtoExa()
        {

        }
        public EventoDtoExa (string nombreLocal,string nombreVisitante)
        {
            this.nombreLocal = nombreLocal;
            this.nombreVisitante = nombreVisitante;
        }
         public string nombreLocal { get; set; }
        public string nombreVisitante { get; set; }

        public Apuesta mercados2 { get; set; }
    }
}