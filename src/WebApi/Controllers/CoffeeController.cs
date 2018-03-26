
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Coffee")]
    public class CoffeeController : Controller
    {
        private Coffee _coffee;

        public CoffeeController(Coffee coffee)
        {
            _coffee = coffee;

        }

        // GET api/Coffees
        [HttpGet]
        public List<Coffee> Get()
        {
            return _coffee.GetAllCoffees();
        }
    }
}