using PlaceMyBet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PlaceMyBet.Controllers
{
    public class MercadosController : ApiController
    {
        // GET: api/Mercados
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Mercados/5
        public List<Mercado> Get(int id)
        {
            var repo = new MercadoRepository();
           List<Mercado> m = repo.Retrieve();
            return m;
        }
        public List<Mercado> Get()
        {
            var repo = new MercadoRepository();
            List <Mercado> m = repo.Retrieve();
            return m;
        }

        // POST: api/Mercados
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Mercados/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Mercados/5
        public void Delete(int id)
        {
        }
    }
}
