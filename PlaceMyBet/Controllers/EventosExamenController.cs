using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class EventosExamenController : ApiController
    {
        // GET: api/EventosExamen
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/EventosExamen/5
        public List<EventosExamen> Get(string nombre)
        {
            var repo = new EventosExamenRepository();
            List<EventosExamen> e = repo.Retrieve2(nombre);
            return e;
        }

        // POST: api/EventosExamen
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/EventosExamen/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EventosExamen/5
        public void Delete(int id)
        {
        }
    }
}
