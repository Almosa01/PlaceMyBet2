using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class EventosExamenRepository
    {


        public static EventosExamen ToDTO(Mercado m, Evento e)
        {
            return new EventosExamen(m.mercadoId, m.cuotaOver, m.cuotaUnder, e.nombreVisitante);
        }

        internal List<EventosExamen> Retrieve2()
        {
            List<EventosExamen> eventos = new List<EventosExamen>();
            Evento e = new Evento();


            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                eventos = context.mercados.Select(m => ToDTO(m,e))
                    .Include(n => n.nombreVisitante).ToList();
            }
            return eventos;
        }
        internal void Save(Mercado m, EventoDto2 e)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            context.eventoDto2s.Add(e);
            context.mercados.Add(m);
            context.SaveChanges();

        }
    }
}