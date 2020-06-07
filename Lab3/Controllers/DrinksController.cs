using System.Collections.Generic;
using Lab3.Services;
using Lab3.Services.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DrinkController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DrinkController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DrinkController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
