using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    [Produces("application/xml")]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        private static List<Product> _products = new List<Product>(new[]
          {
                new Product() { ID = 1, Name = "Green Peppers"},
                new Product() { ID = 2, Name = "Soft Taco"},
                new Product() { ID = 3, Name = "Chipotle Sauce"}

            });

        [HttpGet]//is the actual constraint (SO THIS METHOD ISN'T ACCESSED WITH A POST OR DELETE)
        public List<Product> Get()//does the actual routing
        {
            return _products; //pretend to go to the database ex. dbcontext.Products.List
        }

        [HttpGet("{id}")]//captures route parameter
        public IActionResult Get(int id)
        {
            var product = _products.SingleOrDefault(p => p.ID == id);

            if(product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)//model binding
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("You Stupid Fucker! GET MY API RIGHT!!!!");
            }

            _products.Add(product);
            return CreatedAtAction(nameof(Get), new { id = product.ID }, product);
        }
    }
}