using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using MyWebServices.DAL;
using MyWebServices.Models;

namespace MyWebServices.Controllers
{
    public class PasienController : ApiController
    {
        private PasienDAL pasienDal = new PasienDAL();

        // GET: api/Pasien
        public IEnumerable<Pasien> Get()
        {
            var results = pasienDal.GetAll();
            return results;
        }

        // GET: api/Pasien/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pasien
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Pasien/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pasien/5
        public void Delete(int id)
        {
        }
    }
}
