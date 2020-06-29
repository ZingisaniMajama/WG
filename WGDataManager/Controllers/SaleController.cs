using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WGDataManager.Controllers
{
    public class SaleController : ApiController
    {
        // GET: api/Sale
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Sale/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Sale
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Sale/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sale/5
        public void Delete(int id)
        {
        }
    }
}
