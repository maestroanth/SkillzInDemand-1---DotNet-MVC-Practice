using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    [Produces("application/json")]
    [Route("api/DoNotUseThis")]
    public class DoNotUseThisController : Controller
    {
        // GET: api/DoNotUseThis
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DoNotUseThis/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/DoNotUseThis
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/DoNotUseThis/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
