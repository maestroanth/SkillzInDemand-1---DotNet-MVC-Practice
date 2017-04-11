using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TicketsController : Controller
    {
        [HttpGet("/tix")]//attribute routing. Breaks the controls. Called a Greedy Route URL has to be this
        public IActionResult Index()
        {
            //GO TO THE DATABASE!
            // GET SOME MODELS (STUFF)
            var s = new Seat() { Location = "Orchestra", Price = 99999.00 };
            return View(s);

        }
                
    }
}