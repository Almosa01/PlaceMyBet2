﻿using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class EventosController : ApiController
    {
        // GET: api/Eventos
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        // GET: api/Eventos?NombreELocal=NombreELocal
        //public IEnumerable<Evento> GetNombreFecha(string nombre)
        //{
        //  var repo = new EventoRepository();
        //  List<Evento> eventos = rpeo
        //}

        // GET: api/Eventos/5
        public EventoDto Get(int id)
        {
            var repo = new EventoRepository();
            EventoDto e = repo.Filtrar();
            return e;
        }

        // POST: api/Eventos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Eventos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Eventos/5
        public void Delete(int id)
        {
        }
    }
}
