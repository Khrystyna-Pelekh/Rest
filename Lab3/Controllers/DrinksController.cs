using System.Collections.Generic;
using Lab3.Services;
using Lab3.Services.Models;
using Microsoft.AspNetCore.Mvc;



namespace Lab3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinksController : BaseController<Drink>
    {
        public DrinksController(IService<Drink> service)
            : base(service)
        {
        }

        // GET: api/<DrinkController>
        [HttpGet]
        public ActionResult<IEnumerable<Drink>> Get()
        {
            return Ok(Service.Get());
        }

        // GET api/<DrinkController>/5
        [HttpGet("{id}")]
        public ActionResult<Drink> Get(int id)
        {
            var response = Service.Get(id);
            if (response != null) {
                return Ok(response);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
