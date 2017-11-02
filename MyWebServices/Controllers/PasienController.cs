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
        public Pasien Get(string id)
        {
            var result = pasienDal.GetById(id);
            return result;
        }

        // POST: api/Pasien
        public IHttpActionResult Post(Pasien pasien)
        {
            try
            {
                pasienDal.Insert(pasien);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Pasien/5
        public IHttpActionResult Put(Pasien pasien)
        {
            try
            {
                pasienDal.Update(pasien);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Pasien/5
        public IHttpActionResult Delete(string id)
        {
            try
            {
                pasienDal.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
